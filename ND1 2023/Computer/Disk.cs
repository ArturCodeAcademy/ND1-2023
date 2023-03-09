using ND1;

namespace ND1_2023.Computer
{
    public abstract class Disk : IElement
    {
        public string Name { get; protected set; }
        public short Storage { get; protected set; }

        public string Description => ToString();

        public Disk(string name, short storage)
        {
            Name = name;
            Storage = storage;
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name}\n" +
                    $"Name: {Name}\n" +
                    $"Storage: {Storage}";
            
        }
    }
}
