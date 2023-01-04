namespace BahrainAirshow
{
    partial class ExhibitorsForm
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
            this.groupBox_SelectBooth = new System.Windows.Forms.GroupBox();
            this.radioButton_CornerBooth = new System.Windows.Forms.RadioButton();
            this.radioButton_LBooth = new System.Windows.Forms.RadioButton();
            this.radioButton_SBooth = new System.Windows.Forms.RadioButton();
            this.radioButton_MBooth = new System.Windows.Forms.RadioButton();
            this.label_Descrip = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_ClearDisc = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_Show = new System.Windows.Forms.Button();
            this.radioButton_Military = new System.Windows.Forms.RadioButton();
            this.radioButton_Commercial = new System.Windows.Forms.RadioButton();
            this.button_Done = new System.Windows.Forms.Button();
            this.groupBox_SelectBooth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SelectBooth
            // 
            this.groupBox_SelectBooth.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_SelectBooth.Controls.Add(this.radioButton_CornerBooth);
            this.groupBox_SelectBooth.Controls.Add(this.radioButton_LBooth);
            this.groupBox_SelectBooth.Controls.Add(this.radioButton_SBooth);
            this.groupBox_SelectBooth.Controls.Add(this.radioButton_MBooth);
            this.groupBox_SelectBooth.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SelectBooth.ForeColor = System.Drawing.Color.Navy;
            this.groupBox_SelectBooth.Location = new System.Drawing.Point(49, 144);
            this.groupBox_SelectBooth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_SelectBooth.Name = "groupBox_SelectBooth";
            this.groupBox_SelectBooth.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_SelectBooth.Size = new System.Drawing.Size(586, 164);
            this.groupBox_SelectBooth.TabIndex = 8;
            this.groupBox_SelectBooth.TabStop = false;
            this.groupBox_SelectBooth.Text = "Select a Booth to Exhibit your Products";
            // 
            // radioButton_CornerBooth
            // 
            this.radioButton_CornerBooth.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_CornerBooth.AutoSize = true;
            this.radioButton_CornerBooth.Image = global::BahrainAirshow.Properties.Resources.BoothCorner;
            this.radioButton_CornerBooth.Location = new System.Drawing.Point(27, 26);
            this.radioButton_CornerBooth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_CornerBooth.Name = "radioButton_CornerBooth";
            this.radioButton_CornerBooth.Size = new System.Drawing.Size(106, 129);
            this.radioButton_CornerBooth.TabIndex = 8;
            this.radioButton_CornerBooth.Text = "200 BD";
            this.radioButton_CornerBooth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_CornerBooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton_CornerBooth.UseVisualStyleBackColor = true;
            // 
            // radioButton_LBooth
            // 
            this.radioButton_LBooth.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_LBooth.AutoSize = true;
            this.radioButton_LBooth.Image = global::BahrainAirshow.Properties.Resources.BoothL;
            this.radioButton_LBooth.Location = new System.Drawing.Point(168, 26);
            this.radioButton_LBooth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_LBooth.Name = "radioButton_LBooth";
            this.radioButton_LBooth.Size = new System.Drawing.Size(106, 129);
            this.radioButton_LBooth.TabIndex = 5;
            this.radioButton_LBooth.Text = "150 BD";
            this.radioButton_LBooth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_LBooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton_LBooth.UseVisualStyleBackColor = true;
            this.radioButton_LBooth.CheckedChanged += new System.EventHandler(this.radioButton_LBooth_CheckedChanged);
            // 
            // radioButton_SBooth
            // 
            this.radioButton_SBooth.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_SBooth.AutoSize = true;
            this.radioButton_SBooth.Image = global::BahrainAirshow.Properties.Resources.BoothS;
            this.radioButton_SBooth.Location = new System.Drawing.Point(450, 26);
            this.radioButton_SBooth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_SBooth.Name = "radioButton_SBooth";
            this.radioButton_SBooth.Size = new System.Drawing.Size(106, 129);
            this.radioButton_SBooth.TabIndex = 7;
            this.radioButton_SBooth.Text = "50 BD";
            this.radioButton_SBooth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_SBooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton_SBooth.UseVisualStyleBackColor = true;
            this.radioButton_SBooth.CheckedChanged += new System.EventHandler(this.radioButton_SBooth_CheckedChanged);
            // 
            // radioButton_MBooth
            // 
            this.radioButton_MBooth.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_MBooth.AutoSize = true;
            this.radioButton_MBooth.Image = global::BahrainAirshow.Properties.Resources.BoothM;
            this.radioButton_MBooth.Location = new System.Drawing.Point(309, 26);
            this.radioButton_MBooth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_MBooth.Name = "radioButton_MBooth";
            this.radioButton_MBooth.Size = new System.Drawing.Size(106, 129);
            this.radioButton_MBooth.TabIndex = 6;
            this.radioButton_MBooth.Text = "100 BD";
            this.radioButton_MBooth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_MBooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton_MBooth.UseVisualStyleBackColor = true;
            this.radioButton_MBooth.CheckedChanged += new System.EventHandler(this.radioButton_MBooth_CheckedChanged);
            // 
            // label_Descrip
            // 
            this.label_Descrip.BackColor = System.Drawing.Color.AliceBlue;
            this.label_Descrip.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descrip.ForeColor = System.Drawing.Color.Navy;
            this.label_Descrip.Location = new System.Drawing.Point(47, 391);
            this.label_Descrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Descrip.Name = "label_Descrip";
            this.label_Descrip.Size = new System.Drawing.Size(371, 58);
            this.label_Descrip.TabIndex = 9;
            this.label_Descrip.Text = "If You Got a Show Request Please Select the Type of your show and then Add Descri" +
    "ption and Feature of your OutDoor Show:";
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Description.Location = new System.Drawing.Point(49, 456);
            this.textBox_Description.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(586, 113);
            this.textBox_Description.TabIndex = 10;
            this.textBox_Description.TextChanged += new System.EventHandler(this.textBox_Description_TextChanged);
            // 
            // button_ClearDisc
            // 
            this.button_ClearDisc.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearDisc.ForeColor = System.Drawing.Color.Navy;
            this.button_ClearDisc.Location = new System.Drawing.Point(49, 582);
            this.button_ClearDisc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_ClearDisc.Name = "button_ClearDisc";
            this.button_ClearDisc.Size = new System.Drawing.Size(104, 35);
            this.button_ClearDisc.TabIndex = 12;
            this.button_ClearDisc.Text = "Clear";
            this.button_ClearDisc.UseVisualStyleBackColor = true;
            this.button_ClearDisc.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Image = global::BahrainAirshow.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(195, 0);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(323, 102);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 4;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.ForeColor = System.Drawing.Color.Navy;
            this.button_Show.Location = new System.Drawing.Point(489, 582);
            this.button_Show.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(134, 35);
            this.button_Show.TabIndex = 13;
            this.button_Show.Text = "Show AirCrafts";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // radioButton_Military
            // 
            this.radioButton_Military.AutoSize = true;
            this.radioButton_Military.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Military.Font = new System.Drawing.Font("Arial", 10F);
            this.radioButton_Military.ForeColor = System.Drawing.Color.Navy;
            this.radioButton_Military.Location = new System.Drawing.Point(435, 413);
            this.radioButton_Military.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Military.Name = "radioButton_Military";
            this.radioButton_Military.Size = new System.Drawing.Size(75, 22);
            this.radioButton_Military.TabIndex = 15;
            this.radioButton_Military.TabStop = true;
            this.radioButton_Military.Text = "Military";
            this.radioButton_Military.UseVisualStyleBackColor = false;
            // 
            // radioButton_Commercial
            // 
            this.radioButton_Commercial.AutoSize = true;
            this.radioButton_Commercial.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Commercial.Font = new System.Drawing.Font("Arial", 10F);
            this.radioButton_Commercial.ForeColor = System.Drawing.Color.Navy;
            this.radioButton_Commercial.Location = new System.Drawing.Point(532, 413);
            this.radioButton_Commercial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Commercial.Name = "radioButton_Commercial";
            this.radioButton_Commercial.Size = new System.Drawing.Size(111, 22);
            this.radioButton_Commercial.TabIndex = 16;
            this.radioButton_Commercial.TabStop = true;
            this.radioButton_Commercial.Text = "Commercial";
            this.radioButton_Commercial.UseVisualStyleBackColor = false;
            // 
            // button_Done
            // 
            this.button_Done.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Done.ForeColor = System.Drawing.Color.Navy;
            this.button_Done.Location = new System.Drawing.Point(258, 327);
            this.button_Done.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(158, 35);
            this.button_Done.TabIndex = 17;
            this.button_Done.Text = "Approve on Selected";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // ExhibitorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::BahrainAirshow.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 640);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.radioButton_Commercial);
            this.Controls.Add(this.radioButton_Military);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_ClearDisc);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Descrip);
            this.Controls.Add(this.groupBox_SelectBooth);
            this.Controls.Add(this.pictureBox_Logo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ExhibitorsForm";
            this.Text = "ExhibitorsForm";
            this.Load += new System.EventHandler(this.ExhibitorsForm_Load);
            this.groupBox_SelectBooth.ResumeLayout(false);
            this.groupBox_SelectBooth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.GroupBox groupBox_SelectBooth;
        private System.Windows.Forms.Label label_Descrip;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Button button_ClearDisc;
        public System.Windows.Forms.RadioButton radioButton_LBooth;
        public System.Windows.Forms.RadioButton radioButton_MBooth;
        public System.Windows.Forms.RadioButton radioButton_SBooth;
        public System.Windows.Forms.RadioButton radioButton_CornerBooth;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.RadioButton radioButton_Military;
        private System.Windows.Forms.RadioButton radioButton_Commercial;
        private System.Windows.Forms.Button button_Done;
    }
}