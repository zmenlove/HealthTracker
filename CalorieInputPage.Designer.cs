namespace HealthTracker
{
    partial class CalorieInputPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalorieInputPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calorieReturnToMenu = new System.Windows.Forms.Button();
            this.calorieSaveBtn = new System.Windows.Forms.Button();
            this.calorieDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input your Daily Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calories Consumed:";
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesTextBox.Location = new System.Drawing.Point(173, 117);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 26);
            this.caloriesTextBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // calorieReturnToMenu
            // 
            this.calorieReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieReturnToMenu.Location = new System.Drawing.Point(244, 161);
            this.calorieReturnToMenu.Name = "calorieReturnToMenu";
            this.calorieReturnToMenu.Size = new System.Drawing.Size(134, 48);
            this.calorieReturnToMenu.TabIndex = 6;
            this.calorieReturnToMenu.Text = "Menu";
            this.calorieReturnToMenu.UseVisualStyleBackColor = true;
            this.calorieReturnToMenu.Click += new System.EventHandler(this.calorieReturnToMenu_Click);
            // 
            // calorieSaveBtn
            // 
            this.calorieSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieSaveBtn.Location = new System.Drawing.Point(93, 161);
            this.calorieSaveBtn.Name = "calorieSaveBtn";
            this.calorieSaveBtn.Size = new System.Drawing.Size(131, 48);
            this.calorieSaveBtn.TabIndex = 21;
            this.calorieSaveBtn.Text = "Save";
            this.calorieSaveBtn.UseVisualStyleBackColor = true;
            this.calorieSaveBtn.Click += new System.EventHandler(this.calorieSaveBtn_Click);
            // 
            // calorieDateTime
            // 
            this.calorieDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieDateTime.Location = new System.Drawing.Point(70, 70);
            this.calorieDateTime.Name = "calorieDateTime";
            this.calorieDateTime.Size = new System.Drawing.Size(203, 20);
            this.calorieDateTime.TabIndex = 22;
            // 
            // CalorieInputPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 221);
            this.Controls.Add(this.calorieDateTime);
            this.Controls.Add(this.calorieSaveBtn);
            this.Controls.Add(this.calorieReturnToMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(459, 260);
            this.MinimumSize = new System.Drawing.Size(459, 260);
            this.Name = "CalorieInputPage";
            this.Text = "CalorieInputPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calorieReturnToMenu;
        private System.Windows.Forms.Button calorieSaveBtn;
        private System.Windows.Forms.DateTimePicker calorieDateTime;
    }
}