using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    public class Symbol
    {
        public Symbol(string word, AbstractTypeStrategy type)
        {
            _type = type;
            _word = type.ToDictionaryForm(word);
        }

        public string Word
        {
            get { return this._word; }
            set { this._word = value; }
        }

        public AbstractTypeStrategy Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        private string _word;
        private AbstractTypeStrategy _type;
    }
}
