using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows;

internal class ApiHelper
{
    public static string Url = "http://api.weatherapi.com/v1/forecast.json?key=0685a95f84dc402996561002231606&";

    public static void Get(string Sity)
    {
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(Url + "q=" + Sity).Result;
            string responseContent = response.Content.ReadAsStringAsync().Result;

            // Десериализация содержимого ответа для извлечения данных о погодных условиях
            var weatherData = JsonConvert.DeserializeObject<Root>(responseContent);
            Forecast location = weatherData.Forecast;

            // Отображение данных о погодных условиях в MessageBox
            var message = $"Погодные условия: {location.forecastday[0].hour[4].temp_c}";
            MessageBox.Show(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
