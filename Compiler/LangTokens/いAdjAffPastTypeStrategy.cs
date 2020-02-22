using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    class いAdjAffPastTypeStrategy : AbstractいAdjStrategy
    {
        //Removes かった and adds い
        public override string ToDictionaryForm(string word)
        {
            //Takes the "かった" off of the adjective
            string dictForm = word.Substring(0, word.Length - 3);

            //Adds い 
            dictForm = base.ToDictionaryForm(dictForm);

            return dictForm;
        }
    }
}
