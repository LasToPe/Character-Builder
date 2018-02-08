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
        public void TestAction()
        {
            ContentModel.character.Strength_Score += 2;
            //return PartialView("Sections/Ability_Scores");
        }
    }
}