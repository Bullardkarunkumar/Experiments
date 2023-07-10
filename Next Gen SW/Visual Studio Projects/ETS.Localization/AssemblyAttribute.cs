// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyAttribute.cs" company="ETS-Lindgren LP">
//   Copyright ETS-Lindgren, All rights reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ETS.Localization
{
    using System;
    using System.Reflection;

    /// <summary>
    /// The assembly attribute.
    /// </summary>
    public static class AssemblyAttribute
    {
        #region Public Methods

        /// <summary>
        /// Generic function for retrieving the current executing assembly attributes
        /// </summary>
        /// <typeparam name="T">
        /// the attribute type
        /// </typeparam>
        /// <param name="value">
        /// the param to get
        /// </param>
        /// <returns>
        /// the string value
        /// </returns>
        public static string GetAttribute<T>(Func<T, string> value) where T : Attribute
        {
            var attribute = (T)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
            return value.Invoke(attribute);
        }

        #endregion
    }
}