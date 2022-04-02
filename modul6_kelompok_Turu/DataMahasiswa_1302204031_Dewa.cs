﻿using Newtonsoft.Json;
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
            dynamic data = JsonConvert.DeserializeObject(dataStr);



            Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
            Console.WriteLine("Gender : " + data.gender);
            Console.WriteLine("Umur : " + data.age);
            Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
            Console.WriteLine("Mata Kuliah : ");
            foreach (var item in data.courses)
            {
                Console.WriteLine();
                Console.WriteLine("Kode matkul : " + item.code);
                Console.WriteLine("Nama matkul : " + item.name);
            }
            Console.WriteLine();
        }
    }
}