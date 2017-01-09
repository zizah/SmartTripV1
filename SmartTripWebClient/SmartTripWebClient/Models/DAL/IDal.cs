using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTripWebClient.Models.DAL
{
    public interface IDal : IDisposable
    {


        T_E_ABONNE_ABO AuthentifierAbonne(string nom, string password);


    }
}
