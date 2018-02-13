using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions5
{
    class TvProgram
    {
        public string ProgramName { get; set; }
        public int Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Info { get; set; }

        public TvProgram()
        {

        }

        public TvProgram(string name, int cha, string start, string end, string info)
        {
            ProgramName = name;
            Channel = cha;
            StartTime = start;
            EndTime = end;
            Info = info;
        }

    }
}
