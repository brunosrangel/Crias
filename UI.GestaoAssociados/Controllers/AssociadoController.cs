using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.GestaoAssociados.Controllers
{
    public class AssociadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}