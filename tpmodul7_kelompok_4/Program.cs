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
        DataMahasiswa1302223042 mahasiswa = new DataMahasiswa1302223042();
        mahasiswa.ReadJSON();

        KuliahMahasiswa1302223042 kuliah = new KuliahMahasiswa1302223042();
        kuliah.ReadJSON();

        DataMahasiswa1302223127 mahasiswa = new DataMahasiswa1302223127();
        mahasiswa.ReadJSON();

        Console.WriteLine();

        KuliahMahasiswa1302223127 course = new KuliahMahasiswa1302223127();
        course.ReadJSON();
    }


}