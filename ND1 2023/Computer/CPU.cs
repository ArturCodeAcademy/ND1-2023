using ND1;

namespace ND1_2023.Computer
{
    public class CPU : IElement, IEquatable<CPU>
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public short CoreCount { get; private set; }
        public float Frequency { get; private set; }
        public short? CasheL1 { get; private set; }
        public short? CasheL2 { get; private set; }
        public short? CasheL3 { get; private set; }


        public string Description => ToString();

        public CPU( string name,
                    string manufacturer,
                    short coreCount,
                    float frequency,
                    short? casheL1,
                    short? casheL2,
                    short? casheL3)
        {
            Name = name;
            Manufacturer = manufacturer;
            CoreCount = coreCount;
            Frequency = frequency;
            CasheL1 = casheL1;
            CasheL2 = casheL2;
            CasheL3 = casheL3;
        }

        public override string ToString()
        {
            return  $"Type: {nameof(CPU)}\n" +
                    $"Name: {Name}\n" +
                    $"Manufacturer: {Manufacturer}\n" +
                    $"Core count: {CoreCount}\n" +
                    $"Frequency: {Frequency}\n" +
                    $"CasheL1: {CasheL1}\n" +
                    $"CasheL2: {CasheL2}\n" +
                    $"CasheL3: {CasheL3}\n";
        }

        public override bool Equals(object? obj)
        {
            if (obj is CPU cpu)
                return Equals(cpu);
            return false;
        }

        public bool Equals(CPU? other)
        {
            if (ReferenceEquals(other, this))
                return true;

            if (other == null)
                return false;

            if (    other.Name != Name
                ||  other.Manufacturer != Manufacturer
                ||  other.CoreCount != CoreCount
                ||  other.Frequency != Frequency
                ||  other.CasheL1 != CasheL1
                ||  other.CasheL2 != CasheL2
                ||  other.CasheL3 != CasheL3)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Manufacturer, CoreCount,
                Frequency, CasheL1, CasheL2, CasheL3);
        }

        public static bool operator ==(CPU? a, object? b)
            => a?.Equals(b) ?? ReferenceEquals(b, null);

        public static bool operator !=(CPU? a, object? b)
            => !(a == b);

        public static bool operator ==(CPU? a, CPU? b)
            => a?.Equals(b) ?? ReferenceEquals(b, null);

        public static bool operator !=(CPU? a, CPU? b)
            => !(a == b);
    }
}
