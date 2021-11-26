using Client.Services;
using dnkh.covidnumbers.models;
using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    public partial class Index : ComponentBase
    {
        private CovidModel CurrentCovidData {get;set;}
        private CovidModel FilteredCovidData {get;set;}
        [Inject]
        private ICovidDataService CovidDataService {get;set;}

        public void SearchValueChanged( ChangeEventArgs args )
        {
            FilteredCovidData.Cities = CurrentCovidData.Cities.Where( c => c.CityData.Name.ToLower().Contains(args.Value.ToString().ToLower())).ToList();
        }

        protected override async Task OnInitializedAsync()
        {
            CurrentCovidData = await CovidDataService.GetCovidData();
            FilteredCovidData = new CovidModel
            {
                Cities = new List<City>(CurrentCovidData.Cities)
            };

        }
    }
}