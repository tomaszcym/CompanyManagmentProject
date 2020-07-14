using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public static class CompanyDetails
    {
        public static int id { get; set; }
        public static String name { get; set; } = "TMA Company";
        public static String nip { get; set; } = "85 774 478 41";
        public static String address { get; set; } = "ul. Podkarpacka 11a";
        public static String city { get; set; } = "Rzeszów";
        public static String postcode { get; set; } = "98-009";
        public static String country { get; set; } = "Polska";
    }
}
