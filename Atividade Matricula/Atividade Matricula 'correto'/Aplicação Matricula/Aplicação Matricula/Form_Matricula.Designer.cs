namespace Aplicação_Matricula
{
    partial class Form_Matricula
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
            this.txt_nomeMatricula = new System.Windows.Forms.TextBox();
            this.txt_CPFMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_CursoMatricula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_confirmaMatri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nomeMatricula
            // 
            this.txt_nomeMatricula.Location = new System.Drawing.Point(74, 68);
            this.txt_nomeMatricula.Name = "txt_nomeMatricula";
            this.txt_nomeMatricula.Size = new System.Drawing.Size(198, 20);
            this.txt_nomeMatricula.TabIndex = 0;
            // 
            // txt_CPFMatricula
            // 
            this.txt_CPFMatricula.Location = new System.Drawing.Point(74, 106);
            this.txt_CPFMatricula.Name = "txt_CPFMatricula";
            this.txt_CPFMatricula.Size = new System.Drawing.Size(198, 20);
            this.txt_CPFMatricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Curso:";
            // 
            // box_CursoMatricula
            // 
            this.box_CursoMatricula.FormattingEnabled = true;
            this.box_CursoMatricula.Items.AddRange(new object[] {
            "Sistemas de Informação",
            "Direito",
            "Engenharia Civil",
            "Medicina",
            "Ciencia da Computação",
            "Ciencias Contabeis",
            "Administração"});
            this.box_CursoMatricula.Location = new System.Drawing.Point(74, 147);
            this.box_CursoMatricula.Name = "box_CursoMatricula";
            this.box_CursoMatricula.Size = new System.Drawing.Size(198, 21);
            this.box_CursoMatricula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MATRICULA";
            // 
            // b_confirmaMatri
            // 
            this.b_confirmaMatri.Location = new System.Drawing.Point(197, 218);
            this.b_confirmaMatri.Name = "b_confirmaMatri";
            this.b_confirmaMatri.Size = new System.Drawing.Size(75, 23);
            this.b_confirmaMatri.TabIndex = 8;
            this.b_confirmaMatri.Text = "Confirma";
            this.b_confirmaMatri.UseVisualStyleBackColor = true;
            this.b_confirmaMatri.Click += new System.EventHandler(this.b_confirmaMatri_Click);
            // 
            // Form_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicação_Matricula.Properties.Resources.graduado_ou_professor_em_um_chapéu_do_barrete_40200179;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 282);
            this.Controls.Add(this.b_confirmaMatri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_CursoMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CPFMatricula);
            this.Controls.Add(this.txt_nomeMatricula);
            this.MaximizeBox = false;
            this.Name = "Form_Matricula";
            this.Text = "Universidade de Atlanta";
            this.Load += new System.EventHandler(this.Form_Matricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeMatricula;
        private System.Windows.Forms.TextBox txt_CPFMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_CursoMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_confirmaMatri;
    }
}