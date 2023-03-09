namespace LL_Saldumi11
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
            this.button1 = new System.Windows.Forms.Button();
            this.Summa = new System.Windows.Forms.TextBox();
            this.Nsumma = new System.Windows.Forms.Label();
            this.Dati_TB = new System.Windows.Forms.TextBox();
            this.daudz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Vards = new System.Windows.Forms.Label();
            this.vardsBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Datums = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(657, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aprekinat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Summa
            // 
            this.Summa.Location = new System.Drawing.Point(695, 63);
            this.Summa.Margin = new System.Windows.Forms.Padding(4);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(160, 22);
            this.Summa.TabIndex = 1;
            // 
            // Nsumma
            // 
            this.Nsumma.AutoSize = true;
            this.Nsumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Nsumma.Location = new System.Drawing.Point(511, 65);
            this.Nsumma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nsumma.Name = "Nsumma";
            this.Nsumma.Size = new System.Drawing.Size(154, 24);
            this.Nsumma.TabIndex = 3;
            this.Nsumma.Text = "Naudas summa";
            this.Nsumma.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dati_TB
            // 
            this.Dati_TB.Location = new System.Drawing.Point(695, 103);
            this.Dati_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Dati_TB.Name = "Dati_TB";
            this.Dati_TB.Size = new System.Drawing.Size(160, 22);
            this.Dati_TB.TabIndex = 4;
            this.Dati_TB.TextChanged += new System.EventHandler(this.Dati_TB_TextChanged);
            // 
            // daudz
            // 
            this.daudz.AutoSize = true;
            this.daudz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.daudz.Location = new System.Drawing.Point(603, 106);
            this.daudz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daudz.Name = "daudz";
            this.daudz.Size = new System.Drawing.Size(45, 24);
            this.daudz.TabIndex = 5;
            this.daudz.Text = "Dati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(33, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zefīra cena ir 9.88 e/kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ievadiet skaitli ar komatu ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.checkBox1.Location = new System.Drawing.Point(695, 199);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 33);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Zefīrs";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.checkBox2.Location = new System.Drawing.Point(695, 233);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 33);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Karamele";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Karameles cena ir 6.22 e/kg";
            // 
            // Vards
            // 
            this.Vards.AutoSize = true;
            this.Vards.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vards.Location = new System.Drawing.Point(33, 343);
            this.Vards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vards.Name = "Vards";
            this.Vards.Size = new System.Drawing.Size(57, 23);
            this.Vards.TabIndex = 11;
            this.Vards.Text = "Vārds";
            this.Vards.Click += new System.EventHandler(this.label6_Click);
            // 
            // vardsBox1
            // 
            this.vardsBox1.Location = new System.Drawing.Point(103, 343);
            this.vardsBox1.Margin = new System.Windows.Forms.Padding(4);
            this.vardsBox1.Name = "vardsBox1";
            this.vardsBox1.Size = new System.Drawing.Size(132, 22);
            this.vardsBox1.TabIndex = 14;
            this.vardsBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 409);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Datums
            // 
            this.Datums.AutoSize = true;
            this.Datums.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datums.Location = new System.Drawing.Point(32, 409);
            this.Datums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datums.Name = "Datums";
            this.Datums.Size = new System.Drawing.Size(128, 23);
            this.Datums.TabIndex = 17;
            this.Datums.Text = "Datuma izvēle";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.checkBox3.Location = new System.Drawing.Point(695, 268);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(136, 33);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Šokolāde";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(37, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Šokolādes cena ir 4.20 e/kg";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button2.Location = new System.Drawing.Point(657, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 73);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ceks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.Datums);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.vardsBox1);
            this.Controls.Add(this.Vards);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.daudz);
            this.Controls.Add(this.Dati_TB);
            this.Controls.Add(this.Nsumma);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Summa;
        private System.Windows.Forms.Label Nsumma;
        private System.Windows.Forms.TextBox Dati_TB;
        private System.Windows.Forms.Label daudz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Vards;
        private System.Windows.Forms.TextBox vardsBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Datums;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}