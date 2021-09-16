
namespace assigment
{
    partial class find
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
            this.find_button = new System.Windows.Forms.Button();
            this.find_box = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(37, 133);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(75, 23);
            this.find_button.TabIndex = 0;
            this.find_button.Text = "find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_Click);
            // 
            // find_box
            // 
            this.find_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_box.Location = new System.Drawing.Point(134, 75);
            this.find_box.Name = "find_box";
            this.find_box.Size = new System.Drawing.Size(120, 13);
            this.find_box.TabIndex = 2;
            this.find_box.TextChanged += new System.EventHandler(this.find_TextChanged);
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(31, 59);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(97, 33);
            this.send.TabIndex = 3;
            this.send.Text = "Name";
            // 
            // find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(274, 247);
            this.Controls.Add(this.send);
            this.Controls.Add(this.find_box);
            this.Controls.Add(this.find_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(290, 286);
            this.MinimumSize = new System.Drawing.Size(290, 286);
            this.Name = "find";
            this.Text = "find";
            this.Load += new System.EventHandler(this.find_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.TextBox find_box;
        private System.Windows.Forms.Label send;
    }
}