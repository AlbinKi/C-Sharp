using Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Services
{
    public interface IErrand
    {
        public void AddErrand();
        public void RemoveErrand();
    }
    public class Errand:IErrand
    {
        public string ErrandType { get; set; }
        public int NeededComponent { get; set; }

        public DateTime DateOfCreation { get; set; }

        public Errand(string errandtype, int neededcomponent)
        {
            ErrandType = errandtype;
            NeededComponent = neededcomponent;
            DateOfCreation = DateTime.Now;
        }

        public void AddErrand()
        {

        }
        public void RemoveErrand()
        {

        }
    }
}
