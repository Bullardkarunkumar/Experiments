namespace Ets.Instrument
{
    public  class ScriptItem
    {
        public ScriptItem()
        { }

        public ScriptItem(string line)
        {
            Line = line;
        }

        string _line = string.Empty;
        public string Line
        {
            get
            {
                return _line;
            }
            set
            {
                _line = value;
            }
        }

        public override string ToString()
        {
            return Line;
        }
    }
}
