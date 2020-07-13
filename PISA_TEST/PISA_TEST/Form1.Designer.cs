namespace PISA_TEST
{
    partial class TestForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.testTextTextBox = new System.Windows.Forms.RichTextBox();
            this.answerARadioButton = new System.Windows.Forms.RadioButton();
            this.answerBRadioButton = new System.Windows.Forms.RadioButton();
            this.answerCRadioButton = new System.Windows.Forms.RadioButton();
            this.answerDRadioButton = new System.Windows.Forms.RadioButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вперед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 510);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // testTextTextBox
            // 
            this.testTextTextBox.Location = new System.Drawing.Point(326, 12);
            this.testTextTextBox.Name = "testTextTextBox";
            this.testTextTextBox.ReadOnly = true;
            this.testTextTextBox.Size = new System.Drawing.Size(348, 305);
            this.testTextTextBox.TabIndex = 2;
            this.testTextTextBox.Text = "";
            // 
            // answerARadioButton
            // 
            this.answerARadioButton.AutoSize = true;
            this.answerARadioButton.Location = new System.Drawing.Point(224, 407);
            this.answerARadioButton.Name = "answerARadioButton";
            this.answerARadioButton.Size = new System.Drawing.Size(85, 17);
            this.answerARadioButton.TabIndex = 4;
            this.answerARadioButton.TabStop = true;
            this.answerARadioButton.Text = "radioButton1";
            this.answerARadioButton.UseVisualStyleBackColor = true;
            // 
            // answerBRadioButton
            // 
            this.answerBRadioButton.AutoSize = true;
            this.answerBRadioButton.Location = new System.Drawing.Point(579, 407);
            this.answerBRadioButton.Name = "answerBRadioButton";
            this.answerBRadioButton.Size = new System.Drawing.Size(85, 17);
            this.answerBRadioButton.TabIndex = 5;
            this.answerBRadioButton.TabStop = true;
            this.answerBRadioButton.Text = "radioButton2";
            this.answerBRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerCRadioButton
            // 
            this.answerCRadioButton.AutoSize = true;
            this.answerCRadioButton.Location = new System.Drawing.Point(224, 468);
            this.answerCRadioButton.Name = "answerCRadioButton";
            this.answerCRadioButton.Size = new System.Drawing.Size(85, 17);
            this.answerCRadioButton.TabIndex = 6;
            this.answerCRadioButton.TabStop = true;
            this.answerCRadioButton.Text = "radioButton3";
            this.answerCRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerDRadioButton
            // 
            this.answerDRadioButton.AutoSize = true;
            this.answerDRadioButton.Location = new System.Drawing.Point(579, 468);
            this.answerDRadioButton.Name = "answerDRadioButton";
            this.answerDRadioButton.Size = new System.Drawing.Size(85, 17);
            this.answerDRadioButton.TabIndex = 7;
            this.answerDRadioButton.TabStop = true;
            this.answerDRadioButton.Text = "radioButton4";
            this.answerDRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(695, 59);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(270, 154);
            this.questionTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 305);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerDRadioButton);
            this.Controls.Add(this.answerCRadioButton);
            this.Controls.Add(this.answerBRadioButton);
            this.Controls.Add(this.answerARadioButton);
            this.Controls.Add(this.testTextTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox testTextTextBox;
        private System.Windows.Forms.RadioButton answerARadioButton;
        private System.Windows.Forms.RadioButton answerBRadioButton;
        private System.Windows.Forms.RadioButton answerCRadioButton;
        private System.Windows.Forms.RadioButton answerDRadioButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

