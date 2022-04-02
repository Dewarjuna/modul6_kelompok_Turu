using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_Turu
{
    internal class TeamMembers_1302204031
    {
        public class data1
        {
            public string firstname;
            public string lastname;
            public string gender;
            public int age;
            public string nim;
        }

        public void ReadJSON()
        {

            string dataStr = File.ReadAllText(@"C:\Users\Dewa\source\repos\modul6_kelompok_Turu\jurnal6_1_1302204031.json");
            //data1 dataMahasiswa = JsonSerializer.Deserialize<data1>(dataStr);
            dynamic data = JsonConvert.DeserializeObject(dataStr);

            foreach (var item in data.members)
            {
                Console.WriteLine("Nim : " + item.nim);
                Console.WriteLine("Nama : " + item.firstName + " " + item.lastName);
                Console.WriteLine("Gender : " + item.gender);
                Console.WriteLine("Umur : " + item.age);
                Console.WriteLine();
            }
        }
    }
}