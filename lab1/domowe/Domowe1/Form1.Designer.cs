namespace Domowe1
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxWood = new System.Windows.Forms.TextBox();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.textBoxGold = new System.Windows.Forms.TextBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.textBoxHowManyWood = new System.Windows.Forms.TextBox();
            this.textBoxHowManyFood = new System.Windows.Forms.TextBox();
            this.textBoxHowManyGold = new System.Windows.Forms.TextBox();
            this.textBoxPriceFood = new System.Windows.Forms.TextBox();
            this.buttonBuyFood = new System.Windows.Forms.Button();
            this.textBoxPriceWood = new System.Windows.Forms.TextBox();
            this.buttonBuyWood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxNumber.Location = new System.Drawing.Point(392, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonStart.Location = new System.Drawing.Point(417, 383);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 183);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxWood
            // 
            this.textBoxWood.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxWood.Location = new System.Drawing.Point(21, 48);
            this.textBoxWood.Name = "textBoxWood";
            this.textBoxWood.Size = new System.Drawing.Size(100, 20);
            this.textBoxWood.TabIndex = 3;
            this.textBoxWood.Text = "Wood";
            this.textBoxWood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGold.Image")));
            this.pictureBoxGold.Location = new System.Drawing.Point(168, 69);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(170, 118);
            this.pictureBoxGold.TabIndex = 4;
            this.pictureBoxGold.TabStop = false;
            // 
            // textBoxGold
            // 
            this.textBoxGold.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGold.Location = new System.Drawing.Point(208, 69);
            this.textBoxGold.Name = "textBoxGold";
            this.textBoxGold.Size = new System.Drawing.Size(100, 20);
            this.textBoxGold.TabIndex = 5;
            this.textBoxGold.Text = "Gold";
            this.textBoxGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFood.Image")));
            this.pictureBoxFood.Location = new System.Drawing.Point(361, 48);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(252, 213);
            this.pictureBoxFood.TabIndex = 6;
            this.pictureBoxFood.TabStop = false;
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(439, 48);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(100, 20);
            this.textBoxFood.TabIndex = 7;
            this.textBoxFood.Text = "Food";
            this.textBoxFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHowManyWood
            // 
            this.textBoxHowManyWood.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxHowManyWood.Location = new System.Drawing.Point(21, 237);
            this.textBoxHowManyWood.Name = "textBoxHowManyWood";
            this.textBoxHowManyWood.Size = new System.Drawing.Size(100, 20);
            this.textBoxHowManyWood.TabIndex = 8;
            // 
            // textBoxHowManyFood
            // 
            this.textBoxHowManyFood.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxHowManyFood.Location = new System.Drawing.Point(439, 267);
            this.textBoxHowManyFood.Name = "textBoxHowManyFood";
            this.textBoxHowManyFood.Size = new System.Drawing.Size(100, 20);
            this.textBoxHowManyFood.TabIndex = 9;
            // 
            // textBoxHowManyGold
            // 
            this.textBoxHowManyGold.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxHowManyGold.Location = new System.Drawing.Point(208, 193);
            this.textBoxHowManyGold.Name = "textBoxHowManyGold";
            this.textBoxHowManyGold.Size = new System.Drawing.Size(100, 20);
            this.textBoxHowManyGold.TabIndex = 10;
            // 
            // textBoxPriceFood
            // 
            this.textBoxPriceFood.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPriceFood.Location = new System.Drawing.Point(746, 39);
            this.textBoxPriceFood.Name = "textBoxPriceFood";
            this.textBoxPriceFood.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceFood.TabIndex = 11;
            this.textBoxPriceFood.Text = "Price of Food = 20";
            this.textBoxPriceFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuyFood
            // 
            this.buttonBuyFood.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonBuyFood.Location = new System.Drawing.Point(760, 65);
            this.buttonBuyFood.Name = "buttonBuyFood";
            this.buttonBuyFood.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyFood.TabIndex = 12;
            this.buttonBuyFood.Text = "Buy Food";
            this.buttonBuyFood.UseVisualStyleBackColor = false;
            this.buttonBuyFood.Click += new System.EventHandler(this.ButtonBuyFood_Click);
            // 
            // textBoxPriceWood
            // 
            this.textBoxPriceWood.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPriceWood.Location = new System.Drawing.Point(746, 107);
            this.textBoxPriceWood.Name = "textBoxPriceWood";
            this.textBoxPriceWood.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceWood.TabIndex = 13;
            this.textBoxPriceWood.Text = "Price of Wood = 25";
            this.textBoxPriceWood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuyWood
            // 
            this.buttonBuyWood.Location = new System.Drawing.Point(760, 134);
            this.buttonBuyWood.Name = "buttonBuyWood";
            this.buttonBuyWood.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyWood.TabIndex = 14;
            this.buttonBuyWood.Text = "Buy Wood";
            this.buttonBuyWood.UseVisualStyleBackColor = true;
            this.buttonBuyWood.Click += new System.EventHandler(this.ButtonBuyWood_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.buttonBuyWood);
            this.Controls.Add(this.textBoxPriceWood);
            this.Controls.Add(this.buttonBuyFood);
            this.Controls.Add(this.textBoxPriceFood);
            this.Controls.Add(this.textBoxHowManyGold);
            this.Controls.Add(this.textBoxHowManyFood);
            this.Controls.Add(this.textBoxHowManyWood);
            this.Controls.Add(this.textBoxFood);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.textBoxGold);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.textBoxWood);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "FormGame";
            this.Text = "FormGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxWood;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.TextBox textBoxGold;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.TextBox textBoxHowManyWood;
        private System.Windows.Forms.TextBox textBoxHowManyFood;
        private System.Windows.Forms.TextBox textBoxHowManyGold;
        private System.Windows.Forms.TextBox textBoxPriceFood;
        private System.Windows.Forms.Button buttonBuyFood;
        private System.Windows.Forms.TextBox textBoxPriceWood;
        private System.Windows.Forms.Button buttonBuyWood;
    }
}