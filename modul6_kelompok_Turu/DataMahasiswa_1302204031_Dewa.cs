using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_Turu
{
    internal class DataMahasiswa_1302204031_Dewa
    {
        public class data1
        {
            public string firstname;
            public string lastname;
            public string gender;
            public int age;
        }

        public void ReadJSON()
        {

            string dataStr = File.ReadAllText(@"C:\Users\Dewa\source\repos\modul6_kelompok_Turu\jurnal6_1_1302204031.json");
            //data1 dataMahasiswa = JsonSerializer.Deserialize<data1>(dataStr);
            data1 dataMahasiswa = JsonConvert.DeserializeObject<data1>(dataStr);


            Console.WriteLine($"Nama {dataMahasiswa.firstname} {dataMahasiswa.lastname} berusia {dataMahasiswa.age} dan bejenis kelamin {dataMahasiswa.gender}");
        }
    }
}