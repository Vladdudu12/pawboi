
namespace pawboi
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxNrCamere = new System.Windows.Forms.TextBox();
            this.textBoxMarime = new System.Windows.Forms.TextBox();
            this.textBoxLocatie = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelNrCamere = new System.Windows.Forms.Label();
            this.labelMarime = new System.Windows.Forms.Label();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(180, 140);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 23);
            this.textBoxNume.TabIndex = 2;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(180, 170);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 23);
            this.textBoxPret.TabIndex = 3;
            // 
            // textBoxNrCamere
            // 
            this.textBoxNrCamere.Location = new System.Drawing.Point(180, 200);
            this.textBoxNrCamere.Name = "textBoxNrCamere";
            this.textBoxNrCamere.Size = new System.Drawing.Size(100, 23);
            this.textBoxNrCamere.TabIndex = 4;
            // 
            // textBoxMarime
            // 
            this.textBoxMarime.Location = new System.Drawing.Point(180, 230);
            this.textBoxMarime.Name = "textBoxMarime";
            this.textBoxMarime.Size = new System.Drawing.Size(100, 23);
            this.textBoxMarime.TabIndex = 5;
            // 
            // textBoxLocatie
            // 
            this.textBoxLocatie.Location = new System.Drawing.Point(180, 260);
            this.textBoxLocatie.Name = "textBoxLocatie";
            this.textBoxLocatie.Size = new System.Drawing.Size(100, 23);
            this.textBoxLocatie.TabIndex = 6;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(120, 147);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(40, 15);
            this.labelNume.TabIndex = 7;
            this.labelNume.Text = "Nume";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(120, 177);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(28, 15);
            this.labelPret.TabIndex = 8;
            this.labelPret.Text = "Pret";
            // 
            // labelNrCamere
            // 
            this.labelNrCamere.AutoSize = true;
            this.labelNrCamere.Location = new System.Drawing.Point(107, 208);
            this.labelNrCamere.Name = "labelNrCamere";
            this.labelNrCamere.Size = new System.Drawing.Size(67, 15);
            this.labelNrCamere.TabIndex = 9;
            this.labelNrCamere.Text = "Nr. Camere";
            // 
            // labelMarime
            // 
            this.labelMarime.AutoSize = true;
            this.labelMarime.Location = new System.Drawing.Point(120, 237);
            this.labelMarime.Name = "labelMarime";
            this.labelMarime.Size = new System.Drawing.Size(48, 15);
            this.labelMarime.TabIndex = 10;
            this.labelMarime.Text = "Marime";
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(120, 267);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(45, 15);
            this.labelLocatie.TabIndex = 11;
            this.labelLocatie.Text = "Locatie";
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.Location = new System.Drawing.Point(180, 290);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(100, 23);
            this.buttonAdaugare.TabIndex = 12;
            this.buttonAdaugare.Text = "Adaugare";
            this.buttonAdaugare.UseVisualStyleBackColor = true;
            this.buttonAdaugare.Click += new System.EventHandler(this.buttonAdaugare_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(180, 74);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(344, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(312, 239);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(180, 111);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(100, 23);
            this.textBoxCod.TabIndex = 15;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(120, 119);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(29, 15);
            this.labelCod.TabIndex = 16;
            this.labelCod.Text = "Cod";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonAdaugare);
            this.Controls.Add(this.labelLocatie);
            this.Controls.Add(this.labelMarime);
            this.Controls.Add(this.labelNrCamere);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.textBoxLocatie);
            this.Controls.Add(this.textBoxMarime);
            this.Controls.Add(this.textBoxNrCamere);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxNrCamere;
        private System.Windows.Forms.TextBox textBoxMarime;
        private System.Windows.Forms.TextBox textBoxLocatie;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelNrCamere;
        private System.Windows.Forms.Label labelMarime;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Button buttonAdaugare;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelCod;
    }
}

