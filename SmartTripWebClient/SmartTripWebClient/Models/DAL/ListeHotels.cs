using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SmartTripWebClient.Models.DAL
{
    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_E_HOTEL_HOT", DataType = "ListHotels", IsNullable = true)]
    public class ListHotels
    {
        [XmlElement("T_E_HOTEL_HOT")]
        public T_E_HOTEL_HOT[] Items { get; set; }
    }
}