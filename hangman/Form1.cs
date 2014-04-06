using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Label> lb = new List<Label>();
        string wd= "";
        enum bodypart
        {
            l_eyes,
            r_eyes,
            body,
            l_leg,
            r_leg,
        };
        void end()
        {
          /*  drawbody(bodypart.l_eyes);
            drawbody(bodypart.r_eyes);
            drawbody(bodypart.l_leg);
            drawbody(bodypart.r_leg);
            drawbody(bodypart.body);*/
           // MessageBox.Show(randon().ToString());
            
        }
        int counter = 0;

        void drawbody(bodypart bp)
        {
            if (bp == bodypart.l_eyes)
                textBox3.Text = "x";
            else if (bp == bodypart.r_eyes)
                textBox4.Text = "x";
            else if (bp == bodypart.body)
                textBox5.Text = "x";
            else if (bp == bodypart.l_leg)
                textBox6.Text = "x";
            else if (bp == bodypart.r_leg)
                textBox7.Text = "x";
        }

        string randon()
        {
            string ka = "bacak mitt bushs bushj kennedy";
            string[] kap = ka.Split(' ');
            Random se = new Random();
            return kap[se.Next(0, kap.Length - 1)];
        }
        
        void labelmk()
        {
            wd = randon();
            char[] kapi = wd.ToCharArray();
            int bet = 211 / kapi.Length;
            for (int i = 0; i < kapi.Length - 1; i++)
            {

                lb.Add(new Label());
                lb[i].Location = new Point((i * bet) + 10, 88);
                lb[i].Text = " ";
                lb[i].Parent = groupBox1;
                lb[i].BringToFront();
                lb[i].CreateControl();
            }
            label1.Text ="wrd len"+(kapi.Length).ToString();




        }





        private void Form1_Shown(object sender, EventArgs e)
        {
            end();
            labelmk();
        }
        
        private void button1_Click(object sender, EventArgs e)
        { 
            char kapil = textBox1.Text.ToCharArray()[0];
          //  if (kapil.isempty) { MessageBox.Show("enter"); }
            if (wd.Contains(kapil))
            {
                char[] kapi = wd.ToCharArray();
                for (int i = 0; i < kapi.Length-1; i++)
                {
                    if (kapil == kapi[i])
                    {
                        lb[i].Text = kapil.ToString();
                    }
                }
            }
            else
            {
                label2.Text += kapil.ToString() + " ";
                drawbody((bodypart)counter);
                counter++;
                if (counter == 5) { MessageBox.Show("u over motherfucker"); }
            }
            
            
        }





    }
   
    }

