using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourCheese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){

        }



        // close the process not only the gui
        protected override void OnFormClosing( FormClosingEventArgs e ) {
            base.OnFormClosing(e);
            if(e.CloseReason == CloseReason.WindowsShutDown)
                return;
            if(e.CloseReason == CloseReason.UserClosing) {
                System.Environment.Exit(0);
            }
        }

        private void ShowPlayer_CheckedChanged( object sender,EventArgs e ) {
            if(ShowPlayer.Checked) {
                new Thread(() => Globals.PlayerForm.ShowDialog()).Start();
            } else {
                Globals.PlayerForm.Invoke((MethodInvoker)delegate {
                    Globals.PlayerForm.Hide();
                });
            }
        }
        private void SetImposter_CheckedChanged( object sender,EventArgs e ) {
            if(SetImposter.Checked) {
                Globals.WriteImposter = "1";
            } else {
                Globals.WriteImposter = "-1";
            }
        }

        private void ReviveMe_CheckedChanged( object sender,EventArgs e ) {
            if(ReviveMe.Checked) {
                Globals.ReviveMe = "1";
            } else {
                Globals.ReviveMe = "-1";
            }
        }

        private void MaxLight_CheckedChanged( object sender,EventArgs e ) {
            if(ReviveMe.Checked) {
                Globals.LightValue = "1";
            } else {
                Globals.LightValue = "-1";
            }
        }

        private void KillAll_CheckedChanged( object sender,EventArgs e ) {
            if(InstaWin.Checked) {
                Globals.InstaWin = "1";
            } else {
                Globals.InstaWin = "0";
            }
        }
        private void checkBox1_CheckedChanged( object sender,EventArgs e ) {
            if(InstaWin.Checked) {
                Globals.RainbowSkin = "1";
            } else {
                Globals.RainbowSkin = "0";
            }
        }

        private void checkBox1_CheckedChanged_1( object sender,EventArgs e ) {
            if(InstaWin.Checked) {
                Globals.RainbowSkin = "1";
            } else {
                Globals.RainbowSkin = "0";
            }
        }

        private void NKCD_CheckedChanged( object sender,EventArgs e ) {
            if(InstaWin.Checked) {
                Globals.NKCD = "1";
            } else {
                Globals.NKCD = "0";
            }
        }
    }
}
