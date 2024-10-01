namespace Calculadora
{
    partial class FRMcm
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
            txtNumero = new TextBox();
            lblPergunta = new Label();
            btnConverter = new Button();
            btnLimpar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.Window;
            txtNumero.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(127, 102);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(183, 30);
            txtNumero.TabIndex = 0;
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPergunta.ForeColor = SystemColors.ButtonHighlight;
            lblPergunta.Location = new Point(133, 75);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(177, 24);
            lblPergunta.TabIndex = 1;
            lblPergunta.Text = "Digite um número";
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(273, 173);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(94, 29);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverte_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(78, 173);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ButtonFace;
            lblResultado.Location = new Point(78, 225);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(88, 19);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // FRMcm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(451, 324);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnConverter);
            Controls.Add(lblPergunta);
            Controls.Add(txtNumero);
            Name = "FRMcm";
            Text = "FRMconversordecm";
            FormClosed += FRMcm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label lblPergunta;
        private Button btnConverter;
        private Button btnLimpar;
        private Label lblResultado;
    }
}