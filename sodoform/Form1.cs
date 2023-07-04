using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sodoform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }    

        private void sudokuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void solutionTextBox_TextChanged(object sender, EventArgs e)
        {

        }   

        private void SolveSudok_Click(object sender, EventArgs e)
        {
            string sodok = sudokuTextBox.Text;

            // پارس کردن سودوکو و ذخیره در ماتریس
            int[,] sudokuBoard = new int[9, 9];
            //اگه فاصله خالی یا خطوط مشکل داشتن درستشون میکنه 
            string[] rows = sodok.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (rows.Length != 9)
            {
                //اگه تعداد سطر بیشتر یا کمتر 9 تا باشند این پیام چاپ میشه
                MessageBox.Show(" !!!ورودی سودوکو نا معتبر است ");
                return;

            }
            // اعداد را با کاراکتر فاصله هم چک میکنه واگه اعداد مساوی 9 تا نبودند ارور میده
            for (int i = 0; i < 9; i++)
            {
                string[] numbers = rows[i].Split(' ');
                if (numbers.Length != 9)
                {
                    MessageBox.Show(" !!!ورودی سودوکو نا معتبر است ");
                    return;
                }

                for (int j = 0; j < 9; j++)
                {
                    if (!int.TryParse(numbers[j], out int value))
                    {
                        MessageBox.Show(" !!!ورودی سودوکو نا معتبر است ");
                        return;
                    }

                    sudokuBoard[i, j] = value;
                }
            }

            // حل سودوکو
            if (SolveSudoku(sudokuBoard))
            {
                string solution = "";

                // تبدیل ماتریس حل شده به رشته
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        solution += sudokuBoard[i, j] + " ";
                    }

                    solution += Environment.NewLine;
                }

                solutionTextBox.Text = solution;
            }
            else
            {
                MessageBox.Show("!!!هیچ راه حلی برای حل این سودوکو وجود ندارد");
            }
        }

        private bool SolveSudoku(int[,] board)
        {
            int row = 0;
            int col = 0;
            if (!find(board, ref row, ref col))
            {
                return true; // تمامی خانه‌ها پر شده و سودوکو حل شده است
            }

            // امتحان کردن اعداد از ۱ تا ۹ در هر خانه خالی
            for (int num = 1; num <= 9; num++)
            {
                if (isSafe(board, row, col, num))
                {
                    board[row, col] = num;

                    if (SolveSudoku(board))
                    {
                        return true;
                    }

                    board[row, col] = 0; // اگر حل درست نبود، آن را بازگشت داده و خانه را خالی می‌کنیم
                }
            }

            return false; // هیچ عدد مناسبی پیدا نشد
        }

        private bool find(int[,] board, ref int row, ref int col)
        {
            for (row = 0; row < 9; row++)
            {
                for (col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool isSafe(int[,] board, int str, int sot, int num)
        {
            // بررسی آیا عدد در این ردیف تکراری است
            for (int d = 0; d < 9; d++)
            {
                if (board[str, d] == num)
                {
                    return false;
                }
            }
            for (int r = 0; r < 9; r++)
            {
                if (board[r, sot] == num)
                {
                    return false;
                }
            }

            // بررسی آیا عدد در یک بلوک ۳x۳ تکراری است
            int startRow = str - (str % 3);
            int startCol = sot - (sot % 3);
            for (int r = 0; r < 3; r++)
            {
                for (int d = 0; d < 3; d++)
                {
                    if (board[r + startRow, d + startCol] == num)
                    {
                        return false;
                    }
                }
            }

            return true; // عدد مناسبی پیدا شده است
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا می خواهید خارج شوید؟", "اخطار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سودوکو خودرا به فرمت زیر وارد کنید \n0 0 3 0 2 0 6 0 0\n9 0 0 3 0 5 0 0 1\n0 0 1 8 0 6 4 0 0\n0 0 8 1 0 2 9 0 0\n7 0 0 0 0 0 0 0 8\n0 0 6 7 0 8 2 0 0\n0 0 2 6 0 9 5 0 0\n8 0 0 2 0 3 0 0 9\n0 0 5 0 1 0 3 0 0");

        }
        
    }
    
}
