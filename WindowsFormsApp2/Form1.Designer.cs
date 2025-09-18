namespace WindowsFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateCommentRating = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateCommentText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateCommentRating = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateCommentID = new System.Windows.Forms.TextBox();
            this.UpdateCommentText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.DeleteCommentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CreateCommentRating);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CreateCommentText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Створення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rating:";
            // 
            // CreateCommentRating
            // 
            this.CreateCommentRating.Location = new System.Drawing.Point(104, 172);
            this.CreateCommentRating.Name = "CreateCommentRating";
            this.CreateCommentRating.Size = new System.Drawing.Size(100, 49);
            this.CreateCommentRating.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Створити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateCommentText
            // 
            this.CreateCommentText.Location = new System.Drawing.Point(6, 40);
            this.CreateCommentText.Multiline = true;
            this.CreateCommentText.Name = "CreateCommentText";
            this.CreateCommentText.Size = new System.Drawing.Size(565, 121);
            this.CreateCommentText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UpdateCommentRating);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.UpdateCommentID);
            this.groupBox2.Controls.Add(this.UpdateCommentText);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rating:";
            // 
            // UpdateCommentRating
            // 
            this.UpdateCommentRating.Location = new System.Drawing.Point(104, 176);
            this.UpdateCommentRating.Name = "UpdateCommentRating";
            this.UpdateCommentRating.Size = new System.Drawing.Size(100, 49);
            this.UpdateCommentRating.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Завантажити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // UpdateCommentID
            // 
            this.UpdateCommentID.Location = new System.Drawing.Point(654, 40);
            this.UpdateCommentID.Name = "UpdateCommentID";
            this.UpdateCommentID.Size = new System.Drawing.Size(100, 49);
            this.UpdateCommentID.TabIndex = 3;
            // 
            // UpdateCommentText
            // 
            this.UpdateCommentText.Location = new System.Drawing.Point(6, 35);
            this.UpdateCommentText.Multiline = true;
            this.UpdateCommentText.Name = "UpdateCommentText";
            this.UpdateCommentText.Size = new System.Drawing.Size(565, 135);
            this.UpdateCommentText.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.DeleteCommentID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Видалення";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 62);
            this.button4.TabIndex = 6;
            this.button4.Text = "Видалити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteCommentID
            // 
            this.DeleteCommentID.Location = new System.Drawing.Point(64, 46);
            this.DeleteCommentID.Name = "DeleteCommentID";
            this.DeleteCommentID.Size = new System.Drawing.Size(100, 49);
            this.DeleteCommentID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CreateCommentText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdateCommentID;
        private System.Windows.Forms.TextBox UpdateCommentText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox DeleteCommentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateCommentRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UpdateCommentRating;
    }
}

