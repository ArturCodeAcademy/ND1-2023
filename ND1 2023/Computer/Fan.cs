using ND1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND1_2023.Computer
{
    public class Fan : IElement
    {
        public string Name { get; private set; }
        public short Rpm { get; private set; }
        public short Size { get; private set; }

        public string Description => ToString();

        public Fan(string name, short rpm, short size)
        {
            Name = name;
            Rpm = rpm;
            Size = size;
        }

        public override string ToString()
        {
            return $"Type: {nameof(Fan)}\n" +
                    $"Name: {Name}\n" +
                    $"Size: {Size}\n" +
                    $"RPM: {Rpm}\n";

        }
    }
}
