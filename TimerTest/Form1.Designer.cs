namespace TimerTest
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
            this.BtnTimer1 = new System.Windows.Forms.Button();
            this.TbxLoopCount = new System.Windows.Forms.TextBox();
            this.TbxInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnTimer2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTimer1
            // 
            this.BtnTimer1.Location = new System.Drawing.Point(197, 11);
            this.BtnTimer1.Name = "BtnTimer1";
            this.BtnTimer1.Size = new System.Drawing.Size(75, 22);
            this.BtnTimer1.TabIndex = 0;
            this.BtnTimer1.Text = "一般Timer";
            this.BtnTimer1.UseVisualStyleBackColor = true;
            this.BtnTimer1.Click += new System.EventHandler(this.BtnTimer1_Click);
            // 
            // TbxLoopCount
            // 
            this.TbxLoopCount.Location = new System.Drawing.Point(89, 11);
            this.TbxLoopCount.Name = "TbxLoopCount";
            this.TbxLoopCount.Size = new System.Drawing.Size(100, 22);
            this.TbxLoopCount.TabIndex = 1;
            this.TbxLoopCount.Text = "100";
            // 
            // TbxInterval
            // 
            this.TbxInterval.Location = new System.Drawing.Point(89, 41);
            this.TbxInterval.Name = "TbxInterval";
            this.TbxInterval.Size = new System.Drawing.Size(100, 22);
            this.TbxInterval.TabIndex = 2;
            this.TbxInterval.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "LoopCount : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interval : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 268);
            this.textBox1.TabIndex = 5;
            // 
            // BtnTimer2
            // 
            this.BtnTimer2.Location = new System.Drawing.Point(195, 41);
            this.BtnTimer2.Name = "BtnTimer2";
            this.BtnTimer2.Size = new System.Drawing.Size(75, 22);
            this.BtnTimer2.TabIndex = 6;
            this.BtnTimer2.Text = "高精 Timer";
            this.BtnTimer2.UseVisualStyleBackColor = true;
            this.BtnTimer2.Click += new System.EventHandler(this.BtnTimer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 349);
            this.Controls.Add(this.BtnTimer2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxInterval);
            this.Controls.Add(this.TbxLoopCount);
            this.Controls.Add(this.BtnTimer1);
            this.Name = "Form1";
            this.Text = "TimerTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTimer1;
        private System.Windows.Forms.TextBox TbxLoopCount;
        private System.Windows.Forms.TextBox TbxInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnTimer2;
    }
}

