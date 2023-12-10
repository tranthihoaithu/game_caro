using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;

namespace Caro_TranThiHoaiThu
{
    public partial class frmThu : Form
    {
        #region Properties
        Cls_Thu ChessBoard;
        #endregion
        public frmThu()
        {
            InitializeComponent();
            ChessBoard = new Cls_Thu(pnlChessBoard, txtPlayer1, txtPlayer, timeplayer1, timePlayer2,
                timer2, pnlChessBoard, txtNumberWin1, txtNumberWin2, btnUndo1, btnUndo2, flashTimer,btnClear);
            //timeplayer1.Text = Cls_D.Counter.ToString();
            ChessBoard.DrawerChessBoard();
            // timer2.Start();

        }

        public bool gameOn = false;
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (gameOn)
            {
                timer2.Stop();
                MessageBox.Show("Bạn Muốn Chơi Mới?");
                flashTimer.Stop();
                ChessBoard.Return();


            }
            txtPlayer1.BackColor = Color.Red;
            this.Hide();
            frmSignPlayer NhapTen = new frmSignPlayer(this);
            NhapTen.ShowDialog();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //ChessBoard.SaveResultsToFile();
            
            ChessBoard.ClearBoard();
            foreach (Button btn in pnlChessBoard.Controls.OfType<Button>())
            {
                btn.Text = "";
                btn.BackColor = Color.LightSalmon;
            }
            Cls_D.Counter = 30;
            timeplayer1.Text = "Time:" + Cls_D.Counter.ToString();
            timePlayer2.Text = "Time:" + Cls_D.Counter.ToString();
            Cls_D.BackUndo1 = 3;
            btnUndo1.Text = "UNDO:" + Cls_D.BackUndo1;
            Cls_D.BackUndo2 = 3;
            btnUndo2.Text = "UNDO:" + Cls_D.BackUndo2;
            pnlChessBoard.Enabled = true;
            timer2.Start();
            flashTimer.Stop();
        }
        private void txtPlayer1_TextChanged(object sender, EventArgs e)
        {
            txtPlayer1.ReadOnly = true;

            txtPlayer1.KeyDown += (sender, e) =>
            {
                // Kiểm tra nếu người dùng nhấn phím Delete hoặc Backspace
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = true; // Ngăn không cho xóa
                }
            };
        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {
            // Đặt TextBox thành chỉ đọc (không cho phép người dùng nhập dữ liệu)
            txtPlayer.ReadOnly = true;

            txtPlayer.KeyDown += (sender, e) =>
            {
                // Kiểm tra nếu người dùng nhấn phím Delete hoặc Backspace
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = true; // Ngăn không cho xóa
                }
            };
        }

        private void btnUndo1_Click(object sender, EventArgs e)
        {
            ChessBoard.btnUndo1_Click();
        }
        private void btnUndo2_Click(object sender, EventArgs e)
        {
            ChessBoard.btnUndo2_Click();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Muốn Thoát Game?");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHistory history = new frmHistory(this);
            history.ShowDialog();
        }
    }
}