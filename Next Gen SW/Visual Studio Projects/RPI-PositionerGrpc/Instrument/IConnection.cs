namespace Ets.Instrument
{
    /// <summary>
    /// Interface that defines a connection to a Device over Serial or TCP
    /// To Reads and Write over the connection
    /// </summary>
    public interface IConnection
    {
        void SetDevice(Device device);
        bool ConnectToDevice();
        bool WriteToDevice(string message);
        bool ReadFromDevice(out string response);
        bool IsConnected();
        void CloseConnection();
    }
}
