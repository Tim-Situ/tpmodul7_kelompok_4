using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class Courses
    {
        public String code { get; set; }
        public String name { get; set; }
    }

    public class KuliahMahasiswa1302223042
    {
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:/Users/iksan/source/repos/tpmodul7_kelompok_4/tpmodul7_kelompok_4/json/tp7_2_1302223042.json");

            KuliahMahasiswa1302223042 dataJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223042>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}