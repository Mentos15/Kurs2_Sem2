using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    public static class SwitchForms
    {
        public static CreateObject CreateObject;
        public static Plain Plain = new Plain();
        public static AddCrew Crew = new AddCrew();

        public static CreateObject ReturnCrObj()
        {
            return CreateObject = new CreateObject();
        }
    }
}
