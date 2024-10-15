
namespace Week_5_Sec
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
            this.Input_textBox = new System.Windows.Forms.TextBox();
            this.Mode_label = new System.Windows.Forms.Label();
            this.Submit_button = new System.Windows.Forms.Button();
            this.Output_textBox = new System.Windows.Forms.TextBox();
            this.Info_Encryption_Mode = new System.Windows.Forms.Label();
            this.combo_Box_Mode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Input_textBox
            // 
            this.Input_textBox.Location = new System.Drawing.Point(270, 150);
            this.Input_textBox.Name = "Input_textBox";
            this.Input_textBox.Size = new System.Drawing.Size(329, 22);
            this.Input_textBox.TabIndex = 0;
            // 
            // Mode_label
            // 
            this.Mode_label.AutoSize = true;
            this.Mode_label.Location = new System.Drawing.Point(267, 130);
            this.Mode_label.Name = "Mode_label";
            this.Mode_label.Size = new System.Drawing.Size(218, 17);
            this.Mode_label.TabIndex = 2;
            this.Mode_label.Text = "Encryption with Base64 Encoding";
            // 
            // Submit_button
            // 
            this.Submit_button.Location = new System.Drawing.Point(270, 266);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(75, 23);
            this.Submit_button.TabIndex = 4;
            this.Submit_button.Text = "Submit";
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Output_textBox
            // 
            this.Output_textBox.Location = new System.Drawing.Point(270, 229);
            this.Output_textBox.Name = "Output_textBox";
            this.Output_textBox.Size = new System.Drawing.Size(329, 22);
            this.Output_textBox.TabIndex = 6;
            // 
            // Info_Encryption_Mode
            // 
            this.Info_Encryption_Mode.AutoSize = true;
            this.Info_Encryption_Mode.Location = new System.Drawing.Point(267, 209);
            this.Info_Encryption_Mode.Name = "Info_Encryption_Mode";
            this.Info_Encryption_Mode.Size = new System.Drawing.Size(215, 17);
            this.Info_Encryption_Mode.TabIndex = 8;
            this.Info_Encryption_Mode.Text = "Encrypted with Base64 Encoding";
            // 
            // combo_Box_Mode
            // 
            this.combo_Box_Mode.FormattingEnabled = true;
            this.combo_Box_Mode.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.combo_Box_Mode.SelectedIndex = 0;
            this.combo_Box_Mode.Location = new System.Drawing.Point(478, 266);
            this.combo_Box_Mode.Name = "combo_Box_Mode";
            this.combo_Box_Mode.Size = new System.Drawing.Size(121, 24);
            this.combo_Box_Mode.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 462);
            this.Controls.Add(this.combo_Box_Mode);
            this.Controls.Add(this.Info_Encryption_Mode);
            this.Controls.Add(this.Output_textBox);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.Mode_label);
            this.Controls.Add(this.Input_textBox);
            this.Name = "Form1";
            this.Text = "Encryptie Opdracht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_textBox;
        private System.Windows.Forms.Label Mode_label;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.TextBox Output_textBox;
        private System.Windows.Forms.Label Info_Encryption_Mode;
        private System.Windows.Forms.ComboBox combo_Box_Mode;
    }
}

