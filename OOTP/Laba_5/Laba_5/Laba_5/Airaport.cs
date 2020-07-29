using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    [Serializable]
    public class Airaport
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public int Places { get; set; }
        public DateTime MadeDate { get; set; }
        public List<CrewMember> Crew { get; set; }

        public Airaport(int id, string type, string model, int places, DateTime madeDate)
        {
            ID = id;
            Type = type;
            Model = model;
            Places = places;
            MadeDate = madeDate;
        }

        public string PlaneInfo()
        {
            return $"ID:{ID}\nТип: {Type}\nМодель: {Model}\nКол-во мест: {Places}\nДата выпуска: {MadeDate.Year}";
        }
        public string CrewInfo()
        {
            string str = "";
            foreach (var x in Crew)
            {
                str += x.CrewInfo();
            }
            return str;
        }
    }
}
