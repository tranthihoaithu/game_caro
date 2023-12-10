namespace Caro_TranThiHoaiThu
{
    partial class frmSignPlayer
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
            label1 = new Label();
            label3 = new Label();
            txtNamePlayer1 = new TextBox();
            txtNamePlayer2 = new TextBox();
            btnChoi = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(168, 43);
            label1.Name = "label1";
            label1.Size = new Size(389, 34);
            label1.TabIndex = 0;
            label1.Text = "\"NHẬP TÊN NGƯỜI CHƠI\"";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(412, 113);
            label3.Name = "label3";
            label3.Size = new Size(181, 34);
            label3.TabIndex = 2;
            label3.Text = "NGƯỜI CHƠI 2";
            // 
            // txtNamePlayer1
            // 
            txtNamePlayer1.BackColor = Color.IndianRed;
            txtNamePlayer1.Location = new Point(47, 307);
            txtNamePlayer1.Multiline = true;
            txtNamePlayer1.Name = "txtNamePlayer1";
            txtNamePlayer1.Size = new Size(154, 38);
            txtNamePlayer1.TabIndex = 3;
            txtNamePlayer1.Validating += txtNamePlayer1_Validating;
            // 
            // txtNamePlayer2
            // 
            txtNamePlayer2.BackColor = Color.IndianRed;
            txtNamePlayer2.Location = new Point(439, 307);
            txtNamePlayer2.Multiline = true;
            txtNamePlayer2.Name = "txtNamePlayer2";
            txtNamePlayer2.Size = new Size(154, 38);
            txtNamePlayer2.TabIndex = 4;
            txtNamePlayer2.TextChanged += txtNamePlayer2_TextChanged;
            txtNamePlayer2.Validating += txtNamePlayer2_Validating;
            // 
            // btnChoi
            // 
            btnChoi.BackColor = Color.OrangeRed;
            btnChoi.ForeColor = Color.Black;
            btnChoi.Location = new Point(252, 355);
            btnChoi.Name = "btnChoi";
            btnChoi.Size = new Size(143, 37);
            btnChoi.TabIndex = 5;
            btnChoi.Text = "CHƠI";
            btnChoi.UseVisualStyleBackColor = false;
            btnChoi.Click += btnChoi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 113);
            label2.Name = "label2";
            label2.Size = new Size(181, 34);
            label2.TabIndex = 6;
            label2.Text = "NGƯỜI CHƠI 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tải_xuống;
            pictureBox1.Location = new Point(58, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tải_xuống__1_;
            pictureBox2.Location = new Point(439, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 200);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code Light", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(257, 150);
            label5.Name = "label5";
            label5.Size = new Size(141, 106);
            label5.TabIndex = 10;
            label5.Text = "VS";
            // 
            // frmSignPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(710, 460);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnChoi);
            Controls.Add(txtNamePlayer2);
            Controls.Add(txtNamePlayer1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmSignPlayer";
            Text = "frmSignPlayer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btnChoi;
        private Label label2;
        public TextBox txtNamePlayer1;
        public TextBox txtNamePlayer2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}