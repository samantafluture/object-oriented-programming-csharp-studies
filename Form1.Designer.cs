namespace WindowsFormsSimpleCalculator
{
    partial class MainForm
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
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelNumber1.Location = new System.Drawing.Point(36, 66);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Padding = new System.Windows.Forms.Padding(3);
            this.labelNumber1.Size = new System.Drawing.Size(132, 19);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Input first integer number:";
            this.labelNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelNumber2.Location = new System.Drawing.Point(36, 97);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Padding = new System.Windows.Forms.Padding(3);
            this.labelNumber2.Size = new System.Drawing.Size(151, 19);
            this.labelNumber2.TabIndex = 1;
            this.labelNumber2.Text = "Input second integer number:";
            this.labelNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelResult.Location = new System.Drawing.Point(36, 181);
            this.labelResult.Name = "labelResult";
            this.labelResult.Padding = new System.Windows.Forms.Padding(3);
            this.labelResult.Size = new System.Drawing.Size(56, 19);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "RESULT";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumber1.Location = new System.Drawing.Point(193, 65);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber1.TabIndex = 3;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumber2.Location = new System.Drawing.Point(193, 96);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber2.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(193, 180);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(35, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAdd.Size = new System.Drawing.Size(82, 33);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(331, 260);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Name = "MainForm";
            this.Text = "Easy Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonAdd;
    }
}

