namespace tpmodul3_103022300154
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ouput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(125, 90);
            this.TextInput.Name = "TextInput";
            this.TextInput.PlaceholderText = "Masukkan Nama Kamu";
            this.TextInput.Size = new System.Drawing.Size(332, 39);
            this.TextInput.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(560, 90);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(201, 46);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.onSubmit);
            // 
            // ouput
            // 
            this.ouput.AutoSize = true;
            this.ouput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ouput.Location = new System.Drawing.Point(125, 159);
            this.ouput.Name = "ouput";
            this.ouput.Size = new System.Drawing.Size(205, 45);
            this.ouput.TabIndex = 2;
            this.ouput.Text = "Kamu Siapa?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 311);
            this.Controls.Add(this.ouput);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TextInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextInput;
        private Button SubmitButton;
        private Label ouput;
    }
}