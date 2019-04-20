namespace KarolStulaLab2
{
    partial class Form1
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
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonChangeSize = new System.Windows.Forms.Button();
            this.buttonPerimeter = new System.Windows.Forms.Button();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(140, 112);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 0;
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Location = new System.Drawing.Point(140, 163);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 1;
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(336, 112);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.Text = "Oblicz pole";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.ButtonArea_Click);
            // 
            // buttonChangeSize
            // 
            this.buttonChangeSize.Location = new System.Drawing.Point(150, 235);
            this.buttonChangeSize.Name = "buttonChangeSize";
            this.buttonChangeSize.Size = new System.Drawing.Size(90, 23);
            this.buttonChangeSize.TabIndex = 3;
            this.buttonChangeSize.Text = "Zmien kształt";
            this.buttonChangeSize.UseVisualStyleBackColor = true;
            this.buttonChangeSize.Click += new System.EventHandler(this.ButtonChangeSize_Click);
            // 
            // buttonPerimeter
            // 
            this.buttonPerimeter.Location = new System.Drawing.Point(324, 163);
            this.buttonPerimeter.Name = "buttonPerimeter";
            this.buttonPerimeter.Size = new System.Drawing.Size(104, 23);
            this.buttonPerimeter.TabIndex = 4;
            this.buttonPerimeter.Text = "Oblicz obwód";
            this.buttonPerimeter.UseVisualStyleBackColor = true;
            this.buttonPerimeter.Click += new System.EventHandler(this.ButtonPerimeter_Click);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Location = new System.Drawing.Point(131, 54);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShape.TabIndex = 5;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShape_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.buttonPerimeter);
            this.Controls.Add(this.buttonChangeSize);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.textBoxArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonChangeSize;
        private System.Windows.Forms.Button buttonPerimeter;
        private System.Windows.Forms.ComboBox comboBoxShape;
    }
}

