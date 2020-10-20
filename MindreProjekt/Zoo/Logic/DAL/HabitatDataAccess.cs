
using Logic.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Logic.Habitats;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Logic.DAL
{
    public class HabitatDataAccess
    {
        private const string path = @"D:\C-Sharp\MindreProjekt\Zoo\Logic\DAL\Habitats.json";


        /// <summary>
        /// Loads Habitats from the last time the program was used.
        /// </summary>
        /// <returns></returns>
        public static List<Habitat> LoadHabitats(string path)
        {
            StreamReader sr = new StreamReader(path);
            var json = sr.ReadToEnd();
            List<Habitat> habitats = JsonConvert.DeserializeObject<List<Habitat>>(json);
            sr.Close();

            if (habitats == null)
            {
                habitats = new List<Habitat>();
            }

            return habitats;
        }

        /// <summary>
        /// Serializes a newly created habitat into the database
        /// </summary>
        /// <param name="habitats"></param>
        public static void AddHabitatToDB(List<Habitat> habitats)
        {
            //StreamWriter sw = new StreamWriter(path);
            
            //string json = JsonConvert.SerializeObject(habitats, Formatting.Indented);
            //sw.Write(json);
            //sw.Close();

        }

       
    }
}
