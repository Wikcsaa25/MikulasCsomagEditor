
namespace MikulasCsomagEditor
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.sorsolas = new System.Windows.Forms.Button();
            this.epito = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(129, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "osztály betöltése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sorsolas
            // 
            this.sorsolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sorsolas.Location = new System.Drawing.Point(129, 62);
            this.sorsolas.Name = "sorsolas";
            this.sorsolas.Size = new System.Drawing.Size(245, 44);
            this.sorsolas.TabIndex = 0;
            this.sorsolas.Text = "sorsolás";
            this.sorsolas.UseVisualStyleBackColor = true;
            this.sorsolas.Click += new System.EventHandler(this.sorsolas_Click);
            // 
            // epito
            // 
            this.epito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.epito.Location = new System.Drawing.Point(129, 112);
            this.epito.Name = "epito";
            this.epito.Size = new System.Drawing.Size(245, 44);
            this.epito.TabIndex = 0;
            this.epito.Text = "csomagépítő";
            this.epito.UseVisualStyleBackColor = true;
            this.epito.Click += new System.EventHandler(this.epito_Click);
            // 
            // kilepes
            // 
            this.kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kilepes.Location = new System.Drawing.Point(129, 162);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(245, 44);
            this.kilepes.TabIndex = 0;
            this.kilepes.Text = "Kilépés";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MikulasCsomagEditor.Properties.Resources.csomag_BG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(385, 217);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.epito);
            this.Controls.Add(this.sorsolas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sorsolas;
        private System.Windows.Forms.Button epito;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

