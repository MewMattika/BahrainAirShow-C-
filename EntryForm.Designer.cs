namespace BahrainAirshow
{
    partial class EntryForm
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
            this.button_Next = new System.Windows.Forms.Button();
            this.groupBox_StatusSelect = new System.Windows.Forms.GroupBox();
            this.radioButton_Visitors = new System.Windows.Forms.RadioButton();
            this.radioButton_Exhibitors = new System.Windows.Forms.RadioButton();
            this.radioButton_Organizers = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_StatusSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(353, 438);
            this.button_Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(89, 35);
            this.button_Next.TabIndex = 5;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // groupBox_StatusSelect
            // 
            this.groupBox_StatusSelect.Controls.Add(this.radioButton_Visitors);
            this.groupBox_StatusSelect.Controls.Add(this.radioButton_Exhibitors);
            this.groupBox_StatusSelect.Controls.Add(this.radioButton_Organizers);
            this.groupBox_StatusSelect.Location = new System.Drawing.Point(143, 225);
            this.groupBox_StatusSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_StatusSelect.Name = "groupBox_StatusSelect";
            this.groupBox_StatusSelect.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_StatusSelect.Size = new System.Drawing.Size(202, 170);
            this.groupBox_StatusSelect.TabIndex = 4;
            this.groupBox_StatusSelect.TabStop = false;
            this.groupBox_StatusSelect.Text = "Please Select Your Entrey Type";
            // 
            // radioButton_Visitors
            // 
            this.radioButton_Visitors.AutoSize = true;
            this.radioButton_Visitors.Location = new System.Drawing.Point(20, 113);
            this.radioButton_Visitors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Visitors.Name = "radioButton_Visitors";
            this.radioButton_Visitors.Size = new System.Drawing.Size(68, 20);
            this.radioButton_Visitors.TabIndex = 2;
            this.radioButton_Visitors.TabStop = true;
            this.radioButton_Visitors.Text = "Visitors";
            this.radioButton_Visitors.UseVisualStyleBackColor = true;
            // 
            // radioButton_Exhibitors
            // 
            this.radioButton_Exhibitors.AutoSize = true;
            this.radioButton_Exhibitors.Location = new System.Drawing.Point(20, 78);
            this.radioButton_Exhibitors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Exhibitors.Name = "radioButton_Exhibitors";
            this.radioButton_Exhibitors.Size = new System.Drawing.Size(81, 20);
            this.radioButton_Exhibitors.TabIndex = 1;
            this.radioButton_Exhibitors.TabStop = true;
            this.radioButton_Exhibitors.Text = "Exhibitors";
            this.radioButton_Exhibitors.UseVisualStyleBackColor = true;
            this.radioButton_Exhibitors.CheckedChanged += new System.EventHandler(this.radioButton_Exhibitors_CheckedChanged);
            // 
            // radioButton_Organizers
            // 
            this.radioButton_Organizers.AutoSize = true;
            this.radioButton_Organizers.Location = new System.Drawing.Point(20, 43);
            this.radioButton_Organizers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Organizers.Name = "radioButton_Organizers";
            this.radioButton_Organizers.Size = new System.Drawing.Size(88, 20);
            this.radioButton_Organizers.TabIndex = 0;
            this.radioButton_Organizers.TabStop = true;
            this.radioButton_Organizers.Text = "Organizers";
            this.radioButton_Organizers.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BahrainAirshow.Properties.Resources.bannery1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 545);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.groupBox_StatusSelect);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.groupBox_StatusSelect.ResumeLayout(false);
            this.groupBox_StatusSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.GroupBox groupBox_StatusSelect;
        private System.Windows.Forms.RadioButton radioButton_Visitors;
        private System.Windows.Forms.RadioButton radioButton_Exhibitors;
        private System.Windows.Forms.RadioButton radioButton_Organizers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}