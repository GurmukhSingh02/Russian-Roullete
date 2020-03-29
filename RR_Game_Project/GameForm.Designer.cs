namespace RR_Game_Project
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnRuleToPlay = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.btnLoader = new System.Windows.Forms.Button();
            this.lblDeadOrAlive = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRuleToPlay
            // 
            this.btnRuleToPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRuleToPlay.BackgroundImage")));
            this.btnRuleToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRuleToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleToPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRuleToPlay.Location = new System.Drawing.Point(12, 274);
            this.btnRuleToPlay.Name = "btnRuleToPlay";
            this.btnRuleToPlay.Size = new System.Drawing.Size(230, 116);
            this.btnRuleToPlay.TabIndex = 0;
            this.btnRuleToPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRuleToPlay.UseVisualStyleBackColor = true;
            this.btnRuleToPlay.Click += new System.EventHandler(this.btnRuleToPlay_Click);
            // 
            // btnShot
            // 
            this.btnShot.BackColor = System.Drawing.Color.Silver;
            this.btnShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShot.Image = ((System.Drawing.Image)(resources.GetObject("btnShot.Image")));
            this.btnShot.Location = new System.Drawing.Point(498, 228);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(295, 162);
            this.btnShot.TabIndex = 1;
            this.btnShot.Text = "Shot Now";
            this.btnShot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShot.UseVisualStyleBackColor = false;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // btnAway
            // 
            this.btnAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAway.Image = ((System.Drawing.Image)(resources.GetObject("btnAway.Image")));
            this.btnAway.Location = new System.Drawing.Point(498, 439);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(295, 117);
            this.btnAway.TabIndex = 2;
            this.btnAway.Text = "2X Forgiven Lives";
            this.btnAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // btnLoader
            // 
            this.btnLoader.BackColor = System.Drawing.Color.White;
            this.btnLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoader.Image = ((System.Drawing.Image)(resources.GetObject("btnLoader.Image")));
            this.btnLoader.Location = new System.Drawing.Point(498, 51);
            this.btnLoader.Name = "btnLoader";
            this.btnLoader.Size = new System.Drawing.Size(295, 125);
            this.btnLoader.TabIndex = 3;
            this.btnLoader.Text = "Load The Death";
            this.btnLoader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoader.UseVisualStyleBackColor = false;
            this.btnLoader.Click += new System.EventHandler(this.btnLoader_Click);
            // 
            // lblDeadOrAlive
            // 
            this.lblDeadOrAlive.AutoSize = true;
            this.lblDeadOrAlive.BackColor = System.Drawing.Color.Maroon;
            this.lblDeadOrAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadOrAlive.ForeColor = System.Drawing.Color.Black;
            this.lblDeadOrAlive.Location = new System.Drawing.Point(237, 9);
            this.lblDeadOrAlive.Name = "lblDeadOrAlive";
            this.lblDeadOrAlive.Size = new System.Drawing.Size(203, 33);
            this.lblDeadOrAlive.TabIndex = 0;
            this.lblDeadOrAlive.Text = "Dead or Alive";
            //this.lblDeadOrAlive.Click += new System.EventHandler(this.lblDeadOrAlive_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.Image")));
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 428);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(230, 128);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(8, 152);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(206, 20);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Please Enter Your Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(269, 151);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(171, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 733);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblDeadOrAlive);
            this.Controls.Add(this.btnLoader);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnRuleToPlay);
            this.Name = "Form1";
            this.Text = "MainForm";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRuleToPlay;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Button btnLoader;
        private System.Windows.Forms.Label lblDeadOrAlive;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
    }
}

