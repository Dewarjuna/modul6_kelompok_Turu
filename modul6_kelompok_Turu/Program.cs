using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_Turu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa_1302204031_Dewa data = new DataMahasiswa_1302204031_Dewa();
            data.ReadJSON();

            Console.WriteLine("");
        }
    }
}
