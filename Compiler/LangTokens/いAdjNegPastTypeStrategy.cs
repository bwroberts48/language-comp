using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    class いAdjNegPastTypeStrategy : AbstractいAdjStrategy
    {
        //Removes くなかった and adds い
        public override string ToDictionaryForm(string word)
        {
            string dictForm = word.Substring(0, word.Length - 5);

            //Adds い
            dictForm = base.ToDictionaryForm(dictForm);

            return dictForm;
        }
    }
}
