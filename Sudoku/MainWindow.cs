using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("bite");
            Console.WriteLine(e.RowIndex);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            grille.ColumnHeadersVisible = false;
            
            grille.Rows.Add(9);
            grille.Rows[0].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[1].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[2].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[3].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[4].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[5].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[6].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[7].MinimumHeight = (grille.Height - 2) / 9;
            grille.Rows[8].MinimumHeight = (grille.Height - 2) / 9;


        }

        private void grille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
