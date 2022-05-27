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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelNumber1.Location = new System.Drawing.Point(23, 32);
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
            this.labelNumber2.Location = new System.Drawing.Point(23, 63);
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
            this.labelResult.Location = new System.Drawing.Point(23, 180);
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
            this.textBoxNumber1.Location = new System.Drawing.Point(331, 24);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(134, 20);
            this.textBoxNumber1.TabIndex = 3;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumber2.Location = new System.Drawing.Point(331, 62);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(134, 20);
            this.textBoxNumber2.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(331, 180);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(134, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(22, 119);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAdd.Size = new System.Drawing.Size(82, 33);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "ADD ( + )";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.AutoSize = true;
            this.buttonSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSub.Location = new System.Drawing.Point(110, 119);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonSub.Size = new System.Drawing.Size(82, 33);
            this.buttonSub.TabIndex = 7;
            this.buttonSub.Text = "SUB ( - )";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.AutoSize = true;
            this.buttonMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMult.Location = new System.Drawing.Point(198, 119);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonMult.Size = new System.Drawing.Size(85, 33);
            this.buttonMult.TabIndex = 8;
            this.buttonMult.Text = "MULT ( X )";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.AutoSize = true;
            this.buttonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDiv.Location = new System.Drawing.Point(289, 119);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonDiv.Size = new System.Drawing.Size(85, 33);
            this.buttonDiv.TabIndex = 9;
            this.buttonDiv.Text = "DIV ( / )";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.BackColor = System.Drawing.Color.DarkGray;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReset.Location = new System.Drawing.Point(265, 239);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonReset.Size = new System.Drawing.Size(64, 33);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DimGray;
            this.buttonExit.Location = new System.Drawing.Point(198, 239);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonExit.Size = new System.Drawing.Size(51, 33);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.AutoSize = true;
            this.buttonMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMod.Location = new System.Drawing.Point(380, 119);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonMod.Size = new System.Drawing.Size(85, 33);
            this.buttonMod.TabIndex = 12;
            this.buttonMod.Text = "MOD ( % )";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(492, 297);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Easy Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMod;
    }
}

