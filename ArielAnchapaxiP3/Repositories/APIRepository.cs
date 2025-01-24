using ArielAnchapaxiP3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.Repositories
{
    public class APIRepository
    {
        public APIRepository() { }

        public async Task<AirportModel> GetResponseAPI(string airportname)
        {
            string url = $"https://freetestapi.com/api/v1/airports?search={Uri.EscapeDataString(airportname)}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        string responseAsString = await response.Content.ReadAsStringAsync();
                        AirportModel airport = (AirportModel)JsonConvert.DeserializeObject(responseAsString);

                        return airport;
                    }
                    
                    return null;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
            }
        }
    }
}
