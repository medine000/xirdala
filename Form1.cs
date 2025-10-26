using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pullar = { 500, 200, 100, 50, 20, 10, 5, 1 };


            int mebleg = int.Parse(maskedTextBox1.Text);


            label9.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

            int say = 0;
            for (int i = 0; i < pullar.Length; i++)
            {
                if (mebleg >= pullar[i] && say < 7)
                {
                    int miqdar = mebleg / pullar[i];
                    mebleg = mebleg % pullar[i];
                    say++;

                    if (i == 0) label8.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 1) label7.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 2) label6.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 3) label5.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 4) label4.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 5) label3.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 6) label2.Text = pullar[i] + " manat x " + miqdar;
                    if (i == 7) label1.Text = pullar[i] + " manat x " + miqdar;

                }

            }
        }
    }
}
