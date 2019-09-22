namespace randomkeys
{
    partial class randomnumber
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_megasena = new System.Windows.Forms.Button();
            this.button_lotomania = new System.Windows.Forms.Button();
            this.button_quina = new System.Windows.Forms.Button();
            this.button_duplasena = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_megasena
            // 
            this.button_megasena.Location = new System.Drawing.Point(9, 19);
            this.button_megasena.Name = "button_megasena";
            this.button_megasena.Size = new System.Drawing.Size(75, 49);
            this.button_megasena.TabIndex = 4;
            this.button_megasena.Text = "Mega Sena";
            this.button_megasena.UseVisualStyleBackColor = true;
            this.button_megasena.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_lotomania
            // 
            this.button_lotomania.Location = new System.Drawing.Point(111, 19);
            this.button_lotomania.Name = "button_lotomania";
            this.button_lotomania.Size = new System.Drawing.Size(75, 49);
            this.button_lotomania.TabIndex = 5;
            this.button_lotomania.Text = "Lotomania";
            this.button_lotomania.UseVisualStyleBackColor = true;
            this.button_lotomania.Click += new System.EventHandler(this.button_lotomania_Click);
            // 
            // button_quina
            // 
            this.button_quina.Location = new System.Drawing.Point(210, 19);
            this.button_quina.Name = "button_quina";
            this.button_quina.Size = new System.Drawing.Size(75, 49);
            this.button_quina.TabIndex = 6;
            this.button_quina.Text = "Quina";
            this.button_quina.UseVisualStyleBackColor = true;
            this.button_quina.Click += new System.EventHandler(this.button_quina_Click);
            // 
            // button_duplasena
            // 
            this.button_duplasena.Location = new System.Drawing.Point(304, 19);
            this.button_duplasena.Name = "button_duplasena";
            this.button_duplasena.Size = new System.Drawing.Size(75, 49);
            this.button_duplasena.TabIndex = 7;
            this.button_duplasena.Text = "Dupla Sena";
            this.button_duplasena.UseVisualStyleBackColor = true;
            this.button_duplasena.Click += new System.EventHandler(this.button_duplasena_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(151, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para continuar, selecione o jogo de sua preferência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bem-Vindo(a), ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_megasena);
            this.groupBox2.Controls.Add(this.button_lotomania);
            this.groupBox2.Controls.Add(this.button_quina);
            this.groupBox2.Controls.Add(this.button_duplasena);
            this.groupBox2.Location = new System.Drawing.Point(3, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 84);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione seu tipo de Jogo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(9, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ultimos jogos salvos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 9);
            this.label2.TabIndex = 16;
            this.label2.Text = "v1.0 - Naphatech";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "22/09/2019 às 10:15 - Lotofácil",
            "22/09/2019 às 11:10 - Mega-sena",
            "21/09/2019 às 09:13 - Quina",
            "20/09/2019 às 23:45 - Lotofácil"});
            this.comboBox1.Location = new System.Drawing.Point(12, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::randomkeys.Properties.Resources._4ae21a38_1fa6_4c24_8c0c_6f80df85ff2b_200x200;
            this.pictureBox4.Location = new System.Drawing.Point(322, 202);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(-13, -46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(422, 50);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::randomkeys.Properties.Resources._8f29b862_1993_4ee4_9a5b_e92d9fbb6ff7_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(3, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // randomnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "randomnumber";
            this.Text = "Naphatech - Numeros aleatorios";
            this.TransparencyKey = System.Drawing.Color.OrangeRed;
            this.Load += new System.EventHandler(this.randomnumber_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_megasena;
        private System.Windows.Forms.Button button_lotomania;
        private System.Windows.Forms.Button button_quina;
        private System.Windows.Forms.Button button_duplasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

