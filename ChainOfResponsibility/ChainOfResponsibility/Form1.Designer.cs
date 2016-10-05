namespace ChainOfResponsibility
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
            this.NumbersInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotifyLabel = new System.Windows.Forms.Label();
            this.LettersInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumbersInput
            // 
            this.NumbersInput.Location = new System.Drawing.Point(108, 123);
            this.NumbersInput.Name = "NumbersInput";
            this.NumbersInput.Size = new System.Drawing.Size(120, 22);
            this.NumbersInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voer uw lotnummer in";
            // 
            // NotifyLabel
            // 
            this.NotifyLabel.AutoSize = true;
            this.NotifyLabel.Location = new System.Drawing.Point(55, 174);
            this.NotifyLabel.Name = "NotifyLabel";
            this.NotifyLabel.Size = new System.Drawing.Size(0, 17);
            this.NotifyLabel.TabIndex = 2;
            // 
            // LettersInput
            // 
            this.LettersInput.Location = new System.Drawing.Point(58, 123);
            this.LettersInput.Name = "LettersInput";
            this.LettersInput.Size = new System.Drawing.Size(44, 22);
            this.LettersInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Letters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LettersInput);
            this.Controls.Add(this.NotifyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumbersInput);
            this.Name = "Form1";
            this.Text = "Lotery ticket checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumbersInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NotifyLabel;
        private System.Windows.Forms.TextBox LettersInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

