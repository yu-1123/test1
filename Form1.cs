using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
             public Form1()
        {
            InitializeComponent();
        }

        class person
        {
            int location_x, location_y;  //位置
            int infect_status;  //0 未感染， 1 感染
            int seperate_days;  //隔离天数
            int infect_days;    //感染天数
            int live;   //1表示活着，0表示死掉
            int color;  //0表示黑色（死亡）,1 绿色健康，2 黄色感染未发病，3 红色感染发病
            Random rnd = new Random();

            public
            person()
            {
                //随机找位置；

                infect_status = 0;
                seperate_days = 0;
                infect_days = 0;
                live = 1;
                color = 1;

            }

            // void move(int x, int y);

            void infectdayadd()
            {
                infect_days = infect_days + 1;
                if (infect_days > PublicValue.infectdays)
                {
                    infect_status = 0;
                    seperate_days = 0;
                }
                else if (infect_days <= PublicValue.infectdays)
                {
                    //取随机数
                    int x = rnd.Next(1, 100);
                    if (x <= 3)
                    {
                        live = 0;
                        location_x = 0;
                        location_y = 0;
                        color = 0;
                    }
                }
            }
            // void seperatedayadd();

        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonqueding_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public class PublicValue
        {
            public static int R0 = 2;
            public static int sepdays = 14;
            public static int infectdays = 14;
            public static double PD = 0.03;
            public static int length = 1000;
            public static int width = 1000;
            public static int AimPointx;
            public static int AimPointy;
            public static int Currentx;
            public static int Currenty;
            public int[] array = new int[length];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

    private void Form1_Load(object sender, EventArgs e)
        {

        }
}

