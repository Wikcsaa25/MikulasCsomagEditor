
namespace MikulasCsomagEditor
{
    partial class FrmSorsolas
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
            this.osztalyCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgwSorsolva = new System.Windows.Forms.DataGridView();
            this.a_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSorsolva)).BeginInit();
            this.SuspendLayout();
            // 
            // osztalyCB
            // 
            this.osztalyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztalyCB.FormattingEnabled = true;
            this.osztalyCB.Location = new System.Drawing.Point(15, 52);
            this.osztalyCB.Name = "osztalyCB";
            this.osztalyCB.Size = new System.Drawing.Size(170, 37);
            this.osztalyCB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(220, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Véletlenszerű összepárosítás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgwSorsolva
            // 
            this.dgwSorsolva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSorsolva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSorsolva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a_ID,
            this.ad,
            this.k_ID,
            this.kap});
            this.dgwSorsolva.Enabled = false;
            this.dgwSorsolva.EnableHeadersVisualStyles = false;
            this.dgwSorsolva.Location = new System.Drawing.Point(14, 117);
            this.dgwSorsolva.Name = "dgwSorsolva";
            this.dgwSorsolva.ReadOnly = true;
            this.dgwSorsolva.RowHeadersVisible = false;
            this.dgwSorsolva.RowHeadersWidth = 51;
            this.dgwSorsolva.RowTemplate.Height = 24;
            this.dgwSorsolva.Size = new System.Drawing.Size(592, 193);
            this.dgwSorsolva.TabIndex = 2;
            // 
            // a_ID
            // 
            this.a_ID.FillWeight = 65.1361F;
            this.a_ID.HeaderText = "a_ID";
            this.a_ID.MinimumWidth = 6;
            this.a_ID.Name = "a_ID";
            this.a_ID.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.FillWeight = 140.694F;
            this.ad.HeaderText = "ad";
            this.ad.MinimumWidth = 6;
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // k_ID
            // 
            this.k_ID.FillWeight = 53.47594F;
            this.k_ID.HeaderText = "k_ID";
            this.k_ID.MinimumWidth = 6;
            this.k_ID.Name = "k_ID";
            this.k_ID.ReadOnly = true;
            // 
            // kap
            // 
            this.kap.FillWeight = 140.694F;
            this.kap.HeaderText = "kap";
            this.kap.MinimumWidth = 6;
            this.kap.Name = "kap";
            this.kap.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "a_ID1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "a_ID2";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(121, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "csere";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(15, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(222, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 34);
            this.textBox2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(346, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Véglegesítés!";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Válaszd ki az osztályt:";
            // 
            // FrmSorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(621, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwSorsolva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.osztalyCB);
            this.Name = "FrmSorsolas";
            this.Text = "FrmSorsolas";
            this.Load += new System.EventHandler(this.FrmSorsolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSorsolva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox osztalyCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgwSorsolva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kap;
    }
}