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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_megasena = new System.Windows.Forms.Button();
            this.button_lotomania = new System.Windows.Forms.Button();
            this.button_quina = new System.Windows.Forms.Button();
            this.button_duplasena = new System.Windows.Forms.Button();
            this.button_continuar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo(a), ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para continuar, selecione o jogo de sua preferência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário";
            // 
            // button_megasena
            // 
            this.button_megasena.Location = new System.Drawing.Point(23, 61);
            this.button_megasena.Name = "button_megasena";
            this.button_megasena.Size = new System.Drawing.Size(75, 23);
            this.button_megasena.TabIndex = 4;
            this.button_megasena.Text = "Mega Sena";
            this.button_megasena.UseVisualStyleBackColor = true;
            this.button_megasena.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_lotomania
            // 
            this.button_lotomania.Location = new System.Drawing.Point(104, 61);
            this.button_lotomania.Name = "button_lotomania";
            this.button_lotomania.Size = new System.Drawing.Size(75, 23);
            this.button_lotomania.TabIndex = 5;
            this.button_lotomania.Text = "Lotomania";
            this.button_lotomania.UseVisualStyleBackColor = true;
            this.button_lotomania.Click += new System.EventHandler(this.button_lotomania_Click);
            // 
            // button_quina
            // 
            this.button_quina.Location = new System.Drawing.Point(185, 61);
            this.button_quina.Name = "button_quina";
            this.button_quina.Size = new System.Drawing.Size(75, 23);
            this.button_quina.TabIndex = 6;
            this.button_quina.Text = "Quina";
            this.button_quina.UseVisualStyleBackColor = true;
            this.button_quina.Click += new System.EventHandler(this.button_quina_Click);
            // 
            // button_duplasena
            // 
            this.button_duplasena.Location = new System.Drawing.Point(266, 61);
            this.button_duplasena.Name = "button_duplasena";
            this.button_duplasena.Size = new System.Drawing.Size(75, 23);
            this.button_duplasena.TabIndex = 7;
            this.button_duplasena.Text = "Dupla Sena";
            this.button_duplasena.UseVisualStyleBackColor = true;
            this.button_duplasena.Click += new System.EventHandler(this.button_duplasena_Click);
            // 
            // button_continuar1
            // 
            this.button_continuar1.Location = new System.Drawing.Point(23, 90);
            this.button_continuar1.Name = "button_continuar1";
            this.button_continuar1.Size = new System.Drawing.Size(318, 23);
            this.button_continuar1.TabIndex = 4;
            this.button_continuar1.Text = "Continuar";
            this.button_continuar1.UseVisualStyleBackColor = true;
            // 
            // randomnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 133);
            this.Controls.Add(this.button_duplasena);
            this.Controls.Add(this.button_continuar1);
            this.Controls.Add(this.button_quina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_lotomania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_megasena);
            this.Controls.Add(this.label1);
            this.Name = "randomnumber";
            this.Text = "Naphatech - Numeros aleatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_megasena;
        private System.Windows.Forms.Button button_lotomania;
        private System.Windows.Forms.Button button_quina;
        private System.Windows.Forms.Button button_duplasena;
        private System.Windows.Forms.Button button_continuar1;
    }
}

