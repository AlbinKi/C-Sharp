using System;
using System.Collections.Generic;
using System.Text;
using AnimalLibrary;
using HabitatLibrary;
using PersonellLibrary;

namespace Zoo
{
    class ListMethods
    {

        public static void GetChildrenInList(List<Habitat> habitatlist)
        {
            var i = 0;
            var waterList = new List<Oasis>();
            foreach (var habitat in habitatlist)
            {
                var water = habitatlist[i] as Oasis;
                i++;
                if (water != null)
                {
                    waterList.Add(water);
                }
            }
            Console.WriteLine(waterList.Count);
        }
    }
}
