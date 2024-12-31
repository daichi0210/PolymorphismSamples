namespace PolymorphismSamples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonSing = new Button();
            buttonReset = new Button();
            pictureBoxDog = new PictureBox();
            pictureBoxCat = new PictureBox();
            pictureBoxBird = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "6章6節　ポリモーフィズム";
            // 
            // buttonSing
            // 
            buttonSing.Location = new Point(12, 153);
            buttonSing.Name = "buttonSing";
            buttonSing.Size = new Size(462, 23);
            buttonSing.TabIndex = 1;
            buttonSing.Text = "鳴く";
            buttonSing.UseVisualStyleBackColor = true;
            buttonSing.Click += buttonSing_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(12, 182);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(462, 23);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "元に戻す";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // pictureBoxDog
            // 
            pictureBoxDog.Image = Properties.Resources.DogCookie;
            pictureBoxDog.Location = new Point(12, 27);
            pictureBoxDog.Name = "pictureBoxDog";
            pictureBoxDog.Size = new Size(150, 120);
            pictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDog.TabIndex = 3;
            pictureBoxDog.TabStop = false;
            // 
            // pictureBoxCat
            // 
            pictureBoxCat.Image = Properties.Resources.CatCookie;
            pictureBoxCat.Location = new Point(168, 27);
            pictureBoxCat.Name = "pictureBoxCat";
            pictureBoxCat.Size = new Size(150, 120);
            pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCat.TabIndex = 3;
            pictureBoxCat.TabStop = false;
            // 
            // pictureBoxBird
            // 
            pictureBoxBird.Image = Properties.Resources.BirdCookie;
            pictureBoxBird.Location = new Point(324, 27);
            pictureBoxBird.Name = "pictureBoxBird";
            pictureBoxBird.Size = new Size(150, 120);
            pictureBoxBird.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBird.TabIndex = 3;
            pictureBoxBird.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 218);
            Controls.Add(pictureBoxBird);
            Controls.Add(pictureBoxCat);
            Controls.Add(pictureBoxDog);
            Controls.Add(buttonReset);
            Controls.Add(buttonSing);
            Controls.Add(label1);
            Name = "Form1";
            Text = "動物クッキー";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSing;
        private Button buttonReset;
        private PictureBox pictureBoxDog;
        private PictureBox pictureBoxCat;
        private PictureBox pictureBoxBird;
    }
}
