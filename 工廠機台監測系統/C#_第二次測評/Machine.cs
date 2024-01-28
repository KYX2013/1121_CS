using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__第二次測評
{
    internal class Machine
    {
        public string condi, zhiling, name;
        public DateTime startTime, nowTime;
        public int target, real, good, duration;

        public Machine(string s1, string s2, string s3, DateTime d1, DateTime d2, int i1, int i2, int i3, int i4)
        {
            condi = s1;
            zhiling = s2;
            name = s3;
            startTime = d1;
            nowTime = d2;
            target = i1;
            real = i2;
            good = i3;
            duration = i4;
        }
    }
}
