namespace UnityWizardCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.projectList = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.minimized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectList
            // 
            this.projectList.BackColor = System.Drawing.Color.LemonChiffon;
            this.projectList.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectList.FormattingEnabled = true;
            this.projectList.ItemHeight = 22;
            this.projectList.Location = new System.Drawing.Point(12, 40);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(710, 378);
            this.projectList.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(237, 443);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(251, 53);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(700, 9);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(22, 20);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // minimized
            // 
            this.minimized.BackColor = System.Drawing.Color.Yellow;
            this.minimized.FlatAppearance.BorderSize = 0;
            this.minimized.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimized.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimized.Location = new System.Drawing.Point(672, 9);
            this.minimized.Margin = new System.Windows.Forms.Padding(0);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(22, 20);
            this.minimized.TabIndex = 3;
            this.minimized.Text = "-";
            this.minimized.UseVisualStyleBackColor = false;
            this.minimized.Click += new System.EventHandler(this.minimized_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Patua One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unity wizard project cleaner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(734, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimized);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.projectList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox projectList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button minimized;
        private System.Windows.Forms.Label label1;
    }
}

