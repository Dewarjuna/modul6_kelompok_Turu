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
			DataMahasiswa_1302204060_Eventa data = new DataMahasiswa_1302204060_Eventa();
			data.readJSON(DataMahasiswa_1302204060_Eventa);
		}

	}
	
	internal class DataMahasiswa_1302204060_Eventa
	{
		public static void main readJSON()
		{
			String jsonString = File.ReadAllText("D://KULIAH//Semester_4//Mata_Kuliah//KONSTRUKSI_PERANGKAT_LUNAK//Praktikum//Modul_6//modul6_kelompok_Turu//modul6_kelompok_Turu//jurnal6_1_1302204060");

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