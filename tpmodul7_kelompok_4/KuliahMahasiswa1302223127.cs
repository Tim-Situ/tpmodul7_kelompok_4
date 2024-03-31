using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class Courses1302223127
    {
        public String code { get; set; }
        public String name { get; set; }
    }

    public class KuliahMahasiswa1302223127
    {
        public List<Courses1302223127> courses { get; set; }

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../../tp7_2_1302223127.json");

            KuliahMahasiswa1302223127 dataJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223127>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
