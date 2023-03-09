using ND1_2023.Computer;

namespace ComputerSite.Repository
{
	public class AvailableElementsRepository
	{
		public IEnumerable<CPU> GetAvailableCPU()
		{
			return new List<CPU>()
			{
				new CPU("Intel Core i3 12100F", "Intel", 4, 3.3f, 5, 8, 12),
				new CPU("Intel Core i5 12400F", "Intel", 6, 2.5f, 7, 12, 18),
				new CPU("AMD Ryzen 5 5600X", "AMD", 6, 3.7f, 3, 20, 32),
				new CPU("AMD Ryzen 7 5700X", "AMD", 8, 3.4f, 4, 20, 32)
			};
		}

		public IEnumerable<GPU> GetAvailableGPU()
		{
			return new List<GPU>()
			{
				new GPU("Asus GeForce RTX 3090 ROG Strix Gaming 24GB GDDR6X 384bit", "Asus", 5000, 19.5f, 24),
				new GPU("Gigabyte GeForce RTX 4080 Master 16GB GDDR6X 356bit", "Asus", 6500, 2.5f, 16)
			};
		}

		public IEnumerable<CpuCooller> GetAvailableCpuCooler()
		{
			return new List<CpuCooller>()
			{
				new CpuCooller("Be quiet! Pure Rock Slim 2", 85),
				new CpuCooller("Be quiet! Dark Rock Slim", 150)
			};
		}

		public IEnumerable<Fan> GetAvailableFan()
		{
			return new List<Fan>()
			{
				new Fan("Be quiet! Pure Wings 2", 80, 1900),
				new Fan("Noctua NF-A4x10 FLX", 40, 4500)
			};
		}

		public IEnumerable<HDD> GetAvailableHDD()
		{
			return new List<HDD>()
			{
				new HDD("Seagate IronWolf 12TB 3,5", 12 * 1024, 7200),
				new HDD("Toshiba P300 Bulk 3.5 500GB", 500, 7200)
			};
		}

		public IEnumerable<SSD> GetAvailableSSD()
		{
			return new List<SSD>()
			{
				new SSD("Samsung 980 Pro 1TB", 1024, true),
				new SSD("Innovation IT PerformanceY", 512, false)
			};
		}

		public IEnumerable<PSU> GetAvailablePSU()
		{
			return new List<PSU>()
			{
				new PSU("Be quiet! Straight Power 11 850W", 850),
				new PSU("Thermaltake Toughpower GF1 850W", 850),
			};
		}

		public IEnumerable<RAM> GetAvailableRAM()
		{
			return new List<RAM>()
			{
				new RAM("Kingston Fury Beast RGB Black 16GB DDR4 3200MHZ", RAM.MemoryModuleType.DDR4),
				new RAM("Kingston Fury Renegade RGB Black 16GB DDR4 3600MHZ", RAM.MemoryModuleType.DDR4),
				new RAM("Kingston Fury Beast Black 8GB DDR5 5200MHZ", RAM.MemoryModuleType.DDR5)
			};
		}
	}
}
