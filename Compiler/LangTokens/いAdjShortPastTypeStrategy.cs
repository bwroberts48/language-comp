using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    class いAdjShortPastTypeStrategy : SymbolTypeStrategy
    {
        //Converts the type and returns it
        public override string ToDictionaryForm(string word)
        {
            //Takes the "かった" off of the adjective
            string dictForm = word.Substring(0, word.Length - 3);
            //Adds the い back, lost after it was conjugated
            dictForm += "い";

            return dictForm;
        }
    }
}
