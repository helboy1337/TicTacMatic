﻿namespace TicTacMatic
{
    partial class TicTacMatic
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
            this.field1 = new System.Windows.Forms.PictureBox();
            this.field2 = new System.Windows.Forms.PictureBox();
            this.field3 = new System.Windows.Forms.PictureBox();
            this.field4 = new System.Windows.Forms.PictureBox();
            this.field5 = new System.Windows.Forms.PictureBox();
            this.field6 = new System.Windows.Forms.PictureBox();
            this.field7 = new System.Windows.Forms.PictureBox();
            this.field8 = new System.Windows.Forms.PictureBox();
            this.field9 = new System.Windows.Forms.PictureBox();
            this.botTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.field1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field9)).BeginInit();
            this.SuspendLayout();
            // 
            // field1
            // 
            this.field1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field1.Location = new System.Drawing.Point(12, 12);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(75, 75);
            this.field1.TabIndex = 0;
            this.field1.TabStop = false;
            this.field1.Click += new System.EventHandler(this.Play);
            // 
            // field2
            // 
            this.field2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field2.Location = new System.Drawing.Point(93, 12);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(75, 75);
            this.field2.TabIndex = 1;
            this.field2.TabStop = false;
            this.field2.Click += new System.EventHandler(this.Play);
            // 
            // field3
            // 
            this.field3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field3.Location = new System.Drawing.Point(174, 12);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(75, 75);
            this.field3.TabIndex = 2;
            this.field3.TabStop = false;
            this.field3.Click += new System.EventHandler(this.Play);
            // 
            // field4
            // 
            this.field4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field4.Location = new System.Drawing.Point(12, 93);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(75, 75);
            this.field4.TabIndex = 3;
            this.field4.TabStop = false;
            this.field4.Click += new System.EventHandler(this.Play);
            // 
            // field5
            // 
            this.field5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field5.Location = new System.Drawing.Point(93, 93);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(75, 75);
            this.field5.TabIndex = 4;
            this.field5.TabStop = false;
            this.field5.Click += new System.EventHandler(this.Play);
            // 
            // field6
            // 
            this.field6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field6.Location = new System.Drawing.Point(174, 93);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(75, 75);
            this.field6.TabIndex = 5;
            this.field6.TabStop = false;
            this.field6.Click += new System.EventHandler(this.Play);
            // 
            // field7
            // 
            this.field7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field7.Location = new System.Drawing.Point(12, 174);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(75, 75);
            this.field7.TabIndex = 6;
            this.field7.TabStop = false;
            this.field7.Click += new System.EventHandler(this.Play);
            // 
            // field8
            // 
            this.field8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field8.Location = new System.Drawing.Point(93, 174);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(75, 75);
            this.field8.TabIndex = 7;
            this.field8.TabStop = false;
            this.field8.Click += new System.EventHandler(this.Play);
            // 
            // field9
            // 
            this.field9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field9.Location = new System.Drawing.Point(174, 174);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(75, 75);
            this.field9.TabIndex = 8;
            this.field9.TabStop = false;
            this.field9.Click += new System.EventHandler(this.Play);
            // 
            // botTimer
            // 
            this.botTimer.Interval = 1000;
            this.botTimer.Tick += new System.EventHandler(this.botTimer_Tick);
            // 
            // TicTacMatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 261);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Name = "TicTacMatic";
            this.Text = "TicTacMatic";
            this.Load += new System.EventHandler(this.TicTacMatic_Load);
            this.Click += new System.EventHandler(this.TicTacToe_Click);
            ((System.ComponentModel.ISupportInitialize)(this.field1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox field1;
        private System.Windows.Forms.PictureBox field2;
        private System.Windows.Forms.PictureBox field3;
        private System.Windows.Forms.PictureBox field4;
        private System.Windows.Forms.PictureBox field5;
        private System.Windows.Forms.PictureBox field6;
        private System.Windows.Forms.PictureBox field7;
        private System.Windows.Forms.PictureBox field8;
        private System.Windows.Forms.PictureBox field9;
        private System.Windows.Forms.Timer botTimer;
    }
}

