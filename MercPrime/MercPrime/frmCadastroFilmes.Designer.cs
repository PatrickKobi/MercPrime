namespace MercPrime
{
    partial class frmCadastroFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFilmes));
            this.label6 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarFilme = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gênero";
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(282, 227);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(248, 31);
            this.txtGenero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descrição";
            // 
            // txtDecricao
            // 
            this.txtDecricao.Enabled = false;
            this.txtDecricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecricao.Location = new System.Drawing.Point(30, 303);
            this.txtDecricao.Multiline = true;
            this.txtDecricao.Name = "txtDecricao";
            this.txtDecricao.Size = new System.Drawing.Size(500, 103);
            this.txtDecricao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do filme";
            // 
            // txtFilme
            // 
            this.txtFilme.Enabled = false;
            this.txtFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilme.Location = new System.Drawing.Point(30, 229);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(237, 29);
            this.txtFilme.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MercPrime.Properties.Resources.MERCFLIXLOGO2;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarFilme
            // 
            this.btnCadastrarFilme.BackgroundImage = global::MercPrime.Properties.Resources.BOTAO_CADASTRAR;
            this.btnCadastrarFilme.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFilme.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFilme.Location = new System.Drawing.Point(278, 445);
            this.btnCadastrarFilme.Name = "btnCadastrarFilme";
            this.btnCadastrarFilme.Size = new System.Drawing.Size(120, 50);
            this.btnCadastrarFilme.TabIndex = 7;
            this.btnCadastrarFilme.UseVisualStyleBackColor = true;
            this.btnCadastrarFilme.Visible = false;
            this.btnCadastrarFilme.Click += new System.EventHandler(this.btnCadastrarFilme_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(127, 445);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 50);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadastroFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 531);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrarFilme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCadastroFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes - MercFlix";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovo;
    }
}