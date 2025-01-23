namespace Calculator
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
            pnlVisor = new System.Windows.Forms.FlowLayoutPanel();
            lblPreviousEntry = new System.Windows.Forms.Label();
            lblEntry = new System.Windows.Forms.Label();
            tblButtons = new System.Windows.Forms.TableLayoutPanel();
            btnPlusMinus = new System.Windows.Forms.Button();
            btn0 = new System.Windows.Forms.Button();
            btnComma = new System.Windows.Forms.Button();
            btnEqual = new System.Windows.Forms.Button();
            btnSum = new System.Windows.Forms.Button();
            btn1 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btnSubtract = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btnMultiply = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            btnDivide = new System.Windows.Forms.Button();
            btnSquareRoot = new System.Windows.Forms.Button();
            btnSquare = new System.Windows.Forms.Button();
            btnReciprocal = new System.Windows.Forms.Button();
            btnBackspace = new System.Windows.Forms.Button();
            btnClearAll = new System.Windows.Forms.Button();
            btnClearEntry = new System.Windows.Forms.Button();
            btnPercent = new System.Windows.Forms.Button();
            pnlVisor.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVisor
            // 
            pnlVisor.BackColor = System.Drawing.Color.FromArgb(34, 37, 45);
            pnlVisor.Controls.Add(lblPreviousEntry);
            pnlVisor.Controls.Add(lblEntry);
            pnlVisor.Dock = System.Windows.Forms.DockStyle.Top;
            pnlVisor.Location = new System.Drawing.Point(0, 0);
            pnlVisor.Margin = new System.Windows.Forms.Padding(0);
            pnlVisor.Name = "pnlVisor";
            pnlVisor.Size = new System.Drawing.Size(355, 115);
            pnlVisor.TabIndex = 0;
            // 
            // lblPreviousEntry
            // 
            lblPreviousEntry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPreviousEntry.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPreviousEntry.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            lblPreviousEntry.Location = new System.Drawing.Point(4, 0);
            lblPreviousEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPreviousEntry.Name = "lblPreviousEntry";
            lblPreviousEntry.Size = new System.Drawing.Size(351, 27);
            lblPreviousEntry.TabIndex = 0;
            lblPreviousEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntry
            // 
            lblEntry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEntry.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEntry.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            lblEntry.Location = new System.Drawing.Point(4, 27);
            lblEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEntry.Name = "lblEntry";
            lblEntry.Size = new System.Drawing.Size(351, 89);
            lblEntry.TabIndex = 1;
            lblEntry.Text = "0";
            lblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblButtons
            // 
            tblButtons.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            tblButtons.ColumnCount = 4;
            tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tblButtons.Controls.Add(btnPlusMinus, 0, 5);
            tblButtons.Controls.Add(btn0, 1, 5);
            tblButtons.Controls.Add(btnComma, 2, 5);
            tblButtons.Controls.Add(btnEqual, 3, 5);
            tblButtons.Controls.Add(btnSum, 3, 4);
            tblButtons.Controls.Add(btn1, 0, 4);
            tblButtons.Controls.Add(btn2, 1, 4);
            tblButtons.Controls.Add(btn3, 2, 4);
            tblButtons.Controls.Add(btnSubtract, 3, 3);
            tblButtons.Controls.Add(btn6, 2, 3);
            tblButtons.Controls.Add(btn5, 1, 3);
            tblButtons.Controls.Add(btn4, 0, 3);
            tblButtons.Controls.Add(btnMultiply, 3, 2);
            tblButtons.Controls.Add(btn9, 2, 2);
            tblButtons.Controls.Add(btn8, 1, 2);
            tblButtons.Controls.Add(btn7, 0, 2);
            tblButtons.Controls.Add(btnDivide, 3, 1);
            tblButtons.Controls.Add(btnSquareRoot, 2, 1);
            tblButtons.Controls.Add(btnSquare, 1, 1);
            tblButtons.Controls.Add(btnReciprocal, 0, 1);
            tblButtons.Controls.Add(btnBackspace, 3, 0);
            tblButtons.Controls.Add(btnClearAll, 2, 0);
            tblButtons.Controls.Add(btnClearEntry, 1, 0);
            tblButtons.Controls.Add(btnPercent, 0, 0);
            tblButtons.Location = new System.Drawing.Point(0, 119);
            tblButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 6;
            tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblButtons.Size = new System.Drawing.Size(355, 383);
            tblButtons.TabIndex = 1;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnPlusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlusMinus.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPlusMinus.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnPlusMinus.Location = new System.Drawing.Point(0, 315);
            btnPlusMinus.Margin = new System.Windows.Forms.Padding(0);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new System.Drawing.Size(88, 68);
            btnPlusMinus.TabIndex = 23;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += OnPlusMinusButtonClick;
            // 
            // btn0
            // 
            btn0.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn0.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn0.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn0.Location = new System.Drawing.Point(88, 315);
            btn0.Margin = new System.Windows.Forms.Padding(0);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(88, 68);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += OnNumberButtonClick;
            // 
            // btnComma
            // 
            btnComma.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnComma.Dock = System.Windows.Forms.DockStyle.Fill;
            btnComma.FlatAppearance.BorderSize = 0;
            btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComma.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnComma.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnComma.Location = new System.Drawing.Point(176, 315);
            btnComma.Margin = new System.Windows.Forms.Padding(0);
            btnComma.Name = "btnComma";
            btnComma.Size = new System.Drawing.Size(88, 68);
            btnComma.TabIndex = 21;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = false;
            btnComma.Click += OnCommaButtonClick;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEqual.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEqual.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnEqual.Location = new System.Drawing.Point(264, 315);
            btnEqual.Margin = new System.Windows.Forms.Padding(0);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new System.Drawing.Size(91, 68);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += OnEqualsButtonClick;
            // 
            // btnSum
            // 
            btnSum.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnSum.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSum.FlatAppearance.BorderSize = 0;
            btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSum.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSum.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnSum.Location = new System.Drawing.Point(264, 252);
            btnSum.Margin = new System.Windows.Forms.Padding(0);
            btnSum.Name = "btnSum";
            btnSum.Size = new System.Drawing.Size(91, 63);
            btnSum.TabIndex = 19;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += OnActionButtonClick;
            // 
            // btn1
            // 
            btn1.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn1.Location = new System.Drawing.Point(0, 252);
            btn1.Margin = new System.Windows.Forms.Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(88, 63);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += OnNumberButtonClick;
            // 
            // btn2
            // 
            btn2.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn2.Location = new System.Drawing.Point(88, 252);
            btn2.Margin = new System.Windows.Forms.Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(88, 63);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += OnNumberButtonClick;
            // 
            // btn3
            // 
            btn3.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn3.Location = new System.Drawing.Point(176, 252);
            btn3.Margin = new System.Windows.Forms.Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(88, 63);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += OnNumberButtonClick;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubtract.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnSubtract.Location = new System.Drawing.Point(264, 189);
            btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new System.Drawing.Size(91, 63);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += OnActionButtonClick;
            // 
            // btn6
            // 
            btn6.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn6.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn6.Location = new System.Drawing.Point(176, 189);
            btn6.Margin = new System.Windows.Forms.Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(88, 63);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += OnNumberButtonClick;
            // 
            // btn5
            // 
            btn5.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn5.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn5.Location = new System.Drawing.Point(88, 189);
            btn5.Margin = new System.Windows.Forms.Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(88, 63);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += OnNumberButtonClick;
            // 
            // btn4
            // 
            btn4.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn4.Location = new System.Drawing.Point(0, 189);
            btn4.Margin = new System.Windows.Forms.Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(88, 63);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += OnNumberButtonClick;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMultiply.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnMultiply.Location = new System.Drawing.Point(264, 126);
            btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new System.Drawing.Size(91, 63);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += OnActionButtonClick;
            // 
            // btn9
            // 
            btn9.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn9.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn9.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn9.Location = new System.Drawing.Point(176, 126);
            btn9.Margin = new System.Windows.Forms.Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(88, 63);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += OnNumberButtonClick;
            // 
            // btn8
            // 
            btn8.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn8.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn8.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn8.Location = new System.Drawing.Point(88, 126);
            btn8.Margin = new System.Windows.Forms.Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(88, 63);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += OnNumberButtonClick;
            // 
            // btn7
            // 
            btn7.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn7.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn7.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btn7.Location = new System.Drawing.Point(0, 126);
            btn7.Margin = new System.Windows.Forms.Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(88, 63);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += OnNumberButtonClick;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDivide.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDivide.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnDivide.Location = new System.Drawing.Point(264, 63);
            btnDivide.Margin = new System.Windows.Forms.Padding(0);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new System.Drawing.Size(91, 63);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += OnActionButtonClick;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnSquareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSquareRoot.FlatAppearance.BorderSize = 0;
            btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSquareRoot.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSquareRoot.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnSquareRoot.Location = new System.Drawing.Point(176, 63);
            btnSquareRoot.Margin = new System.Windows.Forms.Padding(0);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new System.Drawing.Size(88, 63);
            btnSquareRoot.TabIndex = 6;
            btnSquareRoot.Text = "²√ₓ";
            btnSquareRoot.UseVisualStyleBackColor = false;
            btnSquareRoot.Click += OnSquareRootButtonClick;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSquare.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSquare.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnSquare.Location = new System.Drawing.Point(88, 63);
            btnSquare.Margin = new System.Windows.Forms.Padding(0);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new System.Drawing.Size(88, 63);
            btnSquare.TabIndex = 5;
            btnSquare.Text = "ₓ²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += OnSquareButtonClick;
            // 
            // btnReciprocal
            // 
            btnReciprocal.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnReciprocal.Dock = System.Windows.Forms.DockStyle.Fill;
            btnReciprocal.FlatAppearance.BorderSize = 0;
            btnReciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReciprocal.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnReciprocal.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnReciprocal.Location = new System.Drawing.Point(0, 63);
            btnReciprocal.Margin = new System.Windows.Forms.Padding(0);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new System.Drawing.Size(88, 63);
            btnReciprocal.TabIndex = 4;
            btnReciprocal.Text = "¹/ₓ";
            btnReciprocal.UseVisualStyleBackColor = false;
            btnReciprocal.Click += OnReciprocalButtonClick;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            btnBackspace.FlatAppearance.BorderSize = 0;
            btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackspace.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBackspace.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnBackspace.Location = new System.Drawing.Point(264, 0);
            btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new System.Drawing.Size(91, 63);
            btnBackspace.TabIndex = 3;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += OnBackspaceButtonClick;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClearAll.FlatAppearance.BorderSize = 0;
            btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearAll.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClearAll.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnClearAll.Location = new System.Drawing.Point(176, 0);
            btnClearAll.Margin = new System.Windows.Forms.Padding(0);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new System.Drawing.Size(88, 63);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += OnClearAllButtonClick;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnClearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClearEntry.FlatAppearance.BorderSize = 0;
            btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearEntry.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClearEntry.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnClearEntry.Location = new System.Drawing.Point(88, 0);
            btnClearEntry.Margin = new System.Windows.Forms.Padding(0);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new System.Drawing.Size(88, 63);
            btnClearEntry.TabIndex = 1;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += OnClearEntryButtonClick;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            btnPercent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 45, 55);
            btnPercent.FlatAppearance.BorderSize = 0;
            btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPercent.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPercent.ForeColor = System.Drawing.Color.FromArgb(255, 255, 254);
            btnPercent.Location = new System.Drawing.Point(0, 0);
            btnPercent.Margin = new System.Windows.Forms.Padding(0);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new System.Drawing.Size(88, 63);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += OnPercentButtonClick;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(34, 37, 45);
            ClientSize = new System.Drawing.Size(355, 509);
            Controls.Add(tblButtons);
            Controls.Add(pnlVisor);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(371, 548);
            MinimumSize = new System.Drawing.Size(371, 548);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            pnlVisor.ResumeLayout(false);
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlVisor;
        private System.Windows.Forms.Label lblPreviousEntry;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

