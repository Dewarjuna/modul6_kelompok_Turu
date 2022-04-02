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
		static void Main(string[] args)
        {
			DataMahasiswa1302204014 data = new DataMahasiswa1302204014();
			data.ReadJSON();
		}

	}
    internal class DataMahasiswa1302204014
    {
        public static void main ReadJSON()
        {
			String jsonString = File.ReadAllText("D://Kuliah//SEMESTER 4//KONSTRUKSI PERANGKAT LUNAK SE-44-03 [HIK]//Praktikum//MOD6//modul6_kelompok_Turu//modul6_kelompok_Turu//jurnal6_1_1302204014");
			dynamic data = JsonConvert.DeserializeObject(jsonString);

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
			return main();


		}

    }
}