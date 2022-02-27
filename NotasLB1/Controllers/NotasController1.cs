using Microsoft.AspNetCore.Mvc;
using NotasLB1.Bussines;
using NotasLB1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NotasLB1.Controllers
{
    public class NotasController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
