using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND1_2023.Computer
{
    public class HDD : Disk
    {
        public short Rpm { get; private set; }

        public HDD(string name, short storage, short rpm) : base(name, storage)
        {
            Rpm = rpm;
        }

        public override string ToString()
        {
            return  $"{base.ToString()}\n" +
                    $"RPM: {Rpm}\n";
        }
    }
}
