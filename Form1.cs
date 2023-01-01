using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Runtime.InteropServices;
using System.Threading;

namespace WaifuFighterAimbot
{
    public partial class Form1 : Form
    {
        AutoItX3 au3 = new AutoItX3();

        [DllImport("user32.dll")]

        static extern short GetAsyncKeyState(Keys vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();

            Thread CMB = new Thread(COMBO) { IsBackground = true };
            CMB.Start();
        }

        void AIMBOT()
        {
            while (true)
            {
                if (aimbotCheckBox.Checked)
                {
                    //au3.PixelSearch(999, 314, 1001, 316, 0xECB600);

                    object pixUpper = au3.PixelGetColor(1000, 315);
                    object pixLower = au3.PixelGetColor(1000, 800);
                    object pixRight = au3.PixelGetColor(1250, 530);
                    object pixLeft = au3.PixelGetColor(660, 520);

                    if (pixUpper.ToString() == (Convert.ToInt32("0xECB600", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{UP}");

                            Thread.Sleep(5);
                        }
                     
                    }

                    if (pixLower.ToString() == (Convert.ToInt32("0xECB600", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{DOWN}");

                            Thread.Sleep(5);
                        }

                    }

                    if (pixRight.ToString() == (Convert.ToInt32("0xECB600", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{RIGHT}");

                            Thread.Sleep(5);
                        }

                    }

                    if (pixLeft.ToString() == (Convert.ToInt32("0xECB600", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{LEFT}");

                            Thread.Sleep(5);
                        }

                    }

                    if (pixUpper.ToString() == (Convert.ToInt32("0x00DCEC", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{DOWN}");

                            Thread.Sleep(5);
                        }

                    }

                    if (pixLower.ToString() == (Convert.ToInt32("0x00DCEC", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{UP}");

                            Thread.Sleep(5);
                        }

                    }

                    if (pixRight.ToString() == (Convert.ToInt32("0x00DCEC", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{LEFT}");

                            Thread.Sleep(5);
                        }

                    }

                    if (pixLeft.ToString() == (Convert.ToInt32("0x00DCEC", 16)).ToString())
                    {

                        for (int i = 0; i <= 10; i++)
                        {
                            au3.Send("{RIGHT}");

                            Thread.Sleep(5);
                        }

                    }

                }

                Thread.Sleep(1);
            }
        }

        void COMBO()
        {
            while (true)
            {
                if (comboCheckBox.Checked)
                {
                    if (GetAsyncKeyState(Keys.Insert)<0)
                    {
                        try
                        {
                            au3.Send("{UP}");
                            Thread.Sleep(2);
                            au3.Send("{DOWN}");
                            Thread.Sleep(2);
                            au3.Send("{LEFT}");
                            Thread.Sleep(2);
                            au3.Send("{RIGHT}");
                            Thread.Sleep(2);
                        }
                        catch (Exception)
                        {

                            
                        }
                    }

                    Thread.Sleep(1);
                }
            }
        }
    }
}
