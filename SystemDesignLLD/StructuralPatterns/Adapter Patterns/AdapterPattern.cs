using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDesignLLD.BehaviouralPatterns.Observer_Pattern;

namespace SystemDesignLLD.StructuralPatterns.Adapter_Patterns
{
    public class AdapterPattern
    {
        //NotificationService notificationService = new EmailNotificationService();
        // We changed EmailNotificationService to SendCloudNotificationService
        NotificationService notificationService = new SendCloudAdapter( new SendCloudNotificationService());
        public void MainMethod()
        {
            notificationService.send("dev@ml.com","Order confirmed","your order will be delivered by next event");
        }
    }

    interface NotificationService
    {
        void send(string to, string subject, string body);
    }

    public class EmailNotificationService : NotificationService
    {
        public void send(string to, string subject, string body)
        {
            Console.WriteLine("Sending to " + to);
            Console.WriteLine("Subject is :  " + subject);
            Console.WriteLine("Body is  " + body);
        }
    }


    // We changed the service from EmailNotificationService to SendCloudNotificationService

    public class SendCloudNotificationService
    {
        public void sendCloudEmail(string recipient, string  title, String content)
        {
            Console.WriteLine("Sending to " + recipient);
            Console.WriteLine("Subject is :  " + title);
            Console.WriteLine("Body is  " + content);
        }
    }

    // SendCloudNotificationService service is not compatible with notificationService  
    // because have different sendCloudEmail() method and  parameter
    // for that resolving problem introduced adapter 

    public class SendCloudAdapter : NotificationService
    {
        private SendCloudNotificationService _sendCloudNotificationService;

        public SendCloudAdapter(SendCloudNotificationService sendCloudNotificationService)
        {
            _sendCloudNotificationService = sendCloudNotificationService;
        }

        //Adapter Method -> convert parameters and calls to SendCloud Method
        public void send(string to, string subject, string body)
        {
            _sendCloudNotificationService.sendCloudEmail(to,subject,body);
        }
    }

}
