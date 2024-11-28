// Helpers/ApiHelper.cs
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Helpers
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; private set; }
        public static string JwtToken { get; set; }

        static ApiHelper()
        {
            InitializeClient();
        }

        private static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://localhost:5136/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
