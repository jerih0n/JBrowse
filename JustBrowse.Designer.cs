namespace JustBrowse
{
    partial class JustBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JustBrowse));
            this.URLInput = new System.Windows.Forms.TextBox();
            this.buttonTip = new System.Windows.Forms.ToolTip(this.components);
            this.makeHomePage = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // URLInput
            // 
            this.URLInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.URLInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.URLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.URLInput.Location = new System.Drawing.Point(162, 3);
            this.URLInput.Name = "URLInput";
            this.URLInput.Size = new System.Drawing.Size(415, 23);
            this.URLInput.TabIndex = 6;
            this.URLInput.Text = "http://";
            this.URLInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLInput_KeyDown);
            // 
            // makeHomePage
            // 
            this.makeHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeHomePage.Image = global::JustBrowse.Properties.Resources.newHopePage;
            this.makeHomePage.Location = new System.Drawing.Point(611, 3);
            this.makeHomePage.Name = "makeHomePage";
            this.makeHomePage.Size = new System.Drawing.Size(34, 23);
            this.makeHomePage.TabIndex = 7;
            this.buttonTip.SetToolTip(this.makeHomePage, "Make this page default home page");
            this.makeHomePage.UseVisualStyleBackColor = true;
            this.makeHomePage.Click += new System.EventHandler(this.makeHomePage_Click);
            // 
            // homePage
            // 
            this.homePage.Image = global::JustBrowse.Properties.Resources.home_512;
            this.homePage.Location = new System.Drawing.Point(122, 3);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(34, 23);
            this.homePage.TabIndex = 4;
            this.buttonTip.SetToolTip(this.homePage, "Go to home page");
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // refresh
            // 
            this.refresh.Image = global::JustBrowse.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(82, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(34, 23);
            this.refresh.TabIndex = 3;
            this.buttonTip.SetToolTip(this.refresh, "Refresh this page");
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // forward
            // 
            this.forward.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.forward.Image = global::JustBrowse.Properties.Resources.forward;
            this.forward.Location = new System.Drawing.Point(42, 3);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(34, 23);
            this.forward.TabIndex = 2;
            this.buttonTip.SetToolTip(this.forward, "Go to the next page");
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.Image = global::JustBrowse.Properties.Resources.back1;
            this.back.Location = new System.Drawing.Point(2, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 1;
            this.buttonTip.SetToolTip(this.back, "Go to the previus page");
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(2, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(717, 335);
            this.tabControl.TabIndex = 9;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar.Location = new System.Drawing.Point(581, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(24, 23);
            this.progressBar.TabIndex = 12;
            // 
            // JustBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 367);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.makeHomePage);
            this.Controls.Add(this.URLInput);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JustBrowse";
            this.Text = "JBrowse";
            this.Load += new System.EventHandler(this.JustBrowse_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.JustBrowse_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.TextBox URLInput;
        private System.Windows.Forms.Button makeHomePage;
        private System.Windows.Forms.ToolTip buttonTip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

