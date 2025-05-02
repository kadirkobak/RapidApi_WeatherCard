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
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul/EN"),
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
                var value = json["main"]["feels_like"].ToString();
                lblFahrenheit.Text = value;


            }
        }
    }
}
