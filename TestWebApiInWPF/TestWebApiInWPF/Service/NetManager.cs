using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestWebApiInWPF.Models;

namespace TestWebApiInWPF.Service
{
    public static class NetManager
    {
        public static string URL = "https://localhost:44329/";
        public static HttpClient httpClient = new HttpClient();

        public static async Task <T> Get<T>(string controller)
        {
            var response = await httpClient.GetAsync(URL + controller);
            var content  = await response.Content.ReadAsStringAsync();  
            var data = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            return data;
        }
        public static async Task<HttpResponseMessage> Post<T>(string controller, T data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var response = await httpClient.PostAsync(URL + controller, new StringContent(jsonData, Encoding.UTF8, "application/json"));
            return response;
        }
        public static async Task<HttpResponseMessage> Put<T>(string controller, T data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var response = await httpClient.PutAsync(URL + controller, new StringContent(jsonData, Encoding.UTF8, "application/json"));
            return response;
        }
        public static async Task<HttpResponseMessage> Delete<T>(string controller)
        {
            var response = await httpClient.DeleteAsync(URL + controller);
            return response;
        }
    }
}
