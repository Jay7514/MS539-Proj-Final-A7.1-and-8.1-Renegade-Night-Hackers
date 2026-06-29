using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Game_1_MS539_Final_Landrau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = true;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = true;
            if (e.KeyCode == Core.KeyRight)
                Core.IsUp = true;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = true;

        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = false;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = false;
            if (e.KeyCode == Core.KeyRight)
                Core.IsUp = false;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = false;


        }



                private void OnKeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}


