using System;

namespace Ets.Common
{
    public interface IDescription
    {

        string Tag { set; get; }

        string Name { set; get; }

        string DisplayName { set; get; }

        IHelp Help { set; get; }
    }

    public interface ISupportDescription
    {
        IDescription Description { get; set; }
    }

    public class Description : IDescription
    {
        public Description()
        {
        }

        public Description(string name)
        {
            Name = name;
            DisplayName = name;
        }

        string _tag = string.Empty;

        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag=value;
            }
        }

        String _name = string.Empty;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name=value;
            }
        }

        string _displayName = string.Empty;

        public string DisplayName
        {
            get
            {
                return _displayName;
            }
            set
            {
                _displayName = value;
            }
        }

        public IHelp Help
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

        public static IDescription Cast(object o)
        {
            if (o is IDescription)
                return (IDescription)o;

            if (o is ISupportDescription)
                return ((ISupportDescription)o).Description;

            return null;
        }
    }
}
