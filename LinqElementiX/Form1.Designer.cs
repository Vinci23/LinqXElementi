namespace LinqElementiX
{
    partial class Form1
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnCitaj = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(12, 12);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(662, 94);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnCitaj
            // 
            this.btnCitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCitaj.Location = new System.Drawing.Point(12, 164);
            this.btnCitaj.Name = "btnCitaj";
            this.btnCitaj.Size = new System.Drawing.Size(662, 92);
            this.btnCitaj.TabIndex = 1;
            this.btnCitaj.Text = "Čitaj";
            this.btnCitaj.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.Location = new System.Drawing.Point(12, 303);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(662, 101);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnCitaj);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Manipuliranje podacima u XMLu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnCitaj;
        private System.Windows.Forms.Button btnFilter;
    }
}

