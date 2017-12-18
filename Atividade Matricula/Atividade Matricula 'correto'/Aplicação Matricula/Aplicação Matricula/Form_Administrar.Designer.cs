namespace Aplicação_Matricula
{
    partial class Form_Administrar
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
            this.txt_nomeProf = new System.Windows.Forms.TextBox();
            this.txt_MateriaProf = new System.Windows.Forms.TextBox();
            this.box_CursoProf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_horarioProf = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nomeProf
            // 
            this.txt_nomeProf.Location = new System.Drawing.Point(71, 64);
            this.txt_nomeProf.Name = "txt_nomeProf";
            this.txt_nomeProf.Size = new System.Drawing.Size(198, 20);
            this.txt_nomeProf.TabIndex = 0;
            // 
            // txt_MateriaProf
            // 
            this.txt_MateriaProf.Location = new System.Drawing.Point(71, 110);
            this.txt_MateriaProf.Name = "txt_MateriaProf";
            this.txt_MateriaProf.Size = new System.Drawing.Size(198, 20);
            this.txt_MateriaProf.TabIndex = 1;
            // 
            // box_CursoProf
            // 
            this.box_CursoProf.FormattingEnabled = true;
            this.box_CursoProf.Items.AddRange(new object[] {
            "Sistemas de Informação",
            "Direito",
            "Engenharia Civil",
            "Medicina",
            "Ciencia da Computação",
            "Ciencias Contabeis",
            "Administração"});
            this.box_CursoProf.Location = new System.Drawing.Point(71, 147);
            this.box_CursoProf.Name = "box_CursoProf";
            this.box_CursoProf.Size = new System.Drawing.Size(198, 21);
            this.box_CursoProf.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CADASTRO DE PROFESSOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Curso:";
            // 
            // box_horarioProf
            // 
            this.box_horarioProf.FormattingEnabled = true;
            this.box_horarioProf.Items.AddRange(new object[] {
            "Segunda e Quarta - 19h as 20:40",
            "Segunda e Quarta - 20:40 as 22:30",
            "Terça e Sexta - 19h as 20:40 ",
            "Terça - 20:40 as 22:30",
            "Quinta e Sabado 20:40 as 22:30 / 11:20 as 13h",
            "Quinta e Sexta 19h as 20:40 / 20:40 as 22:30"});
            this.box_horarioProf.Location = new System.Drawing.Point(71, 189);
            this.box_horarioProf.Name = "box_horarioProf";
            this.box_horarioProf.Size = new System.Drawing.Size(198, 21);
            this.box_horarioProf.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(197, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Administrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicação_Matricula.Properties.Resources.graduado_ou_professor_em_um_chapéu_do_barrete_40200179;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_horarioProf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_CursoProf);
            this.Controls.Add(this.txt_MateriaProf);
            this.Controls.Add(this.txt_nomeProf);
            this.MaximizeBox = false;
            this.Name = "Form_Administrar";
            this.Text = "Universidade de Atlanta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeProf;
        private System.Windows.Forms.TextBox txt_MateriaProf;
        private System.Windows.Forms.ComboBox box_CursoProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox box_horarioProf;
        private System.Windows.Forms.Button button1;
    }
}