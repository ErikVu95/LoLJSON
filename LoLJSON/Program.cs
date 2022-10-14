using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace LoLJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new Options();
            test.MenyOptions();
        }
    }
}

//Sortere etter tags, lage champ, counterpicks