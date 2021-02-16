namespace Space_Battles
{
    partial class GeneralMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartGameBattles = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Space Battles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartGameBattles
            // 
            this.StartGameBattles.BackColor = System.Drawing.Color.White;
            this.StartGameBattles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameBattles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBattles.Location = new System.Drawing.Point(300, 250);
            this.StartGameBattles.Name = "StartGameBattles";
            this.StartGameBattles.Size = new System.Drawing.Size(200, 40);
            this.StartGameBattles.TabIndex = 1;
            this.StartGameBattles.Text = "Start Game";
            this.StartGameBattles.UseVisualStyleBackColor = false;
            this.StartGameBattles.Click += new System.EventHandler(this.StartGameBattles_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.BackColor = System.Drawing.Color.White;
            this.ExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitGame.Location = new System.Drawing.Point(300, 309);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(200, 40);
            this.ExitGame.TabIndex = 2;
            this.ExitGame.Text = "Exit";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // GeneralMenu
            // 
            this.BackgroundImage = global::Space_Battles.Resource.Space_800x600;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.StartGameBattles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GeneralMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Battles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartGameBattles;
        private System.Windows.Forms.Button ExitGame;
    }
}