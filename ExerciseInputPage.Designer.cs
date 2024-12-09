namespace HealthTracker
{
    partial class ExerciseInputPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseInputPage));
            this.calorieReturnToMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exerciseMins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exerciseDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exerciseType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calorieReturnToMenu
            // 
            this.calorieReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieReturnToMenu.Location = new System.Drawing.Point(152, 217);
            this.calorieReturnToMenu.Name = "calorieReturnToMenu";
            this.calorieReturnToMenu.Size = new System.Drawing.Size(165, 47);
            this.calorieReturnToMenu.TabIndex = 13;
            this.calorieReturnToMenu.Text = "Menu";
            this.calorieReturnToMenu.UseVisualStyleBackColor = true;
            this.calorieReturnToMenu.Click += new System.EventHandler(this.calorieReturnToMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // exerciseMins
            // 
            this.exerciseMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseMins.Location = new System.Drawing.Point(173, 168);
            this.exerciseMins.Name = "exerciseMins";
            this.exerciseMins.Size = new System.Drawing.Size(121, 26);
            this.exerciseMins.TabIndex = 11;
            this.exerciseMins.TextChanged += new System.EventHandler(this.exerciseMins_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exercise Type:";
            // 
            // exerciseDate
            // 
            this.exerciseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseDate.Location = new System.Drawing.Point(173, 64);
            this.exerciseDate.Name = "exerciseDate";
            this.exerciseDate.Size = new System.Drawing.Size(121, 26);
            this.exerciseDate.TabIndex = 9;
            this.exerciseDate.TextChanged += new System.EventHandler(this.exerciseDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            // 
            // exerciseType
            // 
            this.exerciseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseType.FormattingEnabled = true;
            this.exerciseType.Location = new System.Drawing.Point(173, 115);
            this.exerciseType.Name = "exerciseType";
            this.exerciseType.Size = new System.Drawing.Size(121, 28);
            this.exerciseType.TabIndex = 14;
            this.exerciseType.SelectedIndexChanged += new System.EventHandler(this.exerciseType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Minutes Exercised:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 9);
            this.label5.MaximumSize = new System.Drawing.Size(337, 42);
            this.label5.MinimumSize = new System.Drawing.Size(337, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "Input your Exercise";
            // 
            // ExerciseInputPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 287);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exerciseType);
            this.Controls.Add(this.calorieReturnToMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exerciseMins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exerciseDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExerciseInputPage";
            this.Text = "ExerciseInputPage";
            this.Load += new System.EventHandler(this.ExerciseInputPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calorieReturnToMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox exerciseMins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exerciseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox exerciseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}