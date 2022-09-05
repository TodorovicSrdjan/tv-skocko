using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSkocko_872019.Properties;

namespace TVSkocko_872019
{
    public enum SymbolValue
    {
        Clover,
        Heart,
        Jumper,
        Pike,
        Star,
        Tile
    };

    public sealed class Symbol : IComparable
    {
        public SymbolValue Value { get; private set; }

        public Symbol(SymbolValue value)
        {
            Value = value;
        }

        public Bitmap ConvertToImage()
        {
            return Symbol.ConvertToImage(this);
        }

        public static Bitmap ConvertToImage(Symbol symbol)
        {
            if (symbol == null)
                return null;

            switch (symbol.Value)
            {
                case SymbolValue.Clover:
                    return Resources.Clover;
                case SymbolValue.Heart:
                    return Resources.Heart;
                case SymbolValue.Jumper:
                    return Resources.Jumper;
                case SymbolValue.Pike:
                    return Resources.Pike;
                case SymbolValue.Star:
                    return Resources.Star;
                case SymbolValue.Tile:
                    return Resources.Tile;
                default:
                    throw new Exception("Dati simbol ne postoji");
            }
        }

        public static Symbol[] Values()
        {
            var values = (SymbolValue[]) Enum.GetValues(typeof(SymbolValue));

            Symbol[] symbols = new Symbol[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                symbols[i] = new Symbol(values[i]);
            }

            return symbols;
        }

        public static implicit operator Image(Symbol symbol)
        {
            return Symbol.ConvertToImage(symbol);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public int CompareTo(object obj)
        {
            Symbol other = obj as Symbol;
            if (other == null)
                throw new ArgumentException("Passed object is not an instance of the type Symbol");

            return this.Value.CompareTo(other.Value);
        }
    }
}
