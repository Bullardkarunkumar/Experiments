using System;

namespace Ets.Instrument
{
    public class SimulatedConnection : IConnection
    {
        private bool _isConnected = false;
        public void SetDevice(Device device)
        {
            ;
        }

        public bool ConnectToDevice()
        {
            _isConnected = true;
            return true;
        }

        public bool WriteToDevice(string message)
        {
            return true;
        }

        public bool ReadFromDevice(out string response)
        {
            response = String.Empty;
            return true;
        }

        public bool IsConnected()
        {
            return _isConnected;
        }

        public void CloseConnection()
        {
           _isConnected = false;
        }
    }
}
