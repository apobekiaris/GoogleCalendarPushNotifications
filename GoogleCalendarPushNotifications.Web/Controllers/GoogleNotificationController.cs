using Microsoft.AspNetCore.Mvc;

namespace GoogleCalendarPushNotifications.Web.Controllers
{
    [Route("api/googlenotifications/")]
    public class GoogleNotificationController : Controller
    {
        public GoogleNotificationController()
        {

        }

        [HttpPost("events")]
        public string Post(int id)
        {
            return "value";
        }
    }
}
