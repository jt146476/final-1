namespace AbandonedHouse
{
    partial class LocationInHouse
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
            this.lbl_bodies = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_basement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_bodies
            // 
            this.lbl_bodies.AutoSize = true;
            this.lbl_bodies.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_bodies.Location = new System.Drawing.Point(240, 171);
            this.lbl_bodies.Name = "lbl_bodies";
            this.lbl_bodies.Size = new System.Drawing.Size(321, 39);
            this.lbl_bodies.TabIndex = 5;
            this.lbl_bodies.Text = "You have heard rumors about kids who have died in that house, \r\nthier bodies have" +
    " been hidden in the basement. You really want to \r\nexplore the entire house thou" +
    "gh. What do you choose? ";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Clear.Location = new System.Drawing.Point(454, 246);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(123, 64);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Stay clear and go upstairs";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_basement
            // 
            this.btn_basement.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_basement.Location = new System.Drawing.Point(227, 246);
            this.btn_basement.Name = "btn_basement";
            this.btn_basement.Size = new System.Drawing.Size(115, 64);
            this.btn_basement.TabIndex = 3;
            this.btn_basement.Text = "Go explore the basement ";
            this.btn_basement.UseVisualStyleBackColor = false;
            this.btn_basement.Click += new System.EventHandler(this.btn_basement_Click);
            // 
            // LocationInHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AbandonedHouse.Properties.Resources.LocationInHouse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_bodies);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_basement);
            this.Name = "LocationInHouse";
            this.Text = "LocationInHouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bodies;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_basement;
    }
}