namespace YourCheese
{
    partial class HeaderDead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderDead));
            this.HeaderPlayer = new System.Windows.Forms.Label();
            this.PlayerField = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeaderImposter = new System.Windows.Forms.Label();
            this.DeadField = new System.Windows.Forms.Label();
            this.ImposterField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderPlayer
            // 
            this.HeaderPlayer.AutoSize = true;
            this.HeaderPlayer.Location = new System.Drawing.Point(12, 9);
            this.HeaderPlayer.Name = "HeaderPlayer";
            this.HeaderPlayer.Size = new System.Drawing.Size(36, 13);
            this.HeaderPlayer.TabIndex = 0;
            this.HeaderPlayer.Text = "Player";
            // 
            // PlayerField
            // 
            this.PlayerField.AutoSize = true;
            this.PlayerField.Location = new System.Drawing.Point(12, 38);
            this.PlayerField.Name = "PlayerField";
            this.PlayerField.Size = new System.Drawing.Size(16, 13);
            this.PlayerField.TabIndex = 1;
            this.PlayerField.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player";
            // 
            // HeaderImposter
            // 
            this.HeaderImposter.AutoSize = true;
            this.HeaderImposter.Location = new System.Drawing.Point(167, 9);
            this.HeaderImposter.Name = "HeaderImposter";
            this.HeaderImposter.Size = new System.Drawing.Size(47, 13);
            this.HeaderImposter.TabIndex = 3;
            this.HeaderImposter.Text = "Imposter";
            // 
            // DeadField
            // 
            this.DeadField.AutoSize = true;
            this.DeadField.Location = new System.Drawing.Point(325, 38);
            this.DeadField.Name = "DeadField";
            this.DeadField.Size = new System.Drawing.Size(16, 13);
            this.DeadField.TabIndex = 4;
            this.DeadField.Text = "---";
            this.DeadField.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImposterField
            // 
            this.ImposterField.AutoSize = true;
            this.ImposterField.Location = new System.Drawing.Point(167, 38);
            this.ImposterField.Name = "ImposterField";
            this.ImposterField.Size = new System.Drawing.Size(16, 13);
            this.ImposterField.TabIndex = 5;
            this.ImposterField.Text = "---";
            // 
            // HeaderDead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(452, 306);
            this.Controls.Add(this.ImposterField);
            this.Controls.Add(this.DeadField);
            this.Controls.Add(this.HeaderImposter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerField);
            this.Controls.Add(this.HeaderPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeaderDead";
            this.Text = "Dead";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderPlayer;
        private System.Windows.Forms.Label PlayerField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HeaderImposter;
        private System.Windows.Forms.Label DeadField;
        private System.Windows.Forms.Label ImposterField;
    }
}