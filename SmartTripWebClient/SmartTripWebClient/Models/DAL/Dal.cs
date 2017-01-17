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
using System.Collections.Specialized;
using Microsoft.AspNet.Identity;

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


            string StringContent = GetDataFromAPI("Search/Hotel/"+query, "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListHotels));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListHotels;

            return obj;



        }

        public T_E_HOTELIER_HTR SearchUser(string mail)
        {

            string StringContent = GetDataFromAPI("Search/User/?mail="+mail, "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListHoteliers));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListHoteliers;

            return obj.Items.First();


        }

        public T_E_HOTEL_HOT cleanHotel(T_E_HOTEL_HOT hotel)
        {
            if(hotel.HOT_NBCHAMBRES == null)
              hotel.HOT_NBCHAMBRES = -1;
            if (hotel.HOT_SITEWEB == null)
                hotel.HOT_SITEWEB = "N/R";
            if (hotel.HOT_ETAT == null)
                hotel.HOT_ETAT = "N/R";
            if (hotel.HOT_ADRLIGNE2 == null)
                hotel.HOT_ADRLIGNE2 = "N/R";
            hotel.HOT_LATITUDE = 0;
            hotel.HOT_LONGITUDE = 0;


            return hotel;
        }
        public int addHotel(T_E_HOTEL_HOT hotel_)
        {
            //HTR_ID
            T_E_HOTEL_HOT hotel = cleanHotel(hotel_);
            string userID=HttpContext.Current.User.Identity.GetUserId();
            T_E_HOTELIER_HTR user = SearchUser(userID);

            using (WebClient client = new WebClient())
            {
                string[] tab = { APIServer, Application, "Hotel" };
                String FullURL = string.Join("/", tab);
                byte[] response =
                client.UploadValues(FullURL, new NameValueCollection()
                {
                       { "CAT_NBETOILES", hotel.CAT_NBETOILES.ToString() },
                       { "PRX_ID", hotel.PRX_ID.ToString() },
                       { "HOT_ADRLIGNE1", hotel.HOT_ADRLIGNE1.ToString() },
                       { "HOT_ADRLIGNE2", hotel.HOT_ADRLIGNE2.ToString() },
                       { "HOT_CP", hotel.HOT_CP.ToString() },
                       { "HOT_DESCRIPTION", hotel.HOT_DESCRIPTION.ToString() },
                       { "HOT_ETAT", hotel.HOT_ETAT.ToString() },
                       { "HOT_LATITUDE", hotel.HOT_LATITUDE.ToString() },
                       { "HOT_LONGITUDE", hotel.HOT_LONGITUDE.ToString() },
                       { "HOT_MEL", hotel.HOT_MEL.ToString() },
                       { "HOT_NBCHAMBRES", hotel.HOT_NBCHAMBRES.ToString() },
                       { "HOT_NOM", hotel.HOT_NOM.ToString() },
                       { "HOT_SITEWEB", hotel.HOT_SITEWEB.ToString() },
                       { "HOT_TEL", hotel.HOT_TEL.ToString() },
                       { "HOT_VILLE", hotel.HOT_VILLE.ToString() },
                       { "HTR_ID", user.HTR_ID.ToString() },
                       { "IND_INDICATIF", hotel.IND_INDICATIF.ToString() },
                       { "PAY_ID", hotel.PAY_ID.ToString() },
 
                });

                string result = System.Text.Encoding.UTF8.GetString(response);
                return 0;
            }
 



        }


        public ListPrix getDefinitionPrixIndicatif()
        {
            string StringContent = GetDataFromAPI("Search/PRX_ID/", "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListPrix));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListPrix;

            return obj;

        }
        public ListPays getDefinitionPays()
        {
            string StringContent = GetDataFromAPI("Search/PAYS/", "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListPays));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListPays;

            return obj;

        }
        public ListEtoiles getDefinitionEtoiles()
        {
            string StringContent = GetDataFromAPI("Search/ETOILES/", "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListEtoiles));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListEtoiles;

            return obj;

        }
        public ListIND getDefinitionIND()
        {
            string StringContent = GetDataFromAPI("Search/IND/", "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListIND));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListIND;

            return obj;

        }
        public ListHotels RenvoieTousLesHotels()
        {


            string StringContent = GetDataFromAPI("Hotel", "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListHotels));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListHotels;

            return obj;



        }

        public T_E_HOTEL_HOT RenvoieHotel(int ID)
        {


            string StringContent = GetDataFromAPI("Hotel/"+ ID,"GET");


            XmlSerializer xs = new XmlSerializer(typeof(T_E_HOTEL_HOT));
            T_E_HOTEL_HOT p;
            using (TextReader rd = new StringReader(StringContent))
                p = xs.Deserialize(rd) as T_E_HOTEL_HOT;


            return p;
        }
        public string GetDataFromAPI(String endPoint,String method)
        {
            string[] tab = { APIServer, Application, endPoint };
            String FullURL = string.Join("/", tab);
            Console.WriteLine(FullURL);

            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FullURL);
            request.ContentType = "application/xml; charset=utf-8";
            request.Method = method;
 
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
 
           



        }

        
    }
    

}