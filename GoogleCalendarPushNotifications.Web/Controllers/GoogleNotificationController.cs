using Microsoft.AspNetCore.Mvc;

namespace GoogleCalendarPushNotifications.Web.Controllers
{
    [Route("api/googlenotifications/")]
    public class GoogleNotificationController : Controller
    {
        public GoogleNotificationController()
        { }

        /// <summary>
        /// Receiving endpoint for Google Calendar push notifications.
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpPost("events")]
        public IActionResult Post()
        {
            var headers = HttpContext.Request.Headers;

            return new OkResult();
        }
    }
}
