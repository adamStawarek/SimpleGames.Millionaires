namespace QUIZ
{
    partial class quizCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizCart));
            this.ansA = new System.Windows.Forms.Button();
            this.ansB = new System.Windows.Forms.Button();
            this.ansD = new System.Windows.Forms.Button();
            this.ansC = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quest = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ansA
            // 
            this.ansA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ansA.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ansA.Location = new System.Drawing.Point(23, 345);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(280, 102);
            this.ansA.TabIndex = 1;
            this.ansA.Text = "a)";
            this.ansA.UseVisualStyleBackColor = true;
            this.ansA.Click += new System.EventHandler(this.Check);
            // 
            // ansB
            // 
            this.ansB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ansB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ansB.FlatAppearance.BorderSize = 3;
            this.ansB.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ansB.Location = new System.Drawing.Point(379, 345);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(280, 102);
            this.ansB.TabIndex = 2;
            this.ansB.Text = "b)";
            this.ansB.UseVisualStyleBackColor = true;
            this.ansB.Click += new System.EventHandler(this.Check);
            // 
            // ansD
            // 
            this.ansD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ansD.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ansD.Location = new System.Drawing.Point(379, 479);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(280, 102);
            this.ansD.TabIndex = 3;
            this.ansD.Text = "d)";
            this.ansD.UseVisualStyleBackColor = true;
            this.ansD.Click += new System.EventHandler(this.Check);
            // 
            // ansC
            // 
            this.ansC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ansC.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ansC.Location = new System.Drawing.Point(23, 479);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(280, 102);
            this.ansC.TabIndex = 4;
            this.ansC.Text = "c)";
            this.ansC.UseVisualStyleBackColor = true;
            this.ansC.Click += new System.EventHandler(this.Check);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question.Location = new System.Drawing.Point(15, 101);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(180, 45);
            this.Question.TabIndex = 5;
            this.Question.Text = "Pytanie1";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QUIZ.Properties.Resources.tabela;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(677, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 614);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Quest
            // 
            this.Quest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Quest.Enabled = false;
            this.Quest.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quest.Location = new System.Drawing.Point(23, 149);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(636, 179);
            this.Quest.TabIndex = 7;
            this.Quest.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QUIZ.Properties.Resources.kolo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(23, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 76);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::QUIZ.Properties.Resources.kolo3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(231, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 76);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::QUIZ.Properties.Resources.kolo2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(445, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 76);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // quizCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::QUIZ.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1034, 616);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Quest);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ansC);
            this.Controls.Add(this.ansD);
            this.Controls.Add(this.ansB);
            this.Controls.Add(this.ansA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "quizCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.quizCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ansA;
        private System.Windows.Forms.Button ansB;
        private System.Windows.Forms.Button ansD;
        private System.Windows.Forms.Button ansC;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox Quest;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}