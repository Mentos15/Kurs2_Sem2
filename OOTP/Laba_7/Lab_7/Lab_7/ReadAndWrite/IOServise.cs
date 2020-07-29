using Lab_7.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7.ReadAndWrite
{
    class IOServise
    {
        private readonly string Path;

        public IOServise( string path)
        {
            Path = path;
        }

        public BindingList<ToDoModels> LoadData()
        {
            var fileExists = File.Exists(Path);
            if(!fileExists)
            {
                File.CreateText(Path).Dispose();
                return new BindingList<ToDoModels>();
            }
            using (var reader = File.OpenText(Path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoModels>>(fileText);
            }
        }

        public void SaveData(object todoData)
        {
            using (StreamWriter writer = File.CreateText(Path))
            {
                string output = JsonConvert.SerializeObject(todoData);
                writer.Write(output);
            }
        }
    }
}
