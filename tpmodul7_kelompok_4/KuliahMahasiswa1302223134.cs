using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class Courses
    {
        public String code { get; set; }
        public String name { get; set; }
    }

    public class KuliahMahasiswa1302223134
    {
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../../../tp7_2_1302223134.json");

            KuliahMahasiswa1302223134 dataJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223134>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}