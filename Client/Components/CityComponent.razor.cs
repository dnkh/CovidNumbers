using dnkh.covidnumbers.models;
using Microsoft.AspNetCore.Components;

namespace Client.Components
{
    public partial class CityComponent : ComponentBase
    {
        [Parameter] public CityData CityData {get;set;}
        public DetailsDialog Details {get;set;}
    }
}