using System.Runtime.Intrinsics.Arm;

namespace ND1_2023.Computer
{
    public class SSD : Disk
    {
        public bool Nvme { get; private set; }

        public SSD(string name, short storage, bool nvme) : base(name, storage)
        {
            Nvme = nvme;
        }

        public override string ToString()
        {
            return  $"{base.ToString()}\n" +
                    $"NVME: {(Nvme ? "+" : "-")}\n";
        }
    }
}
