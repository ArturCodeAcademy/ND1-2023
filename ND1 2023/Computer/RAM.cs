using ND1;

namespace ND1_2023.Computer
{
    public class RAM : IElement
    {
        public string Name { get; private set; }
        public MemoryModuleType MemoryType { get; private set; }

        public string Description => ToString();

        public RAM(string name, MemoryModuleType memoryType)
        {
            Name = name;
            MemoryType = memoryType;
        }

        public override string ToString()
        {
            return $"Type: {nameof(RAM)}\n" +
                    $"Name: {Name}\n" +
                    $"Memory type: {MemoryType}\n";
        }

        public enum MemoryModuleType
        {
            DDR1,
            DDR2,
            DDR3,
            DDR4,
            DDR5
        }
    }
}
