using System.Drawing;
using System.Windows.Forms;

namespace LiquidHash.Win.Forms
{
    public partial class MessageBoxFontForm : Form
    {
        protected MessageBoxFontForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
        }
    }
}
