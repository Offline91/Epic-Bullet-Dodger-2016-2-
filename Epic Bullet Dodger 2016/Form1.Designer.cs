namespace Epic_Bullet_Dodger_2016
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.epicLabel1 = new System.Windows.Forms.Label();
            this.playButton1 = new System.Windows.Forms.Button();
            this.quitButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // epicLabel1
            // 
            this.epicLabel1.AutoSize = true;
            this.epicLabel1.BackColor = System.Drawing.Color.Plum;
            this.epicLabel1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epicLabel1.Location = new System.Drawing.Point(61, 82);
            this.epicLabel1.Name = "epicLabel1";
            this.epicLabel1.Size = new System.Drawing.Size(401, 45);
            this.epicLabel1.TabIndex = 0;
            this.epicLabel1.Text = "Epic Bullet Dodger 2016";
            // 
            // playButton1
            // 
            this.playButton1.Location = new System.Drawing.Point(69, 258);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(112, 49);
            this.playButton1.TabIndex = 1;
            this.playButton1.Text = "Play";
            this.playButton1.UseVisualStyleBackColor = true;
            this.playButton1.Click += new System.EventHandler(this.playButton1_Click);
            // 
            // quitButton1
            // 
            this.quitButton1.Location = new System.Drawing.Point(301, 258);
            this.quitButton1.Name = "quitButton1";
            this.quitButton1.Size = new System.Drawing.Size(112, 49);
            this.quitButton1.TabIndex = 2;
            this.quitButton1.Text = "Quit";
            this.quitButton1.UseVisualStyleBackColor = true;
            this.quitButton1.Click += new System.EventHandler(this.quitButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // gametimer
            // 
            this.gametimer.Interval = 16;
            this.gametimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(61, 20);
            this.score.TabIndex = 4;
            this.score.Text = "Score:";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(79, 12);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(20, 23);
            this.count.TabIndex = 5;
            this.count.Text = "...";
            // 
            // tick
            // 
            this.tick.Interval = 1000;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton1);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.epicLabel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Epic Bullet Dodger 2016";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.bulletdodger_paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label epicLabel;
        private System.Windows.Forms.Label epicLabel1;
        private System.Windows.Forms.Button playButton1;
        private System.Windows.Forms.Button quitButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Timer tick;
    }
}

