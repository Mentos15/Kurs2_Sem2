﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class SwitchForms
    {
        public static CreateObject CreateObject;
        public static Plain Plain = new Plain();
        public static Crew Crew = new Crew();

        public static CreateObject ReturnCrObj()
        {
            return CreateObject = new CreateObject();
        }
    }
}
