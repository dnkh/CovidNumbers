using dnkh.covidnumbers.models;

namespace Client.Services
{
    public interface ICovidDataService
    {
         Task<CovidModel> GetCovidData();
    }
}