namespace BahrainAirshow
{
    partial class Beginning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beginning));
            this.button_Continue = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer_AirShow = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer_AirShow)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Continue
            // 
            resources.ApplyResources(this.button_Continue, "button_Continue");
            this.button_Continue.BackColor = System.Drawing.Color.Black;
            this.button_Continue.BackgroundImage = global::BahrainAirshow.Properties.Resources.continue_button1;
            this.button_Continue.FlatAppearance.BorderSize = 0;
            this.button_Continue.ForeColor = System.Drawing.Color.White;
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.UseVisualStyleBackColor = false;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // WindowsMediaPlayer_AirShow
            // 
            resources.ApplyResources(this.WindowsMediaPlayer_AirShow, "WindowsMediaPlayer_AirShow");
            this.WindowsMediaPlayer_AirShow.Name = "WindowsMediaPlayer_AirShow";
            this.WindowsMediaPlayer_AirShow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer_AirShow.OcxState")));
            // 
            // Beginning
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WindowsMediaPlayer_AirShow);
            this.Controls.Add(this.button_Continue);
            this.Name = "Beginning";
            this.Load += new System.EventHandler(this.Beginning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer_AirShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Continue;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer_AirShow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

