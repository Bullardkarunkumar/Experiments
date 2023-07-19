using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.SwitchFramework
{
    public abstract class SwitchBase
    {
        //errors              
        private bool _executionError;
        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public bool ExecutionError
        {
            get { return _executionError; }
        }
        protected void SetErrorMessage(string errMsg)
        {
            _executionError = true;
            _errorMessage = SetErrorMessageOnCode(errMsg);
        }

        private string SetErrorMessageOnCode(string error)
        {
            if (error.Contains("ERROR_205"))
                return ParametersTypeInfo.ERROR_205;
            else if (error.Contains("ERROR_201"))
                return ParametersTypeInfo.ERROR_201;
            else if (error.Contains("ERROR_202"))
                return ParametersTypeInfo.ERROR_202;
            else if (error.Contains("ERROR_206"))
                return ParametersTypeInfo.ERROR_206;
            else if (error.Contains("ERROR_207"))
                return ParametersTypeInfo.ERROR_207;
            else if (error.Contains("ERROR_208"))
                return ParametersTypeInfo.ERROR_208;
            else if (error.Contains("ERROR_211"))
                return ParametersTypeInfo.ERROR_211;
            else
                return error;
        }
    }
}
