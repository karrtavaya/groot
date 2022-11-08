using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace groot
{
    internal class controller
    {
        public void Save(groots[] groot)
        {
            var json = JsonSerializer.Serialize<groots[]>(groot);
            File.WriteAllText("groots.json", json);
        }
        public groots[] Load(string path)
        {
            path = "groot.json";
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                var json = File.ReadAllText(path);
                groots[] groot = JsonSerializer.Deserialize<groots[]>(json);
                return groot;



            }
        }

    }
}
