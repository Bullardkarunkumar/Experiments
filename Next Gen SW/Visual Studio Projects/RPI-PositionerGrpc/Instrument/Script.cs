using Ets.Common;
using System.Collections.ObjectModel;

namespace Ets.Instrument
{
    public interface IScript
    {
        IDescription Description { set; get; }
    }

    public class Script : IScript
    {
        public Script()
        { 
        }

        public Script(string name)
        {
            // TODO: Complete member initialization
            _description.Name = name;
        }

        IDescription _description = new Description();
        public IDescription Description 
        {
            set
            {
                _description = value;
            }
            get
            {
                return _description;
            }
        }

        public ObservableCollection<ScriptItem> ScriptItems = new ObservableCollection<ScriptItem>();

        public override string ToString()
        {
            return _description.Name;
        }

        public void Add(string cmd)
        {
            ScriptItems.Add(new ScriptItem(cmd));
        }
    }
}
