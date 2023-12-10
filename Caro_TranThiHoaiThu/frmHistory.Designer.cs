namespace Caro_TranThiHoaiThu
{
    partial class frmHistory
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
            txtContent = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.DarkSalmon;
            txtContent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtContent.Location = new Point(54, 74);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(503, 289);
            txtContent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 21);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 1;
            label1.Text = "LỊCH SỬ TRẬN ĐẤU";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(247, 399);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 2;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(622, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtContent);
            Name = "frmHistory";
            Text = "frmHistory";
            Load += frmHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContent;
        private Label label1;
        private Button button1;
    }
}