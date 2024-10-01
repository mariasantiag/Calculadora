namespace Calculadora
{
    partial class frmConverte
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
            txtNumeroDigitado = new TextBox();
            lblNumero = new Label();
            btnLimpar = new Button();
            btnConverter = new Button();
            lblResul = new Label();
            SuspendLayout();
            // 
            // txtNumeroDigitado
            // 
            txtNumeroDigitado.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroDigitado.Location = new Point(136, 119);
            txtNumeroDigitado.Name = "txtNumeroDigitado";
            txtNumeroDigitado.Size = new Size(186, 34);
            txtNumeroDigitado.TabIndex = 0;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Pink;
            lblNumero.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = Color.WhiteSmoke;
            lblNumero.Location = new Point(67, 74);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(330, 24);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Digite o número para a conversão";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnLimpar.Location = new Point(58, 180);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnConverter.Location = new Point(313, 180);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(94, 29);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResul.ForeColor = Color.WhiteSmoke;
            lblResul.Location = new Point(58, 223);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(149, 24);
            lblResul.TabIndex = 4;
            lblResul.Text = "Resultado Aqui";
            // 
            // frmConverte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(448, 352);
            Controls.Add(lblResul);
            Controls.Add(btnConverter);
            Controls.Add(btnLimpar);
            Controls.Add(lblNumero);
            Controls.Add(txtNumeroDigitado);
            Name = "frmConverte";
            Text = "Form3";
            FormClosed += frmConverter_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroDigitado;
        private Label lblNumero;
        private Button btnLimpar;
        private Button btnConverter;
        private Label lblResul;
    }
}