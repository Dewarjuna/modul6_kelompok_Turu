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
			TeamMembers1302204014 tim = new TeamMembers1302204014();
			tim.ReadJSON();

		}	

	}
    internal class DataMahasiswa1302204014
    {
        public void ReadJSON()
        {
			String jsonString = File.ReadAllText("D://Kuliah//SEMESTER 4//KONSTRUKSI PERANGKAT LUNAK SE-44-03 [HIK]//Praktikum//MOD6//modul6_kelompok_Turu//modul6_kelompok_Turu//jurnal6_1_1302204014.json");
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
			


		}

    }
	internal class TeamMembers1302204014
    {
		public void ReadJSON()
		{
			String jsonString = File.ReadAllText("D://Kuliah//SEMESTER 4//KONSTRUKSI PERANGKAT LUNAK SE-44-03 [HIK]//Praktikum//MOD6//modul6_kelompok_Turu//modul6_kelompok_Turu//jurnal6_2_1302204014.json");
			dynamic tim = JsonConvert.DeserializeObject(jsonString);

			Console.WriteLine("Nama : " + tim.firstName1 + " " + tim.lastName1);
			Console.WriteLine("Gender : " + tim.gender1);
			Console.WriteLine("Umur : " + tim.age1);
			Console.WriteLine("NIM : " + tim.nim1);
			Console.WriteLine();

			Console.WriteLine("Nama : " + tim.firstName2 + " " + tim.lastName2);
			Console.WriteLine("Gender : " + tim.gender2);
			Console.WriteLine("Umur : " + tim.age2);
			Console.WriteLine("NIM : " + tim.nim2);
			Console.WriteLine();

			Console.WriteLine("Nama : " + tim.firstName3 + " " + tim.lastName3);
			Console.WriteLine("Gender : " + tim.gender3);
			Console.WriteLine("Umur : " + tim.age3);
			Console.WriteLine("NIM : " + tim.nim3);
			Console.WriteLine();

			Console.WriteLine("Nama : " + tim.firstName3 + " " + tim.lastName3);
			Console.WriteLine("Gender : " + tim.gender3);
			Console.WriteLine("Umur : " + tim.age3);
			Console.WriteLine("NIM : " + tim.nim3);
			Console.WriteLine();

			Console.WriteLine("Nama : " + tim.firstName4 + " " + tim.lastName4);
			Console.WriteLine("Gender : " + tim.gender4);
			Console.WriteLine("Umur : " + tim.age4);
			Console.WriteLine("NIM : " + tim.nim4);
			Console.WriteLine();

			Console.WriteLine("Nama : " + tim.firstName5 + " " + tim.lastName5);
			Console.WriteLine("Gender : " + tim.gender5);
			Console.WriteLine("Umur : " + tim.age5);
			Console.WriteLine("NIM : " + tim.nim5);
			Console.WriteLine();

		}
	}
}