﻿namespace RandomNumbGuess
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
            this.inputLB = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.highlowLB = new System.Windows.Forms.Label();
            this.guessBUT = new System.Windows.Forms.Button();
            this.numberBUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLB
            // 
            this.inputLB.AutoSize = true;
            this.inputLB.Location = new System.Drawing.Point(13, 4);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(113, 13);
            this.inputLB.TabIndex = 0;
            this.inputLB.Text = "Input a Number: 0-100";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(16, 21);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(100, 20);
            this.inputTB.TabIndex = 1;
            // 
            // highlowLB
            // 
            this.highlowLB.AutoSize = true;
            this.highlowLB.Location = new System.Drawing.Point(122, 21);
            this.highlowLB.Name = "highlowLB";
            this.highlowLB.Size = new System.Drawing.Size(82, 13);
            this.highlowLB.TabIndex = 2;
            this.highlowLB.Text = "Higher or Lower";
            // 
            // guessBUT
            // 
            this.guessBUT.Location = new System.Drawing.Point(28, 47);
            this.guessBUT.Name = "guessBUT";
            this.guessBUT.Size = new System.Drawing.Size(75, 23);
            this.guessBUT.TabIndex = 3;
            this.guessBUT.Text = "Guess!";
            this.guessBUT.UseVisualStyleBackColor = true;
            this.guessBUT.Click += new System.EventHandler(this.guessBUT_Click);
            // 
            // numberBUT
            // 
            this.numberBUT.Location = new System.Drawing.Point(125, 47);
            this.numberBUT.Name = "numberBUT";
            this.numberBUT.Size = new System.Drawing.Size(75, 23);
            this.numberBUT.TabIndex = 4;
            this.numberBUT.Text = "Reveal";
            this.numberBUT.UseVisualStyleBackColor = true;
            this.numberBUT.Click += new System.EventHandler(this.numberBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 101);
            this.Controls.Add(this.numberBUT);
            this.Controls.Add(this.guessBUT);
            this.Controls.Add(this.highlowLB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.inputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLB;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label highlowLB;
        private System.Windows.Forms.Button guessBUT;
        private System.Windows.Forms.Button numberBUT;
    }
}

