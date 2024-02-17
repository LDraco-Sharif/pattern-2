using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Observer
{
    public class NotificationService
    {
        private ISet<NotificationListener> _notificationListeners;

        public NotificationService() 
        {
           _notificationListeners = new HashSet<NotificationListener>();
        }

        public void subscribe(NotificationListener listener)
        {
            _notificationListeners.Add(listener);
        }

        public void unsubscribe(NotificationListener listener)
        {
            _notificationListeners.Remove(listener);
        }

        public void notify(string message)
        {
            foreach (var listener in _notificationListeners)
            {
                listener.notify(message);
            }
        }
    }
}
