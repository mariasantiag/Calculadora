namespace Calculadora
{
    partial class frmcalc
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalc));
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMulti = new Button();
            btnDivisao = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnCls = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnIgual = new Button();
            txtVisor = new TextBox();
            pictureBox1 = new PictureBox();
            btn0 = new Button();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            MSsair = new ToolStripMenuItem();
            MSConversao = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.DeepPink;
            btnAdicao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicao.Location = new Point(31, 107);
            btnAdicao.Margin = new Padding(3, 4, 3, 4);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(71, 73);
            btnAdicao.TabIndex = 0;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click_1;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.DeepPink;
            btnSubtracao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(109, 107);
            btnSubtracao.Margin = new Padding(3, 4, 3, 4);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(71, 73);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.DeepPink;
            btnMulti.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(186, 107);
            btnMulti.Margin = new Padding(3, 4, 3, 4);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(71, 73);
            btnMulti.TabIndex = 2;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.DeepPink;
            btnDivisao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivisao.Location = new Point(264, 107);
            btnDivisao.Margin = new Padding(3, 4, 3, 4);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(71, 73);
            btnDivisao.TabIndex = 3;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DeepPink;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(31, 188);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(71, 73);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DeepPink;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(109, 188);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 73);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DeepPink;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(186, 188);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 73);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnCls
            // 
            btnCls.BackColor = Color.DeepPink;
            btnCls.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCls.Location = new Point(264, 188);
            btnCls.Margin = new Padding(3, 4, 3, 4);
            btnCls.Name = "btnCls";
            btnCls.Size = new Size(71, 73);
            btnCls.TabIndex = 7;
            btnCls.Text = "CLS";
            btnCls.UseVisualStyleBackColor = false;
            btnCls.Click += btnCls_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DeepPink;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(31, 269);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 73);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DeepPink;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(109, 269);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 73);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DeepPink;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(186, 269);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 73);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DeepPink;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(31, 351);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 73);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DeepPink;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(109, 351);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 73);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DeepPink;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(186, 351);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 73);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DeepPink;
            btnIgual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(264, 269);
            btnIgual.Margin = new Padding(3, 4, 3, 4);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(71, 236);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisor.Location = new Point(31, 29);
            txtVisor.Margin = new Padding(3, 4, 3, 4);
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(303, 52);
            txtVisor.TabIndex = 16;
            txtVisor.TextChanged += txtVisor_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-38, 497);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DeepPink;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(31, 432);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(226, 73);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(278, 521);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSsair, MSConversao });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(357, 28);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuSdatela";
            // 
            // MSsair
            // 
            MSsair.Name = "MSsair";
            MSsair.Size = new Size(48, 24);
            MSsair.Text = "Sair";
            MSsair.Click += MSsair_Click;
            // 
            // MSConversao
            // 
            MSConversao.Name = "MSConversao";
            MSConversao.Size = new Size(89, 24);
            MSConversao.Text = "Conversor";
            MSConversao.Click += MSConversao_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmcalc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(357, 600);
            Controls.Add(pictureBox2);
            Controls.Add(btn0);
            Controls.Add(pictureBox1);
            Controls.Add(txtVisor);
            Controls.Add(btnIgual);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnCls);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDivisao);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(menuStrip1);
            ForeColor = Color.Transparent;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmcalc";
            Text = "Form2";
            FormClosed += frmcalc_FormClosed;
            Load += frmcalc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMulti;
        private Button btnDivisao;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnCls;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnIgual;
        private TextBox txtVisor;
        private PictureBox pictureBox1;
        private Button btn0;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSsair;
        private ToolStripMenuItem MSConversao;
        private ContextMenuStrip contextMenuStrip1;
    }
}