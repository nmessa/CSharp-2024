namespace Web_Browser
{
    partial class frmChild
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
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLoadPage = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location = new System.Drawing.Point(1, 62);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(540, 352);
            this.WebBrowser1.TabIndex = 15;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(455, 10);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(67, 43);
            this.btnForward.TabIndex = 14;
            this.btnForward.Text = "Fwd";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(406, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 43);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(357, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 43);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(308, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(67, 43);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLoadPage
            // 
            this.btnLoadPage.Location = new System.Drawing.Point(259, 10);
            this.btnLoadPage.Name = "btnLoadPage";
            this.btnLoadPage.Size = new System.Drawing.Size(67, 43);
            this.btnLoadPage.TabIndex = 10;
            this.btnLoadPage.Text = "Go";
            this.btnLoadPage.UseVisualStyleBackColor = true;
            this.btnLoadPage.Click += new System.EventHandler(this.btnLoadPage_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(49, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(224, 20);
            this.txtURL.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "URL";
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 418);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoadPage);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.Label1);
            this.Name = "frmChild";
            this.Text = "Child";
            this.Resize += new System.EventHandler(this.frmChild_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.WebBrowser WebBrowser1;
        internal System.Windows.Forms.Button btnForward;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Button btnHome;
        internal System.Windows.Forms.Button btnLoadPage;
        internal System.Windows.Forms.TextBox txtURL;
        internal System.Windows.Forms.Label Label1;
    }
}