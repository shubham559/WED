namespace WED
{
    partial class Lab_08Form
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
            this.Title_Label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Age_Text_Box = new System.Windows.Forms.TextBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Info_Group_Box = new System.Windows.Forms.GroupBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Output_Label = new System.Windows.Forms.Label();
            this.Info_Group_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(12, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(123, 37);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "LAB 08";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(6, 44);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(168, 31);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Your Name:";
            // 
            // Name_Text_Box
            // 
            this.Name_Text_Box.Location = new System.Drawing.Point(180, 37);
            this.Name_Text_Box.Name = "Name_Text_Box";
            this.Name_Text_Box.Size = new System.Drawing.Size(144, 38);
            this.Name_Text_Box.TabIndex = 2;
            this.Name_Text_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Age_Text_Box
            // 
            this.Age_Text_Box.Location = new System.Drawing.Point(180, 95);
            this.Age_Text_Box.Name = "Age_Text_Box";
            this.Age_Text_Box.Size = new System.Drawing.Size(144, 38);
            this.Age_Text_Box.TabIndex = 4;
            this.Age_Text_Box.TextChanged += new System.EventHandler(this.Age_Text_Box_TextChanged);
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Label.Location = new System.Drawing.Point(16, 102);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(143, 31);
            this.Age_Label.TabIndex = 3;
            this.Age_Label.Text = "Your Age:";
            // 
            // Info_Group_Box
            // 
            this.Info_Group_Box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Info_Group_Box.Controls.Add(this.Name_label);
            this.Info_Group_Box.Controls.Add(this.Age_Text_Box);
            this.Info_Group_Box.Controls.Add(this.Name_Text_Box);
            this.Info_Group_Box.Controls.Add(this.Age_Label);
            this.Info_Group_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_Group_Box.Location = new System.Drawing.Point(12, 67);
            this.Info_Group_Box.Name = "Info_Group_Box";
            this.Info_Group_Box.Size = new System.Drawing.Size(465, 234);
            this.Info_Group_Box.TabIndex = 5;
            this.Info_Group_Box.TabStop = false;
            this.Info_Group_Box.Text = "Info";
            // 
            // Submit_Button
            // 
            this.Submit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.Location = new System.Drawing.Point(221, 350);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(115, 40);
            this.Submit_Button.TabIndex = 5;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Output_Label
            // 
            this.Output_Label.AutoSize = true;
            this.Output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Label.Location = new System.Drawing.Point(18, 359);
            this.Output_Label.Name = "Output_Label";
            this.Output_Label.Size = new System.Drawing.Size(0, 31);
            this.Output_Label.TabIndex = 6;
            // 
            // Lab_08Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Output_Label);
            this.Controls.Add(this.Info_Group_Box);
            this.Controls.Add(this.Title_Label);
            this.Name = "Lab_08Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_08";
            this.Load += new System.EventHandler(this.Lab_08Form_Load);
            this.Info_Group_Box.ResumeLayout(false);
            this.Info_Group_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Name_Text_Box;
        private System.Windows.Forms.TextBox Age_Text_Box;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.GroupBox Info_Group_Box;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label Output_Label;
    }
}

