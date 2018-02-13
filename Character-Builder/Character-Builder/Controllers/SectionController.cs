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
        public void SetScores(int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma)
        {
            ContentModel.character.Base_Strength_Score = Strength;
            ContentModel.character.Base_Dexterity_Score = Dexterity;
            ContentModel.character.Base_Constitution_Score = Constitution;
            ContentModel.character.Base_Intelligence_Score = Intelligence;
            ContentModel.character.Base_Wisdom_Score = Wisdom;
            ContentModel.character.Base_Charisma_Score = Charisma;
        }
    }
}