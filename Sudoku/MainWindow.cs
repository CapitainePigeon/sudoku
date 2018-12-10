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
       
        
        Random rnd ;
        int difficulte=64-4*8;
        int[,] solutionGlobale;
        int cptIndice = 5;
        int nbErreur = 0;

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
            cbBoxDiff.SelectedIndex = 0;
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
            int[,] solution = new int[9, 9] {
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0}};
            GenererGrille(solution);
            solutionGlobale = solution;
            RemplirGrille(GenererGrilleTrou(solution));
            
        }
        private void GenererGrille(int[,] solution)
        {
            // 0 0 pour l'instant inconue
            btn_aff_corr.Visible = false;
            nbErreur = 0;

            List<List<List<int>>> Possibilitee = new List<List<List<int>>>();
            
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
            Console.WriteLine("debut");
            rnd = new Random();
            int val = rnd.Next(1, 9);
            Possibilitee[0][0].Remove(val);
            RemplirCase(0,0, val, 81, solution, Possibilitee);
        }
        private int RemplirCase(int x,int y,int valeur,int caseLibre, int[,] solution, List<List<List<int>>> Possibilitee)
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

                if ((solution[i,y]==0 && Possibilitee[i][y].Count==0 )|| (solution[x, i] == 0 && Possibilitee[x][i].Count == 0))
                {
                    annulation(ModifX, ModifY, ModifValeur, Possibilitee);
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
                        annulation(ModifX, ModifY, ModifValeur, Possibilitee);
                        solution[x, y] = 0;
                        return -1;
                    }
                }

            }

            int nouvX, nouvY;
            //ICI
           // Console.WriteLine("ICI "+caseLibre);
            int[,] ligne = new int[9, 9];
            int[,] carre = new int[9, 9];
            int[,] colone = new int[9, 9];

            for (nouvX = 0; nouvX < 9; nouvX++)
            {
                for (nouvY = 0; nouvY < 9; nouvY++)
                {
                    ligne[nouvX, nouvY] = 0;
                    carre[nouvX, nouvY] = 0;
                    colone[nouvX, nouvY] = 0;
                    if (solution[nouvX,nouvY]==0 && Possibilitee[nouvX][nouvY].Count == 1)
                    {
                        if (RemplirCase(nouvX, nouvY, Possibilitee[nouvX][nouvY][0], caseLibre - 1, solution, Possibilitee) == -1)
                        {
                            annulation(ModifX, ModifY, ModifValeur, Possibilitee);
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

            for (nouvX = 0; nouvX < 9; nouvX++)
            {
                for (nouvY = 0; nouvY < 9; nouvY++)
                {
                    if (solution[nouvX, nouvY] == 0)
                    {
                        foreach (int p in Possibilitee[nouvX][nouvY]){
                            ligne[nouvX, p-1] = ligne[nouvX, p-1] + 1;
                            colone[nouvY, p-1] = colone[nouvY, p-1] + 1;
                            carre[(nouvX/3)*3+ (nouvY / 3), p-1] = carre[(nouvX / 3) * 3 + (nouvY / 3), p-1] + 1;
                        }
                    }
                }
            }
            for (i = 0; i < 9; i++)
            {
                for (int nb = 0; nb < 9; nb++)
                {
                    if (ligne[i, nb] == 1) // si la ligne ne peut contenir le nombre que dans une seule case
                        for (j = 0; j < 9; j++) { //on trouve la case
                            if (solution[i , j] == 0 && Possibilitee[i][j].Contains(nb + 1))
                            {
                               
                                if (RemplirCase(i, j, nb + 1, caseLibre - 1, solution, Possibilitee) == -1)
                                {
                                    annulation(ModifX, ModifY, ModifValeur, Possibilitee);
                                    solution[x, y] = 0;
                                    return -1;

                                }
                                else
                                    return 1;
                            }
                        }
                        //return RemplirCase(i, j, nb+1, caseLibre - 1, solution, Possibilitee); // on y met le nombre
                    if (colone[i, nb] == 1)
                        for (j = 0; j < 9; j++)
                            if (solution[j, i] == 0 && Possibilitee[j][i].Contains(nb))
                                if (RemplirCase(j, i, nb, caseLibre - 1, solution, Possibilitee) == -1)
                                {
                                    annulation(ModifX, ModifY, ModifValeur, Possibilitee);
                                    solution[x, y] = 0;
                                    return -1;

                                }
                                else
                                    return 1;
                     if (carre[i, nb] == 1)
                         for (j = 0; j < 9; j++)
                             if (solution[(i / 3) * 3 + j / 3, (i % 3) * 3 + j % 3] == 0 &&Possibilitee[(i/3)*3+j/3][(i%3)*3+j%3].Contains(nb))
                                if (RemplirCase((i / 3) * 3 + j / 3, (i % 3) * 3 + j % 3, nb, caseLibre - 1, solution, Possibilitee) == -1)
                                {
                                    annulation(ModifX, ModifY, ModifValeur, Possibilitee);
                                    solution[x, y] = 0;
                                    return -1;

                                }
                                else
                                    return 1;
                 
                }
            }


            //jusqu'a ici
            Console.WriteLine("jusqu'a ici");
            nouvX = rnd.Next(0, 9);
            nouvY = rnd.Next(0, 9);
            
            while (solution[nouvX, nouvY] != 0)
            {
                nouvX = rnd.Next(0, 9);
                nouvY = rnd.Next(0, 9);
            }
            int nouvValeur = Possibilitee[nouvX][nouvY][rnd.Next(0, Possibilitee[nouvX][nouvY].Count)];
         
            while (RemplirCase(nouvX, nouvY, nouvValeur, caseLibre - 1, solution, Possibilitee) ==-1)
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
                    annulation(ModifX,ModifY,ModifValeur, Possibilitee);
                    solution[x, y] = 0;
                    return -1;
                }
                nouvValeur = Possibilitee[nouvX][nouvY][rnd.Next(0, Possibilitee[nouvX][nouvY].Count)];
            }
            //Console.WriteLine("retunr 1   "+caseLibre+"  "+valeur );
       /*     for ( i = 0; i < 9; i++)
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
            Console.WriteLine("\n");*/
            return 1;
        }
        private void annulation(List<int> ModifX, List<int> ModifY, List<int> ModifValeur, List<List<List<int>>> Possibilitee)
        {
            int annul = 0;
            while (annul < ModifX.Count)
            {
                Possibilitee[ModifX[annul]][ModifY[annul]].Add(ModifValeur[annul]);
                annul = annul + 1;
            }
        }


        private int[,] GenererGrilleTrou(int[,] solution)
        {
            int[,] grilleATrou= new int[9,9];
            int x, y;
            for (x = 0 ; x < 9 ; x++)
            {
                for (y = 0; y < 9; y++)
                {
                    grilleATrou[x, y] = solution[x, y];
                }
            }
            int[,] grilleNecessaire = new int[9, 9] {
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0}};
            int caseNonNecessaire = 81;
            while (caseNonNecessaire > difficulte)
            {
                x = rnd.Next(0, 9);
                y = rnd.Next(0, 9);
                if (grilleNecessaire[x, y] == 0)
                {
                    if (CaseNecessaire(x, y, grilleATrou))
                    {
                        grilleATrou[x, y] = 0;
                    }
                    grilleNecessaire[x, y] = 1;
                    caseNonNecessaire--;
                }

            }
            
          /*  grilleNecessaire = new int[9, 9] {
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0}};
            caseNonNecessaire = 81;
            for (int i = 0; i < 9; i++) //carré
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grilleATrou[i, j] == 0)
                    {
                        caseNonNecessaire--;
                        grilleNecessaire[i, j] = 1;
                    }
                }
            }*/
         /*   while (caseNonNecessaire > difficulte)
            {
                Console.WriteLine("lili");
                x = rnd.Next(0, 9);
                y = rnd.Next(0, 9);
                if (grilleNecessaire[x, y] == 0)
                {
                    if (grilleATrou[x,y]!=0 && CaseNecessaire(x, y, grilleATrou))
                    {
                        grilleATrou[x, y] = 0;
                    }
                    grilleNecessaire[x, y] = 1;
                    
                    caseNonNecessaire--;
                }

            }*/

            return grilleATrou;
        }


        private void RemplirGrille(int[,] solution)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (solution[i, j] == 0)
                    {
                        grille.Rows[i].Cells[j].Value = "";
                        grille.Rows[i].Cells[j].ReadOnly = false;
                        grille.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        grille.Rows[i].Cells[j].Style.BackColor = Color.White;

                    }
                    else
                    {
                        grille.Rows[i].Cells[j].Value = solution[i, j];
                        grille.Rows[i].Cells[j].ReadOnly = true;
                        grille.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        grille.Rows[i].Cells[j].Style.BackColor = Color.White;

                    }

                }
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
        }


        private bool CaseNecessaire(int x, int y, int[,]grilleATrou)
        {
            //return (RienDAutreNeVaSurLaCase(x, y, grilleATrou) || ValeurNeVaNulPartAilleur(x, y, grilleATrou) || LesAutresHypothèsesNeMarchePas(x, y, grilleATrou));

            return (RienDAutreNeVaSurLaCase(x, y, grilleATrou) || LesAutresHypothèsesNeMarchePas(x, y, grilleATrou));
          
        }
        private bool RienDAutreNeVaSurLaCase(int x, int y, int[,] grilleATrou)
        {
            Console.WriteLine("RienDAutreNeVaSurLaCase");
            int save = grilleATrou[x,y];
            grilleATrou[x,y] = 0;
            List<int> EnsPossib = new List<int>();
            int i;
            for (i = 0; i <= 9; i++)
            {
                EnsPossib.Add(i);
            }

            for(i = 0; i < 9; i++) //ligne et colone
            {
                EnsPossib.Remove(grilleATrou[i,y]);
                EnsPossib.Remove(grilleATrou[x,i]);
            }
            for (i = 0; i < 3; i++) //carré
            {
                for (int j = 0; j < 3; j++)
                {
                    EnsPossib.Remove(grilleATrou[3 * (x / 3) + i % 3,3 * (y / 3) + j % 3]);
                }
            }

            grilleATrou[x,y] = save;
            return (EnsPossib.Count == 1);

        }

        private bool ValeurNeVaNulPartAilleur(int x, int y, int[,] grilleATrou)
        {
            Console.WriteLine("ValeurNeVaNulPartAilleur");
            int EmplacementLibreSurCarre = 9;
            int EmplacementLibreSurLigne = 9;
            int EmplacementLibreSurColone = 9;
            for (int i = 0; i < 9; i++)
            {
                if (grilleATrou[x, i] == grilleATrou[x, y])
                    EmplacementLibreSurLigne = EmplacementLibreSurLigne - 1;
                if (grilleATrou[i, y] == grilleATrou[x, y])
                    EmplacementLibreSurColone = EmplacementLibreSurColone - 1;

            }
            for (int i = 0; i < 3; i++) //carré
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grilleATrou[3 * (x / 3) + i % 3, 3 * (y / 3) + j % 3] == grilleATrou[x, y])
                        EmplacementLibreSurCarre = EmplacementLibreSurCarre - 1;
                }
            }
            return (EmplacementLibreSurCarre==0 || EmplacementLibreSurLigne ==0 || EmplacementLibreSurColone == 0);
        }

        private void initPossibilitee(List<List<List<int>>> Possibilitee, int[,] grilleATrou)
        {
            Console.WriteLine("a");
            List<List<int>> ligne = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                ligne = new List<List<int>>();
                for (int j = 0; j < 9; j++)
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
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(grilleATrou[i, j] != 0)
                    {
                        for(int k=0;k<9;k++)
                        {
                            Possibilitee[i][k].Remove(grilleATrou[i, j]);
                            Possibilitee[k][j].Remove(grilleATrou[i, j]);
                        }
                        for (int i2 = 0; i2 < 3; i2++)
                        {
                            for (int j2 = 0; j2 < 3; j2++)
                            {
                                Possibilitee[3 * (i / 3) + i2 % 3][ 3 * (j / 3) + j2 % 3].Remove(grilleATrou[i, j]);
                                Possibilitee[3 * (i / 3) + i2 % 3][3 * (j / 3) + j2 % 3].Remove(grilleATrou[i, j]);
                            }
                        }
                    }
                    
                }
            }
            Console.WriteLine("coucou");
            for (int i = 0; i < 9; i++)
            {

                Console.WriteLine(
                    grilleATrou[i, 0] + "," +
                    grilleATrou[i, 1] + "," +
                    grilleATrou[i, 2] + "," +
                    grilleATrou[i, 3] + "," +
                    grilleATrou[i, 4] + "," +
                    grilleATrou[i, 5] + "," +
                    grilleATrou[i, 6] + "," +
                    grilleATrou[i, 7] + "," +
                    grilleATrou[i, 8]);

            }
            Console.WriteLine("\n");
        }

        private bool LesAutresHypothèsesNeMarchePas(int x, int y, int[,] grilleATrou)
        {
            Console.WriteLine("LesAutresHypothèsesNeMarchePas");
            int save = grilleATrou[x, y];
            grilleATrou[x, y] = 0;
            List<int> EnsPossib = new List<int>();
            int i;
            for (i = 0; i <= 9; i++)
            {
                EnsPossib.Add(i);
            }

            for (i = 0; i < 9; i++) //ligne et colone
            {
                EnsPossib.Remove(grilleATrou[i, y]);
                EnsPossib.Remove(grilleATrou[x, i]);
            }
            for (i = 0; i < 3; i++) //carré
            {
                for (int j = 0; j < 3; j++)
                {
                    EnsPossib.Remove(grilleATrou[3 * (x / 3) + i % 3, 3 * (y / 3) + j % 3]);
                }
            }
            int[,] CopieGrille= new int[9, 9] {
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0}};
            int nbtrou = 0;
            for (i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    CopieGrille[i, j] = grilleATrou[i, j];
                    if (grilleATrou[i, j] == 0)
                        nbtrou++; 
                }
            }
            EnsPossib.Remove(save);
            grilleATrou[x, y] = save;
            //RemplirGrille(CopieGrille);
            List<List<List<int>>> Possibilitee = new List<List<List<int>>>();

            initPossibilitee(Possibilitee, CopieGrille);



            if (EnsPossib.Count >= 0)
            {
                Console.WriteLine(nbtrou+"  LALALALALA  "+ EnsPossib[0]);
                if( RemplirCase(x, y, EnsPossib[0], nbtrou, CopieGrille, Possibilitee) == 1){
                    Console.WriteLine("==1");
                    return false;
                }
               // Possibilitee[x][y].Remove(EnsPossib[0]);
               // EnsPossib.Remove(EnsPossib[0]);
            }
            
            return true;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNouvGrille_Click(object sender, EventArgs e)
        {
            int[,] solution = new int[9, 9] {
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0}};
            GenererGrille(solution);
            solutionGlobale = solution;
            RemplirGrille(GenererGrilleTrou(solution));
        }

        private void grille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficulte = 58 - cbBoxDiff.SelectedIndex * 8;
            
        }

        private void btn_correction_Click(object sender, EventArgs e)
        {
            btn_aff_corr.Visible = true;
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(grille.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        if (solutionGlobale[i, j] == Int32.Parse(grille.Rows[i].Cells[j].Value.ToString()))
                        {
                            grille.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            grille.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            ++nbErreur;
                        }
                    }
                    else
                    {
                        grille.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        ++nbErreur;
                    }
                }
            }
            if (nbErreur == 0)
                MessageBox.Show("Vous avez fait : " + nbErreur + " erreurs ! Bravo !");
            else
                MessageBox.Show("Vous avez fait : " + nbErreur + " erreurs ! Dommage ...");
        }

        private void btn_aff_corr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    grille.Rows[i].Cells[j].Value = solutionGlobale[i,j];
                }
            }
        }
    }
}
