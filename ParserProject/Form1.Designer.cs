namespace ParserProject
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btn_showForm2 = new System.Windows.Forms.Button();
            this.textPanel = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tstbtn = new System.Windows.Forms.Button();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(13, 495);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(1200, 163);
            this.txtConsole.TabIndex = 24;
            this.txtConsole.WordWrap = false;
            // 
            // btn_showForm2
            // 
            this.btn_showForm2.Location = new System.Drawing.Point(543, 270);
            this.btn_showForm2.Name = "btn_showForm2";
            this.btn_showForm2.Size = new System.Drawing.Size(154, 53);
            this.btn_showForm2.TabIndex = 28;
            this.btn_showForm2.Text = "Tokens To SyntaxTree";
            this.btn_showForm2.UseVisualStyleBackColor = true;
            this.btn_showForm2.Click += new System.EventHandler(this.btn_showForm2_Click);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.tstbtn);
            this.textPanel.Controls.Add(this.button1);
            this.textPanel.Controls.Add(this.outputTextBox);
            this.textPanel.Controls.Add(this.btn_showForm2);
            this.textPanel.Controls.Add(this.inputTextBox);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textPanel.Location = new System.Drawing.Point(0, 0);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(1247, 526);
            this.textPanel.TabIndex = 29;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(126, 39);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputTextBox.Size = new System.Drawing.Size(280, 368);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.WordWrap = false;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(834, 39);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(287, 368);
            this.outputTextBox.TabIndex = 29;
            this.outputTextBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 53);
            this.button1.TabIndex = 30;
            this.button1.Text = "Code to Scanner";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tstbtn
            // 
            this.tstbtn.Location = new System.Drawing.Point(543, 350);
            this.tstbtn.Name = "tstbtn";
            this.tstbtn.Size = new System.Drawing.Size(154, 48);
            this.tstbtn.TabIndex = 31;
            this.tstbtn.Text = "TEST";
            this.tstbtn.UseVisualStyleBackColor = true;
            this.tstbtn.Click += new System.EventHandler(this.tstbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 671);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.textPanel);
            this.MaximumSize = new System.Drawing.Size(1265, 718);
            this.MinimumSize = new System.Drawing.Size(1265, 718);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btn_showForm2;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tstbtn;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

