namespace WindowsFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.groupCalculator = new System.Windows.Forms.GroupBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteNum = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnExtraction = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.groupCalculator.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCalculator
            // 
            this.groupCalculator.Controls.Add(this.pnlTotal);
            this.groupCalculator.Controls.Add(this.panel2);
            this.groupCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupCalculator.Location = new System.Drawing.Point(3, 4);
            this.groupCalculator.Name = "groupCalculator";
            this.groupCalculator.Size = new System.Drawing.Size(657, 439);
            this.groupCalculator.TabIndex = 0;
            this.groupCalculator.TabStop = false;
            this.groupCalculator.Enter += new System.EventHandler(this.groupCalculator_Enter);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlTotal.Location = new System.Drawing.Point(22, 29);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(356, 65);
            this.pnlTotal.TabIndex = 0;
            this.pnlTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTotal_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(0, 29);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(356, 47);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteNum);
            this.panel2.Controls.Add(this.btnClearAll);
            this.panel2.Controls.Add(this.btnEqual);
            this.panel2.Controls.Add(this.btnPoint);
            this.panel2.Controls.Add(this.btnDivision);
            this.panel2.Controls.Add(this.btnMultiplication);
            this.panel2.Controls.Add(this.btnExtraction);
            this.panel2.Controls.Add(this.btnNum0);
            this.panel2.Controls.Add(this.btnNum3);
            this.panel2.Controls.Add(this.btnNum2);
            this.panel2.Controls.Add(this.btnNum6);
            this.panel2.Controls.Add(this.btnNum5);
            this.panel2.Controls.Add(this.btnNum1);
            this.panel2.Controls.Add(this.btnNum4);
            this.panel2.Controls.Add(this.btnAddition);
            this.panel2.Controls.Add(this.btnNum9);
            this.panel2.Controls.Add(this.btnNum8);
            this.panel2.Controls.Add(this.btnNum7);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(22, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 346);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDeleteNum
            // 
            this.btnDeleteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteNum.Location = new System.Drawing.Point(277, 47);
            this.btnDeleteNum.Name = "btnDeleteNum";
            this.btnDeleteNum.Size = new System.Drawing.Size(60, 60);
            this.btnDeleteNum.TabIndex = 18;
            this.btnDeleteNum.Text = "CE";
            this.btnDeleteNum.UseVisualStyleBackColor = true;
            this.btnDeleteNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearAll.Location = new System.Drawing.Point(277, 113);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(60, 60);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEqual.Location = new System.Drawing.Point(277, 179);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(60, 126);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPoint.Location = new System.Drawing.Point(145, 245);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(60, 60);
            this.btnPoint.TabIndex = 16;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDivision.Location = new System.Drawing.Point(211, 47);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(60, 60);
            this.btnDivision.TabIndex = 14;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiplication.Location = new System.Drawing.Point(211, 113);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(60, 60);
            this.btnMultiplication.TabIndex = 13;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnExtraction
            // 
            this.btnExtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtraction.Location = new System.Drawing.Point(211, 179);
            this.btnExtraction.Name = "btnExtraction";
            this.btnExtraction.Size = new System.Drawing.Size(60, 60);
            this.btnExtraction.TabIndex = 12;
            this.btnExtraction.Text = "-";
            this.btnExtraction.UseVisualStyleBackColor = true;
            this.btnExtraction.Click += new System.EventHandler(this.btnExtraction_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum0.Location = new System.Drawing.Point(13, 245);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(126, 60);
            this.btnNum0.TabIndex = 11;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum3.Location = new System.Drawing.Point(145, 179);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(60, 60);
            this.btnNum3.TabIndex = 10;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum2.Location = new System.Drawing.Point(79, 179);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(60, 60);
            this.btnNum2.TabIndex = 9;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum6.Location = new System.Drawing.Point(145, 113);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(60, 60);
            this.btnNum6.TabIndex = 8;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum5.Location = new System.Drawing.Point(79, 113);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(60, 60);
            this.btnNum5.TabIndex = 7;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum1.Location = new System.Drawing.Point(13, 179);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(60, 60);
            this.btnNum1.TabIndex = 6;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum4.Location = new System.Drawing.Point(13, 113);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(60, 60);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddition.Location = new System.Drawing.Point(211, 245);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(60, 60);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum9.Location = new System.Drawing.Point(145, 47);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(60, 60);
            this.btnNum9.TabIndex = 3;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum8.Location = new System.Drawing.Point(79, 47);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(60, 60);
            this.btnNum8.TabIndex = 2;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum7.Location = new System.Drawing.Point(13, 47);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(60, 60);
            this.btnNum7.TabIndex = 1;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 457);
            this.Controls.Add(this.groupCalculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Calculator";
            this.groupCalculator.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCalculator;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExtraction;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDeleteNum;
        private System.Windows.Forms.Button btnClearAll;
    }
}

