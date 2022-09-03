using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVSkocko_872019
{
    internal class SymbolButton : Button
    {
        public int OrdinalNumber { get; private set; }
        public Symbol Symbol { get; private set; }
        public Game ParentForm { get; private set; }

        public SymbolButton(Game parentForm, Symbol symbol)
        {
            Symbol = symbol;
            ParentForm = parentForm;

            this.Width = 40;
            this.Height = 40;
            this.FlatStyle = FlatStyle.Flat;
            this.BackgroundImage = symbol.ConvertToImage();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ImageAlign = ContentAlignment.MiddleCenter;
            this.Click += new System.EventHandler(this.SymbolButton_Click);
        }

        public SymbolButton(Game parentForm, Symbol symbol, int ordinalNumber) : this(parentForm, symbol)
        {
            OrdinalNumber = ordinalNumber;
        }

        private void SymbolButton_Click(object sender, EventArgs e)
        {
            SymbolButton sb = sender as SymbolButton;
            if (sb == null)
                Console.WriteLine($"Sender {sender} cannot be converted to SymbolButton");
            else
            {
                sb.ParentForm.MakeMove(sb.Symbol);
            }
        }
    }
}
