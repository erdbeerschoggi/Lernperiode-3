namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int spieler = 2;
        public int zug = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        bool isDraw()
        {
            if ((zug == 9) && (isWinner() == false))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool isWinner()
        {
            //horizontal
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "")
                return true;
            if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && b4.Text != "")
                return true;
            if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && b7.Text != "")
                return true;
            //vertikal
            if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && b1.Text != "")
                return true;
            if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && b2.Text != "")
                return true;
            if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && b3.Text != "")
                return true;
            //vertikal
            if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && b1.Text != "")
                return true;
            if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && b3.Text != "")
                return true;
            else
                return false;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl4.Text = "X:" + s1;
            lbl2.Text = "O:" + s1;
            lbl3.Text = "Gleichstand:" + s1;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (spieler % 2 == 0)
                {
                    button.Text = "X";
                    spieler++;
                    zug++;
                }
                else
                {
                    button.Text = "O";
                    spieler++;
                    zug++;
                }

                if (isDraw() == true)
                {
                    MessageBox.Show("Unentschieden");
                    sd++;
                    NeuesSpiel();
                }
                if (isWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X hat Gewonnen");
                        s1++;
                        NeuesSpiel();
                    }
                    else
                    {
                        MessageBox.Show("O hat Gewonnen");
                        s2++;
                        NeuesSpiel();
                    }
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        public void NeuesSpiel()
        {
            spieler = 2;
            zug = 0;
            b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";

            lbl4.Text = "X:" + s1;
            lbl2.Text = "O:" + s2;
            lbl3.Text = "Gleichstand:" + sd;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NeuesSpiel();
        }
    }
}
