namespace IdeiaProj1
{
    partial class tela3cs
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txthora1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txthora2 = new System.Windows.Forms.MaskedTextBox();
            this.txtcurso = new System.Windows.Forms.ComboBox();
            this.txtlocal = new System.Windows.Forms.ComboBox();
            this.txtano = new System.Windows.Forms.ComboBox();
            this.txtprof = new System.Windows.Forms.TextBox();
            this.btnreserva = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtreserva = new System.Windows.Forms.ComboBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOCAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORARIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "CURSO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "ANO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "PROFESSOR RESP.:";
            // 
            // txthora1
            // 
            this.txthora1.Location = new System.Drawing.Point(732, 148);
            this.txthora1.Margin = new System.Windows.Forms.Padding(2);
            this.txthora1.Mask = "00:00";
            this.txthora1.Name = "txthora1";
            this.txthora1.Size = new System.Drawing.Size(38, 20);
            this.txthora1.TabIndex = 9;
            this.txthora1.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(690, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Das";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(774, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "as";
            // 
            // txthora2
            // 
            this.txthora2.Location = new System.Drawing.Point(804, 148);
            this.txthora2.Margin = new System.Windows.Forms.Padding(2);
            this.txthora2.Mask = "00:00";
            this.txthora2.Name = "txthora2";
            this.txthora2.Size = new System.Drawing.Size(38, 20);
            this.txthora2.TabIndex = 12;
            this.txthora2.ValidatingType = typeof(System.DateTime);
            // 
            // txtcurso
            // 
            this.txtcurso.FormattingEnabled = true;
            this.txtcurso.Items.AddRange(new object[] {
            "Meio Ambiente",
            "Desenvolvimento de Sistemas ",
            "Administração",
            "Design de Interiores",
            "Hospedagem",
            "Secretariado"});
            this.txtcurso.Location = new System.Drawing.Point(663, 192);
            this.txtcurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(155, 21);
            this.txtcurso.TabIndex = 13;
            // 
            // txtlocal
            // 
            this.txtlocal.FormattingEnabled = true;
            this.txtlocal.Items.AddRange(new object[] {
            "Laboratório 1 (Aquário)",
            "Laboratório 2",
            "Laboratório 3 ",
            "Laboratório de Quimica ",
            "Sala Maker",
            "Sibéria "});
            this.txtlocal.Location = new System.Drawing.Point(663, 65);
            this.txtlocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(179, 21);
            this.txtlocal.TabIndex = 14;
            // 
            // txtano
            // 
            this.txtano.FormattingEnabled = true;
            this.txtano.Items.AddRange(new object[] {
            "1° PRIMEIRO ",
            "2° SEGUNDO",
            "3° TERCEIRO"});
            this.txtano.Location = new System.Drawing.Point(645, 236);
            this.txtano.Margin = new System.Windows.Forms.Padding(2);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(82, 21);
            this.txtano.TabIndex = 15;
            // 
            // txtprof
            // 
            this.txtprof.Location = new System.Drawing.Point(780, 282);
            this.txtprof.Margin = new System.Windows.Forms.Padding(2);
            this.txtprof.Name = "txtprof";
            this.txtprof.Size = new System.Drawing.Size(192, 20);
            this.txtprof.TabIndex = 16;
            // 
            // btnreserva
            // 
            this.btnreserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreserva.Location = new System.Drawing.Point(555, 456);
            this.btnreserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnreserva.Name = "btnreserva";
            this.btnreserva.Size = new System.Drawing.Size(141, 32);
            this.btnreserva.TabIndex = 17;
            this.btnreserva.Text = "Fazer Reserva";
            this.btnreserva.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "DATA:";
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(663, 105);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 20);
            this.txtdata.TabIndex = 19;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(584, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "RESERVA FIXA:";
            // 
            // txtreserva
            // 
            this.txtreserva.FormattingEnabled = true;
            this.txtreserva.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.txtreserva.Location = new System.Drawing.Point(742, 330);
            this.txtreserva.Name = "txtreserva";
            this.txtreserva.Size = new System.Drawing.Size(121, 21);
            this.txtreserva.TabIndex = 21;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(725, 456);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(93, 32);
            this.btnvoltar.TabIndex = 22;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(845, 457);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(84, 31);
            this.btnlimpar.TabIndex = 23;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // tela3cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 783);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtreserva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnreserva);
            this.Controls.Add(this.txtprof);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.txthora2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthora1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tela3cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESERVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txthora1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txthora2;
        private System.Windows.Forms.ComboBox txtcurso;
        private System.Windows.Forms.ComboBox txtlocal;
        private System.Windows.Forms.ComboBox txtano;
        private System.Windows.Forms.TextBox txtprof;
        private System.Windows.Forms.Button btnreserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtreserva;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}