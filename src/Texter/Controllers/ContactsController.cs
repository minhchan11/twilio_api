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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
