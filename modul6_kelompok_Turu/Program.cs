using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_Kelompok_08
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataMahasiswa1302200017 data = new DataMahasiswa1302200017();
			data.ReadJSON();
		}

	}

	internal class DataMahasiswa_1302200017_davi
	{
		public static main readJSON()
		{
			String jsonString = File.ReadAllText("C://Users/ASUS/source/repos/modul6_kelompok_Turu/modul6_kelompok_Turu");

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