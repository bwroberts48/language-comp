using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    abstract public class SymbolTypeStrategy
    {
        abstract public string ToDictionaryForm(string word);
    }
}
