using System.Text.Json;

namespace DP_HWS1
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool InPregnant { get; set; }

        public Person(bool inPregnant)
        {
            Id = CreateRandomInteger(111111111, 999999999);
            Name = GetRandomNameString();
            Age = CreateRandomInteger(13, 100);
            Height = CreateRandomHeight();
            Weight = CreateRandomInteger(40, 120);
            InPregnant = inPregnant;
        }

        public override string ToString()
        {
            return $"\n\n{Name}, Id: {Id}, Age: {Age}, Height: {Height}, Weight: {Weight}";
        }

        public static double CreateRandomHeight()
        {
            Random r = new Random();
            return Math.Round(r.NextDouble() + 1.3, 2);
        }
        public static int CreateRandomInteger(int from, int to)
        {
            Random r = new Random();
           
            return r.Next(from, to);
        }
        public static string GetRandomNameString()
        {
            Random r = new Random();

            string[] names = { "David","Rotem", "Yoni","Adi", "Dani",
                "Shir", "Moshe","Yael", "Nir",
                "Anat","Reuven","Galit", "Shimi","Dana",
                "Yogev","Osnat", "Gad","Tali", "Natan",
                "Liat","Eyal","Rona" };
            int index = r.Next(0, names.Length);
            return names[index];

        }
    }
}
