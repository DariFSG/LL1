using Newtonsoft.Json;

class Programm
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1, 2 or 3");
            string choose = Console.ReadLine();
            if (choose == "1")
            {
                //Знайти середнє арифметичне від'ємних елементів у списку. Замінити на нього мінімальний елемент списку
                int n = 15;
                List<int> listok = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    listok.Add(rnd.Next(-30, 31));
                }
                Console.WriteLine("New List:");
                foreach (int chis in listok)
                {
                    Console.Write(chis + " ");
                }
                List<int> minus = listok.Where(x => x < 0).ToList();
                int av = (int)minus.Average();
                int min = listok.IndexOf(listok.Min());
                listok[min] = av;
                Console.WriteLine("\nChanged List:");
                foreach (int chis in listok)
                {
                    Console.Write(chis + " ");
                }
            }
            else if (choose == "2")
            {
                //Дано словник. Видалити пробіли в значеннях його ключів
                Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                {"key1", "val ue 1 "},
                {"key2", " value 2 "},
                {"key3", "v alue 3"},
                {"key4", " value 4 "},
                {"key5", "valu e  5" },
                };
                Console.WriteLine("New dictionary:");
                foreach (var sth in dict)
                {
                    Console.WriteLine(sth.Key + ": " + sth.Value);
                }
                Dictionary<string, string> nospd = new Dictionary<string, string>();
                foreach (var sth in dict)
                {
                    string repl = sth.Value.Replace(" ", "");
                    nospd.Add(sth.Key, repl);
                }
                Console.WriteLine("No space dictionary:");
                foreach (var sth in nospd)
                {
                    Console.WriteLine(sth.Key + ": " + sth.Value);
                }
                string json = JsonConvert.SerializeObject(nospd, Formatting.Indented);
                Console.WriteLine("JSON:\n" + json);
            }
            else if (choose == "3")
            {
                //Створити список місяців на рік із зазначенням їх назви та кількістю днів у місяці. Створити список місяців у яких 30 днів
                List<(string, int)> months = new List<(string, int)>
                {
                ("Jan", 31), ("Feb", 28), ("Mar", 31), ("Apr", 30), ("May", 31), ("Jun", 30), ("Jul", 31), ("Aug", 30), ("Sep", 31), ("Oct", 30), ("Nov", 31), ("Dec", 30)
                };
                Console.WriteLine("List of months:");
                foreach (var mon in months)
                {
                    Console.WriteLine(mon.Item1 + " - " + mon.Item2 + " days");
                }
                var thirty = months.Where(mon => mon.Item2 == 30).ToList();
                Console.WriteLine("30 days' months:");
                foreach (var mon in thirty)
                {
                    Console.WriteLine(mon.Item1 + " - " + mon.Item2 + "days");
                }
            }
            else
            {
                Console.WriteLine("Error! Invalid data");
            }
            Console.WriteLine("\nContinue? y/n");
            string a = Console.ReadLine();
            if (a == "n")
            {
                break;
            }
        }
    }
}