using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Observer
{
    public class Store
    {
        private NotificationService _notificationService;

        public Store(NotificationService notificationService)
        {
           _notificationService = notificationService;
        }

        public void announce(string message)
        {
            _notificationService.notify(message);
        }
    }
}
