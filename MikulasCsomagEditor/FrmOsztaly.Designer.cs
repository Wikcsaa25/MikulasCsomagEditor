
namespace MikulasCsomagEditor
{
    partial class FrmOsztaly
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.osztalyTB = new System.Windows.Forms.TextBox();
            this.hozzaadas = new System.Windows.Forms.Button();
            this.tallozas = new System.Windows.Forms.Button();
            this.tallozasTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osztálynévsor tallózása:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Írja be az osztályjelzést:";
            // 
            // osztalyTB
            // 
            this.osztalyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztalyTB.Location = new System.Drawing.Point(261, 120);
            this.osztalyTB.Name = "osztalyTB";
            this.osztalyTB.ReadOnly = true;
            this.osztalyTB.Size = new System.Drawing.Size(254, 28);
            this.osztalyTB.TabIndex = 2;
            // 
            // hozzaadas
            // 
            this.hozzaadas.Enabled = false;
            this.hozzaadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaadas.Location = new System.Drawing.Point(29, 173);
            this.hozzaadas.Name = "hozzaadas";
            this.hozzaadas.Size = new System.Drawing.Size(486, 34);
            this.hozzaadas.TabIndex = 3;
            this.hozzaadas.Text = "Hozzáadás az adatbázishoz";
            this.hozzaadas.UseVisualStyleBackColor = true;
            this.hozzaadas.Click += new System.EventHandler(this.hozzaadas_Click);
            // 
            // tallozas
            // 
            this.tallozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tallozas.Location = new System.Drawing.Point(410, 68);
            this.tallozas.Name = "tallozas";
            this.tallozas.Size = new System.Drawing.Size(105, 34);
            this.tallozas.TabIndex = 4;
            this.tallozas.Text = "Tallózás";
            this.tallozas.UseVisualStyleBackColor = true;
            this.tallozas.Click += new System.EventHandler(this.tallozas_Click);
            // 
            // tallozasTB
            // 
            this.tallozasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tallozasTB.Location = new System.Drawing.Point(29, 71);
            this.tallozasTB.Name = "tallozasTB";
            this.tallozasTB.Size = new System.Drawing.Size(352, 28);
            this.tallozasTB.TabIndex = 5;
            this.tallozasTB.TextChanged += new System.EventHandler(this.tallozasTB_TextChanged);
            // 
            // FrmOsztaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(550, 230);
            this.Controls.Add(this.tallozasTB);
            this.Controls.Add(this.tallozas);
            this.Controls.Add(this.hozzaadas);
            this.Controls.Add(this.osztalyTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOsztaly";
            this.Text = "FrmOsztaly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox osztalyTB;
        private System.Windows.Forms.Button hozzaadas;
        private System.Windows.Forms.Button tallozas;
        private System.Windows.Forms.TextBox tallozasTB;
    }
}