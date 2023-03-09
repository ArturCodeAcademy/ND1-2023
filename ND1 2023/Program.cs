using ND1_2023.Computer;

CPU cpu = new CPU("AMD Ryzen 9 9500", "AMD", 8, 4.5f, 256, 64, 16);
GPU gpu = new GPU("Nvidia RTX 4090", "Nvidia", 16384, 2235, 24);
List<SSD> ssds = new List<SSD>()
{
    new SSD ("Samsung 1T", 1024, true)
};
List<RAM> rams = new List<RAM>()
{
    new RAM ("Samsung 16 GB", RAM.MemoryModuleType.DDR4),
    new RAM ("Samsung 16 GB", RAM.MemoryModuleType.DDR4),
};
CpuCooller cpuCooller = new CpuCooller("Cool master", 120);

MotherBoard motherBoard = new MotherBoard("Asus B550", cpu, gpu, ssds, rams, cpuCooller);

PSU psu = new PSU("Cheaftec", 750);
List<Fan> fans = new List<Fan>()
{
    new Fan("Cool air", 1450, 120),
    new Fan("Cool air", 1450, 120),
    new Fan("Cool air", 1450, 120),
    new Fan("Cool air", 1450, 120),
    new Fan("Cool air", 1450, 120)
};

List<Disk> disks = new List<Disk>()
{
    new HDD ("Toshiba 4T", 4096, 7200),
    new HDD ("Toshiba 4T", 4096, 7200),
    new SSD ("Samsung 500 GB", 500, false)
};

Case @case = new Case("Cardboard box", motherBoard,  psu, fans, disks); 

Console.WriteLine(@case.GetFullDescription());