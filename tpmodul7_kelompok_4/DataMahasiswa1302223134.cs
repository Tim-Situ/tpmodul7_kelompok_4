using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class DataMahasiswa1302223134
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }
    }

    public class MyJSON
    {
        //private string filepath = "D:/Telkom University/LMS/Semester 4/Praktikum/KPL/Week 6/tpmodul7_kelompok4/tp7_1_1302223134.json";
        private string filepath = "../../../../tp7_1_1302223134.json";
        public void ReadJSON()
        {
            // Baca file JSON yang diinginkan
            String jsonString = File.ReadAllText(filepath);

            //Deserialize file json menjadi object
            DataMahasiswa1302223134 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223134>(jsonString);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }
}
