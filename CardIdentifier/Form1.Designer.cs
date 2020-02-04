namespace CardIdentifier
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
            this.kingSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.jokerPictureBox = new System.Windows.Forms.PictureBox();
            this.aceSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.eightDiamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.twoClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kingSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightDiamondsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClubsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kingSpadesPictureBox
            // 
            this.kingSpadesPictureBox.Image = global::CardIdentifier.Properties.Resources.King_Spades;
            this.kingSpadesPictureBox.Location = new System.Drawing.Point(294, 275);
            this.kingSpadesPictureBox.Name = "kingSpadesPictureBox";
            this.kingSpadesPictureBox.Size = new System.Drawing.Size(100, 140);
            this.kingSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingSpadesPictureBox.TabIndex = 4;
            this.kingSpadesPictureBox.TabStop = false;
            this.kingSpadesPictureBox.Click += new System.EventHandler(this.kingSpadesPictureBox_Click);
            // 
            // jokerPictureBox
            // 
            this.jokerPictureBox.Image = global::CardIdentifier.Properties.Resources.Joker_Black;
            this.jokerPictureBox.Location = new System.Drawing.Point(129, 275);
            this.jokerPictureBox.Name = "jokerPictureBox";
            this.jokerPictureBox.Size = new System.Drawing.Size(100, 140);
            this.jokerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jokerPictureBox.TabIndex = 3;
            this.jokerPictureBox.TabStop = false;
            this.jokerPictureBox.Click += new System.EventHandler(this.jokerPictureBox_Click);
            // 
            // aceSpadesPictureBox
            // 
            this.aceSpadesPictureBox.Image = global::CardIdentifier.Properties.Resources.Ace_Spades;
            this.aceSpadesPictureBox.Location = new System.Drawing.Point(387, 63);
            this.aceSpadesPictureBox.Name = "aceSpadesPictureBox";
            this.aceSpadesPictureBox.Size = new System.Drawing.Size(100, 140);
            this.aceSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSpadesPictureBox.TabIndex = 2;
            this.aceSpadesPictureBox.TabStop = false;
            this.aceSpadesPictureBox.Click += new System.EventHandler(this.aceSpadesPictureBox_Click);
            // 
            // eightDiamondsPictureBox
            // 
            this.eightDiamondsPictureBox.Image = global::CardIdentifier.Properties.Resources._8_Diamonds;
            this.eightDiamondsPictureBox.Location = new System.Drawing.Point(208, 63);
            this.eightDiamondsPictureBox.Name = "eightDiamondsPictureBox";
            this.eightDiamondsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.eightDiamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eightDiamondsPictureBox.TabIndex = 1;
            this.eightDiamondsPictureBox.TabStop = false;
            this.eightDiamondsPictureBox.Click += new System.EventHandler(this.eightDiamondsPictureBox_Click);
            // 
            // twoClubsPictureBox
            // 
            this.twoClubsPictureBox.Image = global::CardIdentifier.Properties.Resources._2_Clubs;
            this.twoClubsPictureBox.Location = new System.Drawing.Point(45, 63);
            this.twoClubsPictureBox.Name = "twoClubsPictureBox";
            this.twoClubsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.twoClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoClubsPictureBox.TabIndex = 0;
            this.twoClubsPictureBox.TabStop = false;
            this.twoClubsPictureBox.Click += new System.EventHandler(this.twoClubsPictureBox_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.Location = new System.Drawing.Point(129, 229);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(265, 23);
            this.cardLabel.TabIndex = 5;
            this.cardLabel.Text = "Two of Clubs";
            this.cardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click a Card to see it\'s Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.kingSpadesPictureBox);
            this.Controls.Add(this.jokerPictureBox);
            this.Controls.Add(this.aceSpadesPictureBox);
            this.Controls.Add(this.eightDiamondsPictureBox);
            this.Controls.Add(this.twoClubsPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kingSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightDiamondsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClubsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox twoClubsPictureBox;
        private System.Windows.Forms.PictureBox eightDiamondsPictureBox;
        private System.Windows.Forms.PictureBox aceSpadesPictureBox;
        private System.Windows.Forms.PictureBox jokerPictureBox;
        private System.Windows.Forms.PictureBox kingSpadesPictureBox;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label label1;
    }
}

