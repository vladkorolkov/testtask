string url = "https://www.avtoall.ru/catalog/paz-20/avtobusy-36/paz_672m-393/#";
HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://www.avtoall.ru/");
using (HttpResponseMessage response = client.GetAsync(url).Result)
{
   using ( HttpContent content = response.Content)
    {
        string result = content.ReadAsStringAsync().Result;
    }
}