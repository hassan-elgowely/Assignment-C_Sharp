using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02.Question_03
{
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string Message)
        {
            Console.WriteLine($"SMS Notification => {recipient} : {Message}"); ;
        }
    }
}
