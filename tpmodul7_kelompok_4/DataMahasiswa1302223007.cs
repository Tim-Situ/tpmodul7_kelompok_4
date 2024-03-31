using System;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
	public class DataMahasiswa1302223007
	{
        public class Nama
        {
            public String depan { get; set; }
            public String belakang { get; set; }
        }

        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../tp7_1_1302223007.json";
            // membaca file json
            string jsonString = File.ReadAllText(filepath);
            // deserialize file json menjadi object
            DataMahasiswa1302223007 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223007>(jsonString);
            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim "
                + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
}

