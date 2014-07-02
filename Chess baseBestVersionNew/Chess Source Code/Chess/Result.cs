using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chess
{
    public partial class Result : Form
    {
       
        private GameUI gameUI;

        public Result()
        {
            InitializeComponent();
        }

      

        public Result(GameUI gameUI)
        {
            // TODO: Complete member initialization
            this.gameUI = gameUI;
            InitializeComponent();
        }



        public List<double> AnalizeStack()
        {
            double[] StackResult ;
            if (this.gameUI.WhoWins)
            {
                 StackResult = this.gameUI.result.ToArray();
                Array.Reverse(StackResult);

            }
            else
            {
                 StackResult = this.gameUI.resultBlack.ToArray();
                Array.Reverse(StackResult);
            }

            
            List<double> resultU = new List<double>();

            if (StackResult.Length % 2.0 == 1.0)  //Spitakneri haxtanak
            {
              //  resultU.Add(StackResult[0]);
                for (int i = 0; i < StackResult.Length; i +=2)
                {

                    resultU.Add(StackResult[i]);
                }
            }

            else    //severi haxtanak
            {
                
                
                for (int i = 1; i < StackResult.Length; i += 2)
                {

                    resultU.Add(StackResult[i]);
                }

            }




            return resultU;
            
        }

        public double sumU()
        {
            double u=0;

            List<double> ListU = AnalizeStack();
            for (int i = 0; i < ListU.Count-1; i++)
            {
                u += (ListU[i + 1] - ListU[i]) / 9;
            }
            
                return Math.Round(u,3);
            
        }

        private void Result_Load(object sender, EventArgs e)
        {

           
                this.label1.Text = sumU().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double u = Convert.ToDouble(this.label1.Text);
            double a;
            if (sumU() > 0)
            {
                 a = 2;
            }
            else
            {
                a = -2;
            }
            double b = 10;
            double c = 1.7;

            double K = K = 1 / (1 + (Math.Pow(((u - a) / c), b)));
            K = K * 100;
            if (Convert.ToDouble(this.label1.Text)>0)
            {
                label6.Text ="Այս մատը [0...100] միջակայքում "+ Math.Round(K).ToString()+" գործակցով սովորական մատ է:";
            }
            else
            {
                label6.Text = "Այս մատը [0...100] միջակայքում " + Math.Round(K).ToString() + " գործակցով գեղեցիկ մատ է:";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChessMain newgame = new ChessMain();
            newgame.Show();
            this.Hide();
        }

      
      

       
    }
}
