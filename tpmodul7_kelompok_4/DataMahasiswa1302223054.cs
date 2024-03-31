using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_4
{
    internal class DataMahasiswa1302223054
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
    
        // private string filepath = "C:/Praktikum/KPL/tpmodul7_kelompok_4/tp7_1_1302223054.json";
        private string filepath = "../../../../tp7_1_1302223054.json";
        public void ReadJSON()
        {
            //Baca file JSON yang diinginkan
            String jsonString = File.ReadAllText(filepath);

            //Deserialize file json menjadi object
            DataMahasiswa1302223054 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223054>(jsonString);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }    
    }
}
