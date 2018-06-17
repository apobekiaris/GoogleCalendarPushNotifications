using System;
using System.Threading.Tasks;

namespace GoogleCalendarPushNotifications.App
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var service = new GoogleServiceWrapper();

            // Attempting to authenticate with Google Calendar api.
            bool success = await service.InitialiseService();
            Console.WriteLine(success ? Constants.GoogleAuthenticationSuccess : Constants.GoogleAuthenticationFailure);

            if (success)
            {
                // Attempting to register a push notification channel for receiving event change notifications.
                success = await service.RegisterPushNotificationChannel();
                Console.WriteLine(success ? Constants.RegisterChannelSuccess : Constants.RegisterChannelFailure);

                if (success)
                {
                    Console.WriteLine();
                    Console.WriteLine(Constants.DeregisterChannel);
                    Console.ReadKey();

                    // Attempting to deregister the push notification channel.
                    success = await service.DeregisterPushNotificationChannel();
                    Console.WriteLine();
                    Console.WriteLine(success ? Constants.DeregisterChannelSuccess : Constants.DeregisterChannelFailure);
                }
            }

            Console.WriteLine(Constants.TerminateProgram);
            Console.ReadKey();
        }
    }
}
