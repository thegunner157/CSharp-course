namespace Domowe2
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartGameButton = new System.Windows.Forms.Button();
            this.comboBoxSelectCharacter = new System.Windows.Forms.ComboBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.buttonNamePlayer1 = new System.Windows.Forms.Button();
            this.buttonNamePlayer2 = new System.Windows.Forms.Button();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(352, 415);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // comboBoxSelectCharacter
            // 
            this.comboBoxSelectCharacter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxSelectCharacter.FormattingEnabled = true;
            this.comboBoxSelectCharacter.Location = new System.Drawing.Point(323, 34);
            this.comboBoxSelectCharacter.Name = "comboBoxSelectCharacter";
            this.comboBoxSelectCharacter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectCharacter.TabIndex = 3;
            this.comboBoxSelectCharacter.Text = "Select Character";
            this.comboBoxSelectCharacter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectCharacter_SelectedIndexChanged);
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(541, 86);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(223, 248);
            this.pictureBoxPlayer1.TabIndex = 4;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // buttonNamePlayer1
            // 
            this.buttonNamePlayer1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNamePlayer1.Location = new System.Drawing.Point(626, 34);
            this.buttonNamePlayer1.Name = "buttonNamePlayer1";
            this.buttonNamePlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonNamePlayer1.TabIndex = 5;
            this.buttonNamePlayer1.Text = "Player 1";
            this.buttonNamePlayer1.UseVisualStyleBackColor = false;
            this.buttonNamePlayer1.Click += new System.EventHandler(this.ButtonNamePlayer1_Click);
            // 
            // buttonNamePlayer2
            // 
            this.buttonNamePlayer2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNamePlayer2.Location = new System.Drawing.Point(101, 34);
            this.buttonNamePlayer2.Name = "buttonNamePlayer2";
            this.buttonNamePlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonNamePlayer2.TabIndex = 6;
            this.buttonNamePlayer2.Text = "Player 2";
            this.buttonNamePlayer2.UseVisualStyleBackColor = false;
            this.buttonNamePlayer2.Click += new System.EventHandler(this.ButtonNamePlayer2_Click);
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(47, 73);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(200, 274);
            this.pictureBoxPlayer2.TabIndex = 7;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.buttonNamePlayer2);
            this.Controls.Add(this.buttonNamePlayer1);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.comboBoxSelectCharacter);
            this.Controls.Add(this.StartGameButton);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.ComboBox comboBoxSelectCharacter;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.Button buttonNamePlayer1;
        private System.Windows.Forms.Button buttonNamePlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
    }
}

