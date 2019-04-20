namespace Domowe2
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.ShootButtonPlayer1 = new System.Windows.Forms.Button();
            this.ShootPointerPlayer1 = new System.Windows.Forms.Label();
            this.FirstPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.StartTimerPlayer1button = new System.Windows.Forms.Button();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShieldPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShield = new System.Windows.Forms.PictureBox();
            this.ShootPointerPlayer2 = new System.Windows.Forms.Label();
            this.SecondPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.ShootbuttonPlayer2 = new System.Windows.Forms.Button();
            this.StartTimerPlayer2button = new System.Windows.Forms.Button();
            this.labelResultPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2Result = new System.Windows.Forms.Label();
            this.textBoxPlayer1Result = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Result = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShieldPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShield)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootButtonPlayer1
            // 
            this.ShootButtonPlayer1.Location = new System.Drawing.Point(620, 249);
            this.ShootButtonPlayer1.Name = "ShootButtonPlayer1";
            this.ShootButtonPlayer1.Size = new System.Drawing.Size(75, 23);
            this.ShootButtonPlayer1.TabIndex = 1;
            this.ShootButtonPlayer1.Text = "Shoot";
            this.ShootButtonPlayer1.UseVisualStyleBackColor = true;
            this.ShootButtonPlayer1.Click += new System.EventHandler(this.ShootButton_Click);
            // 
            // ShootPointerPlayer1
            // 
            this.ShootPointerPlayer1.AutoSize = true;
            this.ShootPointerPlayer1.BackColor = System.Drawing.Color.Lime;
            this.ShootPointerPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShootPointerPlayer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShootPointerPlayer1.Location = new System.Drawing.Point(553, 140);
            this.ShootPointerPlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShootPointerPlayer1.Name = "ShootPointerPlayer1";
            this.ShootPointerPlayer1.Size = new System.Drawing.Size(4, 5);
            this.ShootPointerPlayer1.TabIndex = 2;
            this.ShootPointerPlayer1.Text = ".";
            // 
            // FirstPlayerTimer
            // 
            this.FirstPlayerTimer.Interval = 30;
            this.FirstPlayerTimer.Tick += new System.EventHandler(this.FirstPlayerTimer_Tick);
            // 
            // StartTimerPlayer1button
            // 
            this.StartTimerPlayer1button.Location = new System.Drawing.Point(620, 278);
            this.StartTimerPlayer1button.Name = "StartTimerPlayer1button";
            this.StartTimerPlayer1button.Size = new System.Drawing.Size(75, 23);
            this.StartTimerPlayer1button.TabIndex = 3;
            this.StartTimerPlayer1button.Text = "Start";
            this.StartTimerPlayer1button.UseVisualStyleBackColor = true;
            this.StartTimerPlayer1button.Click += new System.EventHandler(this.StartTimer1button_Click);
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.Image = global::Domowe2.Properties.Resources.daveGame;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(55, 225);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(125, 160);
            this.pictureBoxPlayer2.TabIndex = 6;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // pictureBoxShieldPlayer2
            // 
            this.pictureBoxShieldPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShieldPlayer2.Image")));
            this.pictureBoxShieldPlayer2.Location = new System.Drawing.Point(173, 45);
            this.pictureBoxShieldPlayer2.Name = "pictureBoxShieldPlayer2";
            this.pictureBoxShieldPlayer2.Size = new System.Drawing.Size(200, 198);
            this.pictureBoxShieldPlayer2.TabIndex = 5;
            this.pictureBoxShieldPlayer2.TabStop = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.Image = global::Domowe2.Properties.Resources.pete;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(420, 235);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(137, 150);
            this.pictureBoxPlayer1.TabIndex = 4;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxShield
            // 
            this.pictureBoxShield.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShield.Image")));
            this.pictureBoxShield.Location = new System.Drawing.Point(554, 45);
            this.pictureBoxShield.Name = "pictureBoxShield";
            this.pictureBoxShield.Size = new System.Drawing.Size(200, 198);
            this.pictureBoxShield.TabIndex = 0;
            this.pictureBoxShield.TabStop = false;
            // 
            // ShootPointerPlayer2
            // 
            this.ShootPointerPlayer2.AutoSize = true;
            this.ShootPointerPlayer2.BackColor = System.Drawing.Color.Fuchsia;
            this.ShootPointerPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F);
            this.ShootPointerPlayer2.Location = new System.Drawing.Point(172, 140);
            this.ShootPointerPlayer2.Name = "ShootPointerPlayer2";
            this.ShootPointerPlayer2.Size = new System.Drawing.Size(4, 5);
            this.ShootPointerPlayer2.TabIndex = 7;
            this.ShootPointerPlayer2.Text = ".";
            // 
            // SecondPlayerTimer
            // 
            this.SecondPlayerTimer.Interval = 30;
            this.SecondPlayerTimer.Tick += new System.EventHandler(this.SecondPlayerTimer_Tick);
            // 
            // ShootbuttonPlayer2
            // 
            this.ShootbuttonPlayer2.Location = new System.Drawing.Point(239, 249);
            this.ShootbuttonPlayer2.Name = "ShootbuttonPlayer2";
            this.ShootbuttonPlayer2.Size = new System.Drawing.Size(75, 23);
            this.ShootbuttonPlayer2.TabIndex = 8;
            this.ShootbuttonPlayer2.Text = "Shoot";
            this.ShootbuttonPlayer2.UseVisualStyleBackColor = true;
            this.ShootbuttonPlayer2.Click += new System.EventHandler(this.ShootbuttonPlayer2_Click);
            // 
            // StartTimerPlayer2button
            // 
            this.StartTimerPlayer2button.Location = new System.Drawing.Point(239, 278);
            this.StartTimerPlayer2button.Name = "StartTimerPlayer2button";
            this.StartTimerPlayer2button.Size = new System.Drawing.Size(75, 23);
            this.StartTimerPlayer2button.TabIndex = 9;
            this.StartTimerPlayer2button.Text = "Start";
            this.StartTimerPlayer2button.UseVisualStyleBackColor = true;
            this.StartTimerPlayer2button.Click += new System.EventHandler(this.StartTimerPlayer2button_Click);
            // 
            // labelResultPlayer1
            // 
            this.labelResultPlayer1.AutoSize = true;
            this.labelResultPlayer1.Location = new System.Drawing.Point(508, 13);
            this.labelResultPlayer1.Name = "labelResultPlayer1";
            this.labelResultPlayer1.Size = new System.Drawing.Size(76, 13);
            this.labelResultPlayer1.TabIndex = 10;
            this.labelResultPlayer1.Text = "Player 1 result:";
            // 
            // labelPlayer2Result
            // 
            this.labelPlayer2Result.AutoSize = true;
            this.labelPlayer2Result.Location = new System.Drawing.Point(125, 13);
            this.labelPlayer2Result.Name = "labelPlayer2Result";
            this.labelPlayer2Result.Size = new System.Drawing.Size(76, 13);
            this.labelPlayer2Result.TabIndex = 11;
            this.labelPlayer2Result.Text = "Player 2 result:";
            // 
            // textBoxPlayer1Result
            // 
            this.textBoxPlayer1Result.Location = new System.Drawing.Point(595, 10);
            this.textBoxPlayer1Result.Name = "textBoxPlayer1Result";
            this.textBoxPlayer1Result.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer1Result.TabIndex = 12;
            // 
            // textBoxPlayer2Result
            // 
            this.textBoxPlayer2Result.Location = new System.Drawing.Point(214, 10);
            this.textBoxPlayer2Result.Name = "textBoxPlayer2Result";
            this.textBoxPlayer2Result.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer2Result.TabIndex = 13;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(408, 122);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 14;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.textBoxPlayer2Result);
            this.Controls.Add(this.textBoxPlayer1Result);
            this.Controls.Add(this.labelPlayer2Result);
            this.Controls.Add(this.labelResultPlayer1);
            this.Controls.Add(this.StartTimerPlayer2button);
            this.Controls.Add(this.ShootbuttonPlayer2);
            this.Controls.Add(this.ShootPointerPlayer2);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxShieldPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.StartTimerPlayer1button);
            this.Controls.Add(this.ShootPointerPlayer1);
            this.Controls.Add(this.ShootButtonPlayer1);
            this.Controls.Add(this.pictureBoxShield);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShieldPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShield;
        private System.Windows.Forms.Button ShootButtonPlayer1;
        private System.Windows.Forms.Label ShootPointerPlayer1;
        private System.Windows.Forms.Timer FirstPlayerTimer;
        private System.Windows.Forms.Button StartTimerPlayer1button;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxShieldPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Label ShootPointerPlayer2;
        private System.Windows.Forms.Timer SecondPlayerTimer;
        private System.Windows.Forms.Button ShootbuttonPlayer2;
        private System.Windows.Forms.Button StartTimerPlayer2button;
        private System.Windows.Forms.Label labelResultPlayer1;
        private System.Windows.Forms.Label labelPlayer2Result;
        private System.Windows.Forms.TextBox textBoxPlayer1Result;
        private System.Windows.Forms.TextBox textBoxPlayer2Result;
        private System.Windows.Forms.Button buttonFinish;
    }
}