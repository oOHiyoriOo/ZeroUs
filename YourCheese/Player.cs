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
    public partial class HeaderDead : Form
    {
        public HeaderDead()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            // newTask
            CancellationTokenSource cts = new CancellationTokenSource();
            Task.Factory.StartNew(
                UpdatePlayerStats
            ,cts.Token);
        }

        static void UpdatePlayerStats() {
            while(Globals.PlayerForm.Visible) {
                    Globals.PlayerForm.Invoke((MethodInvoker)delegate {
                    Globals.PlayerForm.PlayerField.Text = Globals.Player;
                    Globals.PlayerForm.ImposterField.Text = Globals.Imposter;
                    Globals.PlayerForm.DeadField.Text = Globals.Dead;
                });
                System.Threading.Thread.Sleep(100);
            }
        }
        // Disable the Button  !
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void label1_Click( object sender,EventArgs e ) {

        }
    }
}
