namespace HelloWorld
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
            this.buttonDisplayMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDisplayMessage
            // 
            this.buttonDisplayMessage.Location = new System.Drawing.Point(167, 130);
            this.buttonDisplayMessage.Name = "buttonDisplayMessage";
            this.buttonDisplayMessage.Size = new System.Drawing.Size(97, 51);
            this.buttonDisplayMessage.TabIndex = 0;
            this.buttonDisplayMessage.Text = "Display Message";
            this.buttonDisplayMessage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 318);
            this.Controls.Add(this.buttonDisplayMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDisplayMessage;
    }
}