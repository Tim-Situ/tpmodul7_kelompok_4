using System.Runtime.CompilerServices;
using System.Text.Json;

namespace tpmodul7_kelompok_4;

public class DataMahasiswa1302223042
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
     }

     public Nama nama { get; set; }
     public int nim { get; set; }
     public String fakultas { get; set; }

    public void ReadJSON()
    {
        string filepath = "C:/Users/iksan/source/repos/tpmodul7_kelompok_4/tpmodul7_kelompok_4/json/tp7_1_1302223042.json";
        //Baca file Json yang diinginkan
        string jsonString = File.ReadAllText(filepath);
        //Deserialize file json menjadi object
        DataMahasiswa1302223042 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223042>(jsonString);
        Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
    }
}