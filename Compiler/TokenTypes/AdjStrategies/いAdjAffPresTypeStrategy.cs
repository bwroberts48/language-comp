using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    public class いAdjAffPresTypeStrategy : AbstractいAdjStrategy
    {
        //Dictionary form is the same as this type
        public override string ToDictionaryForm(string word)
        {
            return word;
        }
    }
}
