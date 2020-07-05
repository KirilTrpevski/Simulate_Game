namespace Simulate_Game
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
            this.components = new System.ComponentModel.Container();
            this.btnRed3 = new System.Windows.Forms.Button();
            this.btnGreen4 = new System.Windows.Forms.Button();
            this.btnBlue2 = new System.Windows.Forms.Button();
            this.btnOrange1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.startTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerResult = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRed3
            // 
            this.btnRed3.BackColor = System.Drawing.Color.DarkRed;
            this.btnRed3.Location = new System.Drawing.Point(215, 268);
            this.btnRed3.Name = "btnRed3";
            this.btnRed3.Size = new System.Drawing.Size(224, 195);
            this.btnRed3.TabIndex = 2;
            this.btnRed3.UseVisualStyleBackColor = false;
            this.btnRed3.Click += new System.EventHandler(this.btnRed3_Click);
            // 
            // btnGreen4
            // 
            this.btnGreen4.BackColor = System.Drawing.Color.Green;
            this.btnGreen4.Location = new System.Drawing.Point(484, 268);
            this.btnGreen4.Name = "btnGreen4";
            this.btnGreen4.Size = new System.Drawing.Size(224, 195);
            this.btnGreen4.TabIndex = 3;
            this.btnGreen4.UseVisualStyleBackColor = false;
            // 
            // btnBlue2
            // 
            this.btnBlue2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBlue2.Location = new System.Drawing.Point(484, 67);
            this.btnBlue2.Name = "btnBlue2";
            this.btnBlue2.Size = new System.Drawing.Size(224, 195);
            this.btnBlue2.TabIndex = 4;
            this.btnBlue2.UseVisualStyleBackColor = false;
            this.btnBlue2.Click += new System.EventHandler(this.btnBlue2_Click);
            // 
            // btnOrange1
            // 
            this.btnOrange1.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrange1.Location = new System.Drawing.Point(215, 67);
            this.btnOrange1.Name = "btnOrange1";
            this.btnOrange1.Size = new System.Drawing.Size(224, 195);
            this.btnOrange1.TabIndex = 5;
            this.btnOrange1.UseVisualStyleBackColor = false;
            this.btnOrange1.Click += new System.EventHandler(this.btnOrange1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "asd"});
            this.listBox1.Location = new System.Drawing.Point(26, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 6;
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(819, 67);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(75, 23);
            this.startTimer.TabIndex = 7;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timerResult
            // 
            this.timerResult.AutoSize = true;
            this.timerResult.Location = new System.Drawing.Point(819, 120);
            this.timerResult.Name = "timerResult";
            this.timerResult.Size = new System.Drawing.Size(0, 13);
            this.timerResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 476);
            this.Controls.Add(this.timerResult);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrange1);
            this.Controls.Add(this.btnBlue2);
            this.Controls.Add(this.btnGreen4);
            this.Controls.Add(this.btnRed3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnRed3;
        private System.Windows.Forms.Button btnGreen4;
        private System.Windows.Forms.Button btnBlue2;
        private System.Windows.Forms.Button btnOrange1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerResult;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

