using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameForm form = new GameForm();
            this.Hide();
            form.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About phy = new About();
            this.Hide();
            phy.Show();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help frm = new Help();
            this.Hide();
            frm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
