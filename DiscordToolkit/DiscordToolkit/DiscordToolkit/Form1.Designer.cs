namespace DiscordToolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.thirteenForm1 = new Teen.ThirteenForm();
            this.thirteenTabControl1 = new Teen.ThirteenTabControl();
            this.TokenInfo = new System.Windows.Forms.TabPage();
            this.TokenInfoResults = new System.Windows.Forms.RichTextBox();
            this.thirteenButton3 = new Teen.ThirteenButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TokenToLookup = new Teen.ThirteenTextBox();
            this.WebhookSpammer = new System.Windows.Forms.TabPage();
            this.spamProxies = new System.Windows.Forms.RichTextBox();
            this.spamList = new System.Windows.Forms.RichTextBox();
            this.thirteenButton2 = new Teen.ThirteenButton();
            this.label2 = new System.Windows.Forms.Label();
            this.spamTarget = new Teen.ThirteenTextBox();
            this.WebhookDeleter = new System.Windows.Forms.TabPage();
            this.thirteenButton1 = new Teen.ThirteenButton();
            this.label1 = new System.Windows.Forms.Label();
            this.WebhookDeleteTarget = new Teen.ThirteenTextBox();
            this.Credits = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sentAmount = new Teen.ThirteenTextBox();
            this.thirteenButton4 = new Teen.ThirteenButton();
            this.label5 = new System.Windows.Forms.Label();
            this.threads = new Teen.ThirteenTextBox();
            this.thirteenForm1.SuspendLayout();
            this.thirteenTabControl1.SuspendLayout();
            this.TokenInfo.SuspendLayout();
            this.WebhookSpammer.SuspendLayout();
            this.WebhookDeleter.SuspendLayout();
            this.Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // thirteenForm1
            // 
            this.thirteenForm1.AccentColor = System.Drawing.Color.Red;
            this.thirteenForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenForm1.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.thirteenForm1.Controls.Add(this.thirteenTabControl1);
            this.thirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirteenForm1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenForm1.ForeColor = System.Drawing.Color.White;
            this.thirteenForm1.Location = new System.Drawing.Point(0, 0);
            this.thirteenForm1.Name = "thirteenForm1";
            this.thirteenForm1.Size = new System.Drawing.Size(964, 505);
            this.thirteenForm1.TabIndex = 0;
            this.thirteenForm1.Text = "DiscordToolkit";
            // 
            // thirteenTabControl1
            // 
            this.thirteenTabControl1.AccentColor = System.Drawing.Color.Red;
            this.thirteenTabControl1.ColorScheme = Teen.ThirteenTabControl.ColorSchemes.Dark;
            this.thirteenTabControl1.Controls.Add(this.TokenInfo);
            this.thirteenTabControl1.Controls.Add(this.WebhookSpammer);
            this.thirteenTabControl1.Controls.Add(this.WebhookDeleter);
            this.thirteenTabControl1.Controls.Add(this.Credits);
            this.thirteenTabControl1.ForeColor = System.Drawing.Color.White;
            this.thirteenTabControl1.Location = new System.Drawing.Point(12, 42);
            this.thirteenTabControl1.Name = "thirteenTabControl1";
            this.thirteenTabControl1.SelectedIndex = 0;
            this.thirteenTabControl1.Size = new System.Drawing.Size(940, 451);
            this.thirteenTabControl1.TabIndex = 0;
            // 
            // TokenInfo
            // 
            this.TokenInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TokenInfo.Controls.Add(this.TokenInfoResults);
            this.TokenInfo.Controls.Add(this.thirteenButton3);
            this.TokenInfo.Controls.Add(this.label3);
            this.TokenInfo.Controls.Add(this.TokenToLookup);
            this.TokenInfo.Location = new System.Drawing.Point(4, 25);
            this.TokenInfo.Name = "TokenInfo";
            this.TokenInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TokenInfo.Size = new System.Drawing.Size(932, 422);
            this.TokenInfo.TabIndex = 0;
            this.TokenInfo.Text = "Token Info";
            // 
            // TokenInfoResults
            // 
            this.TokenInfoResults.Location = new System.Drawing.Point(472, 52);
            this.TokenInfoResults.Name = "TokenInfoResults";
            this.TokenInfoResults.ReadOnly = true;
            this.TokenInfoResults.Size = new System.Drawing.Size(443, 364);
            this.TokenInfoResults.TabIndex = 8;
            this.TokenInfoResults.Text = "Results will go here";
            // 
            // thirteenButton3
            // 
            this.thirteenButton3.AccentColor = System.Drawing.Color.Red;
            this.thirteenButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton3.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton3.ForeColor = System.Drawing.Color.White;
            this.thirteenButton3.Location = new System.Drawing.Point(49, 52);
            this.thirteenButton3.Name = "thirteenButton3";
            this.thirteenButton3.Size = new System.Drawing.Size(105, 23);
            this.thirteenButton3.TabIndex = 7;
            this.thirteenButton3.Text = "Gather Info";
            this.thirteenButton3.UseVisualStyleBackColor = false;
            this.thirteenButton3.Click += new System.EventHandler(this.thirteenButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Token";
            // 
            // TokenToLookup
            // 
            this.TokenToLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TokenToLookup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TokenToLookup.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.TokenToLookup.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.TokenToLookup.ForeColor = System.Drawing.Color.White;
            this.TokenToLookup.Location = new System.Drawing.Point(49, 21);
            this.TokenToLookup.Name = "TokenToLookup";
            this.TokenToLookup.Size = new System.Drawing.Size(877, 25);
            this.TokenToLookup.TabIndex = 5;
            // 
            // WebhookSpammer
            // 
            this.WebhookSpammer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WebhookSpammer.Controls.Add(this.label5);
            this.WebhookSpammer.Controls.Add(this.threads);
            this.WebhookSpammer.Controls.Add(this.thirteenButton4);
            this.WebhookSpammer.Controls.Add(this.sentAmount);
            this.WebhookSpammer.Controls.Add(this.label4);
            this.WebhookSpammer.Controls.Add(this.spamProxies);
            this.WebhookSpammer.Controls.Add(this.spamList);
            this.WebhookSpammer.Controls.Add(this.thirteenButton2);
            this.WebhookSpammer.Controls.Add(this.label2);
            this.WebhookSpammer.Controls.Add(this.spamTarget);
            this.WebhookSpammer.Location = new System.Drawing.Point(4, 25);
            this.WebhookSpammer.Name = "WebhookSpammer";
            this.WebhookSpammer.Padding = new System.Windows.Forms.Padding(3);
            this.WebhookSpammer.Size = new System.Drawing.Size(932, 422);
            this.WebhookSpammer.TabIndex = 3;
            this.WebhookSpammer.Text = "Webhook Spam";
            this.WebhookSpammer.Click += new System.EventHandler(this.WebhookSpammer_Click);
            // 
            // spamProxies
            // 
            this.spamProxies.Location = new System.Drawing.Point(9, 170);
            this.spamProxies.Name = "spamProxies";
            this.spamProxies.Size = new System.Drawing.Size(372, 246);
            this.spamProxies.TabIndex = 6;
            this.spamProxies.Text = "Paste your HTTP(s) proxies here";
            // 
            // spamList
            // 
            this.spamList.Location = new System.Drawing.Point(554, 53);
            this.spamList.Name = "spamList";
            this.spamList.Size = new System.Drawing.Size(372, 363);
            this.spamList.TabIndex = 5;
            this.spamList.Text = "This webhook is now mine!\nSpam inbound\n@here";
            // 
            // thirteenButton2
            // 
            this.thirteenButton2.AccentColor = System.Drawing.Color.Red;
            this.thirteenButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton2.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton2.ForeColor = System.Drawing.Color.White;
            this.thirteenButton2.Location = new System.Drawing.Point(49, 52);
            this.thirteenButton2.Name = "thirteenButton2";
            this.thirteenButton2.Size = new System.Drawing.Size(105, 23);
            this.thirteenButton2.TabIndex = 4;
            this.thirteenButton2.Text = "Spam";
            this.thirteenButton2.UseVisualStyleBackColor = false;
            this.thirteenButton2.Click += new System.EventHandler(this.thirteenButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL";
            // 
            // spamTarget
            // 
            this.spamTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.spamTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spamTarget.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.spamTarget.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.spamTarget.ForeColor = System.Drawing.Color.White;
            this.spamTarget.Location = new System.Drawing.Point(49, 21);
            this.spamTarget.Name = "spamTarget";
            this.spamTarget.Size = new System.Drawing.Size(877, 25);
            this.spamTarget.TabIndex = 2;
            // 
            // WebhookDeleter
            // 
            this.WebhookDeleter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WebhookDeleter.Controls.Add(this.thirteenButton1);
            this.WebhookDeleter.Controls.Add(this.label1);
            this.WebhookDeleter.Controls.Add(this.WebhookDeleteTarget);
            this.WebhookDeleter.Location = new System.Drawing.Point(4, 25);
            this.WebhookDeleter.Name = "WebhookDeleter";
            this.WebhookDeleter.Padding = new System.Windows.Forms.Padding(3);
            this.WebhookDeleter.Size = new System.Drawing.Size(932, 422);
            this.WebhookDeleter.TabIndex = 1;
            this.WebhookDeleter.Text = "Webhook Deleter";
            // 
            // thirteenButton1
            // 
            this.thirteenButton1.AccentColor = System.Drawing.Color.Red;
            this.thirteenButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton1.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton1.ForeColor = System.Drawing.Color.White;
            this.thirteenButton1.Location = new System.Drawing.Point(49, 52);
            this.thirteenButton1.Name = "thirteenButton1";
            this.thirteenButton1.Size = new System.Drawing.Size(102, 23);
            this.thirteenButton1.TabIndex = 2;
            this.thirteenButton1.Text = "Delete";
            this.thirteenButton1.UseVisualStyleBackColor = false;
            this.thirteenButton1.Click += new System.EventHandler(this.thirteenButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // WebhookDeleteTarget
            // 
            this.WebhookDeleteTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WebhookDeleteTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebhookDeleteTarget.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.WebhookDeleteTarget.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.WebhookDeleteTarget.ForeColor = System.Drawing.Color.White;
            this.WebhookDeleteTarget.Location = new System.Drawing.Point(49, 21);
            this.WebhookDeleteTarget.Name = "WebhookDeleteTarget";
            this.WebhookDeleteTarget.Size = new System.Drawing.Size(877, 25);
            this.WebhookDeleteTarget.TabIndex = 0;
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Credits.Controls.Add(this.pictureBox1);
            this.Credits.Controls.Add(this.richTextBox1);
            this.Credits.Location = new System.Drawing.Point(4, 25);
            this.Credits.Name = "Credits";
            this.Credits.Padding = new System.Windows.Forms.Padding(3);
            this.Credits.Size = new System.Drawing.Size(932, 422);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(920, 302);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Discord Tool Kit\n\nDeveloped by: https://github.com/Kami147\n\nThanks to:\nhttps://gi" +
    "thub.com/csharp-leaf/Leaf.xNet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sent:";
            // 
            // sentAmount
            // 
            this.sentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sentAmount.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.sentAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.sentAmount.ForeColor = System.Drawing.Color.White;
            this.sentAmount.Location = new System.Drawing.Point(420, 399);
            this.sentAmount.Name = "sentAmount";
            this.sentAmount.ReadOnly = true;
            this.sentAmount.Size = new System.Drawing.Size(128, 18);
            this.sentAmount.TabIndex = 8;
            this.sentAmount.Text = "0";
            // 
            // thirteenButton4
            // 
            this.thirteenButton4.AccentColor = System.Drawing.Color.Red;
            this.thirteenButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton4.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton4.ForeColor = System.Drawing.Color.White;
            this.thirteenButton4.Location = new System.Drawing.Point(160, 52);
            this.thirteenButton4.Name = "thirteenButton4";
            this.thirteenButton4.Size = new System.Drawing.Size(105, 23);
            this.thirteenButton4.TabIndex = 9;
            this.thirteenButton4.Text = "Stop";
            this.thirteenButton4.UseVisualStyleBackColor = false;
            this.thirteenButton4.Click += new System.EventHandler(this.thirteenButton4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Threads";
            // 
            // threads
            // 
            this.threads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.threads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threads.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.threads.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.threads.ForeColor = System.Drawing.Color.White;
            this.threads.Location = new System.Drawing.Point(345, 54);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(55, 25);
            this.threads.TabIndex = 10;
            this.threads.Text = "35";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 505);
            this.Controls.Add(this.thirteenForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.thirteenForm1.ResumeLayout(false);
            this.thirteenTabControl1.ResumeLayout(false);
            this.TokenInfo.ResumeLayout(false);
            this.TokenInfo.PerformLayout();
            this.WebhookSpammer.ResumeLayout(false);
            this.WebhookSpammer.PerformLayout();
            this.WebhookDeleter.ResumeLayout(false);
            this.WebhookDeleter.PerformLayout();
            this.Credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Teen.ThirteenForm thirteenForm1;
        private Teen.ThirteenTabControl thirteenTabControl1;
        private System.Windows.Forms.TabPage TokenInfo;
        private System.Windows.Forms.TabPage WebhookDeleter;
        private System.Windows.Forms.Label label1;
        private Teen.ThirteenTextBox WebhookDeleteTarget;
        private System.Windows.Forms.TabPage Credits;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Teen.ThirteenButton thirteenButton1;
        private System.Windows.Forms.TabPage WebhookSpammer;
        private System.Windows.Forms.Label label2;
        private Teen.ThirteenTextBox spamTarget;
        private Teen.ThirteenButton thirteenButton2;
        private System.Windows.Forms.RichTextBox spamList;
        private Teen.ThirteenButton thirteenButton3;
        private System.Windows.Forms.Label label3;
        private Teen.ThirteenTextBox TokenToLookup;
        private System.Windows.Forms.RichTextBox TokenInfoResults;
        private System.Windows.Forms.RichTextBox spamProxies;
        private Teen.ThirteenTextBox sentAmount;
        private System.Windows.Forms.Label label4;
        private Teen.ThirteenButton thirteenButton4;
        private System.Windows.Forms.Label label5;
        private Teen.ThirteenTextBox threads;
    }
}

