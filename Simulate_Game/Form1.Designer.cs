namespace Simulate_Game
{
    partial class timerLabel
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
            this.startTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerResult = new System.Windows.Forms.Label();
            this.Poeni = new System.Windows.Forms.Label();
            this.timeElapsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.startTimer.Location = new System.Drawing.Point(964, 308);
            this.startTimer.Margin = new System.Windows.Forms.Padding(4);
=======
            this.startTimer.Location = new System.Drawing.Point(723, 250);
>>>>>>> 0ff4fe6a393d6169fbdddcd7c14437e0588214f2
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(233, 55);
            this.startTimer.TabIndex = 7;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerResult
            // 
            this.timerResult.AutoSize = true;
            this.timerResult.Location = new System.Drawing.Point(1092, 148);
            this.timerResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerResult.Name = "timerResult";
            this.timerResult.Size = new System.Drawing.Size(0, 17);
            this.timerResult.TabIndex = 8;
            // 
            // Poeni
            // 
            this.Poeni.AutoSize = true;
            this.Poeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.Poeni.Location = new System.Drawing.Point(964, 101);
            this.Poeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Poeni.Name = "Poeni";
            this.Poeni.Size = new System.Drawing.Size(188, 46);
=======
            this.Poeni.Location = new System.Drawing.Point(723, 82);
            this.Poeni.Name = "Poeni";
            this.Poeni.Size = new System.Drawing.Size(149, 37);
>>>>>>> 0ff4fe6a393d6169fbdddcd7c14437e0588214f2
            this.Poeni.TabIndex = 9;
            this.Poeni.Text = "Поени: 0";
            // 
            // timeElapsed
<<<<<<< HEAD
=======
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsed.Location = new System.Drawing.Point(864, 9);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(0, 20);
            this.timeElapsed.TabIndex = 10;
            // 
            // timerLabel
>>>>>>> 0ff4fe6a393d6169fbdddcd7c14437e0588214f2
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsed.Location = new System.Drawing.Point(1152, 11);
            this.timeElapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(0, 25);
            this.timeElapsed.TabIndex = 10;
            // 
            // timerLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1244, 586);
=======
            this.ClientSize = new System.Drawing.Size(933, 476);
>>>>>>> 0ff4fe6a393d6169fbdddcd7c14437e0588214f2
            this.Controls.Add(this.timeElapsed);
            this.Controls.Add(this.Poeni);
            this.Controls.Add(this.timerResult);
            this.Controls.Add(this.startTimer);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Controls.Add(this.listBox1);
>>>>>>> 0ff4fe6a393d6169fbdddcd7c14437e0588214f2
            this.Name = "timerLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerResult;
        private System.Windows.Forms.Label Poeni;
        private System.Windows.Forms.Label timeElapsed;
    }
}