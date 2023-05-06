namespace WindowsFormsExemplos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelQuantidadeHoras = new Label();
            textBoxQuantidadeHoras = new TextBox();
            labelValorHora = new Label();
            textBoxValorHora = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(47, 23);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(61, 25);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(114, 23);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(444, 31);
            textBoxNome.TabIndex = 1;
            // 
            // labelQuantidadeHoras
            // 
            labelQuantidadeHoras.AutoSize = true;
            labelQuantidadeHoras.Location = new Point(47, 77);
            labelQuantidadeHoras.Name = "labelQuantidadeHoras";
            labelQuantidadeHoras.Size = new Size(182, 25);
            labelQuantidadeHoras.TabIndex = 2;
            labelQuantidadeHoras.Text = "Quantidade de Horas";
            // 
            // textBoxQuantidadeHoras
            // 
            textBoxQuantidadeHoras.Location = new Point(247, 77);
            textBoxQuantidadeHoras.Name = "textBoxQuantidadeHoras";
            textBoxQuantidadeHoras.Size = new Size(311, 31);
            textBoxQuantidadeHoras.TabIndex = 3;
            // 
            // labelValorHora
            // 
            labelValorHora.AutoSize = true;
            labelValorHora.Location = new Point(47, 137);
            labelValorHora.Name = "labelValorHora";
            labelValorHora.Size = new Size(96, 25);
            labelValorHora.TabIndex = 4;
            labelValorHora.Text = "Valor Hora";
            // 
            // textBoxValorHora
            // 
            textBoxValorHora.Location = new Point(149, 137);
            textBoxValorHora.Name = "textBoxValorHora";
            textBoxValorHora.Size = new Size(409, 31);
            textBoxValorHora.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 190);
            button1.Name = "button1";
            button1.Size = new Size(546, 248);
            button1.TabIndex = 6;
            button1.Text = "Calcular Salário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(button1);
            Controls.Add(textBoxValorHora);
            Controls.Add(labelValorHora);
            Controls.Add(textBoxQuantidadeHoras);
            Controls.Add(labelQuantidadeHoras);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelQuantidadeHoras;
        private TextBox textBoxQuantidadeHoras;
        private Label labelValorHora;
        private TextBox textBoxValorHora;
        private Button button1;
    }
}