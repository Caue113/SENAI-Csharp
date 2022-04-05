using System;
namespace MeuForms1
{
    public partial class Form1 : Form
    {

        public int Points = 0;
        double pastTime = DateTime.Now.Second;
        //int pastTimeMs = DateTime.Now.Millisecond;
        //int pastTimeS = DateTime.Now.Second;
        double nowTimeMs, nowTimeS, nowTime;
        double deltaTime;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            button1.Location = new Point(rng.Next(0, 600), rng.Next(40, 350));

            AddPoints();
            UpdateScoreText();
            UpdateReflexText();
            textBox3.Text = "past: " + pastTime + " now: " + nowTime;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddPoints() { Points++; }
        public void UpdateScoreText() { textBox1.Text = "Pontos: " + Points; }
        public void UpdateReflexText() {

            //nowTimeMs = DateTime.Now.Millisecond;
            //nowTimeS = DateTime.Now.Second;
            nowTime = DateTime.Now.Second;

            deltaTime = nowTime - pastTime;

            //pastTimeMs = nowTimeMs;s
            //pastTimeS = nowTimeS;
            pastTime = nowTime;

            textBox2.Text = "Delay: " + deltaTime.ToString() + "ms";

        }


    }

    
}