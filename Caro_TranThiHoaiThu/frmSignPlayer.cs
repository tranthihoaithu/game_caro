using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caro_TranThiHoaiThu
{
    public partial class frmSignPlayer : Form
    {
        private frmThu frmThu;
        //private Panel panelChessBoard;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public frmSignPlayer(frmThu frmThu)
        {
            InitializeComponent();
            this.frmThu = frmThu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtNamePlayer2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnChoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThu.txtPlayer1.Text = txtNamePlayer1.Text;
            frmThu.txtPlayer.Text = txtNamePlayer2.Text;

            frmThu.gameOn = true;
            Cls_Thu.GameOn = true;
            frmThu.Show();
            this.Close();
        }

        private void txtNamePlayer1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamePlayer1.Text))
            {
                e.Cancel = true; // Hủy sự kiện Validating nếu TextBox rỗng hoặc chỉ chứa khoảng trắng
                MessageBox.Show(txtNamePlayer1, "!Vui lòng nhập tên người chơi."); // Hiển thị thông báo lỗi
            }

        }

        private void txtNamePlayer2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamePlayer2.Text))
            {
                e.Cancel = true; // Hủy sự kiện Validating nếu TextBox rỗng hoặc chỉ chứa khoảng trắng
                MessageBox.Show(txtNamePlayer2, "!Vui lòng nhập tên người chơi."); // Hiển thị thông báo lỗi
            }
        }

        
    }
}
