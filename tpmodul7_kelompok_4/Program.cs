/* 

KELOMPOK 4 (TIM SITU)

ANGOTA:
Fauzein Mulya Warman / 1302223127
Iksan Oktav Risandy / 1302223042
Muhammad Dias Adani / 1302223134
Muhammad Haulul Azkiyaa / 1302223007
Muhammad Nur Shodiq / 1302223054

*/

using tpmodul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        // Kode Shodiq
        DataMahasiswa1302223054 DataMahasiswa1302223054 = new DataMahasiswa1302223054();
        DataMahasiswa1302223054.ReadJSON();

        KuliahMahasiswa1302223054 KuliahMahasiswa1302223054 = new KuliahMahasiswa1302223054();
        KuliahMahasiswa1302223054.ReadJSON();

        Console.WriteLine("\n==========\n");
      
        // Kode Dias
        DataMahasiswa1302223134 mahasiswa1302223134 = new DataMahasiswa1302223134();
        mahasiswa1302223134.ReadJSON();

        Console.WriteLine();

        KuliahMahasiswa1302223134 course1302223134 = new KuliahMahasiswa1302223134();
        course1302223134.ReadJSON();

        Console.WriteLine("\n==========\n");

        // KODE HAULUL
        DataMahasiswa1302223007 mahasiswa1302223007 = new DataMahasiswa1302223007();
        mahasiswa1302223007.ReadJSON();

        Console.WriteLine();

        KuliahMahasiswa1302223007 course1302223007 = new KuliahMahasiswa1302223007();
        course1302223007.ReadJSON();

        Console.WriteLine("\n==========\n");

        // KODE FAUZEIN
        DataMahasiswa1302223127 mahasiswa1302223127 = new DataMahasiswa1302223127();
        mahasiswa1302223127.ReadJSON();

        Console.WriteLine("");

        KuliahMahasiswa1302223127 course1302223127 = new KuliahMahasiswa1302223127();
        course1302223127.ReadJSON();

        Console.WriteLine("\n==========\n");

        // KODE IKSAN
        DataMahasiswa1302223042 mahasiswa1302223042 = new DataMahasiswa1302223042();
        mahasiswa1302223042.ReadJSON();

        KuliahMahasiswa1302223042 kuliah1302223042 = new KuliahMahasiswa1302223042();
        kuliah1302223042.ReadJSON();
    }
}