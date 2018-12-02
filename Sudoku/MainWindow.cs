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
        int[,] solution;
        List<List<List<int>>> Possibilitee;
        Random rnd ;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("bite");
            //Console.WriteLine(e.RowIndex);
           
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            grille.ColumnHeadersVisible = false;
            Console.WriteLine("lala");
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
            GenererGrille();
            for (int i = 0; i < 9; i++)
             {
                 Console.WriteLine(
                     solution[i, 0] + "," +
                     solution[i, 1] + "," +
                     solution[i, 2] + "," +
                     solution[i, 3] + "," +
                     solution[i, 4] + "," +
                     solution[i, 5] + "," +
                     solution[i, 6] + "," +
                     solution[i, 7] + "," +
                     solution[i, 8] );

             }
            

        }
        private void GenererGrille()
        {
            // 0 0 pour l'instant inconue
            solution = new int[9, 9] {
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0}};

            Possibilitee = new List<List<List<int>>>();
            
            int i,j;
            List<List<int>> ligne= new List<List<int>>();
            for (i=0;i<9;i++) {
                ligne = new List<List<int>>();
                for (j = 0; j < 9; j++)
                {
                    
                    var Case = new List<int>();
                    Case.Add(1);
                    Case.Add(2);
                    Case.Add(3);
                    Case.Add(4);
                    Case.Add(5);
                    Case.Add(6);
                    Case.Add(7);
                    Case.Add(8);
                    Case.Add(9);
                    ligne.Add(Case);
                }
                Possibilitee.Add(ligne);
            }//Possibilitee contien 9 lignes de 9 cases qui on chacune 9 possibilitee

            rnd = new Random();
            int val = rnd.Next(1, 9);
            Possibilitee[0][0].Remove(val);
            TesterCase(0,0, val, 81);
        }
        private int TesterCase(int x,int y,int valeur,int caseLibre)
        {
            //Console.WriteLine(caseLibre + " x " + x + "  y " + y + "  valeur " + valeur);
            solution[x, y] = valeur;
          
            List<int> ModifX = new List<int> ();
            List<int> ModifY = new List<int> ();
            List<int> ModifValeur = new List<int>();
            
            if (caseLibre == 1)
            {
                return 1;
            }
            int i,j;
            for (i = 0; i < 9; i++)
            {
                //la valeur n'est plus disponible ni sur la ligne, ni sur la colone

                if (Possibilitee[i][y].Remove(valeur))
                {
                    ModifX.Add(i);
                    ModifY.Add(y);
                    ModifValeur.Add(valeur);
                }
                if(Possibilitee[x][i].Remove(valeur))
                {
                    ModifX.Add(x);
                    ModifValeur.Add(valeur);
                    ModifY.Add(i);
                }

                if ((solution[i,y]==0 && Possibilitee[i][y].Count==0 )|| (solution[x, i] == 0&&Possibilitee[x][i].Count == 0))
                {
                    int annul = 0;
                    while (annul < ModifX.Count)
                    {
                        Possibilitee[ModifX[annul]][ModifY[annul]].Add(ModifValeur[annul]);
                        annul = annul + 1;
                    }
                    
                    solution[x, y] = 0;
                    return -1;
                }
            }
            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    // ni sur le caré
                    if(Possibilitee[3 * (x / 3) + i % 3][3 * (y / 3) + j % 3].Remove(valeur))
                    {
                        ModifX.Add(3 * (x / 3) + i % 3);
                        ModifY.Add(3 * (y / 3) + j % 3);
                        ModifValeur.Add(valeur);
                    }
                    if(solution[(3 * (x / 3) + i % 3),(3 * (y / 3) + j % 3)] == 0 && Possibilitee[3 * (x / 3) + i % 3][3 * (y / 3) + j % 3].Count == 0)
                    {
                        int annul = 0;
                        while (annul < ModifX.Count)
                        {
                            Possibilitee[ModifX[annul]][ModifY[annul]].Add(ModifValeur[annul]);
                            annul = annul + 1;
                        }
                        solution[x, y] = 0;
                        return -1;
                    }
                }

            }

            int nouvX, nouvY;
            //ICI
            for (nouvX = 0; nouvX < 9; nouvX++)
            {
                for (nouvY = 0; nouvY < 9; nouvY++)
                {
                    if(solution[nouvX,nouvY]==0 && Possibilitee[nouvX][nouvY].Count == 1)
                    {
                        if (TesterCase(nouvX, nouvY, Possibilitee[nouvX][nouvY][0], caseLibre - 1) == -1)
                        {
                            int annul = 0;
                            while (annul < ModifX.Count)
                            {
                                Possibilitee[ModifX[annul]][ModifY[annul]].Add(ModifValeur[annul]);
                                annul = annul + 1;
                            }
                            solution[x, y] = 0;
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }




            //jusqu'a ici
            nouvX = rnd.Next(0, 9);
            nouvY = rnd.Next(0, 9);
            
            while (solution[nouvX, nouvY] != 0)
            {
                nouvX = rnd.Next(0, 9);
                nouvY = rnd.Next(0, 9);
            }
            int nouvValeur = Possibilitee[nouvX][nouvY][rnd.Next(0, Possibilitee[nouvX][nouvY].Count)];
         
            while (TesterCase(nouvX, nouvY, nouvValeur, caseLibre - 1)==-1)
            {
               // Console.WriteLine(caseLibre + "LILI nouvX " + nouvX + "  nouvY " + nouvY + "  nouvValeur "+ nouvValeur + "  Possibilitee[nouvX][nouvY].Count " + Possibilitee[nouvX][nouvY].Count);
                
                Possibilitee[nouvX][nouvY].Remove(nouvValeur);
                ModifX.Add(nouvX);
                ModifY.Add(nouvY);
                ModifValeur.Add(nouvValeur);
                
                //Console.WriteLine("nouvX "+ nouvX+ "  nouvY "+ nouvY+ "  nouvValeur "+ nouvValeur+ "  Possibilitee[nouvX][nouvY].Count "+ Possibilitee[nouvX][nouvY].Count);
                //Console.WriteLine("count ModifX " + ModifX.Count + "  ModifY " + ModifY.Count + "  ModifValeur " + ModifValeur.Count);
                if (Possibilitee[nouvX][nouvY].Count == 0)
                {
                    //Console.WriteLine("LALAL nouvX " + nouvX + "  nouvY " + nouvY + "  nouvValeur " + nouvValeur);
                    int annul = 0;
                    while (annul < ModifX.Count)
                    {
                        Possibilitee[ModifX[annul]][ModifY[annul]].Add(ModifValeur[annul]);
                        annul = annul + 1;
                    }

                   /* for (i = 0; i < 9; i++)
                    {
                        Console.WriteLine(
                            solution[i, 0] + "," +
                            solution[i, 1] + "," +
                            solution[i, 2] + "," +
                            solution[i, 3] + "," +
                            solution[i, 4] + "," +
                            solution[i, 5] + "," +
                            solution[i, 6] + "," +
                            solution[i, 7] + "," +
                            solution[i, 8]);

                    }
                    i = 0;
                    while (i < Possibilitee[x][y].Count)
                    {
                        Console.WriteLine(Possibilitee[x][y][i]);
                        i = i + 1;
                    }
                    Console.WriteLine(caseLibre + " x " + x + "  y " + y + "  valeur " + valeur);
                    Console.WriteLine(caseLibre + "LOLO nouvX " + nouvX + "  nouvY " + nouvY + "  nouvValeur " + nouvValeur + "  Possibilitee[nouvX][nouvY].Count " + Possibilitee[nouvX][nouvY].Count + "\n");
                    */solution[x, y] = 0;
                    return -1;
                }
                nouvValeur = Possibilitee[nouvX][nouvY][rnd.Next(0, Possibilitee[nouvX][nouvY].Count)];
            }
            //Console.WriteLine("retunr 1   "+caseLibre+"  "+valeur );
            return 1;
        }

        private void grille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
