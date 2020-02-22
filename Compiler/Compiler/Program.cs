using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LangTokens;

namespace Compiler
{
    class Program
    {

        static void Main(string[] args)
        {

            Symbol sym = new Symbol("かわいかった", new いAdjAffPastTypeStrategy());
            Symbol sym2 = new Symbol("むずかしくなかった", new いAdjNegPastTypeStrategy());
            Symbol sym3 = new Symbol("むずかしくなかった", new いAdjNegPresTypeStrategy());

            if (sym.Word == "かわいい" && sym2.Word == "むずかしい")
                Console.WriteLine("It works!");
        }
    }
}
