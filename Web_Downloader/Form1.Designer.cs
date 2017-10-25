namespace Web_Downloader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxURL = new System.Windows.Forms.GroupBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDwnld = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonRecharger = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxURL.SuspendLayout();
            this.groupBoxDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxURL
            // 
            this.groupBoxURL.Controls.Add(this.textBoxURL);
            this.groupBoxURL.Location = new System.Drawing.Point(12, 35);
            this.groupBoxURL.Name = "groupBoxURL";
            this.groupBoxURL.Size = new System.Drawing.Size(650, 63);
            this.groupBoxURL.TabIndex = 0;
            this.groupBoxURL.TabStop = false;
            this.groupBoxURL.Text = "URL du fichier à télécharger";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(19, 27);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(486, 20);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Controls.Add(this.buttonParcourir);
            this.groupBoxDestination.Controls.Add(this.textBox1);
            this.groupBoxDestination.Location = new System.Drawing.Point(12, 121);
            this.groupBoxDestination.Name = "groupBoxDestination";
            this.groupBoxDestination.Size = new System.Drawing.Size(650, 63);
            this.groupBoxDestination.TabIndex = 1;
            this.groupBoxDestination.TabStop = false;
            this.groupBoxDestination.Text = "Répertoire de destination";
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Location = new System.Drawing.Point(534, 28);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(89, 20);
            this.buttonParcourir.TabIndex = 2;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonDwnld
            // 
            this.buttonDwnld.Location = new System.Drawing.Point(546, 237);
            this.buttonDwnld.Name = "buttonDwnld";
            this.buttonDwnld.Size = new System.Drawing.Size(89, 20);
            this.buttonDwnld.TabIndex = 3;
            this.buttonDwnld.Text = "Télécharger";
            this.buttonDwnld.UseVisualStyleBackColor = true;
            this.buttonDwnld.Click += new System.EventHandler(this.buttonDwnld_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 234);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // buttonRecharger
            // 
            this.buttonRecharger.Location = new System.Drawing.Point(546, 9);
            this.buttonRecharger.Name = "buttonRecharger";
            this.buttonRecharger.Size = new System.Drawing.Size(89, 20);
            this.buttonRecharger.TabIndex = 5;
            this.buttonRecharger.Text = "Recharger";
            this.buttonRecharger.UseVisualStyleBackColor = true;
            this.buttonRecharger.Click += new System.EventHandler(this.buttonRecharger_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 289);
            this.Controls.Add(this.buttonRecharger);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonDwnld);
            this.Controls.Add(this.groupBoxDestination);
            this.Controls.Add(this.groupBoxURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxURL.ResumeLayout(false);
            this.groupBoxURL.PerformLayout();
            this.groupBoxDestination.ResumeLayout(false);
            this.groupBoxDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBoxDestination;
        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Button buttonDwnld;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonRecharger;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

