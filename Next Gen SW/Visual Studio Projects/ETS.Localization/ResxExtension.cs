// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResxExtension.cs" company="ETS-Lindgren LP">
//   Copyright ETS-Lindgren, All rights reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ETS.Localization
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Resources.NetStandard;
    using System.Runtime.InteropServices;

    using Microsoft.Win32;


    /// <summary>
    /// Defines the handling method for the <see cref="ResxExtension.GetResource"/> event
    /// </summary>
    /// <param name="resxName">The name of the resx file</param>
    /// <param name="key">The resource key within the file</param>
    /// <param name="culture">The culture to get the resource for</param>
    /// <returns>The resource</returns>
    public delegate object GetResourceHandler(string resxName, string key, CultureInfo culture);

    /// <summary>
    /// A markup extension to allow resources for WPF Windows and controls to be retrieved
    /// from an embedded resource (resx) file associated with the window or control
    /// </summary>
    public class ResxExtension 
    {
        #region Static Fields
        #endregion

        #region Fields

        /// <summary>
        /// The default value for the property
        /// </summary>
        private string _defaultValue;

        /// <summary>
        /// The resource manager to use for this extension.  Holding a strong reference to the
        /// Resource Manager keeps it in the cache while ever there are ResxExtensions that
        /// are using it.
        /// </summary>
        private ResourceManager _resourceManager;

        /// <summary>
        /// Cached resource managers
        /// </summary>
        private static readonly Dictionary<string, Tuple<WeakReference, string>> _resourceManagers =
            new Dictionary<string, Tuple<WeakReference, string>>();

        /// <summary>
        /// List of temporary files
        /// </summary>
        private static readonly List<TemporaryFile> _temporaryFiles = new List<TemporaryFile>();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the ResxExtension class
        /// </summary>
        public ResxExtension()
        {
        }

        #endregion

        #region Public Events

        /// <summary>
        /// This event allows a designer or preview application (such as Globalizer.NET) to
        /// intercept calls to get resources and provide the values instead dynamically
        /// </summary>
        public static event GetResourceHandler GetResource;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the default value to use if the resource can't be found
        /// </summary>
        /// <remarks>
        /// This particularly useful for properties which require non-null
        /// values because it allows the page to be displayed even if
        /// the resource can't be loaded
        /// </remarks>
        public string DefaultValue
        {
            get
            {
                return this._defaultValue;
            }

            set
            {
                this._defaultValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the DesignerPath for finding resx files at design time
        /// </summary>
        public string DesignerPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified name of the embedded resx (without .resources) to get
        /// the resource from
        /// </summary>
        public string ResxName { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Gets a file-based resource manager from the specified resxName, and the rootPath
        /// </summary>
        /// <param name="resxName">
        /// The .resx file
        /// </param>
        /// <param name="rootPath">
        /// The path containing the file
        /// </param>
        /// <param name="writeInRootPath">
        /// if true, write .resource file in the root path instead of the local app path
        /// </param>
        /// <returns>
        /// The resource manager or null if the file is not found
        /// </returns>
        /// <remarks>
        /// The .resx file is converted to a .resources file if the timestamp is newer on the .resx file
        /// </remarks>
        private static ResourceManager GetResourceManagerFromResx(
            string resxName, string rootPath, bool writeInRootPath = false)
        {
            ResourceManager result = null;
            if (Directory.Exists(rootPath))
            {
                // Check local documents area
                string companyName = AssemblyAttribute.GetAttribute<AssemblyCompanyAttribute>(a => a.Company);
                string productName = AssemblyAttribute.GetAttribute<AssemblyProductAttribute>(a => a.Product);
                string localAppPath = writeInRootPath
                                          ? rootPath
                                          : Path.Combine(
                                              Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                                              companyName,
                                              productName,
                                              "Resources");

                if (!Directory.Exists(localAppPath))
                {
                    Directory.CreateDirectory(localAppPath);
                }

                string[] files = Directory.GetFiles(rootPath, resxName + "*.resx");
                if (files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        string resFile = Path.Combine(
                            localAppPath, Path.GetFileName(file).Replace(".resx", ".resources"));

                        if (!(File.Exists(resFile) && File.GetLastWriteTime(file) <= File.GetLastWriteTime(resFile)))
                        {
                            // Create a .resources file from the .resx file
                            var resourceReader = new ResXResourceReader(file);
                            IDictionaryEnumerator items = resourceReader.GetEnumerator();

                            FileStream fs = null;

                            try
                            {
                                // If a writer cannot be opened, just ignore the error
                                fs = new FileStream(resFile, FileMode.OpenOrCreate, FileAccess.Write);
                            }


                            // ReSharper disable EmptyGeneralCatchClause
                            catch (Exception)
                            {
                                // ReSharper restore EmptyGeneralCatchClause
                                try
                                {
                                    // Try a temporary file
                                    var tmpFile = new TemporaryFile(null, "resources");
                                    resxName = Path.GetFileNameWithoutExtension(tmpFile.FilePath);
                                    localAppPath = Path.GetDirectoryName(tmpFile.FilePath);
                                    fs = tmpFile.FileStream;
                                    _temporaryFiles.Add(tmpFile);
                                }
                                // ReSharper disable EmptyGeneralCatchClause
                                catch (Exception)
                                {
                                    // ReSharper restore EmptyGeneralCatchClause
                                }
                            }

                            if (fs != null)
                            {
                                IResourceWriter writer = new ResourceWriter(fs);

                                while (items.MoveNext())
                                {
                                    writer.AddResource(items.Key.ToString(), items.Value.ToString());
                                }

                                writer.Close();
                            }
                        }
                    }

                    result = ResourceManager.CreateFileBasedResourceManager(resxName, localAppPath, null);
                }
            }

            return result;
        }


        /// <summary>
        /// Get the resource manager for this type
        /// </summary>
        /// <param name="resxName">
        /// The name of the embedded resx
        /// </param>
        /// <param name="designerPath">
        /// The optional path for the designer to find the resx file
        /// </param>
        /// <param name="createIfMissing">
        /// If true, an empty resx file will be created
        /// </param>
        /// <returns>
        /// The resource manager
        /// </returns>
        /// <remarks>
        /// Caches resource managers to improve performance
        /// </remarks>
        public static ResourceManager GetResourceManager(string resxName, string designerPath, bool createIfMissing = false)
        {
            lock (_resourceManagers)
            {
                Tuple<WeakReference, string> reference = null;
                ResourceManager result = null;
                string uniqueName = designerPath == null ? resxName : Path.Combine(designerPath, resxName);
                if (_resourceManagers.TryGetValue(uniqueName, out reference))
                {
                    result = reference.Item1.Target as ResourceManager;

                    // if the resource manager has been garbage collected then remove the cache
                    // entry (it will be re-added)
                    if (result == null)
                    {
                        _resourceManagers.Remove(uniqueName);
                    }
                }

                if (result == null)
                {
                    // Check executing assembly
                    string rootPath = Path.Combine(
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources");
                    result = GetResourceManagerFromResx(resxName, rootPath);

                    if (result == null)
                    {
                        // Try modules
                        rootPath = Path.Combine(
                            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Modules\\Resources");
                        result = GetResourceManagerFromResx(resxName, rootPath);
                    }

                    if (result == null)
                    {
                        // Try startup assembly
                        Assembly entry = Assembly.GetEntryAssembly();
                        if (entry != null)
                        {
                            rootPath = Path.Combine(Path.GetDirectoryName(entry.Location), "Resources");
                            result = GetResourceManagerFromResx(resxName, rootPath);

                            if (result == null)
                            {
                                // Try modules
                                rootPath = Path.Combine(Path.GetDirectoryName(entry.Location), "Modules\\Resources");
                                result = GetResourceManagerFromResx(resxName, rootPath);
                            }
                        }
                    }

                    if (result == null)
                    {
                        // Try designer environment
                        rootPath = Path.Combine(Environment.CurrentDirectory, "Resources");
                        result = GetResourceManagerFromResx(resxName, rootPath);
                    }

                    if (result == null)
                    {
                        // Try designer environment, modules
                        rootPath = Path.Combine(Environment.CurrentDirectory, "Modules\\Resources");
                        result = GetResourceManagerFromResx(resxName, rootPath);
                    }

                    if (result == null)
                    {
                        // Attempt to lookup the path just for the designer
                        if (!string.IsNullOrEmpty(designerPath))
                        {
                            // Try designer path by itself
                            rootPath = designerPath;
                            result = GetResourceManagerFromResx(resxName, rootPath, true);
                            if (result == null)
                            {
                                // Try visual studio environment
                                RegistryKey key = Registry.CurrentUser;
                                RegistryKey vsKey = key.OpenSubKey("Software\\Microsoft\\VisualStudio\\10.0");
                                if (vsKey != null)
                                {
                                    var vsProjectsPath = vsKey.GetValue("DefaultNewProjectLocation") as string;

                                    if (!string.IsNullOrEmpty(vsProjectsPath))
                                    {
                                        vsProjectsPath = Environment.ExpandEnvironmentVariables(vsProjectsPath);
                                        if (!string.IsNullOrEmpty(vsProjectsPath))
                                        {
                                            rootPath = Path.Combine(vsProjectsPath, designerPath, "Resources");
                                            result = GetResourceManagerFromResx(resxName, rootPath, true);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Local documents area is the default
                    string companyName = AssemblyAttribute.GetAttribute<AssemblyCompanyAttribute>(a => a.Company);
                    string productName = AssemblyAttribute.GetAttribute<AssemblyProductAttribute>(a => a.Product);
                    string defaultRootPath =
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                            companyName,
                            productName,
                            "Resources");
                    ResourceManager defaultResx = GetResourceManagerFromResx(resxName, defaultRootPath);

                    if (defaultResx != null)
                    {
                        result = defaultResx;
                        rootPath = defaultRootPath;
                    }

                    if (result == null)
                    {
                        Assembly assembly = FindResourceAssembly(resxName);
                        if (assembly != null)
                        {
                            result = new ResourceManager(resxName, assembly);
                        }
                    }

                    if (result != null)
                    {
                        _resourceManagers.Add(
                            uniqueName,
                            new Tuple<WeakReference, string>(
                                new WeakReference(result), Path.Combine(rootPath, resxName)));
                    }

                    // Nothing found, create a blank
                    if (result == null && !string.IsNullOrEmpty(designerPath) && Directory.Exists(designerPath) && createIfMissing)
                    {
                        var resourceWriter = new ResXResourceWriter(Path.Combine(designerPath, resxName + ".resx"));
                        resourceWriter.Generate();
                        resourceWriter.Close();
                        rootPath = designerPath;
                        result = GetResourceManagerFromResx(resxName, rootPath, true);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Get's the orginal resx file location that was the source of the '.resources' file
        /// </summary>
        /// <param name="resourceManager">
        /// the source resource manager
        /// </param>
        /// <returns>
        /// the path, or null
        /// </returns>
        public static string GetSourceResx(ResourceManager resourceManager)
        {
            return (from value in _resourceManagers.Values
                    let mgr = value.Item1.Target as ResourceManager
                    where mgr == resourceManager
                    select value.Item2).FirstOrDefault();
        }

        /// <summary>
        /// Removes the given resource manager from the active list 
        /// </summary>
        /// <param name="resourceManager">
        /// the resource manager to remove
        /// </param>
        public static void RemoveResourceManager(ResourceManager resourceManager)
        {
            foreach (var kv in _resourceManagers)
            {
                var rm = kv.Value.Item1.Target as ResourceManager;
                if (rm != null && rm == resourceManager)
                {
                    rm.ReleaseAllResources();
                    _resourceManagers.Remove(kv.Key);
                    GC.Collect();
                    break;
                }
            }
        }

        /// <summary>
        /// Removes all resource managers from the list
        /// </summary>
        public static void ResetResourceManager()
        {
            foreach (var kv in _resourceManagers)
            {
                var rm = kv.Value.Item1.Target as ResourceManager;
                if (rm != null)
                {
                    rm.ReleaseAllResources();
                }
            }

            _resourceManagers.Clear();
            GC.Collect();
        }


        #endregion

        #region Methods

        /// <summary>
        /// The delete object.
        /// </summary>
        /// <param name="hObject">
        /// The h object.
        /// </param>
        /// <returns>
        /// The System.Boolean.
        /// </returns>
        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        /// <summary>
        /// Find the assembly that contains the type
        /// </summary>
        /// <param name="resxName">
        /// the name of the resource
        /// </param>
        /// <returns>
        /// the assembly or null
        /// </returns>
        private static Assembly FindResourceAssembly(string resxName)
        {
            Assembly assembly = Assembly.GetEntryAssembly();

            // check the entry assembly first - this will short circuit a lot of searching
            if (assembly != null && HasEmbeddedResx(assembly, resxName))
            {
                return assembly;
            }

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly searchAssembly in assemblies)
            {
                // skip system assemblies
                string name = searchAssembly.FullName;
                if (!name.StartsWith("Microsoft.") && !name.StartsWith("System.") && !name.StartsWith("System,")
                    && !name.StartsWith("mscorlib,") && !name.StartsWith("PresentationFramework,")
                    && !name.StartsWith("WindowsBase,") && !name.StartsWith("Anonymously"))
                {
                    if (HasEmbeddedResx(searchAssembly, resxName))
                    {
                        return searchAssembly;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Check if the assembly contains an embedded resx of the given name
        /// </summary>
        /// <param name="assembly">
        /// The assembly to check
        /// </param>
        /// <param name="resxName">
        /// The name of the resource we are looking for
        /// </param>
        /// <returns>
        /// True if the assembly contains the resource
        /// </returns>
        private static bool HasEmbeddedResx(Assembly assembly, string resxName)
        {
            try
            {
                string[] resources = assembly.GetManifestResourceNames();
                string searchName = resxName.ToLower() + ".resources";
                foreach (string resource in resources)
                {
                    if (resource.ToLower() == searchName)
                    {
                        return true;
                    }
                }
            }
            catch
            {
                // GetManifestResourceNames throws an exception for some
                // dynamic assemblies - just ignore these assemblies.
            }

            return false;
        }

        #endregion
    }
}