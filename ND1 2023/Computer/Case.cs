using ND1;
using System.Linq;
using System.Text;

namespace ND1_2023.Computer
{
    public class Case : IElementContainer
    {
        public string Name { get; private set; }

        public string Description => ToString();

        private MotherBoard? _motherBoard;
        private PSU? _psu;
        private List<Fan> _fans;
        private List<Disk> _disks;

        private List<IElement> _elements;

        public Case(string name,
                    MotherBoard? motherBoard = null,
                    PSU? psu = null,
                    IEnumerable<Fan>? fans = null,
                    IEnumerable<Disk>? disks = null)
        {
            Name = name;
            _motherBoard = motherBoard;
            _psu = psu;
            _fans = new List<Fan>(fans ?? Enumerable.Empty<Fan>());
            _disks = new List<Disk>(disks ?? Enumerable.Empty<Disk>());

            _elements = new List<IElement>() { _psu!, _motherBoard! };
            _elements.AddRange(_fans);
            _elements.AddRange(_disks);

            _elements = _elements.Where(x => x != null).ToList();
        }

        public override string ToString()
        {
            return $"Type: {nameof(Case)}\n" +
                    $"Name: {Name}\n" +
                    $"";

        }

        public string GetFullDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Description);

            foreach (var element in _elements)
            {
                if (element is IElementContainer container)
                    sb.AppendLine(container.GetFullDescription());
                else
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
            return _elements.OfType<IElementContainer>()
                .SelectMany(x => x.GetAllElements()).Concat(_elements);
        }
    }
}
