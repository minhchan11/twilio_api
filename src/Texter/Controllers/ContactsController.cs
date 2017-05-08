using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Texter.Models;

namespace Texter.Controllers
{
    public class ContactsController : Controller
    {
        private TexterContext db = new TexterContext();
        public IActionResult Index()
        {
            return View(db.Contacts.ToList());
        }
    }
}
