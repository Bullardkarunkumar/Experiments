using System;

namespace Ets.Common
{
    public interface IHelp
    {
        String SimpleHelp { set; get; }
        Uri MainHelpFile { set; get; }
        Uri[] OtherHelpFiles { set; get; }

        object HelpPanel { set; get; }
    }

    class Help : IHelp
    {
        public string SimpleHelp
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Uri MainHelpFile
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Uri[] OtherHelpFiles
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public object HelpPanel
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
