using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoLJSON
{
    public class Options
    {
        static string fileName = "champions.json";
        public string jsonFile = File.ReadAllText(fileName);
        public List<Champion> Champions = new();
        readonly SortValues sortValues = new();
        int option;

        public Options()
        {
            Champions = JsonConvert.DeserializeObject<List<Champion>>(jsonFile);
            sortValues.TagsAdd();
        }
        public void MenyOptions()
        {
            Console.WriteLine("Welcome to my LoL Champion application.\n");

            while (true)
            {
                Console.WriteLine("Type the number of the option you'd like to go to.");
                PrintMenu();
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch /*Exception e*/
                {
                    Console.Clear();
                    Console.WriteLine("Type in a valid number");
                    //  Console.WriteLine(e.Message);
                    //  Console.ReadLine();
                }

                if (option <= 0 || option >= 5)
                {
                    Console.Clear();
                    Console.WriteLine("Type in a valid number");
                }
                if (option == 1) { PrintAllChamps(); }
                else if (option == 2) { sortValues.SortTags(Champions); }
                else if (option == 3) {  }
                else if (option == 4) { Environment.Exit(0); }


            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Print out all champions and stats.");
            Console.WriteLine("2. Sort champions after roles");
            Console.WriteLine("3. placeholder sorter etter noe");
            Console.WriteLine("4. Exit.");
        }

        public void PrintAllChamps()
        {
            foreach (var champ in Champions)
            {

                Console.WriteLine($"\n{champ.Name} \nTitle = {champ.Title}");
                Console.WriteLine("Tags: ");

                foreach (var tag in champ.Tags)
                {
                    Console.Write(tag);
                    Console.WriteLine();
                }

                Console.Write("Hp = " + champ.Stats.Hp + ", ");
                Console.Write("Mana = " + champ.Stats.Mp + ", ");
                Console.Write("Movespeed = " + champ.Stats.Armor + ", ");
                Console.Write("Armor = " + champ.Stats.Armor + ", ");
                Console.Write("Crit = " + champ.Stats.Crit + ", ");
                Console.Write("Attack damage = " + champ.Stats.Attackdamage + ", ");
                Console.Write("Attack speed = " + champ.Stats.Attackspeed + "\n");
            }
            Console.WriteLine("\n\nPress enter to go back to the menu.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
