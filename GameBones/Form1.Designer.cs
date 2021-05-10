
namespace GameBones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRoll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDice1 = new System.Windows.Forms.Label();
            this.labelDice2 = new System.Windows.Forms.Label();
            this.textBoxSumDices = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(151, 277);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(118, 59);
            this.buttonRoll.TabIndex = 0;
            this.buttonRoll.Text = "Roll the dice";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 163);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(226, 12);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(169, 163);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(169, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 163);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelDice1
            // 
            this.labelDice1.AutoSize = true;
            this.labelDice1.Location = new System.Drawing.Point(85, 189);
            this.labelDice1.Name = "labelDice1";
            this.labelDice1.Size = new System.Drawing.Size(0, 20);
            this.labelDice1.TabIndex = 3;
            // 
            // labelDice2
            // 
            this.labelDice2.AutoSize = true;
            this.labelDice2.Location = new System.Drawing.Point(280, 189);
            this.labelDice2.Name = "labelDice2";
            this.labelDice2.Size = new System.Drawing.Size(0, 20);
            this.labelDice2.TabIndex = 4;
            // 
            // textBoxSumDices
            // 
            this.textBoxSumDices.Location = new System.Drawing.Point(144, 227);
            this.textBoxSumDices.Name = "textBoxSumDices";
            this.textBoxSumDices.Size = new System.Drawing.Size(125, 27);
            this.textBoxSumDices.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 348);
            this.Controls.Add(this.textBoxSumDices);
            this.Controls.Add(this.labelDice2);
            this.Controls.Add(this.labelDice1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDice1;
        private System.Windows.Forms.Label labelDice2;
        private System.Windows.Forms.TextBox textBoxSumDices;
    }
}

