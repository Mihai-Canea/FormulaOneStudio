namespace FormulaOneStudio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateCountry = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateDrivers = new System.Windows.Forms.Button();
            this.btnCreateTeams = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDropDrivers = new System.Windows.Forms.Button();
            this.btnDropTeams = new System.Windows.Forms.Button();
            this.btnDropCountry = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCountry
            // 
            this.btnCreateCountry.Location = new System.Drawing.Point(6, 19);
            this.btnCreateCountry.Name = "btnCreateCountry";
            this.btnCreateCountry.Size = new System.Drawing.Size(75, 30);
            this.btnCreateCountry.TabIndex = 1;
            this.btnCreateCountry.Text = "Country";
            this.btnCreateCountry.UseVisualStyleBackColor = true;
            this.btnCreateCountry.Click += new System.EventHandler(this.btnCreateCountry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateDrivers);
            this.groupBox1.Controls.Add(this.btnCreateTeams);
            this.groupBox1.Controls.Add(this.btnCreateCountry);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE";
            // 
            // btnCreateDrivers
            // 
            this.btnCreateDrivers.Location = new System.Drawing.Point(168, 19);
            this.btnCreateDrivers.Name = "btnCreateDrivers";
            this.btnCreateDrivers.Size = new System.Drawing.Size(75, 30);
            this.btnCreateDrivers.TabIndex = 3;
            this.btnCreateDrivers.Text = "Drivers";
            this.btnCreateDrivers.UseVisualStyleBackColor = true;
            this.btnCreateDrivers.Click += new System.EventHandler(this.btnCreateDrivers_Click);
            // 
            // btnCreateTeams
            // 
            this.btnCreateTeams.Location = new System.Drawing.Point(87, 19);
            this.btnCreateTeams.Name = "btnCreateTeams";
            this.btnCreateTeams.Size = new System.Drawing.Size(75, 30);
            this.btnCreateTeams.TabIndex = 2;
            this.btnCreateTeams.Text = "Teams";
            this.btnCreateTeams.UseVisualStyleBackColor = true;
            this.btnCreateTeams.Click += new System.EventHandler(this.btnCreateTeams_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDropDrivers);
            this.groupBox2.Controls.Add(this.btnDropTeams);
            this.groupBox2.Controls.Add(this.btnDropCountry);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DROP";
            // 
            // btnDropDrivers
            // 
            this.btnDropDrivers.Location = new System.Drawing.Point(174, 19);
            this.btnDropDrivers.Name = "btnDropDrivers";
            this.btnDropDrivers.Size = new System.Drawing.Size(75, 30);
            this.btnDropDrivers.TabIndex = 6;
            this.btnDropDrivers.Text = "Drivers";
            this.btnDropDrivers.UseVisualStyleBackColor = true;
            // 
            // btnDropTeams
            // 
            this.btnDropTeams.Location = new System.Drawing.Point(93, 19);
            this.btnDropTeams.Name = "btnDropTeams";
            this.btnDropTeams.Size = new System.Drawing.Size(75, 30);
            this.btnDropTeams.TabIndex = 5;
            this.btnDropTeams.Text = "Teams";
            this.btnDropTeams.UseVisualStyleBackColor = true;
            // 
            // btnDropCountry
            // 
            this.btnDropCountry.Location = new System.Drawing.Point(12, 19);
            this.btnDropCountry.Name = "btnDropCountry";
            this.btnDropCountry.Size = new System.Drawing.Size(75, 30);
            this.btnDropCountry.TabIndex = 4;
            this.btnDropCountry.Text = "Country";
            this.btnDropCountry.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOutput);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OUTPUT";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(7, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(321, 78);
            this.txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SCRIPTS - FORM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateDrivers;
        private System.Windows.Forms.Button btnCreateTeams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDropDrivers;
        private System.Windows.Forms.Button btnDropTeams;
        private System.Windows.Forms.Button btnDropCountry;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

