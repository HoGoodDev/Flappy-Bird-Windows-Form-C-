namespace Flappy_Bird_Windows_Form
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
            this.components = new System.ComponentModel.Container();
            this.picPIpeTop = new System.Windows.Forms.PictureBox();
            this.picPipeBottom = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picFlappyBird = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPIpeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // picPIpeTop
            // 
            this.picPIpeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.picPIpeTop.Location = new System.Drawing.Point(337, -1);
            this.picPIpeTop.Name = "picPIpeTop";
            this.picPIpeTop.Size = new System.Drawing.Size(100, 174);
            this.picPIpeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPIpeTop.TabIndex = 0;
            this.picPIpeTop.TabStop = false;
            // 
            // picPipeBottom
            // 
            this.picPipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.picPipeBottom.Location = new System.Drawing.Point(460, 365);
            this.picPipeBottom.Name = "picPipeBottom";
            this.picPipeBottom.Size = new System.Drawing.Size(100, 172);
            this.picPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipeBottom.TabIndex = 1;
            this.picPipeBottom.TabStop = false;
            // 
            // picGround
            // 
            this.picGround.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(2, 532);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(586, 125);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 2;
            this.picGround.TabStop = false;
            // 
            // picFlappyBird
            // 
            this.picFlappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bird;
            this.picFlappyBird.Location = new System.Drawing.Point(35, 241);
            this.picFlappyBird.Name = "picFlappyBird";
            this.picFlappyBird.Size = new System.Drawing.Size(74, 56);
            this.picFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlappyBird.TabIndex = 3;
            this.picFlappyBird.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Wheat;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 561);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(121, 38);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 599);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picFlappyBird);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picPipeBottom);
            this.Controls.Add(this.picPIpeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeysdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeysup);
            ((System.ComponentModel.ISupportInitialize)(this.picPIpeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPIpeTop;
        private System.Windows.Forms.PictureBox picPipeBottom;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picFlappyBird;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

