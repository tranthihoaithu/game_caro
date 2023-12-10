using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Caro_TranThiHoaiThu
{
    public partial class frmHistory : Form
    {
        private frmThu frmThu;
        public frmHistory(frmThu frmThu)
        {
            InitializeComponent();
            this.frmThu = frmThu;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\Nam4\\LTWINDOWNS\\Caro_TranThiHoaiThu\\Caro_TranThiHoaiThu\\bin\\Debug\\net6.0-windows\\matrix_results.txt";

            //string filePath = "matrix_results.txt";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    StringBuilder fileContent = new StringBuilder(); // Dùng StringBuilder để xây dựng nội dung tệp

                    while ((line = sr.ReadLine()) != null)
                    {
                        // Thêm nội dung của từng dòng vào StringBuilder
                        fileContent.AppendLine(line);
                    }

                    // Hiển thị nội dung trong TextBox
                    txtContent.Text = fileContent.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            frmThu.Show();
            this.Close();
        }
    }
}
