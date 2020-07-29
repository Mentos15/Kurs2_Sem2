using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Lab_7.Json
{
    class Serialization
    {
        public static void Save(BindingList<ToDoModels> list)
        {
            using (StreamWriter stream = new StreamWriter(@"json.txt"))
            {
                string outStr = JsonConvert.SerializeObject(list);
                stream.WriteLine(outStr);
            }
        }
        public static void Load()
        {
            if (File.Exists(@"json.txt"))
            {
                using (StreamReader stream = new StreamReader(@"json.txt"))
                {
                    string outStr = stream.ReadToEnd();
                    TaskList.taskList = JsonConvert.DeserializeObject<BindingList<ToDoModels>>(outStr);
                }
            }
        }
    
    }
}
