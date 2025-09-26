using Rock_Paper_Scissor_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor_Project
{

    public partial class Game : Form
    {
        private readonly Random rnd = new Random();
        int random(int from, int to)
        {
            return rnd.Next(from, to + 1);
        }
        private (string name, Image img)[] choices;
        int stopafter = 0;
        int elapsed = 0;
        int playerwin = 0;
        int compwin = 0;
        int draw = 0;
        int round = 1;
        int mxround = 3;
        public Game()
        {
            InitializeComponent();
            choices = new (string, Image)[] { ("Rock", Resources.Rock), ("Paper", Resources.Paper), ("Scissor", Resources.Scissor) };
            spintimer.Interval = 40;
        }
        void computerturn()
        {
            elapsed = 0;
            stopafter = random(15, 30);
            spintimer.Start();
        }

        void updateimage()
        {
            if (rdrock.Checked)
            {
                pictureBox1.Image = Resources.Rock;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = "Rock";
            }
            else if (rdpaper.Checked)
            {
                pictureBox1.Image = Resources.Paper;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Tag = "Paper";

            }
            else if (rdscissor.Checked)
            {
                pictureBox1.Image = Resources.Scissor;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Tag = "Scissor";

            }
            else
            {
                pictureBox1.Image = Resources.question_mark_96;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Tag = "question";

            }
        }
        void endgame()
        {
            if (compwin > playerwin)
            {
                FRlb.Text = "Computer Win";
            }
            else if (compwin < playerwin)
            {
                FRlb.Text = "Player Win";
            }
            else
            {
                FRlb.Text = "Draw";
            }
            MessageBox.Show("Game Over");
            rdrock.Enabled = false;
            rdpaper.Enabled = false;
            rdscissor.Enabled = false;
            button1.Enabled = true;
        }
        void checkwinner()
        {
            string p = (pictureBox1.Tag as string)?.Trim();
            string c = (pictureBox2.Tag as string)?.Trim();

            if (string.IsNullOrEmpty(p) || string.IsNullOrEmpty(c))
            {
                winnerlb.Text = "";
                return;
            }

            if (p==c)
            {
                winnerlb.Text = "Draw";
                draw++;
                drawlb.Text=draw.ToString();
            }
            else if ((p == "Rock" && c == "Scissor") ||
                     (p == "Paper" && c == "Rock") ||
                     (p == "Scissor" && c == "Paper"))
            {
                winnerlb.Text = "Player";
                playerwin++;
                playerwins.Text= playerwin.ToString();
            }
            else
            {
                winnerlb.Text = "Computer";
                compwin++;
                compwins.Text = compwin.ToString();
            }
            round++;
            if (round > mxround)
            {
                endgame();
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void rdrock_CheckedChanged(object sender, EventArgs e)
        {
            Roundlb.Text = round.ToString();

            updateimage();
            computerturn();
        }
        private void rdpaper_CheckedChanged(object sender, EventArgs e)
        {
            Roundlb.Text = round.ToString();
            updateimage();
            computerturn();
        }

        private void rdscissor_CheckedChanged(object sender, EventArgs e)
        {
            Roundlb.Text = round.ToString();

            updateimage();
            computerturn();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rdrock.Tag = "Rock";
            rdpaper.Tag = "Paper";
            rdscissor.Tag = "Scissor";
            radioButton1.Enabled = false;
            radioButton1.Visible = false;
            button1.Enabled = false;
        }

        private void spintimer_Tick(object sender, EventArgs e)
        {
            int r = rnd.Next(choices.Length);
            pictureBox2.Image = choices[r].img;
            pictureBox2.Tag = choices[r].name;
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            elapsed++;
            if(elapsed >= stopafter)
            {
                spintimer.Stop();
                checkwinner();
            }
        }

        private void winnerlb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            winnerlb.Text = "";
            compwins.Text = "";
            playerwins.Text= "";
            drawlb.Text = "";
            pictureBox1.Image = Resources.question_mark_96;
            pictureBox2.Image= Resources.question_mark_96;
            round = 1;
        }
    }
}
