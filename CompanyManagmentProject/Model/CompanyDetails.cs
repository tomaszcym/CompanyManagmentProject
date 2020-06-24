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
        public static String name { get; set; } = "Ustaw nazwe firmy";
        public static String nip { get; set; } = "Ustaw NIP firmy";
        public static String address { get; set; } = "Ustaw adres firmy";
        public static String city { get; set; } = "Ustaw miasto";
        public static String postcode { get; set; } = "Ustaw kod pocztowy";
        public static String country { get; set; } = "Ustaw państwo";
    }
}
