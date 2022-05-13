using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    internal class RestApiQueries
    {
        private HttpClient _client;
        public RestApiQueries()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5000/api/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> AddDresseurAsync(Models.Dresseur dresseur,string path)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(dresseur),Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(path,content);
            if (response.IsSuccessStatusCode)
                return true;
            else 
                return false;
        }
        public bool AddDresseur(Models.Dresseur newDresseur,string path)
        {
            try
            {
                Task<bool> task = Task.Run(async() =>await AddDresseurAsync(newDresseur,path));
                task.Wait();
                return task.Result;
            }
            catch (Exception) { }
            return false;
        }

        public async Task<List<Models.Dresseur>> GetDresseursAsync(string path)
        {
            HttpResponseMessage response = await _client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string data=await response.Content.ReadAsStringAsync();
                List<Models.Dresseur> dresseurs = JsonConvert.DeserializeObject<List<Models.Dresseur>>(data);
                return dresseurs;
            }
            return new List<Models.Dresseur>();
        }

        public List<Models.Dresseur> GetDresseurs(string path)
        {
            List<Models.Dresseur> dresseurs = new List<Models.Dresseur>();
            try
            {
                Task<List<Models.Dresseur>> task = Task.Run(async () => await GetDresseursAsync(path));
                task.Wait();
                dresseurs = task.Result;
            }
            catch(Exception) { }
            return dresseurs;
        }
    }
}
