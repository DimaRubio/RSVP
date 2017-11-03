using RSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSVP.Controllers
{
    public class InvitationController : Controller
    {
        // GET: Invitation
        [HttpGet]
        public ActionResult Invitation()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Invitation(GuestResponse guest)
        {
            if (ModelState.IsValid)
                return View("Thanks", guest);
            else
                // Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}