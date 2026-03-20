namespace WinFormsApp1
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
            button = new Button();
            textCity = new TextBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(86, 132);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 0;
            button.Text = "Sprawdz pogode";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textCity
            // 
            textCity.Location = new Point(86, 80);
            textCity.Name = "textCity";
            textCity.Size = new Size(125, 27);
            textCity.TabIndex = 1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(86, 196);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 20);
            labelResult.TabIndex = 2;
            labelResult.Text = "Pogoda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(textCity);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox textCity;
        private Label labelResult;
    }
}
