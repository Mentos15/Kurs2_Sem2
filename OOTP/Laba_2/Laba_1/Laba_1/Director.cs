using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Director
    {
        private readonly IBuild_Zoo  _build;

        public Director (IBuild_Zoo builder)
        {
            _build = builder;
        }

        public Build_Zoo BUILD()
        {
            _build.BuildCage();
            _build.BuildRoad();
            _build.BuildTrees();
            _build.BuildWC();
            return _build.GetResult();
        }
    }
}
