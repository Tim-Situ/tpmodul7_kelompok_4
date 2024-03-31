using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa1302223127
	{
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }

        public void ReadJSON()
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText("../../../tp7_1_1302223127.json");

            //Deserialize file json menjadi object
            DataMahasiswa1302223127 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223127>(jsonString);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }
}