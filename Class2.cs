using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Calendari
{
    internal class WriteFile
    {
        public static void Registrstionclass(string Name, string Description, DateOnly date )
        {
            Sobitie sob = new Sobitie();
            sob.Description = Description;
            sob.Name = Name;
            sob.Data = date;

            string text = File.ReadAllText("C:\\Users\\Fetis\\Desktop\\f.json");             
            List<Sobitie> calendar1 = JsonConvert.DeserializeObject<List<Sobitie>>(text);
            calendar1.Add(sob);

            string json = JsonConvert.SerializeObject(calendar1);
            File.WriteAllText("C:\\Users\\Fetis\\Desktop\\f.json", json);

        }
    }
}
