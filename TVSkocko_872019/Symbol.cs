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

    internal sealed class Symbol
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
            switch (symbol.Value)
            {
                case SymbolValue.Clover:
                    return Resources.clover;
                case SymbolValue.Heart:
                    return Resources.heart;
                case SymbolValue.Jumper:
                    return Resources.jumper;
                case SymbolValue.Pike:
                    return Resources.pike;
                case SymbolValue.Star:
                    return Resources.star;
                case SymbolValue.Tile:
                    return Resources.tile;
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
    }
}
