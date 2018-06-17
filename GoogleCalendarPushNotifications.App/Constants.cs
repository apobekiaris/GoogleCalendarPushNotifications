namespace GoogleCalendarPushNotifications.App
{
    public class Constants
    {
        /// <summary>
        /// The Google account that owns the calendar we are registering for.
        /// </summary>
        public const string GoogleAccount = "[GSUITE ACCOUNT EMAIL]";

        /// <summary>
        /// The calendar id of the Google calendar we are registering for.
        /// </summary>
        public const string GoogleCalendarId = "[GOOGLE CALENDAR ID]";

        /// <summary>
        /// Service account key file name.
        /// </summary>
        public const string ServiceAccountKeyFile = "[SERVICE ACCOUNT KEY FILE NAME].json";

        /// <summary>
        /// The google url for registering notification channels.
        /// </summary>
        public const string GoogleChannelRegistrationUrl = "https://www.googleapis.com/calendar/v3/calendars/" + GoogleCalendarId + "/events/watch";

        /// <summary>
        /// The google url for deregistering notification channels.
        /// </summary>
        public const string GoogleChannelDeregistrationUrl = "https://www.googleapis.com/calendar/v3/channels/stop";

        /// <summary>
        /// The url to receive the google calendar push notifications.
        /// </summary>
        public const string ReceivingUrl = "[RECEIVING URL FOR PUSH NOTIFICATIONS]";

        public const string DeregisterChannel = "Press any key to deregister channel...";
        public const string TerminateProgram = "Press any key to terminate...";
        public const string GoogleAuthenticationSuccess = "Authentication with Google Calendar api was successful...";
        public const string GoogleAuthenticationFailure = "Authentication with Google Calendar api failed...";
        public const string RegisterChannelSuccess = "Registering push notification channel with Google Calendar api was successful...";
        public const string RegisterChannelFailure = "Registering push notification channel with Google Calendar api failed...";
        public const string DeregisterChannelSuccess = "Deregistering push notification channel with Google Calendar api was successful...";
        public const string DeregisterChannelFailure = "Deregistering push notification channel with Google Calendar api was successful...";
    }
}
