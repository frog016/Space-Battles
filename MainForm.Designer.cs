namespace Space_Battles
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.RefreshClick = new System.Windows.Forms.Timer(this.components);
            this.Scores = new System.Windows.Forms.Label();
            this.GameAcceleration = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // RefreshClick
            // 
            this.RefreshClick.Enabled = true;
            this.RefreshClick.Interval = 150;
            this.RefreshClick.Tick += new System.EventHandler(this.RefreshClicks);
            // 
            // Scores
            // 
            this.Scores.AutoSize = true;
            this.Scores.BackColor = System.Drawing.SystemColors.InfoText;
            this.Scores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Scores.Location = new System.Drawing.Point(755, 0);
            this.Scores.Name = "Scores";
            this.Scores.Padding = new System.Windows.Forms.Padding(4);
            this.Scores.Size = new System.Drawing.Size(29, 30);
            this.Scores.TabIndex = 0;
            this.Scores.Text = "0";
            // 
            // GameAcceleration
            // 
            this.GameAcceleration.Enabled = true;
            this.GameAcceleration.Interval = 10000;
            this.GameAcceleration.Tick += new System.EventHandler(this.GameAcceleration_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Battles.Resource.CosmoBG;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Scores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Battles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer RefreshClick;
        private System.Windows.Forms.Label Scores;
        private System.Windows.Forms.Timer GameAcceleration;
    }
}

