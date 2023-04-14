using Microsoft.EntityFrameworkCore;

namespace ProjetFinal
{
    public partial class Form1 : Form
    {
        private ProjetFinalDbContext dbContext;
        public Form1()
        {
            dbContext = new ProjetFinalDbContext("CnSqlProjetFinal");
            InitializeComponent();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            dbContext.AddEmploye(new Employes
            {
                NumEmp = int.Parse(txtNumEmp.Text),
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Adresse = txtAdresse.Text,
                Courriel = txtCourriel.Text,
                Telephone = txtTelephone.Text
            });
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dbContext.DeleteEmploye(int.Parse(txtNumEmp.Text));

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            dbContext.UpdateEmploye(new Employes
            {
                NumEmp = int.Parse(txtNumEmp.Text),
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Adresse = txtAdresse.Text,
                Courriel = txtCourriel.Text,
                Telephone = txtTelephone.Text
            });
        }

        private void btnAfficherList_Click(object sender, EventArgs e)
        {
            dataGridEmployes.DataSource = dbContext.GetAllEmployes();
        }

        private void btnAjouterProjets_Click(object sender, EventArgs e)
        {
            dbContext.AddProjet(new Projets
            {
                NumProjet = int.Parse(txtNumProjet.Text),
                Titre = txtSemaine.Text,
                NbHeuresPrevues = int.Parse(txtHPrevues.Text)
            });
        }

        private void btnAfficherListe_Click(object sender, EventArgs e)
        {
            dataGridEmployes.DataSource = dbContext.GetAllProjets();
        }

        private void btnSupprimerProjets_Click(object sender, EventArgs e)
        {
            dbContext.DeleteProjet(int.Parse(txtNumProjet.Text));
        }

        private void btnModifierProjets_Click(object sender, EventArgs e)
        {
            dbContext.UpdateProjet(new Projets
            {
                NumProjet = int.Parse(txtNumProjet.Text),
                Titre = txtSemaine.Text,
                NbHeuresPrevues = int.Parse(txtHPrevues.Text)
            });
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            dataGridEmployes.DataSource = dbContext.GetTachesParProjet(int.Parse(txtNumEmp.Text));
        }

        private void btnAjouterTaches_Click(object sender, EventArgs e)
        {
            dbContext.AddTache(new Taches
            {
                Id = int.Parse(txtIdTache.Text),
                NumProjet = int.Parse(comboBoxProjet.Text),
                NumEmp = int.Parse(txtNumEmp.Text),
                Semaine = int.Parse(txtSemaine.Text),
                NbHeures = int.Parse(txtNbHeures.Text)

            });

        }

        private void btnSupprimerTaches_Click(object sender, EventArgs e)
        {
            dbContext.DeleteTache(int.Parse(txtIdTache.Text));
        }

        private void btnModifierTaches_Click(object sender, EventArgs e)
        {
            dbContext.DeleteTache(int.Parse(txtIdTache.Text));
            dbContext.AddTache(new Taches
            {
                Id = int.Parse(txtIdTache.Text),
                NumProjet = int.Parse(comboBoxProjet.Text),
                NumEmp = int.Parse(txtNumEmp.Text),
                Semaine = int.Parse(txtSemaine.Text),
                NbHeures = int.Parse(txtNbHeures.Text)

            });
        }
    }
}