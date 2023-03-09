using ND1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND1_2023.Computer
{
    public class PSU : IElement
    {
        public string Name { get; private set; }
        public short Power { get; private set; }

        public string Description => ToString();

        public PSU(string name, short power)
        {
            Name = name;
            Power = power;
        }

        public override string ToString()
        {
            return $"Type: {nameof(PSU)}\n" +
                    $"Name: {Name}\n" +
                    $"Power: {Power}\n";
        }

    }
}
