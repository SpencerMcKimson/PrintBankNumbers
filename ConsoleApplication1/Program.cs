using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBankNumbers
{
    class Program
    {
        private static Dictionary<int, string[,]> symbols = new Dictionary<int, string[,]>()
        {
            {0, new string[,] { {" ", "_", " "}, {"|", " ", "|"}, {"|", "_", "|"} }},
            {1, new string[,] { {" ", " ", " "}, {" ", "|", " "}, {" ", "|", " "} }},
            {2, new string[,] { {" ", "_", " "}, {" ", "_", "|"}, {"|", "_", " "} }},
            {3, new string[,] { {" ", "_", " "}, {" ", "_", "|"}, {" ", "_", "|"} }},
            {4, new string[,] { {" ", " ", " "}, {"|", "_", "|"}, {" ", " ", "|"} }},
            {5, new string[,] { {" ", "_", " "}, {"|", "_", " "}, {" ", "_", "|"} }},
            {6, new string[,] { {" ", "_", " "}, {"|", "_", " "}, {"|", "_", "|"} }},
            {7, new string[,] { {" ", "_", " "}, {" ", " ", "|"}, {" ", " ", "|"} }},
            {8, new string[,] { {" ", "_", " "}, {"|", "_", "|"}, {"|", "_", "|"} }},
            {9, new string[,] { {" ", "_", " "}, {"|", "_", "|"}, {" ", "_", "|"} }}
        };

        static void Main(string[] args)
        {
            foreach(char c in args[0])
            {
                if (!char.IsDigit(c))
                    throw new System.ArgumentException("Parameter must only consist of numbers");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < args[0].Length; j++)
                {
                    string[,] symbol;
                    symbols.TryGetValue((int)char.GetNumericValue(args[0][j]), out symbol);
                    Console.Write(symbol[i, 0] + symbol[i, 1] + symbol[i, 2]);
                }
                Console.WriteLine();
            }
        }
    }
}
