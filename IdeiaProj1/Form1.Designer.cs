namespace IdeiaProj1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ControlResv";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(519, 134);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(186, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(529, 181);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(156, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.White;
            this.lblsenha.Location = new System.Drawing.Point(444, 177);
            this.lblsenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(81, 24);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "SENHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(444, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMAIL:";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnentrar.Location = new System.Drawing.Point(468, 243);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(63, 26);
            this.btnentrar.TabIndex = 7;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lbltituloform
            // 
            this.lbltituloform.AutoSize = true;
            this.lbltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloform.ForeColor = System.Drawing.Color.White;
            this.lbltituloform.Location = new System.Drawing.Point(442, 67);
            this.lbltituloform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltituloform.Name = "lbltituloform";
            this.lbltituloform.Size = new System.Drawing.Size(204, 31);
            this.lbltituloform.TabIndex = 8;
            this.lbltituloform.Text = "Login Professor";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnCadastro.Location = new System.Drawing.Point(562, 243);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(99, 26);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1090, 447);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lbltituloform);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Professor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button btnCadastro;
    }
}

