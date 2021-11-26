using dnkh.covidnumbers.models;
using Microsoft.AspNetCore.Components;

namespace Client.Components
{
    public partial class DetailsDialog : ComponentBase
    {
        private bool DoRenderComponent {get;set;} = false;
        protected override bool ShouldRender()
        {
        return DoRenderComponent;
        }

    

    private CityData CityData {get;set;}
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;

    public void Open(CityData cityData)
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        CityData = cityData;
        DoRenderComponent = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        
        StateHasChanged();
        DoRenderComponent = false;
    }
    }
}