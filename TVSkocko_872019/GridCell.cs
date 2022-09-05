using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVSkocko_872019
{
    public class GridCell : Panel
    {
        private Symbol symbol;
        public Image Background 
        { 
            get { return this.BackgroundImage; }
            set { this.BackgroundImage = value; }
        }
        public Symbol SymbolContent
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public int CellSize { get; private set; } = 40;

        public GridCell(Image backgroundImage)
        {
            Background = backgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Height = CellSize;
            this.Width = CellSize;
        }

        public GridCell(Image backgroundImage, ImageLayout imageLayout) : this(backgroundImage)
        {
            this.BackgroundImageLayout = imageLayout;
        }

        public GridCell(Image backgroundImage, ImageLayout imageLayout, int size) : this(backgroundImage, imageLayout)
        {
            CellSize = size;

            this.Height = CellSize;
            this.Width = CellSize;
        }
    }
}
