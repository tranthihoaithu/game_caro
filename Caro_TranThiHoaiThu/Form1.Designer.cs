namespace Caro_TranThiHoaiThu
{
    partial class frmThu
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
            btnStart = new Button();
            btnClear = new Button();
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            pnlPlayer1 = new Panel();
            btnUndo1 = new Button();
            txtPlayer1 = new TextBox();
            timeplayer1 = new Label();
            txtNumberWin1 = new TextBox();
            pnlPlayer2 = new Panel();
            btnUndo2 = new Button();
            txtNumberWin2 = new TextBox();
            txtPlayer = new TextBox();
            timePlayer2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            flashTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel2.SuspendLayout();
            pnlPlayer1.SuspendLayout();
            pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Snow;
            btnStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Coral;
            btnStart.Location = new Point(17, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(115, 39);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SeaShell;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Tomato;
            btnClear.Location = new Point(17, 39);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 41);
            btnClear.TabIndex = 1;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = Color.LightSalmon;
            pnlChessBoard.BorderStyle = BorderStyle.Fixed3D;
            pnlChessBoard.Location = new Point(184, 27);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(524, 523);
            pnlChessBoard.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(btnClear);
            panel2.Location = new Point(778, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 85);
            panel2.TabIndex = 5;
            // 
            // pnlPlayer1
            // 
            pnlPlayer1.BackColor = Color.SandyBrown;
            pnlPlayer1.BorderStyle = BorderStyle.FixedSingle;
            pnlPlayer1.Controls.Add(btnUndo1);
            pnlPlayer1.Controls.Add(txtPlayer1);
            pnlPlayer1.Controls.Add(timeplayer1);
            pnlPlayer1.Controls.Add(txtNumberWin1);
            pnlPlayer1.Location = new Point(778, 202);
            pnlPlayer1.Name = "pnlPlayer1";
            pnlPlayer1.Size = new Size(152, 178);
            pnlPlayer1.TabIndex = 6;
            // 
            // btnUndo1
            // 
            btnUndo1.BackColor = Color.IndianRed;
            btnUndo1.FlatStyle = FlatStyle.Flat;
            btnUndo1.Location = new Point(8, 93);
            btnUndo1.Name = "btnUndo1";
            btnUndo1.Size = new Size(124, 28);
            btnUndo1.TabIndex = 8;
            btnUndo1.Text = "UNDO";
            btnUndo1.UseVisualStyleBackColor = false;
            btnUndo1.Click += btnUndo1_Click;
            // 
            // txtPlayer1
            // 
            txtPlayer1.BackColor = Color.MediumAquamarine;
            txtPlayer1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtPlayer1.Location = new Point(8, 15);
            txtPlayer1.Multiline = true;
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.Size = new Size(124, 32);
            txtPlayer1.TabIndex = 8;
            txtPlayer1.Text = "PLAYER1";
            txtPlayer1.TextAlign = HorizontalAlignment.Center;
            txtPlayer1.TextChanged += txtPlayer1_TextChanged;
            // 
            // timeplayer1
            // 
            timeplayer1.AutoSize = true;
            timeplayer1.BackColor = Color.IndianRed;
            timeplayer1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            timeplayer1.Location = new Point(8, 50);
            timeplayer1.Name = "timeplayer1";
            timeplayer1.Size = new Size(125, 30);
            timeplayer1.TabIndex = 7;
            timeplayer1.Text = "Time: 00:00";
            // 
            // txtNumberWin1
            // 
            txtNumberWin1.BackColor = Color.IndianRed;
            txtNumberWin1.BorderStyle = BorderStyle.None;
            txtNumberWin1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberWin1.Location = new Point(8, 127);
            txtNumberWin1.Margin = new Padding(5, 3, 3, 3);
            txtNumberWin1.Multiline = true;
            txtNumberWin1.Name = "txtNumberWin1";
            txtNumberWin1.Size = new Size(124, 29);
            txtNumberWin1.TabIndex = 3;
            txtNumberWin1.Text = "Win:0/0";
            txtNumberWin1.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlPlayer2
            // 
            pnlPlayer2.BackColor = Color.SandyBrown;
            pnlPlayer2.BorderStyle = BorderStyle.FixedSingle;
            pnlPlayer2.Controls.Add(btnUndo2);
            pnlPlayer2.Controls.Add(txtNumberWin2);
            pnlPlayer2.Controls.Add(txtPlayer);
            pnlPlayer2.Controls.Add(timePlayer2);
            pnlPlayer2.Location = new Point(3, 202);
            pnlPlayer2.Name = "pnlPlayer2";
            pnlPlayer2.Size = new Size(149, 178);
            pnlPlayer2.TabIndex = 7;
            // 
            // btnUndo2
            // 
            btnUndo2.BackColor = Color.IndianRed;
            btnUndo2.FlatStyle = FlatStyle.Flat;
            btnUndo2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUndo2.Location = new Point(8, 93);
            btnUndo2.Name = "btnUndo2";
            btnUndo2.Size = new Size(132, 28);
            btnUndo2.TabIndex = 9;
            btnUndo2.Text = "UNDO";
            btnUndo2.UseVisualStyleBackColor = false;
            btnUndo2.Click += btnUndo2_Click;
            // 
            // txtNumberWin2
            // 
            txtNumberWin2.BackColor = Color.IndianRed;
            txtNumberWin2.BorderStyle = BorderStyle.None;
            txtNumberWin2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberWin2.Location = new Point(8, 127);
            txtNumberWin2.Multiline = true;
            txtNumberWin2.Name = "txtNumberWin2";
            txtNumberWin2.Size = new Size(132, 33);
            txtNumberWin2.TabIndex = 9;
            txtNumberWin2.Text = " WIN: 0/0";
            txtNumberWin2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlayer
            // 
            txtPlayer.BackColor = Color.MediumAquamarine;
            txtPlayer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtPlayer.Location = new Point(8, 15);
            txtPlayer.Multiline = true;
            txtPlayer.Name = "txtPlayer";
            txtPlayer.Size = new Size(132, 34);
            txtPlayer.TabIndex = 8;
            txtPlayer.Text = "PLAYER2";
            txtPlayer.TextAlign = HorizontalAlignment.Center;
            txtPlayer.TextChanged += txtPlayer_TextChanged;
            // 
            // timePlayer2
            // 
            timePlayer2.AutoSize = true;
            timePlayer2.BackColor = Color.IndianRed;
            timePlayer2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            timePlayer2.Location = new Point(8, 52);
            timePlayer2.Name = "timePlayer2";
            timePlayer2.Size = new Size(128, 31);
            timePlayer2.TabIndex = 8;
            timePlayer2.Text = "Time: 00:00";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kisspng_check_mark_x_mark_computer_icons_clip_art_cross_heart_5b5ea78a695c75_1672286615329299304316;
            pictureBox1.Location = new Point(811, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.O;
            pictureBox2.Location = new Point(26, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(15, 31);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 39);
            btnExit.TabIndex = 10;
            btnExit.Text = "EXIT ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // flashTimer
            // 
            flashTimer.Interval = 1000;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(15, 89);
            button1.Name = "button1";
            button1.Size = new Size(129, 35);
            button1.TabIndex = 11;
            button1.Text = "History";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tong_hop_background_xinh_cute_dep_nhat_045525088;
            ClientSize = new Size(947, 557);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pnlPlayer2);
            Controls.Add(pnlPlayer1);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Name = "frmThu";
            Text = "frmThu";
            panel2.ResumeLayout(false);
            pnlPlayer1.ResumeLayout(false);
            pnlPlayer1.PerformLayout();
            pnlPlayer2.ResumeLayout(false);
            pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnClear;
        private Panel pnlChessBoard;
        private Panel panel2;
        private Panel pnlPlayer1;
        private Panel pnlPlayer2;
        private TextBox txtNumberWin1;
        private Label timeplayer1;
        private Label timePlayer2;
        public TextBox txtPlayer1;
        public TextBox txtPlayer;
        private System.Windows.Forms.Timer timer2;
        private TextBox txtNumberWin2;
        private Button btnUndo1;
        private Button btnUndo2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnExit;
        private System.Windows.Forms.Timer flashTimer;
        private Button button1;
    }
}