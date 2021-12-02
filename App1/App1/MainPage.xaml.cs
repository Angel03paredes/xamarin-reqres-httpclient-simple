using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using App1.models;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        private static readonly HttpClient client = new HttpClient();
        string URL = "https://reqres.in/api/users";
        public  MainPage()
        {
            InitializeComponent();

            getUsers();

        }
       


        private async void getUsers()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(URL);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "aplication/json");

            HttpResponseMessage response = await client.SendAsync(request); 
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                reqres resultado = JsonConvert.DeserializeObject<reqres>(content);

                ListUser.ItemsSource = resultado.data;
               
            }
            
        }
    }
}
