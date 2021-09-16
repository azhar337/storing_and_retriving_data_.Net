
namespace assigment
{
    partial class delete
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
            this.del_button = new System.Windows.Forms.Button();
            this.del_box = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(37, 133);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 23);
            this.del_button.TabIndex = 0;
            this.del_button.Text = "delete";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // del_box
            // 
            this.del_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.del_box.Location = new System.Drawing.Point(110, 75);
            this.del_box.Name = "del_box";
            this.del_box.Size = new System.Drawing.Size(120, 13);
            this.del_box.TabIndex = 2;
            this.del_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.del.Text = "MCT";
            // 
            // del
            // 
            this.del.AutoSize = true;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(31, 59);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(46, 33);
            this.del.TabIndex = 3;
            this.del.Text = "ID";
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(274, 247);
            this.Controls.Add(this.del);
            this.Controls.Add(this.del_box);
            this.Controls.Add(this.del_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(290, 286);
            this.MinimumSize = new System.Drawing.Size(290, 286);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.TextBox del_box;
        private System.Windows.Forms.Label del;
    }
}