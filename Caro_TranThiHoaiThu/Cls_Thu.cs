using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Caro_TranThiHoaiThu
{
    internal class Cls_Thu
    {
       
        #region Properties
        private Panel chessBoard;
        public bool gameOn = false;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer flashTime;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        private TextBox playerName1;
        private Panel pnlChessBoard;

        private TextBox txtNumberWin1;
        private TextBox txtNumberWin2;

        private Label timePlayer1;
        private Label timePlayer2;

        private Button btnUndo1;
        private Button btnUndo2;

        private Button btnClear;

        public static bool GameOn { get; internal set; }
        public TextBox PlayerName1 { get => playerName1; set => playerName1 = value; }
        public TextBox PlayerName2 { get => playerName2; set => playerName2 = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
       
        public Label TimePlayer1 { get => timePlayer1; set => timePlayer1 = value; }
        public Label TimePlayer2 { get => timePlayer2; set => timePlayer2 = value; }
        public Button BtnUndo1 { get => btnUndo1; set => btnUndo1 = value; }
        public Button BtnUndo2 { get => btnUndo2; set => btnUndo2 = value; }
        public Button BtnClear { get => btnClear; set => btnClear = value; }

        private TextBox playerName2;

        private List<List<Button>> matrix;
        private int NumberWin1 = 0;
        private int NumberWin2 = 0;

       private List<Button> moveHistoryPlayer1 = new List<Button>();
       private List<Button> moveHistoryPlayer2 = new List<Button>();
        private bool flashingState = false;
        private List<Button> hightLightWin = new List<Button>();

        #endregion

        #region Initialize
        public Cls_Thu(Panel chessBoard, TextBox playerName1, TextBox playerName2,
            Label timePlayer1, Label timePlayer2, System.Windows.Forms.Timer timer2,
            Panel pnlChessBoard, TextBox txtNumberWin1, TextBox txtNumberWin2,
            Button btnUndo1,  Button btnUndo2, System.Windows.Forms.Timer flashTime,Button btnClear)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName1 = playerName1;
            this.PlayerName2 = playerName2;
            this.gameOn = false;
            this.timePlayer1 = timePlayer1;
            this.timePlayer2 = timePlayer2;
            this.timer2 = timer2;
            //this.Player = new List<Player>();

            timer2.Tick += Timer2_Tick;
            timer2.Start();
            this.pnlChessBoard = pnlChessBoard;
            this.txtNumberWin1 = txtNumberWin1;
            this.txtNumberWin2 = txtNumberWin2;
            this.BtnUndo1 = btnUndo1;
            this.BtnUndo2 = btnUndo2;
            this.btnClear = btnClear;
            this.flashTime = flashTime;
            flashTime.Tick += FlashTimer_Tick;
           // flashTime.Start();
            
        }
        #endregion
        #region Methods


        public bool TurnPlay = true;
        

        public void DrawerChessBoard()
        {
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cls_D.Chess_Board_H; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cls_D.Chess_Board_W; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cls_D.Chess_W,
                        Height = Cls_D.Chess_H,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold),
                        Tag = i.ToString(),
                    };
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn); // lưu vào trong mãng
                   
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cls_D.Chess_H);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }

        }
       
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           // flashTime.Stop();
            if (GameOn)
            {
                if (!string.IsNullOrEmpty(btn.Text))
                {
                    return;
                }
                Cls_D.Counter = 30;
                timePlayer1.Text = "Time:" + Cls_D.Counter.ToString();
                timePlayer2.Text = "Time:" + Cls_D.Counter.ToString();

                if (TurnPlay)
                {
                    btn.Text = "X";
                    moveHistoryPlayer1.Add(btn);
                    btnUndo2.Enabled = false;
                    btnUndo1.Enabled = true;

                    if (Cls_D.BackUndo1 == 0)
                    {
                        btnUndo1.Enabled = false;
                    }
                    btn.BackColor = Color.Aqua;
                    btn.ForeColor = Color.White;
                    PlayerName1.BackColor = Color.White;
                    PlayerName2.BackColor = Color.Red;

                }
                else
                {
                    btn.Text = "O";
                    moveHistoryPlayer2.Add(btn);
                    btnUndo1.Enabled = false;
                    btnUndo2.Enabled = true;
                    if (Cls_D.BackUndo2 == 0)
                    {
                        btnUndo2.Enabled = false;
                    }
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    PlayerName1.BackColor = Color.Red;
                    PlayerName2.BackColor = Color.White;
                        
                }
               
                if (isEndGame(btn))
                {
                    timer2.Stop();
                    string winner = TurnPlay ? PlayerName1.Text : PlayerName2.Text;
                    
                    MessageBox.Show(winner + " Thắng!", "Chúc mừng!");
                    flashTime.Start();
                    // EndGame();
                    if (TurnPlay)
                    {
                        NumberWin1++;
                        txtNumberWin1.Text = "WIN:" + NumberWin1 + "/" + NumberWin2;
                        txtNumberWin2.Text = "WIN:" + NumberWin2 + "/" + NumberWin1;

                    }
                    else
                    {
                        NumberWin2++;
                        txtNumberWin1.Text = "WIN:" + NumberWin1 + "/" + NumberWin2;
                        txtNumberWin2.Text = "WIN:" + NumberWin2 + "/" + NumberWin1;
                    }

                    pnlChessBoard.Enabled = false;
                    SaveResultsToFile(); // Chiến thắng lưu kết quả về file
                }
                SumWin(); // Tổng trận đấu 
                TurnPlay = !TurnPlay;
            }
            else
            {
                // Hiển thị thông báo cho người chơi khi gameOn vẫn là false.
                MessageBox.Show("Vui lòng bắt đầu trò chơi bằng cách nhấn nút Start.");
            }
            return;
        }

        public void Timer2_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (Cls_D.Counter > 0)
                {
                    Cls_D.Counter--; // Giảm 1 giây
                    if (TurnPlay)
                    {
                        timePlayer1.Text = "Time:" + Cls_D.Counter.ToString();
                    }
                    else
                    {
                        timePlayer2.Text = "Time:"+ Cls_D.Counter.ToString();
                    }

                }
                else
                {
                    timer2.Stop();
                    pnlChessBoard.Enabled = false;
                    string winner = TurnPlay ?   PlayerName2.Text : PlayerName1.Text;
                    MessageBox.Show(winner + " Thắng!", "Chúc mừng!");
                    if (TurnPlay)
                    {
                        NumberWin2++;
                        txtNumberWin1.Text = "WIN:" + NumberWin1 + "/" + NumberWin2;
                        txtNumberWin2.Text = "WIN:" + NumberWin2 + "/" + NumberWin1;   
                    }
                    else
                    {
                        NumberWin1++;
                        txtNumberWin1.Text = "WIN:" + NumberWin1 + "/" + NumberWin2;
                        txtNumberWin2.Text = "WIN:" + NumberWin2 + "/" + NumberWin1;
                    }
                    SumWin();
                }
            }
            
        }
        public void btnUndo1_Click()
        {
           // MessageBox.Show("s");
            if (moveHistoryPlayer1.Count > 0)
            {
               
                // Lấy bước đi cuối cùng
                Button lastMove = moveHistoryPlayer1[moveHistoryPlayer1.Count - 1];

                // Xóa bước đi cuối cùng
                moveHistoryPlayer1.RemoveAt(moveHistoryPlayer1.Count - 1);

                // Đặt lại nội dung của nút thành ""
                lastMove.Text = "";
                lastMove.BackColor = Color.LightSalmon;

                Cls_D.BackUndo1--;
                btnUndo1.Text = "UNDO" + Cls_D.BackUndo1;
                // Đảm bảo cập nhật lượt chơi (TurnPlay)
                TurnPlay = !TurnPlay;
                btnUndo1.Enabled = false;
            }
            
        }
        public void btnUndo2_Click()
        {
            if (moveHistoryPlayer2.Count > 0)
            {
                // Lấy bước đi cuối cùng
                Button lastMove = moveHistoryPlayer2[moveHistoryPlayer2.Count - 1];

                // Xóa bước đi cuối cùng
                moveHistoryPlayer2.RemoveAt(moveHistoryPlayer2.Count - 1);

                // Đặt lại nội dung của nút thành ""
                lastMove.Text = "";
                lastMove.BackColor = Color.LightSalmon;
                Cls_D.BackUndo2--;
                btnUndo2.Text = "UNDO" + Cls_D.BackUndo2;
                // Đảm bảo cập nhật lượt chơi (TurnPlay)
                TurnPlay = !TurnPlay;
                btnUndo2.Enabled = false;
            }
        }
        public void Return () // Xét lại khi chơi mới
        {
            foreach (var row in Matrix)
            {
                foreach (var button in row)
                {
                    button.Text = ""; // Xoá nội dung của ô Button
                    button.BackColor = Color.LightSalmon;
                }
            }
            PlayerName1.Text = "PLAYER1";
            PlayerName2.Text = "PLAYER2";
            timePlayer1.Text = "TIME: 00:00";
            timePlayer2.Text = "TIME: 00:00";
            btnUndo1.Text = "UNDO" + Cls_D.BackUndo1;
            btnUndo2.Text = "UNDO" + Cls_D.BackUndo1;
            txtNumberWin1.Text = "WIN: 0/0";
            txtNumberWin2.Text = "WIN: 0/0";
            pnlChessBoard.Enabled = true;
            timer2.Start();
        }
        public void ClearBoard()
        {
            
            foreach (var row in Matrix)
            {
                foreach (var button in row)
                {
                    button.Text = ""; // Xoá nội dung của ô Button
                    button.BackColor = Color.LightSalmon;
                }
            }
            Cls_D.Counter = 30;
            timePlayer1.Text ="Time:"+ Cls_D.Counter.ToString();
            timePlayer2.Text ="Time:"+ Cls_D.Counter.ToString();
            pnlChessBoard.Enabled = true;
        }
        public void SumWin() //số lần thắng / tổng số ván
        {
            // khi chơi đủ 5 ván thì hiện thị người thắng 
            string name1 = PlayerName1.Text;
            string name2 = PlayerName2.Text;
            if(NumberWin1 + NumberWin2 == 5)
            {
                btnClear.Enabled = false; // không cho nhấn clear nữa, nhấn start để chơi mới
                if (NumberWin1> NumberWin2)
                {
                    MessageBox.Show("Kết Thúc Trận Đấu","Người Chiến Thắng:"+name1+","+"Với Tỷ Số"+NumberWin1+"/"+NumberWin2);

                }
                else
                {
                    MessageBox.Show("Kết Thúc Trận Đấu", "Người Chiến Thắng:" + name2+"," + "Với Tỷ Số" + NumberWin2 + "/" + NumberWin1);
                }
                pnlChessBoard.Enabled = false;
                NumberWin1 = 0;
                NumberWin2 =0;
            }
        }
        public void EndGame()
        {
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc game!");
           
            ClearBoard();
        }

        private bool isEndGame(Button btn)
        {
            return CheckHorizontal(btn)|| CheckVertical(btn) || CheckDiagonalMain(btn) || CheckDiagonalSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }
        private bool CheckHorizontal(Button btn) // hàng ngang
        {
            hightLightWin.Clear();
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    countLeft++;
                    hightLightWin.Add(Matrix[point.Y][i]);
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Cls_D.Chess_Board_W; i++)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    countRight++;
                    hightLightWin.Add(Matrix[point.Y][i]);
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
    }
        private bool CheckVertical(Button btn) // hàng dọc
        {
            
            hightLightWin.Clear();
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    countTop++;
                    hightLightWin.Add(Matrix[i][point.X]);
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cls_D.Chess_Board_H; i++)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    countBottom++;
                    hightLightWin.Add(Matrix[i][point.X]);
                }
                else
                    break;
            }

            // Kiểm tra chiến thắng
            return (countTop + countBottom == 5);
           
        }
        private bool CheckDiagonalMain(Button btn) // đường chéo chính
        {
            hightLightWin.Clear();
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].Text == btn.Text)
                {
                    countTop++;
                    hightLightWin.Add(Matrix[point.Y - i][point.X - i]);
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cls_D.Chess_Board_W - point.X; i++)
            {
                if (point.Y + i >= Cls_D.Chess_Board_H || point.X + i >= Cls_D.Chess_Board_W)
                    break;

                if (Matrix[point.Y + i][point.X + i].Text == btn.Text)
                {
                    countBottom++;
                    hightLightWin.Add(Matrix[point.Y + i][point.X + i]);
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool CheckDiagonalSub(Button btn)// đường chéo phụ
        {
            hightLightWin.Clear();
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i < 5; i++)// kiểm tra 5 ô liên tiếp đường chéo phụ
            {
                int x = point.X - i; // tính toạ độ X
                int y = point.Y + i; // tính toạ độ y

                if (x >= 0 && y < Cls_D.Chess_Board_H && Matrix[y][x].Text == btn.Text)
                {
                    countTop++;
                    hightLightWin.Add(Matrix[y][x]);

                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = 0; i < 5; i++) // kiểm tra 5 ô liên tiếp đường chéo phụ
            {
                int x = point.X + i;
                int y = point.Y - i;

                if (x < Cls_D.Chess_Board_W && y >= 0 && Matrix[y][x].Text == btn.Text)
                {
                    countBottom++;
                    hightLightWin.Add(Matrix[y][x]);

                }
                else
                {
                    break;
                }
            }
            return (countTop == 5 || countBottom == 5);
        } 
        public void SaveResultsToFile() // Lưu kết quả về file
        {
            int rows = Matrix.Count; // Số hàng (dòng)
            int columns = Matrix[0].Count; // Số cột (chiều ngang) (giả sử tất cả danh sách bên trong có cùng độ dài)
            using (StreamWriter writer = new StreamWriter("matrix_results.txt"))
            {
                writer.WriteLine( "Người Chơi 1:"+PlayerName1.Text + " : " + NumberWin1);
                writer.WriteLine("Người Chơi 2:"+PlayerName2.Text + " : " + NumberWin2);

                foreach (var row in Matrix)
                {
                    string rowString = string.Join("-", row.Select(cell => cell.Text));
                    writer.WriteLine(rowString);
                }
            }
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            // Toggle the flashing state
            flashingState = !flashingState;

            // Show or hide winButtons based on the state
            hightLightWin.ForEach(btn =>
            {
                if (flashingState)
                {
                    btn.BackColor = Color.GreenYellow;
                }
                else
                    btn.BackColor = Color.YellowGreen;
            });
        }

        #endregion


    }
}







