using System;
using System.Windows.Forms;

namespace HPN_for_win
{
    public partial class Fireworks : UserControl
    {
        public Fireworks()
        {
            InitializeComponent();
        }

        public static int defaultWidth = 36;
        public static int defaultHeight = 119;
        private void Fireworks_SizeChanged(object sender, EventArgs e)
        {
            Height = 119;
            Width = 36;
        }
    }
}
