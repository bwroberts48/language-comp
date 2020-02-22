using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    public abstract class AbstractいAdjStrategy : AbstractTypeStrategy
    {
        //Adds い to the end of the word. To be used by subclasses
        public override string ToDictionaryForm(string word)
        {
            return word += "い";
        }
    }
}
