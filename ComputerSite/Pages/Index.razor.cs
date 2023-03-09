using ComputerSite.Repository;
using ND1;

namespace ComputerSite.Pages
{
	public partial class Index
    {
        private IEnumerable<IElement> _elements;
        private string _seletableElement;
		private AvailableElementsRepository _repo;
		private Action<IElement> _onClick;
		private bool _showAddButton;
		private List<IElement> _selectedElements;

		protected override void OnInitialized()
        {
			_repo = repo;
            _elements = _repo.GetAvailableCPU();
			_seletableElement = "CPU";
            _onClick = Step1;
			_showAddButton = true;
			_selectedElements = new List<IElement>();
		}

		private void Step1(IElement el)
        {
			_elements = _repo.GetAvailableGPU();
			_selectedElements.Add(el);
			_seletableElement = "GPU";
			_onClick = Step2;
		}

		private void Step2(IElement el)
		{
			_elements = _repo.GetAvailableCpuCooler();
			_selectedElements.Add(el);
			_seletableElement = "CPU Cooler";
			_onClick = Step3;
		}

		private void Step3(IElement el)
		{
			_elements = _repo.GetAvailableFan();
			_selectedElements.Add(el);
			_seletableElement = "Fan";
			_onClick = Step4;
		}

		private void Step4(IElement el)
		{
			_elements = _repo.GetAvailableHDD();
			_selectedElements.Add(el);
			_seletableElement = "HDD";
			_onClick = Step5;
		}

		private void Step5(IElement el)
		{
			_elements = _repo.GetAvailableSSD();
			_selectedElements.Add(el);
			_seletableElement = "SSD";
			_onClick = Step6;
		}

		private void Step6(IElement el)
		{
			_elements = _repo.GetAvailablePSU();
			_selectedElements.Add(el);
			_seletableElement = "PSU";
			_onClick = Step7;
		}

		private void Step7(IElement el)
		{
			_elements = _repo.GetAvailableRAM();
			_selectedElements.Add(el);
			_seletableElement = "RAM";
			_onClick = Step8;
		}

		private void Step8(IElement el)
		{
			_showAddButton = false;
			_seletableElement = "Result";
			_selectedElements.Add(el);
			_elements = _selectedElements;
		}

	}
}