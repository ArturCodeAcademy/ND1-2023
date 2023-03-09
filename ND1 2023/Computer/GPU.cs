using ND1;

namespace ND1_2023.Computer
{
    public class GPU : IElement
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public short CoreCount { get; private set; }
        public float Frequency { get; private set; }
        public float Memory { get; private set; }

        public string Description => ToString();

        public GPU(string name, string manufacturer, short coreCount, float frequency, float memory)
        {
            Name = name;
            Manufacturer = manufacturer;
            CoreCount = coreCount;
            Frequency = frequency;
            Memory = memory;
        }

        public override string ToString()
        {
            return $"Type: {nameof(GPU)}\n" +
                    $"Name: {Name}\n" +
                    $"Manufacturer: {Manufacturer}\n" +
                    $"Core count: {CoreCount}\n" +
                    $"Frequency: {Frequency}\n" +
                    $"Memory: {Memory}\n";
        }
    }
}
