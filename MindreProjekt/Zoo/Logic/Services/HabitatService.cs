using Logic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Logic.Habitats;

namespace Logic.Services
{
    public class HabitatService
    {
        private HabitatDataAccess _db;

        public HabitatService()
        {
            _db = new HabitatDataAccess();
        }

        public void AddHabitatToDB(Habitat habitat)
        {
           
        }

    }
}
