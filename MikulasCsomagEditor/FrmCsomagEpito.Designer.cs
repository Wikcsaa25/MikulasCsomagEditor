
namespace MikulasCsomagEditor
{
    partial class FrmCsomagEpito
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
            this.vasarlasa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statisztika = new System.Windows.Forms.Button();
            this.betesz = new System.Windows.Forms.Button();
            this.ertekHatar = new System.Windows.Forms.NumericUpDown();
            this.vegOsszeg = new System.Windows.Forms.Label();
            this.dgwTartalom = new System.Windows.Forms.DataGridView();
            this.termek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.termekCB = new System.Windows.Forms.ComboBox();
            this.mennyiseg = new System.Windows.Forms.TextBox();
            this.azon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ertekHatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTartalom)).BeginInit();
            this.SuspendLayout();
            // 
            // vasarlasa
            // 
            this.vasarlasa.Enabled = false;
            this.vasarlasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vasarlasa.Location = new System.Drawing.Point(390, 365);
            this.vasarlasa.Name = "vasarlasa";
            this.vasarlasa.Size = new System.Drawing.Size(253, 39);
            this.vasarlasa.TabIndex = 0;
            this.vasarlasa.Text = "Csomag megvásárlása!";
            this.vasarlasa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "értékhatár:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(374, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Írd be az azonosítód:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Csomag értéke jelenleg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(294, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "db";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(184, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "termék:";
            // 
            // statisztika
            // 
            this.statisztika.Enabled = false;
            this.statisztika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisztika.Location = new System.Drawing.Point(28, 365);
            this.statisztika.Name = "statisztika";
            this.statisztika.Size = new System.Drawing.Size(298, 39);
            this.statisztika.TabIndex = 2;
            this.statisztika.Text = "statisztika";
            this.statisztika.UseVisualStyleBackColor = true;
            // 
            // betesz
            // 
            this.betesz.Enabled = false;
            this.betesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betesz.Location = new System.Drawing.Point(28, 195);
            this.betesz.Name = "betesz";
            this.betesz.Size = new System.Drawing.Size(298, 39);
            this.betesz.TabIndex = 3;
            this.betesz.Text = "Csomagba tesz!";
            this.betesz.UseVisualStyleBackColor = true;
            this.betesz.Click += new System.EventHandler(this.betesz_Click);
            // 
            // ertekHatar
            // 
            this.ertekHatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ertekHatar.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ertekHatar.Location = new System.Drawing.Point(143, 36);
            this.ertekHatar.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.ertekHatar.Name = "ertekHatar";
            this.ertekHatar.Size = new System.Drawing.Size(84, 28);
            this.ertekHatar.TabIndex = 4;
            this.ertekHatar.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // vegOsszeg
            // 
            this.vegOsszeg.AutoSize = true;
            this.vegOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vegOsszeg.ForeColor = System.Drawing.Color.White;
            this.vegOsszeg.Location = new System.Drawing.Point(602, 305);
            this.vegOsszeg.Name = "vegOsszeg";
            this.vegOsszeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vegOsszeg.Size = new System.Drawing.Size(41, 24);
            this.vegOsszeg.TabIndex = 5;
            this.vegOsszeg.Text = "0 Ft";
            this.vegOsszeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgwTartalom
            // 
            this.dgwTartalom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTartalom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTartalom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termek,
            this.db});
            this.dgwTartalom.Location = new System.Drawing.Point(390, 140);
            this.dgwTartalom.Name = "dgwTartalom";
            this.dgwTartalom.ReadOnly = true;
            this.dgwTartalom.RowHeadersVisible = false;
            this.dgwTartalom.RowHeadersWidth = 51;
            this.dgwTartalom.RowTemplate.Height = 24;
            this.dgwTartalom.Size = new System.Drawing.Size(253, 150);
            this.dgwTartalom.TabIndex = 6;
            // 
            // termek
            // 
            this.termek.HeaderText = "termek";
            this.termek.MinimumWidth = 6;
            this.termek.Name = "termek";
            this.termek.ReadOnly = true;
            // 
            // db
            // 
            this.db.HeaderText = "db";
            this.db.MinimumWidth = 6;
            this.db.Name = "db";
            this.db.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(374, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Csomag tartalma jelenleg:";
            // 
            // termekCB
            // 
            this.termekCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termekCB.FormattingEnabled = true;
            this.termekCB.Location = new System.Drawing.Point(28, 137);
            this.termekCB.Name = "termekCB";
            this.termekCB.Size = new System.Drawing.Size(150, 30);
            this.termekCB.TabIndex = 7;
            // 
            // mennyiseg
            // 
            this.mennyiseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mennyiseg.Location = new System.Drawing.Point(214, 137);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(74, 28);
            this.mennyiseg.TabIndex = 8;
            this.mennyiseg.Text = "1";
            // 
            // azon
            // 
            this.azon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azon.Location = new System.Drawing.Point(588, 36);
            this.azon.Name = "azon";
            this.azon.Size = new System.Drawing.Size(68, 28);
            this.azon.TabIndex = 9;
            this.azon.TextChanged += new System.EventHandler(this.azon_TextChanged);
            // 
            // FrmCsomagEpito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.azon);
            this.Controls.Add(this.mennyiseg);
            this.Controls.Add(this.termekCB);
            this.Controls.Add(this.dgwTartalom);
            this.Controls.Add(this.vegOsszeg);
            this.Controls.Add(this.ertekHatar);
            this.Controls.Add(this.betesz);
            this.Controls.Add(this.statisztika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vasarlasa);
            this.Name = "FrmCsomagEpito";
            this.Text = "FrmCsomagEpito";
            this.Load += new System.EventHandler(this.FrmCsomagEpito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ertekHatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTartalom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vasarlasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button statisztika;
        private System.Windows.Forms.Button betesz;
        private System.Windows.Forms.NumericUpDown ertekHatar;
        private System.Windows.Forms.Label vegOsszeg;
        private System.Windows.Forms.DataGridView dgwTartalom;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek;
        private System.Windows.Forms.DataGridViewTextBoxColumn db;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox termekCB;
        private System.Windows.Forms.TextBox mennyiseg;
        private System.Windows.Forms.TextBox azon;
    }
}