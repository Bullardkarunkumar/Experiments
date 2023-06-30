using System;
using System.Diagnostics;
using System.Reflection;

namespace Ets.Common
{
    public delegate void StatusNotificationHandler(object sender, EventArgs args);
/*
    public interface ISupportDisplayString
    {
        public enum DisplayStringDetail
        {
            Normal,
            Detail
        }

        string ToDisplayString(DisplayStringDetail detailLevel);
    }
    */
    public class StatusEventArgs : EventArgs
    {
        #region Constructors

        public StatusEventArgs(object sender, String msg)
        {
            _init();
            Sender = sender;
            Message = msg;

        }

        public StatusEventArgs(object sender, String msg, bool withTrace, int stackLevel)
        {
            _init();
            Sender = sender;
            Message = msg;
            TraceInfo = new TraceInfo(stackLevel);
        }

        public StatusEventArgs(object sender, String msg, double progress)
        {
            _init();

            Sender = sender;
            Message = msg;
            Progress = progress;

            MessageType = MessageTypes.Progress;
        }

        public StatusEventArgs(object sender, String msg, Exception ex)
        {
            Sender = sender;
            MessageType = MessageTypes.Activity;
            Message = msg;
            Exception = ex;

            _init();
        }

        void _init()
        {
            TimeStamp = DateTime.Now;
        }

        #endregion

        #region Properties

        public object Sender;

        public Exception Exception;

        public MessageTypes MessageType { get; set; }

        public double Progress;

        public TraceInfo TraceInfo { get; set; }

        public DateTime TimeStamp { get; set; }

        public String Message { get; set; }

        virtual public String Detail { get; set; }

        public bool IsError
        {
            get
            {
                return Utils.IsNotNull(Exception);
            }
        }

        #endregion

        #region Enums

        public enum MessageTypes
        {
            Activity,
            Progress,
            Warning,
            Error,
            Exception
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            if (Utils.IsNotNull(Exception))
            {
                if(Utils.IsNotEmpty(Exception.Message))
                    return Exception.Message;
            }

            if(Utils.IsNotEmpty(Message))
                return Message;

            if (Utils.IsNotNull(TraceInfo))
                return TraceInfo.ToString();

            return TimeStamp.ToString()+" <Unknown Event>";
        }

        #endregion
    }

    public class ErrorStatusEventArgs : StatusEventArgs
    {
        public ErrorStatusEventArgs(object sender, String msg, Exception ex)
            : base(sender, msg, ex)
        {
            MessageType = MessageTypes.Error;
            if (Utils.IsNotNull(ex))
                MessageType = MessageTypes.Exception;//.Error
        }
    }

    public class TraceInfo
    {
        public TraceInfo(int stackFrameIndex)
        {
            //    Assembly assembly = Assembly.GetCallingAssembly();
            try
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(stackFrameIndex);
                MethodBase methodBase = stackFrame.GetMethod();

                //   AssemblyName = assembly.FullName;
                MethodName = methodBase.Name;
                ObjectType = methodBase.DeclaringType.FullName;
                AssemblyName = methodBase.DeclaringType.Assembly.FullName;
                ModuleName = methodBase.DeclaringType.Assembly.ManifestModule.Name;
            }
            catch (Exception ex)
            {
                Utils.Noop(ex);
            }
        }

        void _init()
        {
        }

        public String AssemblyName = "unknown";
        public String ModuleName = "unknown";
        public String ObjectType = "unknown";
        public String MethodName = "unknown";

        public override string ToString()
        {
            return ObjectType + "." + MethodName + " [" + ModuleName + "]";
        }

    }

    public class ErrorTraceStatusEventArgs : ErrorStatusEventArgs
    {
        public ErrorTraceStatusEventArgs(object sender, String msg, Exception ex, int stackLevel)
            : base(sender, msg, ex)
        {
            if (stackLevel >= 0)
                TraceInfo = new TraceInfo(stackLevel);
        }
    }

    public interface IStatus : ISupportError
    {
        //   UserControl StatusPanel { get; set; } REGJ - should support panels

        event StatusNotificationHandler StatusErrorOccured;
        event StatusNotificationHandler StatusActivityBegin;
        event StatusNotificationHandler StatusActivity;
        event StatusNotificationHandler StatusActivityEnd;
    }

    public interface ISupportStatus
    {
        IStatus Status { get; set; }
    }

    public class Status : IStatus
    {
        #region Private Fields

        const int _stackLevel = 3;

        #endregion

        #region Constructors

        public Status(object owner)
        {
            Owner = owner;
        }

        #endregion

        #region Events

        public event StatusNotificationHandler StatusActivityBegin;

        public event StatusNotificationHandler StatusActivity;
        public event StatusNotificationHandler StatusErrorOccured;

        public event StatusNotificationHandler StatusActivityEnd;

        #endregion

        #region Properties

        object _owner;
        public object Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }

        #endregion

        /*
                UserControl _statusPanel;
                public UserControl StatusPanel
                {
                    get
                    {
                        return _statusPanel;
                    }
                    set
                    {
                        _statusPanel = value;
                    }
                }
         */

        #region ISupportError

        IError _error = new Error();
        public IError Error
        {
            get
            {
                return _error;
            }

            set
            {
                _error = value;
            }
        }

        #endregion

        #region Methods

        public void ErrorOccuredMessage(String msg, bool trace)
        {
            ErrorOccuredMessage(msg, trace, _stackLevel);
        }

        public void ErrorOccuredMessage(String msg, bool trace, int stackLevel)
        {
            if (!trace)
                stackLevel = -1;

            ErrorTraceStatusEventArgs e = new ErrorTraceStatusEventArgs(Owner, msg, null, stackLevel);
            Error.AddError(e);

            if (Utils.IsNull(StatusErrorOccured))
                return;

            StatusErrorOccured(Owner, e);
        }

        public void ErrorOccuredMessage(String msg, Exception ex, bool trace)
        {
            ErrorOccuredMessage(msg, ex, trace, _stackLevel);
        }

        public void ErrorOccuredMessage(String msg, Exception ex, bool trace, int stackLevel)
        {
            if (!trace)
                stackLevel = -1;

            if(Utils.IsEmpty(msg) && Utils.IsNotNull(ex))
                msg = ex.Message;

            ErrorTraceStatusEventArgs e = new ErrorTraceStatusEventArgs(Owner, msg, ex, stackLevel);
            Error.AddError(e);

            if (Utils.IsNull(StatusErrorOccured))
                return;

            if (Utils.IsEmpty(msg) && Utils.IsNotNull(ex))
                msg = ex.Message;

            StatusErrorOccured(Owner, e);
        }

        public void ActivityMessage(String msg)
        {
            if (Utils.IsNull(StatusActivity))
                return;

            StatusActivity(Owner, new StatusEventArgs(Owner, msg));
        }

        public void ActivityMessage(String msg, bool trace)
        {
            if (Utils.IsNull(StatusActivity))
                return;

            StatusActivity(Owner, new StatusEventArgs(Owner, msg, trace, _stackLevel));
        }

        public void ActivityMessage(String msg, double progress)
        {
            if (Utils.IsNull(StatusActivity))
                return;

            StatusActivity(Owner, new StatusEventArgs(Owner, msg, progress));
        }

        public void ActivityBegin(String msg, double progress)
        {
            if (Utils.IsNull(StatusActivityBegin))
                return;

            StatusActivityBegin(Owner, new StatusEventArgs(Owner, msg, progress));
        }

        public void ActivityEnd(String msg, double progress)
        {
            if (Utils.IsNull(StatusActivityEnd))
                return;

            StatusActivityEnd(Owner, new StatusEventArgs(Owner, msg, progress));
        }

        public void ActivityMessage()
        {
            if (Utils.IsNull(StatusActivity))
                return;

            StatusActivity(Owner, new StatusEventArgs(Owner, "normal activity", true, _stackLevel));
        }

        public void ErrorOccuredMessage(Exception ex, bool trace)
        {
            ErrorOccuredMessage("", ex, trace, _stackLevel + 1);
        }

        #endregion
    }
}
