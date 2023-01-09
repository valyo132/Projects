namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateWord = new System.Windows.Forms.Button();
            this.wordPlace1 = new System.Windows.Forms.Label();
            this.wordPlace2 = new System.Windows.Forms.Label();
            this.wordPlace3 = new System.Windows.Forms.Label();
            this.wordPlace4 = new System.Windows.Forms.Label();
            this.wordPlace5 = new System.Windows.Forms.Label();
            this.wordPlace6 = new System.Windows.Forms.Label();
            this.wordPlace7 = new System.Windows.Forms.Label();
            this.wordPlace8 = new System.Windows.Forms.Label();
            this.wordPlace9 = new System.Windows.Forms.Label();
            this.wordPlace10 = new System.Windows.Forms.Label();
            this.guessLetter = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.mistakesText = new System.Windows.Forms.Label();
            this.mistakenLetters = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.wordType = new System.Windows.Forms.ComboBox();
            this.wordPlace11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateWord
            // 
            this.GenerateWord.Location = new System.Drawing.Point(660, 403);
            this.GenerateWord.Name = "GenerateWord";
            this.GenerateWord.Size = new System.Drawing.Size(128, 35);
            this.GenerateWord.TabIndex = 13;
            this.GenerateWord.Text = "Generate Word";
            this.GenerateWord.UseVisualStyleBackColor = true;
            this.GenerateWord.Click += new System.EventHandler(this.GenerateWord_Click);
            // 
            // wordPlace1
            // 
            this.wordPlace1.AllowDrop = true;
            this.wordPlace1.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace1.ForeColor = System.Drawing.Color.White;
            this.wordPlace1.Location = new System.Drawing.Point(59, 292);
            this.wordPlace1.Name = "wordPlace1";
            this.wordPlace1.Size = new System.Drawing.Size(56, 54);
            this.wordPlace1.TabIndex = 14;
            this.wordPlace1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace1.Visible = false;
            // 
            // wordPlace2
            // 
            this.wordPlace2.AllowDrop = true;
            this.wordPlace2.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace2.ForeColor = System.Drawing.Color.White;
            this.wordPlace2.Location = new System.Drawing.Point(121, 292);
            this.wordPlace2.Name = "wordPlace2";
            this.wordPlace2.Size = new System.Drawing.Size(56, 54);
            this.wordPlace2.TabIndex = 15;
            this.wordPlace2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace2.Visible = false;
            // 
            // wordPlace3
            // 
            this.wordPlace3.AllowDrop = true;
            this.wordPlace3.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace3.ForeColor = System.Drawing.Color.White;
            this.wordPlace3.Location = new System.Drawing.Point(183, 292);
            this.wordPlace3.Name = "wordPlace3";
            this.wordPlace3.Size = new System.Drawing.Size(56, 54);
            this.wordPlace3.TabIndex = 16;
            this.wordPlace3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace3.Visible = false;
            // 
            // wordPlace4
            // 
            this.wordPlace4.AllowDrop = true;
            this.wordPlace4.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace4.ForeColor = System.Drawing.Color.White;
            this.wordPlace4.Location = new System.Drawing.Point(245, 292);
            this.wordPlace4.Name = "wordPlace4";
            this.wordPlace4.Size = new System.Drawing.Size(56, 54);
            this.wordPlace4.TabIndex = 17;
            this.wordPlace4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace4.Visible = false;
            // 
            // wordPlace5
            // 
            this.wordPlace5.AllowDrop = true;
            this.wordPlace5.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace5.ForeColor = System.Drawing.Color.White;
            this.wordPlace5.Location = new System.Drawing.Point(307, 292);
            this.wordPlace5.Name = "wordPlace5";
            this.wordPlace5.Size = new System.Drawing.Size(56, 54);
            this.wordPlace5.TabIndex = 18;
            this.wordPlace5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace5.Visible = false;
            // 
            // wordPlace6
            // 
            this.wordPlace6.AllowDrop = true;
            this.wordPlace6.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace6.ForeColor = System.Drawing.Color.White;
            this.wordPlace6.Location = new System.Drawing.Point(369, 292);
            this.wordPlace6.Name = "wordPlace6";
            this.wordPlace6.Size = new System.Drawing.Size(56, 54);
            this.wordPlace6.TabIndex = 19;
            this.wordPlace6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace6.Visible = false;
            // 
            // wordPlace7
            // 
            this.wordPlace7.AllowDrop = true;
            this.wordPlace7.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace7.ForeColor = System.Drawing.Color.White;
            this.wordPlace7.Location = new System.Drawing.Point(431, 292);
            this.wordPlace7.Name = "wordPlace7";
            this.wordPlace7.Size = new System.Drawing.Size(56, 54);
            this.wordPlace7.TabIndex = 20;
            this.wordPlace7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace7.Visible = false;
            // 
            // wordPlace8
            // 
            this.wordPlace8.AllowDrop = true;
            this.wordPlace8.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace8.ForeColor = System.Drawing.Color.White;
            this.wordPlace8.Location = new System.Drawing.Point(493, 292);
            this.wordPlace8.Name = "wordPlace8";
            this.wordPlace8.Size = new System.Drawing.Size(56, 54);
            this.wordPlace8.TabIndex = 21;
            this.wordPlace8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace8.Visible = false;
            // 
            // wordPlace9
            // 
            this.wordPlace9.AllowDrop = true;
            this.wordPlace9.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace9.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace9.ForeColor = System.Drawing.Color.White;
            this.wordPlace9.Location = new System.Drawing.Point(555, 292);
            this.wordPlace9.Name = "wordPlace9";
            this.wordPlace9.Size = new System.Drawing.Size(56, 54);
            this.wordPlace9.TabIndex = 22;
            this.wordPlace9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace9.Visible = false;
            // 
            // wordPlace10
            // 
            this.wordPlace10.AllowDrop = true;
            this.wordPlace10.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace10.ForeColor = System.Drawing.Color.White;
            this.wordPlace10.Location = new System.Drawing.Point(617, 292);
            this.wordPlace10.Name = "wordPlace10";
            this.wordPlace10.Size = new System.Drawing.Size(56, 54);
            this.wordPlace10.TabIndex = 23;
            this.wordPlace10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace10.Visible = false;
            // 
            // guessLetter
            // 
            this.guessLetter.Enabled = false;
            this.guessLetter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLetter.Location = new System.Drawing.Point(394, 403);
            this.guessLetter.Name = "guessLetter";
            this.guessLetter.PlaceholderText = "Type here...";
            this.guessLetter.Size = new System.Drawing.Size(144, 35);
            this.guessLetter.TabIndex = 24;
            // 
            // GuessButton
            // 
            this.GuessButton.Enabled = false;
            this.GuessButton.Location = new System.Drawing.Point(544, 403);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(68, 35);
            this.GuessButton.TabIndex = 25;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            this.GuessButton.Enter += new System.EventHandler(this.GuessButton_Click);
            // 
            // mistakesText
            // 
            this.mistakesText.AutoSize = true;
            this.mistakesText.BackColor = System.Drawing.Color.Transparent;
            this.mistakesText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mistakesText.ForeColor = System.Drawing.Color.White;
            this.mistakesText.Location = new System.Drawing.Point(313, 26);
            this.mistakesText.Name = "mistakesText";
            this.mistakesText.Size = new System.Drawing.Size(94, 25);
            this.mistakesText.TabIndex = 26;
            this.mistakesText.Text = "Mistakes:";
            this.mistakesText.Visible = false;
            // 
            // mistakenLetters
            // 
            this.mistakenLetters.BackColor = System.Drawing.Color.Transparent;
            this.mistakenLetters.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mistakenLetters.ForeColor = System.Drawing.SystemColors.Control;
            this.mistakenLetters.Location = new System.Drawing.Point(413, 26);
            this.mistakenLetters.Name = "mistakenLetters";
            this.mistakenLetters.Size = new System.Drawing.Size(375, 23);
            this.mistakenLetters.TabIndex = 27;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 403);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 32);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // wordType
            // 
            this.wordType.FormattingEnabled = true;
            this.wordType.Items.AddRange(new object[] {
            "All",
            "Animals",
            "Sports"});
            this.wordType.Location = new System.Drawing.Point(108, 403);
            this.wordType.Name = "wordType";
            this.wordType.Size = new System.Drawing.Size(185, 23);
            this.wordType.TabIndex = 30;
            this.wordType.Text = "All";
            // 
            // wordPlace11
            // 
            this.wordPlace11.AllowDrop = true;
            this.wordPlace11.BackColor = System.Drawing.Color.Transparent;
            this.wordPlace11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPlace11.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordPlace11.ForeColor = System.Drawing.Color.White;
            this.wordPlace11.Location = new System.Drawing.Point(679, 292);
            this.wordPlace11.Name = "wordPlace11";
            this.wordPlace11.Size = new System.Drawing.Size(56, 54);
            this.wordPlace11.TabIndex = 31;
            this.wordPlace11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordPlace11.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 10);
            this.label1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Hangman.Properties.Resources.black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordPlace11);
            this.Controls.Add(this.wordType);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.mistakenLetters);
            this.Controls.Add(this.mistakesText);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.guessLetter);
            this.Controls.Add(this.wordPlace10);
            this.Controls.Add(this.wordPlace9);
            this.Controls.Add(this.wordPlace8);
            this.Controls.Add(this.wordPlace7);
            this.Controls.Add(this.wordPlace6);
            this.Controls.Add(this.wordPlace5);
            this.Controls.Add(this.wordPlace4);
            this.Controls.Add(this.wordPlace3);
            this.Controls.Add(this.wordPlace2);
            this.Controls.Add(this.wordPlace1);
            this.Controls.Add(this.GenerateWord);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GenerateWord;
        public System.Windows.Forms.Label wordPlace1;
        public System.Windows.Forms.Label wordPlace2;
        public System.Windows.Forms.Label wordPlace3;
        public System.Windows.Forms.Label wordPlace4;
        public System.Windows.Forms.Label wordPlace5;
        public System.Windows.Forms.Label wordPlace6;
        public System.Windows.Forms.Label wordPlace7;
        public System.Windows.Forms.Label wordPlace8;
        public System.Windows.Forms.Label wordPlace9;
        public System.Windows.Forms.Label wordPlace10;
        private System.Windows.Forms.TextBox guessLetter;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label mistakesText;
        private System.Windows.Forms.Label mistakenLetters;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox wordType;
        public System.Windows.Forms.Label wordPlace11;
        private System.Windows.Forms.Label label1;
    }
}
