using System;
using System.Collections.ObjectModel;

namespace Ets.Common.Wpf
{
    class StatusHandler 
    {
        public StatusHandler(ISupportStatus s)
        {
            if (Utils.IsNull(s))
                return;

            _init(s.Status);
        }

        public StatusHandler(IStatus s)
        {
            _init(s);
        }

        private void _init(IStatus s)
        {
            if (Utils.IsNull(s))
                return;

            Clear();

            s.StatusActivity += new StatusNotificationHandler(OnStatusActivity);
            s.StatusActivityBegin += new StatusNotificationHandler(OnStatusActivityBegin);
            s.StatusActivityEnd += new StatusNotificationHandler(OnStatusActivityEnd);
            s.StatusErrorOccured += new StatusNotificationHandler(OnStatusErrorOccured);

        }

        public void Clear()
        {
            _statusItems = new ObservableCollection<StatusEventArgs>();
        }

        ObservableCollection<StatusEventArgs> _statusItems =new ObservableCollection<StatusEventArgs>();
        ObservableCollection<StatusEventArgs> StatusItems
        {
            get
            {
                return _statusItems;
            }
        }

        public virtual void OnStatusErrorOccured(object sender, EventArgs args)
        {
            StatusItems.Add((StatusEventArgs)args);
        }

        public virtual void OnStatusActivityEnd(object sender, EventArgs args)
        {
            StatusItems.Add((StatusEventArgs)args);
        }

        public virtual void OnStatusActivityBegin(object sender, EventArgs args)
        {
            StatusItems.Add((StatusEventArgs)args);
        }

        public virtual void OnStatusActivity(object sender, EventArgs args)
        {
            StatusItems.Add((StatusEventArgs)args);
        }
    }
}
