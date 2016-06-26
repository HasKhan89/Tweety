namespace Tweety
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
            this.btnListHomelineTweets = new System.Windows.Forms.Button();
            this.lstTweets = new System.Windows.Forms.ListBox();
            this.cmbScreenNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtYeniTweet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniTweetGonder = new System.Windows.Forms.Button();
            this.btnListMyTweets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListHomelineTweets
            // 
            this.btnListHomelineTweets.Location = new System.Drawing.Point(390, 36);
            this.btnListHomelineTweets.Name = "btnListHomelineTweets";
            this.btnListHomelineTweets.Size = new System.Drawing.Size(75, 53);
            this.btnListHomelineTweets.TabIndex = 0;
            this.btnListHomelineTweets.Text = "List Home Timeline Tweets";
            this.btnListHomelineTweets.UseVisualStyleBackColor = true;
            this.btnListHomelineTweets.Click += new System.EventHandler(this.btnListHomelineTweets_Click);
            // 
            // lstTweets
            // 
            this.lstTweets.FormattingEnabled = true;
            this.lstTweets.Location = new System.Drawing.Point(16, 36);
            this.lstTweets.Name = "lstTweets";
            this.lstTweets.Size = new System.Drawing.Size(368, 134);
            this.lstTweets.TabIndex = 1;
            // 
            // cmbScreenNames
            // 
            this.cmbScreenNames.FormattingEnabled = true;
            this.cmbScreenNames.Location = new System.Drawing.Point(102, 9);
            this.cmbScreenNames.Name = "cmbScreenNames";
            this.cmbScreenNames.Size = new System.Drawing.Size(282, 21);
            this.cmbScreenNames.TabIndex = 2;
            this.cmbScreenNames.SelectedIndexChanged += new System.EventHandler(this.cmbScreenNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Screen Names :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtYeniTweet
            // 
            this.txtYeniTweet.Location = new System.Drawing.Point(124, 176);
            this.txtYeniTweet.MaxLength = 140;
            this.txtYeniTweet.Name = "txtYeniTweet";
            this.txtYeniTweet.Size = new System.Drawing.Size(260, 20);
            this.txtYeniTweet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni Tweet Gönder :";
            // 
            // btnYeniTweetGonder
            // 
            this.btnYeniTweetGonder.Location = new System.Drawing.Point(390, 175);
            this.btnYeniTweetGonder.Name = "btnYeniTweetGonder";
            this.btnYeniTweetGonder.Size = new System.Drawing.Size(75, 23);
            this.btnYeniTweetGonder.TabIndex = 7;
            this.btnYeniTweetGonder.Text = "Gönder";
            this.btnYeniTweetGonder.UseVisualStyleBackColor = true;
            this.btnYeniTweetGonder.Click += new System.EventHandler(this.btnYeniTweetGonder_Click);
            // 
            // btnListMyTweets
            // 
            this.btnListMyTweets.Location = new System.Drawing.Point(390, 95);
            this.btnListMyTweets.Name = "btnListMyTweets";
            this.btnListMyTweets.Size = new System.Drawing.Size(75, 74);
            this.btnListMyTweets.TabIndex = 8;
            this.btnListMyTweets.Text = "List My Tweets";
            this.btnListMyTweets.UseVisualStyleBackColor = true;
            this.btnListMyTweets.Click += new System.EventHandler(this.btnListMyTweets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 210);
            this.Controls.Add(this.btnListMyTweets);
            this.Controls.Add(this.btnYeniTweetGonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYeniTweet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbScreenNames);
            this.Controls.Add(this.lstTweets);
            this.Controls.Add(this.btnListHomelineTweets);
            this.Name = "Form1";
            this.Text = "My Fake Twitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListHomelineTweets;
        private System.Windows.Forms.ListBox lstTweets;
        private System.Windows.Forms.ComboBox cmbScreenNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtYeniTweet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniTweetGonder;
        private System.Windows.Forms.Button btnListMyTweets;
    }
}

