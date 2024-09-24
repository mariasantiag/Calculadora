namespace Calculadora
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pgbcarregar = new ProgressBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tmrcarregar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pgbcarregar
            // 
            pgbcarregar.Location = new Point(468, 368);
            pgbcarregar.MarqueeAnimationSpeed = 1000;
            pgbcarregar.Name = "pgbcarregar";
            pgbcarregar.Size = new Size(252, 35);
            pgbcarregar.TabIndex = 0;
            pgbcarregar.Click += pgbcarregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(480, 62);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 1;
            label1.Text = "CALCULADORA ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BAL5;
            pictureBox1.Location = new Point(21, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(468, 350);
            label2.Name = "label2";
            label2.Size = new Size(85, 16);
            label2.TabIndex = 3;
            label2.Text = "QUASE LÁ...";
            // 
            // tmrcarregar
            // 
            tmrcarregar.Enabled = true;
            tmrcarregar.Tick += tmrcarregar_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pgbcarregar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgbcarregar;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private System.Windows.Forms.Timer tmrcarregar;
    }
}
