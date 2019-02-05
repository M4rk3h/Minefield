using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minefield
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        //Click the button Go!
        private void btnGo_Click(object sender, EventArgs e)
        {
            //Hide this form (Welcome.cs)
            this.Hide();
            //This opens the gameForm named Form1.
            GameForm f1 = new GameForm();
            //Used a modal show function so only one form can be opened.
            f1.ShowDialog(); 
        }
                
    }
}
