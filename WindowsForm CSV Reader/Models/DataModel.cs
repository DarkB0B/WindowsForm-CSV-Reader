using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
namespace WindowsForm_CSV_Reader.Models
{
    public class DataModel
    {

        [Name("zdjecie")]
        public string Main_Picture { get; set; }

        [Name("zdjęcie")]
        public string Pictures { get; set;}

        [Key]
        [Name("KOD")]
        public string ID_KARTOTEKI { get; set; }

        [Name("nazwa")]
        public string NAZWA { get; set; }

        [Name("EAN")]
        public string EAN { get; set; }

        [Name("Producent")]
        public string PRODUCENT { get; set; }

        [Name("atrybut stan unimet")]
        public string STAN_NA_MAGAZYNIE { get; set; }

        [Name("Vat")]
        public string VAT { get; set; }

        [Name("waga")]
        public string WAGA { get; set; }

        [Name("jm")]
        public string JEDNOSTKA_MIARY { get; set; }

        [Name("opis html")]
        public string OPIS { get; set; }

        [Name("atrybut unimet min zamówieniowe")]
        public string MIN_ZAM { get; set; }

        [Name("nr katalogowy")]
        public string KOD_PRODUCENTA { get; set; }

    }
}
