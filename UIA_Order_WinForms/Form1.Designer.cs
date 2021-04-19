
namespace UIA_Order_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.labelFourth = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxThird = new System.Windows.Forms.TextBox();
            this.textBoxFourth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please fill in the form.";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(13, 88);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(56, 30);
            this.labelFirst.TabIndex = 1;
            this.labelFirst.Text = "&First:";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(117, 88);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(175, 35);
            this.textBoxFirst.TabIndex = 2;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(13, 157);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(86, 30);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "&Second:";
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Location = new System.Drawing.Point(13, 220);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(60, 30);
            this.labelThird.TabIndex = 4;
            this.labelThird.Text = "&Third";
            // 
            // labelFourth
            // 
            this.labelFourth.AutoSize = true;
            this.labelFourth.Location = new System.Drawing.Point(13, 282);
            this.labelFourth.Name = "labelFourth";
            this.labelFourth.Size = new System.Drawing.Size(78, 30);
            this.labelFourth.TabIndex = 5;
            this.labelFourth.Text = "F&ourth:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(657, 398);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(131, 40);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(117, 152);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(175, 35);
            this.textBoxSecond.TabIndex = 6;
            // 
            // textBoxThird
            // 
            this.textBoxThird.Location = new System.Drawing.Point(117, 215);
            this.textBoxThird.Name = "textBoxThird";
            this.textBoxThird.Size = new System.Drawing.Size(175, 35);
            this.textBoxThird.TabIndex = 7;
            // 
            // textBoxFourth
            // 
            this.textBoxFourth.Location = new System.Drawing.Point(117, 277);
            this.textBoxFourth.Name = "textBoxFourth";
            this.textBoxFourth.Size = new System.Drawing.Size(175, 35);
            this.textBoxFourth.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxFourth);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxThird);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelFourth);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelThird;
        private System.Windows.Forms.Label labelFourth;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxThird;
        private System.Windows.Forms.TextBox textBoxFourth;
    }
}

