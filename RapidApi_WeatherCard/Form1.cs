using Newtonsoft.Json.Linq;

namespace RapidApi_WeatherCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/konya/EN"),
                Headers =
    {
        { "x-rapidapi-key", "ee46bfe5f8msh9847dc72b78f403p12245cjsn61d2010bb2e7" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var fahrenheit = json["main"]["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                var weatherSituationApi = json["weather"][0]["main"].ToString();
                string weatherSituation = weatherSituationApi.ToString();
                lblFahrenheit.Text = fahrenheit;
                lblWindSpeed.Text = windSpeed;
                lblHumidity.Text = humidity;
                decimal celcius = (decimal.Parse(fahrenheit) - 32) * 5 / 9;
                lblCelcius.Text = celcius.ToString("00.00");


                switch (weatherSituation)
                {
                    case "Clear":
                        weatherImage.Image = Properties.Resources.sunny;
                        break;
                    case "Clouds":
                        weatherImage.Image = Properties.Resources.cloudy;
                        break;
                    case "Rain":
                        weatherImage.Image = Properties.Resources.rainy;
                        break;
                    default:
                        weatherImage.Image = Properties.Resources.sunny;
                        break;
                }

            }
        }
    }
}
