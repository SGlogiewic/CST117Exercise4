namespace CST117Exercise4
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5_secondsToMinutes = new System.Windows.Forms.Label();
            this.label6_secondsToHours = new System.Windows.Forms.Label();
            this.label7_secondsToDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter any amount of seconds as a whole number:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seconds to minutes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seconds to hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seconds to days:";
            // 
            // label5_secondsToMinutes
            // 
            this.label5_secondsToMinutes.AutoSize = true;
            this.label5_secondsToMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_secondsToMinutes.Location = new System.Drawing.Point(421, 252);
            this.label5_secondsToMinutes.Name = "label5_secondsToMinutes";
            this.label5_secondsToMinutes.Size = new System.Drawing.Size(195, 22);
            this.label5_secondsToMinutes.TabIndex = 6;
            this.label5_secondsToMinutes.Text = "x seconds is x minutes.";
            this.label5_secondsToMinutes.Click += new System.EventHandler(this.label5_secondsToMinutes_Click);
            // 
            // label6_secondsToHours
            // 
            this.label6_secondsToHours.AutoSize = true;
            this.label6_secondsToHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_secondsToHours.Location = new System.Drawing.Point(421, 300);
            this.label6_secondsToHours.Name = "label6_secondsToHours";
            this.label6_secondsToHours.Size = new System.Drawing.Size(173, 22);
            this.label6_secondsToHours.TabIndex = 7;
            this.label6_secondsToHours.Text = "x seconds is x hours";
            this.label6_secondsToHours.Click += new System.EventHandler(this.label6_secondsToHours_Click);
            // 
            // label7_secondsToDays
            // 
            this.label7_secondsToDays.AutoSize = true;
            this.label7_secondsToDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_secondsToDays.Location = new System.Drawing.Point(421, 345);
            this.label7_secondsToDays.Name = "label7_secondsToDays";
            this.label7_secondsToDays.Size = new System.Drawing.Size(166, 22);
            this.label7_secondsToDays.TabIndex = 8;
            this.label7_secondsToDays.Text = "x seconds is x days";
            this.label7_secondsToDays.Click += new System.EventHandler(this.label7_secondsToDays_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.label7_secondsToDays);
            this.Controls.Add(this.label6_secondsToHours);
            this.Controls.Add(this.label5_secondsToMinutes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5_secondsToMinutes;
        private System.Windows.Forms.Label label6_secondsToHours;
        private System.Windows.Forms.Label label7_secondsToDays;
    }
}

