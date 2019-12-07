using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amaya.Models;
using Microsoft.EntityFrameworkCore;
namespace Amaya.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AmayaContext _db;

        public CustomersController(AmayaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Customers> model = _db.Customers.ToList();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    
} 
}       
