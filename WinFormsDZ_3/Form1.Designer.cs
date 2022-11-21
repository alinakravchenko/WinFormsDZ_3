namespace WinFormsDZ_3
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.btnTopLevelMenu = new System.Windows.Forms.Button();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.btnSubItem = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(154, 130);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(225, 20);
            this.TopLevelMenu.TabIndex = 1;
            // 
            // btnTopLevelMenu
            // 
            this.btnTopLevelMenu.Location = new System.Drawing.Point(398, 127);
            this.btnTopLevelMenu.Name = "btnTopLevelMenu";
            this.btnTopLevelMenu.Size = new System.Drawing.Size(141, 23);
            this.btnTopLevelMenu.TabIndex = 2;
            this.btnTopLevelMenu.Text = "Добавить пункт меню";
            this.btnTopLevelMenu.UseVisualStyleBackColor = true;
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(154, 176);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(225, 20);
            this.SubItem.TabIndex = 3;
            // 
            // btnSubItem
            // 
            this.btnSubItem.Location = new System.Drawing.Point(398, 174);
            this.btnSubItem.Name = "btnSubItem";
            this.btnSubItem.Size = new System.Drawing.Size(141, 23);
            this.btnSubItem.TabIndex = 4;
            this.btnSubItem.Text = "Добавить подменю";
            this.btnSubItem.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(213, 80);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(274, 24);
            this.label.TabIndex = 5;
            this.label.Text = "Добавления пунктов меню";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 268);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSubItem);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.btnTopLevelMenu);
            this.Controls.Add(this.TopLevelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Forms приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.Button btnTopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button btnSubItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
    }

}