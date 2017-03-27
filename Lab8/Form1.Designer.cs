namespace Lab8
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
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.Miles_Text = new System.Windows.Forms.TextBox();
            this.Trip_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(95, 202);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(100, 46);
            this.Calculate_Button.TabIndex = 0;
            this.Calculate_Button.Text = "Calculate";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // Miles_Text
            // 
            this.Miles_Text.Location = new System.Drawing.Point(95, 124);
            this.Miles_Text.Name = "Miles_Text";
            this.Miles_Text.Size = new System.Drawing.Size(98, 26);
            this.Miles_Text.TabIndex = 1;
            // 
            // Trip_Label
            // 
            this.Trip_Label.AutoSize = true;
            this.Trip_Label.Location = new System.Drawing.Point(91, 59);
            this.Trip_Label.Name = "Trip_Label";
            this.Trip_Label.Size = new System.Drawing.Size(102, 20);
            this.Trip_Label.TabIndex = 2;
            this.Trip_Label.Text = "Trip Distance";
            // 
            // Form1
            // 
            this.AcceptButton = this.Calculate_Button;
            this.AccessibleDescription = "lab";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 290);
            this.Controls.Add(this.Trip_Label);
            this.Controls.Add(this.Miles_Text);
            this.Controls.Add(this.Calculate_Button);
            this.Name = "Form1";
            this.Text = "Lab8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.TextBox Miles_Text;
        private System.Windows.Forms.Label Trip_Label;
    }
}

