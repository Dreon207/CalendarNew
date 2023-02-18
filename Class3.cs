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
    internal class ReadFile
    {
     
        List<string> getdate(DateOnly date1)
        {
            List<string> add = new List<string>();
            string text = File.ReadAllText("C:\\Users\\Fetis\\Desktop\\f.json");
            List<Sobitie> calendar1 = JsonConvert.DeserializeObject<List<Sobitie>>(text);

           int i = calendar1.Count();
           int j = 0;
           
           for (j = 0; j<=i; j++)

            {
               if (calendar1[j].Data == date1)

                {

                    add.Add(calendar1[j].Name);

                }
            }

            return add;
        }

        
    }
}
