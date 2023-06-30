using System;

namespace Ets.Instrument
{
    public interface IConnector
    {
        string ConnectionString { get; set; }
    }

    public class Connector : IConnector
    { 
        #region Constructors
        public Connector()
        {
        }

        public Connector(string connectionString)
        {
            ConnectionString = connectionString;
        }
        #endregion

        #region Properties
        #endregion

        #region Properties (Serializable)

        String _connectionString = string.Empty;
        virtual public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
        #endregion
 
    }
}
