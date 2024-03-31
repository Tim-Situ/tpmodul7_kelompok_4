using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_4
{
    internal class KuliahMahasiswa1302223054
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public List<Course> courses { get; set; }
        // private string filepath = "C:/Praktikum/KPL/tpmodul7_kelompok_4/tp7_2_1302223054.json";
        private string filepath = "../../../../tp7_2_1302223054.json";

        public void ReadJSON()
        {
            //Baca file JSON yang diinginkan
            String jsonString = File.ReadAllText(filepath);

            //Deserialize file json menjadi object
            KuliahMahasiswa1302223054 dataJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223054>(jsonString);

            int i = 0;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i+1} {course.code} - {course.name}");
                i++;
            }
                
        }
        
    }
}
