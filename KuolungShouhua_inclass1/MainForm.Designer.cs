namespace KuolungShouhua_inclass1
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
            this.lblProcess = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(86, 53);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 21);
            this.lblProcess.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(90, 112);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(542, 31);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(90, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(376, 325);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(93, 36);
            this.btnSix.TabIndex = 3;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.operandClick);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(376, 398);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(93, 36);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.operandClick);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(90, 398);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(93, 36);
            this.btnOne.TabIndex = 5;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.operandClick);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(236, 398);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(93, 36);
            this.btnTwo.TabIndex = 6;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.operandClick);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(236, 325);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(93, 36);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.operandClick);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(90, 325);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(93, 36);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.operandClick);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(376, 258);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(93, 36);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.operandClick);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(236, 258);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(93, 36);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.operandClick);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(90, 258);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(93, 36);
            this.btnSeven.TabIndex = 11;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.operandClick);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(236, 191);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(93, 36);
            this.btnCE.TabIndex = 12;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(539, 191);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(93, 36);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.operatorClick);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(236, 474);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(93, 36);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.operandClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(539, 258);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(93, 36);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operatorClick);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(539, 474);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(93, 36);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(539, 398);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(93, 36);
            this.btnDivide.TabIndex = 17;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.operatorClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(539, 325);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(93, 36);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.operatorClick);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(376, 474);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(93, 36);
            this.btnDot.TabIndex = 19;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.operandClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 582);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblProcess);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDot;
    }
}

