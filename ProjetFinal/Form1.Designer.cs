namespace ProjetFinal
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
            tabProjets = new TabPage();
            tabPage3 = new TabPage();
            tabTaches.SuspendLayout();
            SuspendLayout();
            // 
            // tabTaches
            // 
            tabTaches.Controls.Add(tabEmployes);
            tabTaches.Controls.Add(tabProjets);
            tabTaches.Controls.Add(tabPage3);
            tabTaches.Location = new Point(22, 14);
            tabTaches.Name = "tabTaches";
            tabTaches.SelectedIndex = 0;
            tabTaches.Size = new Size(1172, 557);
            tabTaches.TabIndex = 0;
            // 
            // tabEmployes
            // 
            tabEmployes.Location = new Point(4, 24);
            tabEmployes.Name = "tabEmployes";
            tabEmployes.Padding = new Padding(3);
            tabEmployes.Size = new Size(1164, 529);
            tabEmployes.TabIndex = 0;
            tabEmployes.Text = "Employes";
            tabEmployes.UseVisualStyleBackColor = true;
            // 
            // tabProjets
            // 
            tabProjets.Location = new Point(4, 24);
            tabProjets.Name = "tabProjets";
            tabProjets.Padding = new Padding(3);
            tabProjets.Size = new Size(1164, 529);
            tabProjets.TabIndex = 1;
            tabProjets.Text = "Projets";
            tabProjets.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1164, 529);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 583);
            Controls.Add(tabTaches);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            tabTaches.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabTaches;
        private TabPage tabEmployes;
        private TabPage tabProjets;
        private TabPage tabPage3;
    }
}