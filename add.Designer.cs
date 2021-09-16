
namespace assigment
{
    partial class Add
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
            this.id = new System.Windows.Forms.Label();
            this.matric = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.matricbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(32, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(28, 20);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // matric
            // 
            this.matric.AutoSize = true;
            this.matric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matric.Location = new System.Drawing.Point(32, 92);
            this.matric.Name = "matric";
            this.matric.Size = new System.Drawing.Size(90, 20);
            this.matric.TabIndex = 1;
            this.matric.Text = "Matric No.";
            this.matric.Click += new System.EventHandler(this.matric_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(32, 147);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // matricbox
            // 
            this.matricbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matricbox.Location = new System.Drawing.Point(128, 99);
            this.matricbox.Name = "matricbox";
            this.matricbox.Size = new System.Drawing.Size(136, 13);
            this.matricbox.TabIndex = 3;
            // 
            // namebox
            // 
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namebox.Location = new System.Drawing.Point(128, 154);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(136, 13);
            this.namebox.TabIndex = 4;
            // 
            // idbox
            // 
            this.idbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.idbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idbox.Cursor = System.Windows.Forms.Cursors.No;
            this.idbox.Enabled = false;
            this.idbox.Location = new System.Drawing.Point(128, 40);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(136, 13);
            this.idbox.TabIndex = 5;
            this.idbox.Text = "id";
            this.idbox.TextChanged += new System.EventHandler(this.idbox_TextChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Location = new System.Drawing.Point(36, 198);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Add";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(274, 247);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.matricbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.matric);
            this.Controls.Add(this.id);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(290, 286);
            this.MinimumSize = new System.Drawing.Size(290, 286);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label matric;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox matricbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button submit;
    }
}