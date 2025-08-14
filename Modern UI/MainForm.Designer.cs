namespace Modern_UI
{
    partial class MainForm
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
            this.side_panel = new System.Windows.Forms.Panel();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.Form1_but = new System.Windows.Forms.Button();
            this.Form2_but = new System.Windows.Forms.Button();
            this.Form3_but = new System.Windows.Forms.Button();
            this.Setting_but = new System.Windows.Forms.Button();
            this.FormpaL = new System.Windows.Forms.Panel();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.side_panel.Controls.Add(this.Setting_but);
            this.side_panel.Controls.Add(this.Form3_but);
            this.side_panel.Controls.Add(this.Form2_but);
            this.side_panel.Controls.Add(this.Form1_but);
            this.side_panel.Controls.Add(this.profile_panel);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(200, 490);
            this.side_panel.TabIndex = 0;
            // 
            // profile_panel
            // 
            this.profile_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_panel.Location = new System.Drawing.Point(0, 0);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(200, 92);
            this.profile_panel.TabIndex = 0;
            // 
            // Form1_but
            // 
            this.Form1_but.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form1_but.FlatAppearance.BorderSize = 0;
            this.Form1_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1_but.Font = new System.Drawing.Font("Paperlogy 4 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.Form1_but.Location = new System.Drawing.Point(0, 92);
            this.Form1_but.Name = "Form1_but";
            this.Form1_but.Size = new System.Drawing.Size(200, 41);
            this.Form1_but.TabIndex = 1;
            this.Form1_but.Text = "Form1";
            this.Form1_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Form1_but.UseVisualStyleBackColor = true;
            this.Form1_but.Click += new System.EventHandler(this.Form1_but_Click);
            // 
            // Form2_but
            // 
            this.Form2_but.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form2_but.FlatAppearance.BorderSize = 0;
            this.Form2_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form2_but.Font = new System.Drawing.Font("Paperlogy 4 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form2_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.Form2_but.Location = new System.Drawing.Point(0, 133);
            this.Form2_but.Name = "Form2_but";
            this.Form2_but.Size = new System.Drawing.Size(200, 41);
            this.Form2_but.TabIndex = 2;
            this.Form2_but.Text = "Form2";
            this.Form2_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Form2_but.UseVisualStyleBackColor = true;
            this.Form2_but.Click += new System.EventHandler(this.Form2_but_Click);
            // 
            // Form3_but
            // 
            this.Form3_but.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form3_but.FlatAppearance.BorderSize = 0;
            this.Form3_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form3_but.Font = new System.Drawing.Font("Paperlogy 4 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form3_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.Form3_but.Location = new System.Drawing.Point(0, 174);
            this.Form3_but.Name = "Form3_but";
            this.Form3_but.Size = new System.Drawing.Size(200, 41);
            this.Form3_but.TabIndex = 3;
            this.Form3_but.Text = "Form3";
            this.Form3_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Form3_but.UseVisualStyleBackColor = true;
            this.Form3_but.Click += new System.EventHandler(this.Form3_but_Click);
            // 
            // Setting_but
            // 
            this.Setting_but.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Setting_but.FlatAppearance.BorderSize = 0;
            this.Setting_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_but.Font = new System.Drawing.Font("Paperlogy 4 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.Setting_but.Location = new System.Drawing.Point(0, 449);
            this.Setting_but.Name = "Setting_but";
            this.Setting_but.Size = new System.Drawing.Size(200, 41);
            this.Setting_but.TabIndex = 4;
            this.Setting_but.Text = "Settings";
            this.Setting_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Setting_but.UseVisualStyleBackColor = true;
            this.Setting_but.Click += new System.EventHandler(this.Setting_but_Click);
            // 
            // FormpaL
            // 
            this.FormpaL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormpaL.Location = new System.Drawing.Point(200, 0);
            this.FormpaL.Name = "FormpaL";
            this.FormpaL.Size = new System.Drawing.Size(670, 490);
            this.FormpaL.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.FormpaL);
            this.Controls.Add(this.side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(870, 490);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.Button Form1_but;
        private System.Windows.Forms.Button Form3_but;
        private System.Windows.Forms.Button Form2_but;
        private System.Windows.Forms.Button Setting_but;
        private System.Windows.Forms.Panel FormpaL;
    }
}

