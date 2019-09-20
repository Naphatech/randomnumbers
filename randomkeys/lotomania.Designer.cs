namespace randomkeys
{
    partial class lotomania
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
            this.Resultado = new System.Windows.Forms.ListBox();
            this.button_lotomania_gerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valordezenas = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resultado.FormattingEnabled = true;
            this.Resultado.Location = new System.Drawing.Point(219, 17);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(339, 247);
            this.Resultado.TabIndex = 0;
            // 
            // button_lotomania_gerar
            // 
            this.button_lotomania_gerar.BackColor = System.Drawing.Color.Transparent;
            this.button_lotomania_gerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_lotomania_gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_lotomania_gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lotomania_gerar.Location = new System.Drawing.Point(6, 71);
            this.button_lotomania_gerar.Name = "button_lotomania_gerar";
            this.button_lotomania_gerar.Size = new System.Drawing.Size(188, 23);
            this.button_lotomania_gerar.TabIndex = 1;
            this.button_lotomania_gerar.Text = "Sortear";
            this.button_lotomania_gerar.UseVisualStyleBackColor = false;
            this.button_lotomania_gerar.Click += new System.EventHandler(this.button_lotomania_gerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Jogo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde Dezenas *:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valordezenas);
            this.groupBox1.Controls.Add(this.button_lotomania_gerar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // valordezenas
            // 
            this.valordezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valordezenas.Location = new System.Drawing.Point(94, 36);
            this.valordezenas.Name = "valordezenas";
            this.valordezenas.Size = new System.Drawing.Size(100, 20);
            this.valordezenas.TabIndex = 6;
            this.valordezenas.Tag = "valordezenas";
            this.valordezenas.Text = "min. 50 Dezenas";
            this.valordezenas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valordezenas.UseWaitCursor = true;
            this.valordezenas.TextChanged += new System.EventHandler(this.valordezenas_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lotomania",
            "Mega-Sena",
            "Quina",
            "Dupla-Sena"});
            this.comboBox1.Location = new System.Drawing.Point(73, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Lotomania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lotofacil - Gerador de Números";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Para usar, siga estes procedimentos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "1. Confirme o tipo de jogo;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "2. Informe a quantidade de Dezenas;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "3. Clique em Sortear;";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Boa sorte!";
            // 
            // lotomania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 281);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Resultado);
            this.Name = "lotomania";
            this.Text = "Lotomania";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Resultado;
        private System.Windows.Forms.Button button_lotomania_gerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox valordezenas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}