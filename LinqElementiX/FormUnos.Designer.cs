namespace LinqElementiX
{
    partial class FormUnos
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtGodRod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnosPodataka = new System.Windows.Forms.Button();
            this.snimiNoviDokument = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(42, 42);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(388, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(42, 105);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(388, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtGodRod
            // 
            this.txtGodRod.Location = new System.Drawing.Point(42, 166);
            this.txtGodRod.Name = "txtGodRod";
            this.txtGodRod.Size = new System.Drawing.Size(388, 20);
            this.txtGodRod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Godina rođenja";
            // 
            // btnUnosPodataka
            // 
            this.btnUnosPodataka.Location = new System.Drawing.Point(42, 263);
            this.btnUnosPodataka.Name = "btnUnosPodataka";
            this.btnUnosPodataka.Size = new System.Drawing.Size(388, 92);
            this.btnUnosPodataka.TabIndex = 6;
            this.btnUnosPodataka.Text = "Unesi";
            this.btnUnosPodataka.UseVisualStyleBackColor = true;
            this.btnUnosPodataka.Click += new System.EventHandler(this.btnUnosPodataka_Click);
            // 
            // snimiNoviDokument
            // 
            this.snimiNoviDokument.DefaultExt = "xml";
            this.snimiNoviDokument.InitialDirectory = "c:\\";
            this.snimiNoviDokument.Title = "Novi dokument";
            // 
            // FormUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 430);
            this.Controls.Add(this.btnUnosPodataka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGodRod);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "FormUnos";
            this.Text = "FormUnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtGodRod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnosPodataka;
        private System.Windows.Forms.SaveFileDialog snimiNoviDokument;
    }
}