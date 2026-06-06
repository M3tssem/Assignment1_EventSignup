using Microsoft.AspNetCore.Mvc;
using Assignment1_EventSignup.Models;

namespace Assignment1_EventSignup.Controllers
{
    public class EventController : Controller
    {
        private static List<Event> events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Title = "Career Fair",
                Date = new DateTime(2026, 2, 1),
                Location = "Gym"
            },
            new Event
            {
                Id = 2,
                Title = "Tech Talk",
                Date = new DateTime(2026, 2, 8),
                Location = "Auditorium"
            },
            new Event
            {
                Id = 3,
                Title = "Hack Night",
                Date = new DateTime(2026, 2, 15),
                Location = "Library"
            }
        };

        public IActionResult Index()
        {
            return View(events);
        }
        public IActionResult Manage(int id)
    }
}