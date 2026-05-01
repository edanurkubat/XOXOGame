namespace WinFormsAppXOXOGame
{
    public partial class FormXox : Form
    {
        public FormXox()
        {
            InitializeComponent();
        }

        private void XOXTiklama_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (lblXO.Text == "X")
            {
                bt.Text = "X";
                bt.Enabled = false;
                lblXO.Text = "O";
            }

            else if (lblXO.Text == "O")
            {
                bt.Text = "O";
                bt.Enabled = false;
                lblXO.Text = "X";
            }
            Kontrol();
        }
        private void Kontrol()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();
            }

            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();

            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();

            }


            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("X Oyunu Kazandý");
                YeniOyun();
            }


            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }


            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }


            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("O Oyunu Kazandý");
                YeniOyun();
            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Beraberlik");
                YeniOyun();
            }
            
        }

        private void YeniOyun()
        {
            lblXO.Text = "X";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void FormXox_Load(object sender, EventArgs e)
        {
            YeniOyun();
        }
    }
}
