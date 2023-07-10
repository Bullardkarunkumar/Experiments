// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemporaryFile.cs" company="ETS-Lindgren LP">
//   Copyright ETS-Lindgren, All rights reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ETS.Localization
{
    using System;
    using System.IO;

    /// <summary>
    /// The temporary file.
    /// </summary>
    public sealed class TemporaryFile : IDisposable
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryFile"/> class.
        /// </summary>
        public TemporaryFile()
            : this(Path.GetTempPath())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryFile"/> class.
        /// </summary>
        /// <param name="directory">
        /// The directory.
        /// </param>
        public TemporaryFile(string directory)
        {
            this.Create(Path.Combine(directory, Path.GetRandomFileName()));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryFile"/> class.
        /// </summary>
        /// <param name="directory">The directory</param>
        /// <param name="extension">The file extension</param>
        public TemporaryFile(string directory, string extension)
        {
            this.Create(Path.Combine(directory ?? Path.GetTempPath(), Path.GetRandomFileName() + "." + extension));
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="TemporaryFile"/> class. 
        /// </summary>
        ~TemporaryFile()
        {
            this.Delete();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets FilePath.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the FileStream
        /// </summary>
        public FileStream FileStream { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            this.Delete();
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        private void Create(string path)
        {
            this.FilePath = path;
            this.FileStream = new FileStream(this.FilePath, FileMode.OpenOrCreate, FileAccess.Write);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        private void Delete()
        {
            if (this.FilePath == null)
            {
                return;
            }

            try
            {
                File.Delete(this.FilePath);
            }
// ReSharper disable EmptyGeneralCatchClause
            catch (Exception)
// ReSharper restore EmptyGeneralCatchClause
            {
            }

            this.FileStream.Close();
            this.FilePath = null;
        }

        #endregion
    }
}