using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLJSON
{

    public class SortValues
    {
        public List<Tag> Tags = new();
        public void TagsAdd()
        {
            Tags.Add(new Tag("Tank", 1));
            Tags.Add(new Tag("Support", 2));
            Tags.Add(new Tag("Mage", 3));
            Tags.Add(new Tag("Marksman", 4));
            Tags.Add(new Tag("Fighter", 5));
            Tags.Add(new Tag("Assassin", 6));
        }

        public void SortTags(List<Champion> champions)
        {
            TagsList();
            int userInput = Convert.ToInt32(Console.ReadLine());

            foreach (var champ in champions)
            {
                foreach (var tag in Tags)
                {
                    if (userInput == tag.Id && champ.Tags.Contains(tag.TagName))
                    {
                        Console.WriteLine(champ.Name);
                    }
                }
            }

            Console.WriteLine();
        }

        public void RangeStats()
        {
            //velg nummer for over eller under så og så mye stats for å printe ut de champsa
        }

        public void TagsList()
        {
            Console.WriteLine("\nChoose a role by typing in a number.");
            foreach (var tag in Tags)
            {
                Console.WriteLine($"{tag.Id}." + $"{tag.TagName}");
            }
        }
    }
}
