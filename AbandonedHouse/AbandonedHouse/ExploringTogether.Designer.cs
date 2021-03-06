﻿namespace AbandonedHouse
{
    partial class ExploringTogether
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
            this.btn_Stay = new System.Windows.Forms.Button();
            this.btn_Split = new System.Windows.Forms.Button();
            this.lbl_PhoneLight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Stay
            // 
            this.btn_Stay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Stay.Location = new System.Drawing.Point(215, 222);
            this.btn_Stay.Name = "btn_Stay";
            this.btn_Stay.Size = new System.Drawing.Size(112, 70);
            this.btn_Stay.TabIndex = 0;
            this.btn_Stay.Text = "Stay together and explore";
            this.btn_Stay.UseVisualStyleBackColor = false;
            this.btn_Stay.Click += new System.EventHandler(this.btn_Stay_Click);
            // 
            // btn_Split
            // 
            this.btn_Split.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Split.Location = new System.Drawing.Point(64, 216);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(98, 76);
            this.btn_Split.TabIndex = 1;
            this.btn_Split.Text = "Split up and explore";
            this.btn_Split.UseVisualStyleBackColor = false;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // lbl_PhoneLight
            // 
            this.lbl_PhoneLight.AutoSize = true;
            this.lbl_PhoneLight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_PhoneLight.Location = new System.Drawing.Point(73, 127);
            this.lbl_PhoneLight.Name = "lbl_PhoneLight";
            this.lbl_PhoneLight.Size = new System.Drawing.Size(215, 13);
            this.lbl_PhoneLight.TabIndex = 2;
            this.lbl_PhoneLight.Text = "You are good with little phone light. Do you..";
            this.lbl_PhoneLight.Click += new System.EventHandler(this.lbl_PhoneLight_Click);
            // 
            // ExploringTogether
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AbandonedHouse.Properties.Resources.LocationInHouse;
            this.ClientSize = new System.Drawing.Size(398, 408);
            this.Controls.Add(this.lbl_PhoneLight);
            this.Controls.Add(this.btn_Split);
            this.Controls.Add(this.btn_Stay);
            this.Name = "ExploringTogether";
            this.Text = "ExploringTogether";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Stay;
        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.Label lbl_PhoneLight;
    }
}