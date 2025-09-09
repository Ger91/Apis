using ApiOnePiece.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiOnePiece.Controllers
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public List<Personaje>? Data { get; set; }
    }
    public class PersonajeController
    {
        private HttpClient client;

        public PersonajeController()
        {
            client = new HttpClient();
        }

        public async Task<List<Personaje>> GetAllPersonajes()
        {
            
           try {
                List<Personaje> listaPersonaje = new List<Personaje>();



                ApiResponse apiResponse =new ApiResponse();
                HttpResponseMessage response = await client.GetAsync("https://api.api-onepiece.com/v2/characters/en");

                response.EnsureSuccessStatusCode(); 

                string  responseJson = await response.Content.ReadAsStringAsync();

                listaPersonaje = JsonConvert.DeserializeObject<List<Personaje>>(responseJson);

                return listaPersonaje ;

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return new List<Personaje>();
            }    
        }

        private object JsonConverterCollection<T>(string responseJson)
        {
            throw new NotImplementedException();
        }
    }
}
