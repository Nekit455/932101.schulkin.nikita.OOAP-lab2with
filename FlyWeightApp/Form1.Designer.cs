namespace FlyWeightApp
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
            this.ButtonBtn = new System.Windows.Forms.Button();
            this.ImageBtn = new System.Windows.Forms.Button();
            this.TextBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBtn = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblTb = new System.Windows.Forms.Label();
            this.CLearBtn = new System.Windows.Forms.Button();
            this.AddAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBtn
            // 
            this.ButtonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonBtn.Location = new System.Drawing.Point(110, 94);
            this.ButtonBtn.Name = "ButtonBtn";
            this.ButtonBtn.Size = new System.Drawing.Size(105, 38);
            this.ButtonBtn.TabIndex = 0;
            this.ButtonBtn.Text = "Button";
            this.ButtonBtn.UseVisualStyleBackColor = true;
            this.ButtonBtn.Click += new System.EventHandler(this.ButtonBtn_Click);
            // 
            // ImageBtn
            // 
            this.ImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ImageBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ImageBtn.Location = new System.Drawing.Point(302, 94);
            this.ImageBtn.Name = "ImageBtn";
            this.ImageBtn.Size = new System.Drawing.Size(102, 38);
            this.ImageBtn.TabIndex = 1;
            this.ImageBtn.Text = "Image";
            this.ImageBtn.UseVisualStyleBackColor = true;
            this.ImageBtn.Click += new System.EventHandler(this.ImageBtn_Click);
            // 
            // TextBoxBtn
            // 
            this.TextBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextBoxBtn.Location = new System.Drawing.Point(495, 94);
            this.TextBoxBtn.Name = "TextBoxBtn";
            this.TextBoxBtn.Size = new System.Drawing.Size(101, 38);
            this.TextBoxBtn.TabIndex = 2;
            this.TextBoxBtn.Text = "TextBox";
            this.TextBoxBtn.UseVisualStyleBackColor = true;
            this.TextBoxBtn.Click += new System.EventHandler(this.TextBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите элемент:";
            // 
            // lblBtn
            // 
            this.lblBtn.AutoSize = true;
            this.lblBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBtn.Location = new System.Drawing.Point(126, 202);
            this.lblBtn.Name = "lblBtn";
            this.lblBtn.Size = new System.Drawing.Size(0, 16);
            this.lblBtn.TabIndex = 4;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(317, 193);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(0, 16);
            this.lblImg.TabIndex = 5;
            // 
            // lblTb
            // 
            this.lblTb.AutoSize = true;
            this.lblTb.Location = new System.Drawing.Point(492, 202);
            this.lblTb.Name = "lblTb";
            this.lblTb.Size = new System.Drawing.Size(0, 16);
            this.lblTb.TabIndex = 6;
            // 
            // CLearBtn
            // 
            this.CLearBtn.Location = new System.Drawing.Point(79, 348);
            this.CLearBtn.Name = "CLearBtn";
            this.CLearBtn.Size = new System.Drawing.Size(114, 34);
            this.CLearBtn.TabIndex = 7;
            this.CLearBtn.Text = "Очистить все";
            this.CLearBtn.UseVisualStyleBackColor = true;
            this.CLearBtn.Click += new System.EventHandler(this.CLearBtn_Click);
            // 
            // AddAllBtn
            // 
            this.AddAllBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAllBtn.Location = new System.Drawing.Point(522, 327);
            this.AddAllBtn.Name = "AddAllBtn";
            this.AddAllBtn.Size = new System.Drawing.Size(143, 70);
            this.AddAllBtn.TabIndex = 8;
            this.AddAllBtn.Text = "Список добавленных элементов";
            this.AddAllBtn.UseVisualStyleBackColor = true;
            this.AddAllBtn.Click += new System.EventHandler(this.AddAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAllBtn);
            this.Controls.Add(this.CLearBtn);
            this.Controls.Add(this.lblTb);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.lblBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxBtn);
            this.Controls.Add(this.ImageBtn);
            this.Controls.Add(this.ButtonBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBtn;
        private System.Windows.Forms.Button ImageBtn;
        private System.Windows.Forms.Button TextBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBtn;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblTb;
        private System.Windows.Forms.Button CLearBtn;
        private System.Windows.Forms.Button AddAllBtn;
    }
}

