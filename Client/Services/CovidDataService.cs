using System.Net.Http.Json;
using dnkh.covidnumbers.models;

namespace Client.Services
{
    public class CovidDataService
    {
        public static async Task<CovidModel> GetCovidData()
        {
            var client = new HttpClient();
            var covidData = await client.GetFromJsonAsync<CovidModel>("https://services7.arcgis.com/0Uc5jDlEgdLosloE/arcgis/rest/services/Gemeinden/FeatureServer/0/query?f=json&where=1%3D1&outFields=*&returngeometry=false");
            return covidData;
        }
    }
}