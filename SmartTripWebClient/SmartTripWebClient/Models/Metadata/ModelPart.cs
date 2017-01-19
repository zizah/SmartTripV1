using SmartTripWebClient.Models.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartTripWebClient.Models

{
    // LISTE META DATA DEFINITIONS
    [MetadataType(typeof(T_E_HOTEL_HOTMetadata))]
    public partial class T_E_HOTEL_HOT
    {
    }

    [MetadataType(typeof(T_E_ABONNE_ABOMetadata))]
    public partial class T_E_ABONNE_ABO
    {
    }
}