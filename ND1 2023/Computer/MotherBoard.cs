using ND1;
using System.Text;
using System.Xml.Linq;

namespace ND1_2023.Computer
{
    public class MotherBoard : IElementContainer
    {
        public string Name { get; private set; }

        public string Description => ToString();

        private CPU? _cpu;
        private GPU? _gpu;
        private List<SSD> _ssds;
        private List<RAM> _rams;
        private CpuCooller? _cooller;

        private List<IElement> _elements;

        public MotherBoard( string name,
                            CPU? cpu = null,
                            GPU? gpu = null,
                            List<SSD>? ssds = null,
                            List<RAM>? rams = null,
                            CpuCooller? cooller = null)
        {
            Name = name;
            _cpu = cpu;
            _gpu = gpu;
            _ssds = new List<SSD>(ssds ?? Enumerable.Empty<SSD>());
            _rams = new List<RAM>(rams ?? Enumerable.Empty<RAM>());
            _cooller = cooller;

            _elements = new List<IElement>
            {
                _cpu!,
                _gpu!,
                _cooller!
            };
            _elements.AddRange(_ssds);
            _elements.AddRange(_rams);

            _elements = _elements.Where(x => x != null).ToList();
        }

        public override string ToString()
        {
            return $"Type: {nameof(MotherBoard)}\n" +
                    $"Name: {Name}\n";
        }

        public string GetFullDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Description);

            foreach (var element in _elements) 
            {
                sb.AppendLine(element.Description);
            }

            return sb.ToString();
        }

        public IElement? GetElementByName(string name)
        {
            foreach (IElement el in _elements)
                if (el.Name == name)
                    return el;

            return null;
        }

        public IEnumerable<IElement> GetElementsByName(string name)
        {
            List<IElement> list = new List<IElement>();
            foreach (IElement el in _elements)
                if (el.Name == name)
                    list.Add(el);

            return list;
        }

        public T? GetElementByType<T>() where T : IElement
        {
            foreach (IElement el in _elements)
                if (el is T elT)
                    return elT;

            return default;
        }

        public IEnumerable<T> GetElementsByType<T>() where T : IElement
        {
            List<T> list = new List<T>();
            foreach (IElement el in _elements)
                if (el is T elT)
                    list.Add(elT);

            return list;
        }

        public IEnumerable<IElement> GetAllElements()
        {
            return _elements;
        }
    }
}
