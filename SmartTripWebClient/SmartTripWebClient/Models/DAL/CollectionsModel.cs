using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SmartTripWebClient.Models.DAL
{


    // COUCHE PERMETTANT DE GERER LES COLLECTIONS DE DONNES RECUPERES PAR LE WS DE TYPE ArrayOf<MODEL_CLASS>
    public class CollectionModel
    {

    }

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_E_ABONNE_ABO", DataType = "ListAbonne", IsNullable = true)]
    public class ListAbonne : CollectionModel
    {
        [XmlElement("T_E_ABONNE_ABO")]
        public T_E_ABONNE_ABO[] Items { get; set; }
    }

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_E_HOTELIER_HTR", DataType = "ListHoteliers", IsNullable = true)]
    public class ListHoteliers: CollectionModel
    {
        [XmlElement("T_E_HOTELIER_HTR")]
        public T_E_HOTELIER_HTR[] Items { get; set; }
    }
    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_E_HOTEL_HOT", DataType = "ListHotels", IsNullable = true)]
    public class ListHotels: CollectionModel
    {
        [XmlElement("T_E_HOTEL_HOT")]
        public T_E_HOTEL_HOT[] Items { get; set; }
    }

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_R_FOURCHETTEPRIX_PRX", DataType = "ListPrix", IsNullable = true)]
    public class ListPrix: CollectionModel
    {
        [XmlElement("T_R_FOURCHETTEPRIX_PRX")]
        public T_R_FOURCHETTEPRIX_PRX[] Items { get; set; }
    }

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_R_PAYS_PAY", DataType = "ListPays", IsNullable = true)]
    public class ListPays: CollectionModel
    {
        [XmlElement("T_R_PAYS_PAY")]
        public T_R_PAYS_PAY[] Items { get; set; }
    }

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_R_INDICATIFTEL_IND", DataType = "ListIND", IsNullable = true)]
    public class ListIND: CollectionModel
    {
        [XmlElement("T_R_INDICATIFTEL_IND")]
        public T_R_INDICATIFTEL_IND[] Items { get; set; }
    }

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_E_PHOTO_PHO", DataType = "ListPhoto", IsNullable = true)]
    public class ListPhoto : CollectionModel
    {
        [XmlElement("T_E_PHOTO_PHO")]
        public T_E_PHOTO_PHO[] Items { get; set; }
    }

    

    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/SmartTripV1.Models", ElementName = "ArrayOfT_R_CATEGORIEHOTEL_CAT", DataType = "ListEtoiles", IsNullable = true)]
    public class ListEtoiles: CollectionModel
    {
        [XmlElement("T_R_CATEGORIEHOTEL_CAT")]
        public T_R_CATEGORIEHOTEL_CAT[] Items { get; set; }
    }
}