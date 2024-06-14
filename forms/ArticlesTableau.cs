using mini_projet1.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_projet1.forms
{
    public partial class ArticlesTableau : Form
    {
        private ArticleManager articleManager;

        public ArticlesTableau(ArticleManager articleManager)
        {
            InitializeComponent();
            this.articleManager = articleManager;
        }

        private void ArticlesTableau_Load(object sender, EventArgs e)
        {
            DataTable articles = articleManager.ReadArticles();
            articleListTable.DataSource = articles;
        }


        private void articleListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Editeur editeurPage = new Editeur();
            editeurPage.FormClosed += (s, args) => this.Show(); 
            this.Hide();
            editeurPage.Show();
        }

        private void addArticlePageBtn_Click(object sender, EventArgs e)
        {
            Ajouter ajouterForm = new Ajouter(articleManager);
            ajouterForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            ajouterForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
