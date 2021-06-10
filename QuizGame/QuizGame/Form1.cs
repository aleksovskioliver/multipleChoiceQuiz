using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            init();
            totalQuestions = 12;
        }
        private void init()
        {
            askQuestion(questionNumber);
            pbTimer.Maximum = 30;
            pbTimer.Value = 30;
        }
        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                questionNumber++;
                this.init();

            }

        }
        private void askQuestion(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.ronaldo;

                    btn1.Text = "Lionel Messi";
                    btn2.Text = "Cristiano Ronaldo";
                    btn3.Text = "Diego Costa";
                    btn4.Text = "Luis Suarez";

                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.grizi;

                    btn1.Text = "Antoine Griezmann";
                    btn2.Text = "Ousmane Dembele";
                    btn3.Text = "Jordi Alba";
                    btn4.Text = "Xabi Alonso";

                    correctAnswer = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.kane;

                    btn1.Text = "Edison Cavani";
                    btn2.Text = "Sergio Ramos";
                    btn3.Text = "Harry Kane";
                    btn4.Text = "Neymar JR.";

                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.isco;

                    btn1.Text = "Dani Carvajal";
                    btn2.Text = "Gerrard Pique";
                    btn3.Text = "Dani Alves";
                    btn4.Text = "Isco Alarcon";

                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.lorenzo;

                    btn1.Text = "Xavi Hernandez";
                    btn2.Text = "Andres Iniesta";
                    btn3.Text = "Ricardo Kaka";
                    btn4.Text = "Lorenzo Insigne";

                    correctAnswer = 4;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.umtiti;

                    btn1.Text = "Samuel Umtiti";
                    btn2.Text = "Didier Drogba";
                    btn3.Text = "Samuel Eto'o";
                    btn4.Text = "Yaya Toure";

                    correctAnswer = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.renato;

                    btn1.Text = "Karim Benzema";
                    btn2.Text = "Jason Denayer";
                    btn3.Text = "Renato Sanches";
                    btn4.Text = "Romelu Lukaku";

                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.bardhi;

                    btn1.Text = "Goran Pandev";
                    btn2.Text = "Enis Bardhi";
                    btn3.Text = "Elif Elmas";
                    btn4.Text = "Boban Nikolov";

                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.arnautovic;

                    btn1.Text = "David Alaba";
                    btn2.Text = "Pedro Rodriguez";
                    btn3.Text = "Marko Arnautovic";
                    btn4.Text = "Marcos Llorente";

                    correctAnswer = 3;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.youri;

                    btn1.Text = "Youri Tielemans";
                    btn2.Text = "Kylian Mbappe";
                    btn3.Text = "James Rodriguez";
                    btn4.Text = "Mario Balotelli";

                    correctAnswer = 1;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.goretzka;

                    btn1.Text = "Joshua Kimmich";
                    btn2.Text = "Mats Humels";
                    btn3.Text = "Mario Gotze";
                    btn4.Text = "Leon Goretzka";

                    correctAnswer = 4;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.krkic;

                    btn1.Text = "Cristan Tello";
                    btn2.Text = "Isac Cuenca";
                    btn3.Text = "Bojan Krkic";
                    btn4.Text = "Carles Puyol";

                    correctAnswer = 3;
                    break;
            }
        }
        private void showMessageBoxForEnd(string description)
        {
            DialogResult dr = MessageBox.Show(description, "GameOver", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.init();
            }
            else
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
