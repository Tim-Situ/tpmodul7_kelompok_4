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
    }


}