using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangTokens
{
    public class Symbol
    {
        public string Word
        {
            get { return this._word; }
            set { this._word = value; }
        }

        public SymbolTypeStrategy Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        private string _word;
        private SymbolTypeStrategy _type;
    }
}
