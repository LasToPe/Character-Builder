using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Character_Builder.Models;
using Microsoft.AspNetCore.Mvc;

namespace Character_Builder.Controllers
{
    public class SectionController : Controller
    {
        public IActionResult TestAction()
        {
            ContentModel.TestInt++;
            return PartialView("Sections/Test");
        }
    }
}