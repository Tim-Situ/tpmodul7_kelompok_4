using System;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
	public class KuliahMahasiswa1302223007
	{
        public class Course
        {
            public String code { get; set; }
            public String name { get; set; }
        }

        public List<Course> courses { get; set; }

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../../tp7_2_1302223007.json");

            KuliahMahasiswa1302223007 dataJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223007>(jsonString);

            int i = 0;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine("MK " + (i+1) + " " + course.code + " - " + course.name);
                i++;
            }
        }
    }
}

