using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTripWebClient.Models.DAL
{
    public interface IDal : IDisposable
    {


        ListHotels RenvoieTousLesHotels();
        ListHotels RechercherHotel(string tag);


    }

}
