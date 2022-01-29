using System.Net;

WebClient client = new WebClient();
var strPage = client.DownloadString("https://www.avtoall.ru/catalog/paz-20/avtobusy-36/paz_672m-393/");
Console.ReadLine();
