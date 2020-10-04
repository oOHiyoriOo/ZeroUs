namespace YourCheese
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShowPlayer = new System.Windows.Forms.CheckBox();
            this.SetImposter = new System.Windows.Forms.CheckBox();
            this.ReviveMe = new System.Windows.Forms.CheckBox();
            this.MaxLight = new System.Windows.Forms.CheckBox();
            this.InstaWin = new System.Windows.Forms.CheckBox();
            this.RainbowSkin = new System.Windows.Forms.CheckBox();
            this.debug = new System.Windows.Forms.Label();
            this.SeeImposter = new System.Windows.Forms.CheckBox();
            this.NKCD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ShowPlayer
            // 
            this.ShowPlayer.AutoSize = true;
            this.ShowPlayer.Location = new System.Drawing.Point(12, 12);
            this.ShowPlayer.Name = "ShowPlayer";
            this.ShowPlayer.Size = new System.Drawing.Size(74, 17);
            this.ShowPlayer.TabIndex = 0;
            this.ShowPlayer.Text = "Player List";
            this.ShowPlayer.UseVisualStyleBackColor = true;
            this.ShowPlayer.CheckedChanged += new System.EventHandler(this.ShowPlayer_CheckedChanged);
            // 
            // SetImposter
            // 
            this.SetImposter.AutoSize = true;
            this.SetImposter.Location = new System.Drawing.Point(12, 35);
            this.SetImposter.Name = "SetImposter";
            this.SetImposter.Size = new System.Drawing.Size(126, 17);
            this.SetImposter.TabIndex = 1;
            this.SetImposter.Text = "Set Yourself Imposter";
            this.SetImposter.UseVisualStyleBackColor = true;
            this.SetImposter.CheckedChanged += new System.EventHandler(this.SetImposter_CheckedChanged);
            // 
            // ReviveMe
            // 
            this.ReviveMe.AutoSize = true;
            this.ReviveMe.Location = new System.Drawing.Point(12, 54);
            this.ReviveMe.Name = "ReviveMe";
            this.ReviveMe.Size = new System.Drawing.Size(77, 17);
            this.ReviveMe.TabIndex = 2;
            this.ReviveMe.Text = "Revive me";
            this.ReviveMe.UseVisualStyleBackColor = true;
            this.ReviveMe.CheckedChanged += new System.EventHandler(this.ReviveMe_CheckedChanged);
            // 
            // MaxLight
            // 
            this.MaxLight.AutoSize = true;
            this.MaxLight.Location = new System.Drawing.Point(12, 146);
            this.MaxLight.Name = "MaxLight";
            this.MaxLight.Size = new System.Drawing.Size(72, 17);
            this.MaxLight.TabIndex = 3;
            this.MaxLight.Text = "Max Light";
            this.MaxLight.UseVisualStyleBackColor = true;
            this.MaxLight.CheckedChanged += new System.EventHandler(this.MaxLight_CheckedChanged);
            // 
            // InstaWin
            // 
            this.InstaWin.AutoSize = true;
            this.InstaWin.Location = new System.Drawing.Point(12, 77);
            this.InstaWin.Name = "InstaWin";
            this.InstaWin.Size = new System.Drawing.Size(68, 17);
            this.InstaWin.TabIndex = 4;
            this.InstaWin.Text = "InstaWin";
            this.InstaWin.UseVisualStyleBackColor = true;
            this.InstaWin.CheckedChanged += new System.EventHandler(this.KillAll_CheckedChanged);
            // 
            // RainbowSkin
            // 
            this.RainbowSkin.AutoSize = true;
            this.RainbowSkin.Location = new System.Drawing.Point(12, 100);
            this.RainbowSkin.Name = "RainbowSkin";
            this.RainbowSkin.Size = new System.Drawing.Size(92, 17);
            this.RainbowSkin.TabIndex = 6;
            this.RainbowSkin.Text = "Rainbow Skin";
            this.RainbowSkin.UseVisualStyleBackColor = true;
            this.RainbowSkin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(13, 438);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(42, 13);
            this.debug.TabIndex = 7;
            this.debug.Text = "Debug:";
            // 
            // SeeImposter
            // 
            this.SeeImposter.AutoSize = true;
            this.SeeImposter.Location = new System.Drawing.Point(12, 123);
            this.SeeImposter.Name = "SeeImposter";
            this.SeeImposter.Size = new System.Drawing.Size(88, 17);
            this.SeeImposter.TabIndex = 8;
            this.SeeImposter.Text = "See Imposter";
            this.SeeImposter.UseVisualStyleBackColor = true;
            this.SeeImposter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // NKCD
            // 
            this.NKCD.AutoSize = true;
            this.NKCD.Location = new System.Drawing.Point(12, 169);
            this.NKCD.Name = "NKCD";
            this.NKCD.Size = new System.Drawing.Size(106, 17);
            this.NKCD.TabIndex = 9;
            this.NKCD.Text = "No Kill Cooldown";
            this.NKCD.UseVisualStyleBackColor = true;
            this.NKCD.CheckedChanged += new System.EventHandler(this.NKCD_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(280, 463);
            this.Controls.Add(this.NKCD);
            this.Controls.Add(this.SeeImposter);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.RainbowSkin);
            this.Controls.Add(this.InstaWin);
            this.Controls.Add(this.MaxLight);
            this.Controls.Add(this.ReviveMe);
            this.Controls.Add(this.SetImposter);
            this.Controls.Add(this.ShowPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "ZeroUs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowPlayer;
        private System.Windows.Forms.CheckBox SetImposter;
        private System.Windows.Forms.CheckBox ReviveMe;
        private System.Windows.Forms.CheckBox MaxLight;
        private System.Windows.Forms.CheckBox InstaWin;
        private System.Windows.Forms.CheckBox RainbowSkin;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.CheckBox SeeImposter;
        private System.Windows.Forms.CheckBox NKCD;
    }
}