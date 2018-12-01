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
        }

    }
}
