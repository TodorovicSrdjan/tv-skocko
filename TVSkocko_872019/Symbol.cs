using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSkocko_872019.Properties;

namespace TVSkocko_872019
{
    [Flags]
    public enum SymbolValue
    {
        None,
        Clover,
        Heart,
        Jumper,
        Pike,
        Star,
        Tile
    };

    [Serializable]
    public sealed class Symbol : IComparable
    {
        public SymbolValue Value { get; set; }

        public Symbol()
        {
            
        }

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
            var valuesArray = (SymbolValue[]) Enum.GetValues(typeof(SymbolValue));
            var valuesList = valuesArray.ToList();
            valuesList.Remove(SymbolValue.None);
            var values = valuesList.ToArray();

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
