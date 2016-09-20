namespace MathMagician
{
    partial class StandardCalculatorForm
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
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumbers
            // 
            this.tbNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumbers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumbers.Location = new System.Drawing.Point(5, 12);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.ReadOnly = true;
            this.tbNumbers.Size = new System.Drawing.Size(218, 27);
            this.tbNumbers.TabIndex = 0;
            this.tbNumbers.Text = "0";
            this.tbNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StandardCalculatorForm_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(5, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnAdd.Size = new System.Drawing.Size(50, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(61, 50);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnSubtract.Size = new System.Drawing.Size(50, 40);
            this.btnSubtract.TabIndex = 2;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(117, 50);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnMultiply.Size = new System.Drawing.Size(50, 40);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(173, 50);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnDivide.Size = new System.Drawing.Size(50, 40);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(5, 96);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnSeven.Size = new System.Drawing.Size(50, 40);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.TabStop = false;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(61, 96);
            this.btnEight.Name = "btnEight";
            this.btnEight.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnEight.Size = new System.Drawing.Size(50, 40);
            this.btnEight.TabIndex = 6;
            this.btnEight.TabStop = false;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(117, 96);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(50, 40);
            this.btnNine.TabIndex = 7;
            this.btnNine.TabStop = false;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(5, 142);
            this.btnFour.Name = "btnFour";
            this.btnFour.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnFour.Size = new System.Drawing.Size(50, 40);
            this.btnFour.TabIndex = 8;
            this.btnFour.TabStop = false;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(61, 142);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.buttonFive.Size = new System.Drawing.Size(50, 40);
            this.buttonFive.TabIndex = 9;
            this.buttonFive.TabStop = false;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(117, 142);
            this.btnSix.Name = "btnSix";
            this.btnSix.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnSix.Size = new System.Drawing.Size(50, 40);
            this.btnSix.TabIndex = 10;
            this.btnSix.TabStop = false;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(5, 188);
            this.btnOne.Name = "btnOne";
            this.btnOne.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnOne.Size = new System.Drawing.Size(50, 40);
            this.btnOne.TabIndex = 11;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(61, 188);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnTwo.Size = new System.Drawing.Size(50, 40);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.TabStop = false;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(117, 188);
            this.btnThree.Name = "btnThree";
            this.btnThree.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnThree.Size = new System.Drawing.Size(50, 40);
            this.btnThree.TabIndex = 13;
            this.btnThree.TabStop = false;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(117, 234);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnDecimal.Size = new System.Drawing.Size(50, 40);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(5, 234);
            this.btnZero.Name = "btnZero";
            this.btnZero.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnZero.Size = new System.Drawing.Size(106, 40);
            this.btnZero.TabIndex = 15;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(173, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnClear.Size = new System.Drawing.Size(50, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "CLR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(173, 188);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnEquals.Size = new System.Drawing.Size(50, 86);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.Location = new System.Drawing.Point(173, 142);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnInvert.Size = new System.Drawing.Size(50, 40);
            this.btnInvert.TabIndex = 18;
            this.btnInvert.TabStop = false;
            this.btnInvert.Text = "+/-";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // StandardCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(228, 279);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNumbers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StandardCalculatorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StandardCalculatorForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnInvert;
    }
}

