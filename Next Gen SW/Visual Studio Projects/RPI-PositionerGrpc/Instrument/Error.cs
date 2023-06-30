using System.Collections.Generic;
using System.Linq;

namespace Ets.Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IError
    {
        List<object> Errors { get; set; }
        void ClearErrors();
        void AddError(object o);
        bool IsError { get; }
        int MaxErrors { get; set; }
        object LastError { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ISupportError
    {
        IError Error { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Error : IError
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        public Error()
        {
        }

        #endregion

        #region Properties

        List<object> _errors = new List<object>();
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public List<object> Errors
        {
            get
            {
                return _errors;
            }
            set
            {
                _errors = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is error; otherwise, <c>false</c>.
        /// </value>
        public bool IsError
        {
            get
            {
                return Errors.Count > 0;
            }
        }

        int _maxErrors = 10;
        /// <summary>
        /// Gets or sets the max errors.
        /// </summary>
        /// <value>
        /// The max errors.
        /// </value>
        public int MaxErrors
        {
            get
            {
                return _maxErrors;
            }
            set
            {
                _maxErrors=value;
            }
        }

        /// <summary>
        /// Gets the last error.
        /// </summary>
        public object LastError
        {
            get
            {
                if (Errors.Count == 0)
                    return null;

                return Errors.Last();
            }

            set
            {
            
            }
        }

        #endregion

        #region Methods
        public void ClearErrors()
        {
            _errors.Clear();
        }

        public void AddError(object o)
        {
            Errors.Add(o);
            if (Errors.Count > MaxErrors)
                Errors.RemoveAt(0);
        }
        #endregion

        #region Static Methods
        public static IError Cast(object o)
        {
            if (o is IError)
                return (IError)o;

            if (o is ISupportError)
                return ((ISupportError)o).Error;

            return null;
        }
        #endregion

    }
}
