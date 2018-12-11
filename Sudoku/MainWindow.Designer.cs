namespace Sudoku
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grille = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.TextBox();
            this.btnNouvGrille = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_aff_corr = new System.Windows.Forms.Button();
            this.btn_correction = new System.Windows.Forms.Button();
            this.lbl_Diff = new System.Windows.Forms.Label();
            this.cbBoxDiff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grille
            // 
            this.grille.AllowUserToAddRows = false;
            this.grille.AllowUserToDeleteRows = false;
            this.grille.AllowUserToResizeColumns = false;
            this.grille.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.grille.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.grille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grille.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grille.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grille.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grille.DefaultCellStyle = dataGridViewCellStyle35;
            this.grille.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grille.Location = new System.Drawing.Point(196, 20);
            this.grille.MultiSelect = false;
            this.grille.Name = "grille";
            this.grille.RowHeadersVisible = false;
            dataGridViewCellStyle36.Format = "N0";
            dataGridViewCellStyle36.NullValue = null;
            this.grille.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.grille.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grille.RowTemplate.DividerHeight = 1;
            this.grille.RowTemplate.Height = 90;
            this.grille.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grille.Size = new System.Drawing.Size(450, 452);
            this.grille.TabIndex = 0;
            this.grille.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grille_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle26;
            this.Column1.FillWeight = 11.1F;
            this.Column1.HeaderText = "";
            this.Column1.MaxInputLength = 1;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle27;
            this.Column2.FillWeight = 11.1F;
            this.Column2.HeaderText = "";
            this.Column2.MaxInputLength = 1;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle28;
            this.Column3.FillWeight = 11.1F;
            this.Column3.HeaderText = "";
            this.Column3.MaxInputLength = 1;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle29;
            this.Column4.FillWeight = 11.1F;
            this.Column4.HeaderText = "";
            this.Column4.MaxInputLength = 1;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle30;
            this.Column5.FillWeight = 11.1F;
            this.Column5.HeaderText = "";
            this.Column5.MaxInputLength = 1;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle31;
            this.Column6.FillWeight = 11.1F;
            this.Column6.HeaderText = "";
            this.Column6.MaxInputLength = 1;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle32;
            this.Column7.FillWeight = 11.1F;
            this.Column7.HeaderText = "";
            this.Column7.MaxInputLength = 1;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle33;
            this.Column8.FillWeight = 11.1F;
            this.Column8.HeaderText = "";
            this.Column8.MaxInputLength = 1;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle34;
            this.Column9.FillWeight = 11.1F;
            this.Column9.HeaderText = "";
            this.Column9.MaxInputLength = 1;
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Titre
            // 
            this.Titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titre.Location = new System.Drawing.Point(0, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(746, 20);
            this.Titre.TabIndex = 1;
            this.Titre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNouvGrille
            // 
            this.btnNouvGrille.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNouvGrille.Location = new System.Drawing.Point(23, 462);
            this.btnNouvGrille.Name = "btnNouvGrille";
            this.btnNouvGrille.Size = new System.Drawing.Size(108, 32);
            this.btnNouvGrille.TabIndex = 2;
            this.btnNouvGrille.Text = "Nouvelle grille";
            this.btnNouvGrille.UseVisualStyleBackColor = true;
            this.btnNouvGrille.Click += new System.EventHandler(this.btnNouvGrille_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_aff_corr);
            this.panel1.Controls.Add(this.btn_correction);
            this.panel1.Controls.Add(this.lbl_Diff);
            this.panel1.Controls.Add(this.cbBoxDiff);
            this.panel1.Controls.Add(this.btnNouvGrille);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 551);
            this.panel1.TabIndex = 3;
            // 
            // btn_aff_corr
            // 
            this.btn_aff_corr.Location = new System.Drawing.Point(23, 101);
            this.btn_aff_corr.Name = "btn_aff_corr";
            this.btn_aff_corr.Size = new System.Drawing.Size(108, 23);
            this.btn_aff_corr.TabIndex = 6;
            this.btn_aff_corr.Text = "Afficher correction";
            this.btn_aff_corr.UseVisualStyleBackColor = true;
            this.btn_aff_corr.Visible = false;
            this.btn_aff_corr.Click += new System.EventHandler(this.btn_aff_corr_Click);
            // 
            // btn_correction
            // 
            this.btn_correction.Location = new System.Drawing.Point(23, 60);
            this.btn_correction.Name = "btn_correction";
            this.btn_correction.Size = new System.Drawing.Size(75, 23);
            this.btn_correction.TabIndex = 5;
            this.btn_correction.Text = "Corriger";
            this.btn_correction.UseVisualStyleBackColor = true;
            this.btn_correction.Click += new System.EventHandler(this.btn_correction_Click);
            // 
            // lbl_Diff
            // 
            this.lbl_Diff.AutoSize = true;
            this.lbl_Diff.Location = new System.Drawing.Point(20, 171);
            this.lbl_Diff.Name = "lbl_Diff";
            this.lbl_Diff.Size = new System.Drawing.Size(48, 13);
            this.lbl_Diff.TabIndex = 4;
            this.lbl_Diff.Text = "Difficulté";
            this.lbl_Diff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Diff.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbBoxDiff
            // 
            this.cbBoxDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxDiff.Items.AddRange(new object[] {
            "Niveau 1",
            "Niveau 2",
            "Niveau 3",
            "Niveau 4",
            "Niveau 5",
            "Niveau 6"});
            this.cbBoxDiff.Location = new System.Drawing.Point(23, 196);
            this.cbBoxDiff.MaxLength = 10;
            this.cbBoxDiff.Name = "cbBoxDiff";
            this.cbBoxDiff.Size = new System.Drawing.Size(121, 21);
            this.cbBoxDiff.Sorted = true;
            this.cbBoxDiff.TabIndex = 3;
            this.cbBoxDiff.SelectedIndexChanged += new System.EventHandler(this.cbBoxDiff_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.grille);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grille;
        private System.Windows.Forms.Button btnNouvGrille;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label lbl_Diff;
        private System.Windows.Forms.ComboBox cbBoxDiff;
        private System.Windows.Forms.Button btn_correction;
        private System.Windows.Forms.Button btn_aff_corr;
    }
}

