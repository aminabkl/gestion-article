namespace mini_projet1.forms
{
    partial class ArticlesTableau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.articleListTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.addArticlePageBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(87)))), ((int)(((byte)(185)))));
            this.groupBox2.Controls.Add(this.addArticlePageBtn);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Location = new System.Drawing.Point(-2, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 566);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // articleListTable
            // 
            this.articleListTable.AllowUserToAddRows = false;
            this.articleListTable.AllowUserToDeleteRows = false;
            this.articleListTable.AllowUserToOrderColumns = true;
            this.articleListTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.articleListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleListTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.articleListTable.Location = new System.Drawing.Point(389, 127);
            this.articleListTable.Name = "articleListTable";
            this.articleListTable.ReadOnly = true;
            this.articleListTable.RowHeadersWidth = 51;
            this.articleListTable.RowTemplate.Height = 24;
            this.articleListTable.Size = new System.Drawing.Size(587, 371);
            this.articleListTable.TabIndex = 16;
            this.articleListTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleListTable_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label6.Location = new System.Drawing.Point(352, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Liste des articles";
            // 
            // addArticlePageBtn
            // 
            this.addArticlePageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addArticlePageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(87)))), ((int)(((byte)(185)))));
            this.addArticlePageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.addArticlePageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.addArticlePageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.addArticlePageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.addArticlePageBtn.Location = new System.Drawing.Point(45, 200);
            this.addArticlePageBtn.Name = "addArticlePageBtn";
            this.addArticlePageBtn.Size = new System.Drawing.Size(200, 43);
            this.addArticlePageBtn.TabIndex = 2;
            this.addArticlePageBtn.Text = "Ajouter un article";
            this.addArticlePageBtn.UseVisualStyleBackColor = true;
            this.addArticlePageBtn.Click += new System.EventHandler(this.addArticlePageBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(87)))), ((int)(((byte)(185)))));
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.editBtn.Location = new System.Drawing.Point(45, 120);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(200, 43);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Éditeur des articles";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ArticlesTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1084, 548);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.articleListTable);
            this.Controls.Add(this.groupBox2);
            this.Name = "ArticlesTableau";
            this.Text = "Liste des articles";
            this.Load += new System.EventHandler(this.ArticlesTableau_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView articleListTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addArticlePageBtn;
        private System.Windows.Forms.Button editBtn;
    }
}