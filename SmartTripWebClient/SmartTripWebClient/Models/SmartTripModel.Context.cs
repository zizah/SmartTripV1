﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartTripWebClient.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartTripEntities1 : DbContext
    {
        public SmartTripEntities1()
            : base("name=SmartTripEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_E_ABONNE_ABO> T_E_ABONNE_ABO { get; set; }
        public virtual DbSet<T_E_ALIAS_ALI> T_E_ALIAS_ALI { get; set; }
        public virtual DbSet<T_E_AVIS_AVI> T_E_AVIS_AVI { get; set; }
        public virtual DbSet<T_E_HOTEL_HOT> T_E_HOTEL_HOT { get; set; }
        public virtual DbSet<T_E_HOTELIER_HTR> T_E_HOTELIER_HTR { get; set; }
        public virtual DbSet<T_E_PHOTO_PHO> T_E_PHOTO_PHO { get; set; }
        public virtual DbSet<T_E_REPONSEAVIS_REP> T_E_REPONSEAVIS_REP { get; set; }
        public virtual DbSet<T_J_STYLEAVIS_STA> T_J_STYLEAVIS_STA { get; set; }
        public virtual DbSet<T_R_CATEGORIEHOTEL_CAT> T_R_CATEGORIEHOTEL_CAT { get; set; }
        public virtual DbSet<T_R_EQUIPEMENT_EQU> T_R_EQUIPEMENT_EQU { get; set; }
        public virtual DbSet<T_R_FOURCHETTEPRIX_PRX> T_R_FOURCHETTEPRIX_PRX { get; set; }
        public virtual DbSet<T_R_INDICATIFTEL_IND> T_R_INDICATIFTEL_IND { get; set; }
        public virtual DbSet<T_R_LANGUEAVIS_LNG> T_R_LANGUEAVIS_LNG { get; set; }
        public virtual DbSet<T_R_LIEUALENTOUR_LAL> T_R_LIEUALENTOUR_LAL { get; set; }
        public virtual DbSet<T_R_PAYS_PAY> T_R_PAYS_PAY { get; set; }
        public virtual DbSet<T_R_PERIODEVISITE_PER> T_R_PERIODEVISITE_PER { get; set; }
        public virtual DbSet<T_R_STYLE_STY> T_R_STYLE_STY { get; set; }
        public virtual DbSet<T_R_TYPEVISITE_VIS> T_R_TYPEVISITE_VIS { get; set; }
        public virtual DbSet<T_R_WIFI_WIF> T_R_WIFI_WIF { get; set; }
    }
}