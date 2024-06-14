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
    public partial class Ajouter : Form
    {
        private ArticleManager articleManager;
        public Ajouter(ArticleManager articleManager)
        {
            InitializeComponent();
            this.articleManager = articleManager;
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string nom = name.Text;
            string categorie = category.Text;
            decimal prixUnitaire = decimal.Parse(pu.Text);
            //articleManager.CreateArticle(nom, categorie, prixUnitaire);
            articleManager.CreateArticle(nom, categorie, prixUnitaire);
            MessageBox.Show("Article ajouté avec succès !", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFormInputs();
        }

        private void ClearFormInputs()
        {
            name.Text = "";
            category.SelectedIndex = -1;
            pu.Text = "";
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            Editeur editeurPage = new Editeur();
            editeurPage.FormClosed += (s, args) => this.Show();
            this.Hide();
            editeurPage.Show();

        }

        private void articlesTabPageBtn_Click_1(object sender, EventArgs e)
        {
            ArticlesTableau articlesTableauForm = new ArticlesTableau(articleManager);
            articlesTableauForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            articlesTableauForm.Show();

        }
    }
}
