﻿namespace ProjetFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabTaches = new TabControl();
            tabEmployes = new TabPage();
            dataGridEmployes = new DataGridView();
            txtTelephone = new TextBox();
            lblTelephone = new Label();
            txtCourriel = new TextBox();
            lblCourriel = new Label();
            txtAdresse = new TextBox();
            lblAdresse = new Label();
            txtPrenom = new TextBox();
            lblPrenom = new Label();
            txtNom = new TextBox();
            lblNom = new Label();
            txtNumEmp = new TextBox();
            lblNumero = new Label();
            btnAfficherList = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnAjouter = new Button();
            tabProjets = new TabPage();
            dataGridProjets = new DataGridView();
            txtHPrevues = new TextBox();
            lblHeures = new Label();
            txtTitreProjets = new TextBox();
            lblTitre = new Label();
            txtNumProjet = new TextBox();
            lblNumeroProjets = new Label();
            btnAfficherListe = new Button();
            btnModifierProjets = new Button();
            btnSupprimerProjets = new Button();
            btnAjouterProjets = new Button();
            tabTach = new TabPage();
            label1 = new Label();
            comboProjet = new ComboBox();
            comboBoxEmploye = new ComboBox();
            comboBoxProjet = new ComboBox();
            dataGridTaches = new DataGridView();
            txtNbHeures = new TextBox();
            lblHPrevues = new Label();
            txtSemaine = new TextBox();
            lblTitreTaches = new Label();
            lblEmploye = new Label();
            lblProjet = new Label();
            txtIdTache = new TextBox();
            lblIdTache = new Label();
            btnRechercher = new Button();
            btnModifierTaches = new Button();
            btnSupprimerTaches = new Button();
            btnAjouterTaches = new Button();
            tabTaches.SuspendLayout();
            tabEmployes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployes).BeginInit();
            tabProjets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProjets).BeginInit();
            tabTach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTaches).BeginInit();
            SuspendLayout();
            // 
            // tabTaches
            // 
            tabTaches.Controls.Add(tabEmployes);
            tabTaches.Controls.Add(tabProjets);
            tabTaches.Controls.Add(tabTach);
            tabTaches.Location = new Point(22, 14);
            tabTaches.Name = "tabTaches";
            tabTaches.SelectedIndex = 0;
            tabTaches.Size = new Size(1172, 557);
            tabTaches.TabIndex = 0;
            // 
            // tabEmployes
            // 
            tabEmployes.Controls.Add(dataGridEmployes);
            tabEmployes.Controls.Add(txtTelephone);
            tabEmployes.Controls.Add(lblTelephone);
            tabEmployes.Controls.Add(txtCourriel);
            tabEmployes.Controls.Add(lblCourriel);
            tabEmployes.Controls.Add(txtAdresse);
            tabEmployes.Controls.Add(lblAdresse);
            tabEmployes.Controls.Add(txtPrenom);
            tabEmployes.Controls.Add(lblPrenom);
            tabEmployes.Controls.Add(txtNom);
            tabEmployes.Controls.Add(lblNom);
            tabEmployes.Controls.Add(txtNumEmp);
            tabEmployes.Controls.Add(lblNumero);
            tabEmployes.Controls.Add(btnAfficherList);
            tabEmployes.Controls.Add(btnModifier);
            tabEmployes.Controls.Add(btnSupprimer);
            tabEmployes.Controls.Add(btnAjouter);
            tabEmployes.Location = new Point(4, 24);
            tabEmployes.Name = "tabEmployes";
            tabEmployes.Padding = new Padding(3);
            tabEmployes.Size = new Size(1164, 529);
            tabEmployes.TabIndex = 0;
            tabEmployes.Text = "Employes";
            tabEmployes.UseVisualStyleBackColor = true;
            // 
            // dataGridEmployes
            // 
            dataGridEmployes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployes.Location = new Point(647, 87);
            dataGridEmployes.Name = "dataGridEmployes";
            dataGridEmployes.RowTemplate.Height = 25;
            dataGridEmployes.Size = new Size(494, 402);
            dataGridEmployes.TabIndex = 16;
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelephone.Location = new Point(122, 360);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(224, 26);
            txtTelephone.TabIndex = 15;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelephone.Location = new Point(22, 368);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(79, 18);
            lblTelephone.TabIndex = 14;
            lblTelephone.Text = "Telephone";
            // 
            // txtCourriel
            // 
            txtCourriel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCourriel.Location = new Point(122, 290);
            txtCourriel.Name = "txtCourriel";
            txtCourriel.Size = new Size(224, 26);
            txtCourriel.TabIndex = 13;
            // 
            // lblCourriel
            // 
            lblCourriel.AutoSize = true;
            lblCourriel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCourriel.Location = new Point(22, 298);
            lblCourriel.Name = "lblCourriel";
            lblCourriel.Size = new Size(63, 18);
            lblCourriel.TabIndex = 12;
            lblCourriel.Text = "Courriel";
            // 
            // txtAdresse
            // 
            txtAdresse.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdresse.Location = new Point(122, 231);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(224, 26);
            txtAdresse.TabIndex = 11;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdresse.Location = new Point(22, 239);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(67, 18);
            lblAdresse.TabIndex = 10;
            lblAdresse.Text = "Adresse";
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrenom.Location = new Point(122, 172);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(224, 26);
            txtPrenom.TabIndex = 9;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrenom.Location = new Point(22, 180);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(63, 18);
            lblPrenom.TabIndex = 8;
            lblPrenom.Text = "Prénom";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNom.Location = new Point(122, 121);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(224, 26);
            txtNom.TabIndex = 7;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNom.Location = new Point(22, 129);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(41, 18);
            lblNom.TabIndex = 6;
            lblNom.Text = "Nom";
            // 
            // txtNumEmp
            // 
            txtNumEmp.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumEmp.Location = new Point(122, 69);
            txtNumEmp.Name = "txtNumEmp";
            txtNumEmp.Size = new Size(224, 26);
            txtNumEmp.TabIndex = 5;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(22, 77);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 18);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Numero";
            // 
            // btnAfficherList
            // 
            btnAfficherList.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAfficherList.Location = new Point(829, 25);
            btnAfficherList.Name = "btnAfficherList";
            btnAfficherList.Size = new Size(156, 37);
            btnAfficherList.TabIndex = 3;
            btnAfficherList.Text = "Afficher List";
            btnAfficherList.UseVisualStyleBackColor = true;
            btnAfficherList.Click += btnAfficherList_Click;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifier.Location = new Point(423, 452);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(156, 37);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(233, 452);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(156, 37);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.Location = new Point(46, 452);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(156, 37);
            btnAjouter.TabIndex = 0;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // tabProjets
            // 
            tabProjets.Controls.Add(dataGridProjets);
            tabProjets.Controls.Add(txtHPrevues);
            tabProjets.Controls.Add(lblHeures);
            tabProjets.Controls.Add(txtTitreProjets);
            tabProjets.Controls.Add(lblTitre);
            tabProjets.Controls.Add(txtNumProjet);
            tabProjets.Controls.Add(lblNumeroProjets);
            tabProjets.Controls.Add(btnAfficherListe);
            tabProjets.Controls.Add(btnModifierProjets);
            tabProjets.Controls.Add(btnSupprimerProjets);
            tabProjets.Controls.Add(btnAjouterProjets);
            tabProjets.Location = new Point(4, 24);
            tabProjets.Name = "tabProjets";
            tabProjets.Padding = new Padding(3);
            tabProjets.Size = new Size(1164, 529);
            tabProjets.TabIndex = 1;
            tabProjets.Text = "Projets";
            tabProjets.UseVisualStyleBackColor = true;
            // 
            // dataGridProjets
            // 
            dataGridProjets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProjets.Location = new Point(648, 94);
            dataGridProjets.Name = "dataGridProjets";
            dataGridProjets.RowTemplate.Height = 25;
            dataGridProjets.Size = new Size(494, 402);
            dataGridProjets.TabIndex = 33;
            // 
            // txtHPrevues
            // 
            txtHPrevues.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHPrevues.Location = new Point(166, 179);
            txtHPrevues.Name = "txtHPrevues";
            txtHPrevues.Size = new Size(224, 26);
            txtHPrevues.TabIndex = 26;
            // 
            // lblHeures
            // 
            lblHeures.AutoSize = true;
            lblHeures.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeures.Location = new Point(23, 187);
            lblHeures.Name = "lblHeures";
            lblHeures.Size = new Size(119, 18);
            lblHeures.TabIndex = 25;
            lblHeures.Text = "Heures Prévues";
            // 
            // txtTitreProjets
            // 
            txtTitreProjets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitreProjets.Location = new Point(166, 128);
            txtTitreProjets.Name = "txtTitreProjets";
            txtTitreProjets.Size = new Size(224, 26);
            txtTitreProjets.TabIndex = 24;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(23, 136);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(38, 18);
            lblTitre.TabIndex = 23;
            lblTitre.Text = "Titre";
            // 
            // txtNumProjet
            // 
            txtNumProjet.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumProjet.Location = new Point(166, 76);
            txtNumProjet.Name = "txtNumProjet";
            txtNumProjet.Size = new Size(224, 26);
            txtNumProjet.TabIndex = 22;
            // 
            // lblNumeroProjets
            // 
            lblNumeroProjets.AutoSize = true;
            lblNumeroProjets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroProjets.Location = new Point(23, 84);
            lblNumeroProjets.Name = "lblNumeroProjets";
            lblNumeroProjets.Size = new Size(63, 18);
            lblNumeroProjets.TabIndex = 21;
            lblNumeroProjets.Text = "Numero";
            // 
            // btnAfficherListe
            // 
            btnAfficherListe.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAfficherListe.Location = new Point(830, 32);
            btnAfficherListe.Name = "btnAfficherListe";
            btnAfficherListe.Size = new Size(156, 37);
            btnAfficherListe.TabIndex = 20;
            btnAfficherListe.Text = "Afficher Liste";
            btnAfficherListe.UseVisualStyleBackColor = true;
            btnAfficherListe.Click += btnAfficherListe_Click;
            // 
            // btnModifierProjets
            // 
            btnModifierProjets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifierProjets.Location = new Point(424, 459);
            btnModifierProjets.Name = "btnModifierProjets";
            btnModifierProjets.Size = new Size(156, 37);
            btnModifierProjets.TabIndex = 19;
            btnModifierProjets.Text = "Modifier";
            btnModifierProjets.UseVisualStyleBackColor = true;
            btnModifierProjets.Click += btnModifierProjets_Click;
            // 
            // btnSupprimerProjets
            // 
            btnSupprimerProjets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimerProjets.Location = new Point(234, 459);
            btnSupprimerProjets.Name = "btnSupprimerProjets";
            btnSupprimerProjets.Size = new Size(156, 37);
            btnSupprimerProjets.TabIndex = 18;
            btnSupprimerProjets.Text = "Supprimer";
            btnSupprimerProjets.UseVisualStyleBackColor = true;
            btnSupprimerProjets.Click += btnSupprimerProjets_Click;
            // 
            // btnAjouterProjets
            // 
            btnAjouterProjets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouterProjets.Location = new Point(47, 459);
            btnAjouterProjets.Name = "btnAjouterProjets";
            btnAjouterProjets.Size = new Size(156, 37);
            btnAjouterProjets.TabIndex = 17;
            btnAjouterProjets.Text = "Ajouter";
            btnAjouterProjets.UseVisualStyleBackColor = true;
            btnAjouterProjets.Click += btnAjouterProjets_Click;
            // 
            // tabTach
            // 
            tabTach.Controls.Add(label1);
            tabTach.Controls.Add(comboProjet);
            tabTach.Controls.Add(comboBoxEmploye);
            tabTach.Controls.Add(comboBoxProjet);
            tabTach.Controls.Add(dataGridTaches);
            tabTach.Controls.Add(txtNbHeures);
            tabTach.Controls.Add(lblHPrevues);
            tabTach.Controls.Add(txtSemaine);
            tabTach.Controls.Add(lblTitreTaches);
            tabTach.Controls.Add(lblEmploye);
            tabTach.Controls.Add(lblProjet);
            tabTach.Controls.Add(txtIdTache);
            tabTach.Controls.Add(lblIdTache);
            tabTach.Controls.Add(btnRechercher);
            tabTach.Controls.Add(btnModifierTaches);
            tabTach.Controls.Add(btnSupprimerTaches);
            tabTach.Controls.Add(btnAjouterTaches);
            tabTach.Location = new Point(4, 24);
            tabTach.Name = "tabTach";
            tabTach.Padding = new Padding(3);
            tabTach.Size = new Size(1164, 529);
            tabTach.TabIndex = 2;
            tabTach.Text = "Taches";
            tabTach.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(648, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 37;
            label1.Text = "Projet";
            // 
            // comboProjet
            // 
            comboProjet.FormattingEnabled = true;
            comboProjet.Location = new Point(702, 48);
            comboProjet.Name = "comboProjet";
            comboProjet.Size = new Size(224, 23);
            comboProjet.TabIndex = 36;
            // 
            // comboBoxEmploye
            // 
            comboBoxEmploye.FormattingEnabled = true;
            comboBoxEmploye.Location = new Point(123, 187);
            comboBoxEmploye.Name = "comboBoxEmploye";
            comboBoxEmploye.Size = new Size(224, 23);
            comboBoxEmploye.TabIndex = 35;
            // 
            // comboBoxProjet
            // 
            comboBoxProjet.FormattingEnabled = true;
            comboBoxProjet.Location = new Point(123, 131);
            comboBoxProjet.Name = "comboBoxProjet";
            comboBoxProjet.Size = new Size(224, 23);
            comboBoxProjet.TabIndex = 34;
            // 
            // dataGridTaches
            // 
            dataGridTaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTaches.Location = new Point(648, 94);
            dataGridTaches.Name = "dataGridTaches";
            dataGridTaches.RowTemplate.Height = 25;
            dataGridTaches.Size = new Size(494, 402);
            dataGridTaches.TabIndex = 33;
            // 
            // txtNbHeures
            // 
            txtNbHeures.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNbHeures.Location = new Point(123, 297);
            txtNbHeures.Name = "txtNbHeures";
            txtNbHeures.Size = new Size(224, 26);
            txtNbHeures.TabIndex = 30;
            // 
            // lblHPrevues
            // 
            lblHPrevues.AutoSize = true;
            lblHPrevues.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHPrevues.Location = new Point(6, 300);
            lblHPrevues.Name = "lblHPrevues";
            lblHPrevues.Size = new Size(117, 18);
            lblHPrevues.TabIndex = 29;
            lblHPrevues.Text = "Heures prévues";
            // 
            // txtSemaine
            // 
            txtSemaine.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSemaine.Location = new Point(123, 238);
            txtSemaine.Name = "txtSemaine";
            txtSemaine.Size = new Size(224, 26);
            txtSemaine.TabIndex = 28;
            // 
            // lblTitreTaches
            // 
            lblTitreTaches.AutoSize = true;
            lblTitreTaches.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitreTaches.Location = new Point(23, 246);
            lblTitreTaches.Name = "lblTitreTaches";
            lblTitreTaches.Size = new Size(71, 18);
            lblTitreTaches.TabIndex = 27;
            lblTitreTaches.Text = "Semaine";
            // 
            // lblEmploye
            // 
            lblEmploye.AutoSize = true;
            lblEmploye.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmploye.Location = new Point(23, 187);
            lblEmploye.Name = "lblEmploye";
            lblEmploye.Size = new Size(69, 18);
            lblEmploye.TabIndex = 25;
            lblEmploye.Text = "Employé";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProjet.Location = new Point(23, 136);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new Size(49, 18);
            lblProjet.TabIndex = 23;
            lblProjet.Text = "Projet";
            // 
            // txtIdTache
            // 
            txtIdTache.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdTache.Location = new Point(123, 76);
            txtIdTache.Name = "txtIdTache";
            txtIdTache.Size = new Size(224, 26);
            txtIdTache.TabIndex = 22;
            // 
            // lblIdTache
            // 
            lblIdTache.AutoSize = true;
            lblIdTache.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdTache.Location = new Point(23, 84);
            lblIdTache.Name = "lblIdTache";
            lblIdTache.Size = new Size(68, 18);
            lblIdTache.TabIndex = 21;
            lblIdTache.Text = "ID Tache";
            // 
            // btnRechercher
            // 
            btnRechercher.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRechercher.Location = new Point(946, 39);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(156, 37);
            btnRechercher.TabIndex = 20;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnModifierTaches
            // 
            btnModifierTaches.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifierTaches.Location = new Point(424, 459);
            btnModifierTaches.Name = "btnModifierTaches";
            btnModifierTaches.Size = new Size(156, 37);
            btnModifierTaches.TabIndex = 19;
            btnModifierTaches.Text = "Modifier";
            btnModifierTaches.UseVisualStyleBackColor = true;
            btnModifierTaches.Click += btnModifierTaches_Click;
            // 
            // btnSupprimerTaches
            // 
            btnSupprimerTaches.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimerTaches.Location = new Point(234, 459);
            btnSupprimerTaches.Name = "btnSupprimerTaches";
            btnSupprimerTaches.Size = new Size(156, 37);
            btnSupprimerTaches.TabIndex = 18;
            btnSupprimerTaches.Text = "Supprimer";
            btnSupprimerTaches.UseVisualStyleBackColor = true;
            btnSupprimerTaches.Click += btnSupprimerTaches_Click;
            // 
            // btnAjouterTaches
            // 
            btnAjouterTaches.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouterTaches.Location = new Point(47, 459);
            btnAjouterTaches.Name = "btnAjouterTaches";
            btnAjouterTaches.Size = new Size(156, 37);
            btnAjouterTaches.TabIndex = 17;
            btnAjouterTaches.Text = "Ajouter";
            btnAjouterTaches.UseVisualStyleBackColor = true;
            btnAjouterTaches.Click += btnAjouterTaches_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 583);
            Controls.Add(tabTaches);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            tabTaches.ResumeLayout(false);
            tabEmployes.ResumeLayout(false);
            tabEmployes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployes).EndInit();
            tabProjets.ResumeLayout(false);
            tabProjets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProjets).EndInit();
            tabTach.ResumeLayout(false);
            tabTach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTaches).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabTaches;
        private TabPage tabEmployes;
        private TabPage tabProjets;
        private TabPage tabTach;
        private Label lblNumero;
        private Button btnAfficherList;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnAjouter;
        private TextBox txtTelephone;
        private Label lblTelephone;
        private TextBox txtCourriel;
        private Label lblCourriel;
        private TextBox txtAdresse;
        private Label lblAdresse;
        private TextBox txtPrenom;
        private Label lblPrenom;
        private TextBox txtNom;
        private Label lblNom;
        private TextBox txtNumEmp;
        private DataGridView dataGridEmployes;
        private DataGridView dataGridProjets;
        private TextBox txtHPrevues;
        private Label lblHeures;
        private TextBox txtTitreProjets;
        private Label lblTitre;
        private TextBox txtNumProjet;
        private Label lblNumeroProjets;
        private Button btnAfficherListe;
        private Button btnModifierProjets;
        private Button btnSupprimerProjets;
        private Button btnAjouterProjets;
        private ComboBox comboProjet;
        private ComboBox comboBoxEmploye;
        private ComboBox comboBoxProjet;
        private DataGridView dataGridTaches;
        private TextBox txtNbHeures;
        private Label lblHPrevues;
        private TextBox txtSemaine;
        private Label lblTitreTaches;
        private Label lblEmploye;
        private Label lblProjet;
        private TextBox txtIdTache;
        private Label lblIdTache;
        private Button btnRechercher;
        private Button btnModifierTaches;
        private Button btnSupprimerTaches;
        private Button btnAjouterTaches;
        private Label label1;
    }
}