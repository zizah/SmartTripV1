using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
using System.Xml.Serialization;
using System.Text;

namespace SmartTripWebClient.Models.DAL
{
    public class Dal : IDal
    {
        String APIServer= "http://localhost:2293";
        String Application = "API";


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ListHotels SearchHotel(string query)
        {


            string StringContent = GetDataFromAPI("Search/Hotel/"+query);
            XmlSerializer xs = new XmlSerializer(typeof(ListHotels));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListHotels;

            return obj;



        }

 
        public ListPrix getDefinitionPrixIndicatif()
        {
            string StringContent = GetDataFromAPI("Search/PRX_ID/");
            XmlSerializer xs = new XmlSerializer(typeof(ListPrix));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListPrix;

            return obj;

        }
        public ListHotels RenvoieTousLesHotels()
        {


            string StringContent = GetDataFromAPI("Hotel");
            XmlSerializer xs = new XmlSerializer(typeof(ListHotels));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListHotels;

            return obj;



        }

        public T_E_HOTEL_HOT RenvoieHotel(int ID)
        {


            string StringContent = GetDataFromAPI("Hotel/"+ ID);


            XmlSerializer xs = new XmlSerializer(typeof(T_E_HOTEL_HOT));
            T_E_HOTEL_HOT p;
            using (TextReader rd = new StringReader(StringContent))
                p = xs.Deserialize(rd) as T_E_HOTEL_HOT;


            return p;
        }
        public string GetDataFromAPI(String endPoint)
        {
            string[] tab = { APIServer, Application, endPoint };
            String FullURL = string.Join("/", tab);
            Console.WriteLine(FullURL);

            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FullURL);
            request.ContentType = "application/xml; charset=utf-8";
            request.Method = "GET";

            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
            Console.WriteLine(html);

            // dt = JsonConvert.DeserializeObject<DataTable>(maString, new DataTableConverter());
            /* using (var client = new HttpClient())
             {
                 var values = new Dictionary<string, string>
                 {
                    { "thing1", "hello" },
                  };

                 var content = new FormUrlEncodedContent(values);

                 var response = await client.PostAsync(FullURL, content);

                 var responseString = await response.Content.ReadAsStringAsync();

                 return responseString;

             }*/



        }

        
    }
    

}