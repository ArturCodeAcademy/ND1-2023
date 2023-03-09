using ND1;

namespace ND1_2023.Computer
{
    public class CpuCooller : IElement
    {
        public string Name { get; private set; }
        public short Tdp { get; private set; }

        public string Description => ToString();

        public CpuCooller(string name, short tdp)
        {
            Name = name;
            Tdp = tdp;
        }

        public override string ToString()
        {
            return $"Type: {nameof(CpuCooller)}\n" +
                    $"Name: {Name}\n" +
                    $"TDP: {Tdp}";

        }
    }
}
