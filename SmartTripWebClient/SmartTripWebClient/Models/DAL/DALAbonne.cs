using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;

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
    }
}