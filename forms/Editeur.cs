using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mini_projet1.database;
using mini_projet1.forms;
using MySql.Data.MySqlClient;

namespace mini_projet1
{
    public partial class Editeur : Form
    {

        private ArticleManager articleManager;

        public Editeur()
        {
            InitializeComponent();
            string mysqlCred = "server=localhost; user=root; database=gestion_article; password=";
            articleManager = new ArticleManager(mysqlCred);
            try {
                Console.WriteLine("Connected to database !! ");
            } 
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable articles = articleManager.ReadArticles();
            articlesMenu.DataSource = articles;
            articlesMenu.SelectedIndex = -1;
            ClearFormInputs();
            articlesMenu.DisplayMember = "nom";  // Set this to the column name you want to display
            articlesMenu.ValueMember = "id";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void articlesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articlesMenu.SelectedValue != null)
            {
                int selectedId = (int)articlesMenu.SelectedValue;
                DataRow selectedArticle = articleManager.GetArticleById(selectedId);
                if (selectedArticle != null)
                {
                    articleId.Text = selectedArticle["id"].ToString();
                    name.Text = selectedArticle["nom"].ToString();
                    category.Text = selectedArticle["categorie"].ToString();
                    pu.Text = selectedArticle["pu"].ToString();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string nom = name.Text;
            string categorie = category.Text;
            decimal prixUnitaire = decimal.Parse(pu.Text);
            
            int id = int.Parse(articleId.Text);
            articleManager.UpdateArticle(id, nom, categorie, prixUnitaire);
            
            MessageBox.Show("Modifications enregistrées avec succès !","Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData();
            ClearFormInputs();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(articleId.Text);
            articleManager.DeleteArticle(id);
            MessageBox.Show("Article supprimé avec succès !", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData();
            ClearFormInputs();

        }
        private void RefreshData()
        {
            DataTable articles = articleManager.ReadArticles();
            articlesMenu.DataSource = articles;
        }
        private void ClearFormInputs()
        {
            articleId.Text = "";
            name.Text = "";
            category.SelectedIndex = -1;
            pu.Text = "";
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (articlesMenu.Items.Count > 0)
            {
                int newIndex = articlesMenu.SelectedIndex - 1;
                if (newIndex < 0)
                {
                    newIndex = articlesMenu.Items.Count - 1;
                }
                articlesMenu.SelectedIndex = newIndex;
            }

        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            if (articlesMenu.Items.Count > 0)
            {
                int newIndex = articlesMenu.SelectedIndex + 1;
                if (newIndex >= articlesMenu.Items.Count)
                {
                    newIndex = 0;
                }
                articlesMenu.SelectedIndex = newIndex;
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addArticlePageBtn_Click_1(object sender, EventArgs e)
        {
            Ajouter ajouterForm = new Ajouter(articleManager);
            ajouterForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            ajouterForm.Show();

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
