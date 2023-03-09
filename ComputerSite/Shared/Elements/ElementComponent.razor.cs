using Microsoft.AspNetCore.Components;
using ND1;

namespace ComputerSite.Shared.Elements
{
    public partial class ElementComponent
    {
        [Parameter] public IElement Element { get; set; }
        [Parameter] public EventCallback OnAddClick { get; set; }
        [Parameter] public bool ShowAddButton { get; set; }
    }
}