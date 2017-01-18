using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Serialization;

namespace SmartTripWebClient.Models.DAL
{
    public class DALAbonne : IDal
    {
        String APIServer = "http://localhost:2293";
        String Application = "API";
        public void Dispose()
        {
            throw new NotImplementedException();
        }

         

        CollectionModel IDal.RenvoiTous()
        {
            throw new NotImplementedException();
        }
        public T_E_ABONNE_ABO SearchUser(string mail)
        {

            string StringContent = GetDataFromAPI("Search/Abonne/?mail=" + mail, "GET");
            XmlSerializer xs = new XmlSerializer(typeof(ListAbonne));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(StringContent));
            var obj = xs.Deserialize(ms) as ListAbonne;

            return obj.Items.First();


        }
        public void Register(T_E_ABONNE_ABO abonne)
        {
            using (WebClient client = new WebClient())
            {
                string[] tab = { APIServer, Application, "Abonne" };
                String FullURL = string.Join("/", tab);
                byte[] response =
                client.UploadValues(FullURL, new NameValueCollection()
                {
                       { "ABO_ADRLIGNE1", abonne.ABO_ADRLIGNE1.ToString() },
                       { "ABO_ADRLIGNE2", abonne.ABO_ADRLIGNE2.ToString() },
                       { "ABO_AEROPORT", abonne.ABO_AEROPORT.ToString() },
                       { "ABO_CP", abonne.ABO_CP.ToString() },
                       { "ABO_ETAT", abonne.ABO_ETAT.ToString() },
                       { "ABO_LATITUDE", abonne.ABO_LATITUDE.ToString() },
                       { "ABO_LONGITUDE", abonne.ABO_LONGITUDE.ToString() },
                       { "ABO_MEL", abonne.ABO_MEL.ToString() },
                       { "ABO_MOTPASSE", abonne.ABO_MOTPASSE.ToString() },
                       { "ABO_NOM", abonne.ABO_NOM.ToString() },
                       { "ABO_PRENOM", abonne.ABO_PRENOM.ToString() },
                       { "ABO_PSEUDO", abonne.ABO_PSEUDO.ToString() },
                       { "ABO_TEL", abonne.ABO_TEL.ToString() },
                       { "ABO_VILLE", abonne.ABO_VILLE.ToString() },
                       { "PAY_ID", abonne.PAY_ID.ToString() },
                       { "IND_INDICATIF", abonne.IND_INDICATIF.ToString() },
 


                });

                string result = System.Text.Encoding.UTF8.GetString(response);
            }
        }

        CollectionModel IDal.Search(string query)
        {
            throw new NotImplementedException();
        }
        public string GetDataFromAPI(String endPoint, String method)
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