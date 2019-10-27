namespace Mashkanta
{
    partial class frmCourseResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdSum = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalFund = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblPeriodMonth = new System.Windows.Forms.Label();
            this.lblPeriodYears = new System.Windows.Forms.Label();
            this.lblLoanPercentage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalReturn = new System.Windows.Forms.Label();
            this.lblMinReturn = new System.Windows.Forms.Label();
            this.lblMaxReturn = new System.Windows.Forms.Label();
            this.lblTotalInt = new System.Windows.Forms.Label();
            this.lblRatio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdPayments = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.grdSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayments)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnShowHide);
            this.panel3.Controls.Add(this.grdSum);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 167);
            this.panel3.TabIndex = 7;
            // 
            // grdSum
            // 
            this.grdSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSum.BackColor = System.Drawing.Color.White;
            this.grdSum.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.grdSum.ColumnCount = 4;
            this.grdSum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grdSum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grdSum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grdSum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grdSum.Controls.Add(this.lblTotalFund, 3, 5);
            this.grdSum.Controls.Add(this.label11, 2, 5);
            this.grdSum.Controls.Add(this.lblCourse, 1, 0);
            this.grdSum.Controls.Add(this.lblAmount, 1, 1);
            this.grdSum.Controls.Add(this.lblInterest, 1, 5);
            this.grdSum.Controls.Add(this.lblPeriodMonth, 1, 3);
            this.grdSum.Controls.Add(this.lblPeriodYears, 1, 4);
            this.grdSum.Controls.Add(this.lblLoanPercentage, 1, 2);
            this.grdSum.Controls.Add(this.label10, 0, 4);
            this.grdSum.Controls.Add(this.label9, 0, 3);
            this.grdSum.Controls.Add(this.label8, 0, 5);
            this.grdSum.Controls.Add(this.label7, 0, 2);
            this.grdSum.Controls.Add(this.label2, 0, 0);
            this.grdSum.Controls.Add(this.label1, 0, 1);
            this.grdSum.Controls.Add(this.label12, 2, 4);
            this.grdSum.Controls.Add(this.lblTotalReturn, 3, 3);
            this.grdSum.Controls.Add(this.lblMinReturn, 3, 2);
            this.grdSum.Controls.Add(this.lblMaxReturn, 3, 1);
            this.grdSum.Controls.Add(this.lblTotalInt, 3, 4);
            this.grdSum.Controls.Add(this.lblRatio, 3, 0);
            this.grdSum.Controls.Add(this.label6, 2, 3);
            this.grdSum.Controls.Add(this.label5, 2, 2);
            this.grdSum.Controls.Add(this.label4, 2, 1);
            this.grdSum.Controls.Add(this.label3, 2, 0);
            this.grdSum.Location = new System.Drawing.Point(300, 0);
            this.grdSum.Name = "grdSum";
            this.grdSum.RowCount = 6;
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.grdSum.Size = new System.Drawing.Size(717, 139);
            this.grdSum.TabIndex = 8;
            // 
            // lblTotalFund
            // 
            this.lblTotalFund.BackColor = System.Drawing.Color.White;
            this.lblTotalFund.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalFund.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalFund.Location = new System.Drawing.Point(4, 116);
            this.lblTotalFund.Name = "lblTotalFund";
            this.lblTotalFund.Size = new System.Drawing.Size(172, 19);
            this.lblTotalFund.TabIndex = 33;
            this.lblTotalFund.Text = "0";
            this.lblTotalFund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label11.Location = new System.Drawing.Point(183, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "יתרת קרן";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse
            // 
            this.lblCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourse.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCourse.Location = new System.Drawing.Point(362, 1);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(172, 19);
            this.lblCourse.TabIndex = 31;
            this.lblCourse.Text = "0";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAmount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAmount.Location = new System.Drawing.Point(362, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(172, 19);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = "0";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInterest
            // 
            this.lblInterest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInterest.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInterest.Location = new System.Drawing.Point(362, 116);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInterest.Size = new System.Drawing.Size(172, 19);
            this.lblInterest.TabIndex = 29;
            this.lblInterest.Text = "0";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPeriodMonth
            // 
            this.lblPeriodMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPeriodMonth.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPeriodMonth.Location = new System.Drawing.Point(362, 70);
            this.lblPeriodMonth.Name = "lblPeriodMonth";
            this.lblPeriodMonth.Size = new System.Drawing.Size(172, 19);
            this.lblPeriodMonth.TabIndex = 28;
            this.lblPeriodMonth.Text = "0";
            this.lblPeriodMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPeriodYears
            // 
            this.lblPeriodYears.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPeriodYears.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPeriodYears.Location = new System.Drawing.Point(362, 93);
            this.lblPeriodYears.Name = "lblPeriodYears";
            this.lblPeriodYears.Size = new System.Drawing.Size(172, 19);
            this.lblPeriodYears.TabIndex = 27;
            this.lblPeriodYears.Text = "0";
            this.lblPeriodYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoanPercentage
            // 
            this.lblLoanPercentage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoanPercentage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLoanPercentage.Location = new System.Drawing.Point(362, 47);
            this.lblLoanPercentage.Name = "lblLoanPercentage";
            this.lblLoanPercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoanPercentage.Size = new System.Drawing.Size(172, 19);
            this.lblLoanPercentage.TabIndex = 26;
            this.lblLoanPercentage.Text = "0";
            this.lblLoanPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(541, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "תקופה (שנים)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(541, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "תקופה (חודשים)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(541, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "ריבית/מרווח %";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(541, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "אחוז מההלוואה";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(541, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "מסלול";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "סכום";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label12.Location = new System.Drawing.Point(183, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "סה\"כ ריבית והצמדה";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalReturn
            // 
            this.lblTotalReturn.BackColor = System.Drawing.Color.White;
            this.lblTotalReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalReturn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalReturn.Location = new System.Drawing.Point(4, 70);
            this.lblTotalReturn.Name = "lblTotalReturn";
            this.lblTotalReturn.Size = new System.Drawing.Size(172, 19);
            this.lblTotalReturn.TabIndex = 18;
            this.lblTotalReturn.Text = "0";
            this.lblTotalReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMinReturn
            // 
            this.lblMinReturn.BackColor = System.Drawing.Color.White;
            this.lblMinReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMinReturn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMinReturn.Location = new System.Drawing.Point(4, 47);
            this.lblMinReturn.Name = "lblMinReturn";
            this.lblMinReturn.Size = new System.Drawing.Size(172, 19);
            this.lblMinReturn.TabIndex = 17;
            this.lblMinReturn.Text = "0";
            this.lblMinReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxReturn
            // 
            this.lblMaxReturn.BackColor = System.Drawing.Color.White;
            this.lblMaxReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaxReturn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMaxReturn.Location = new System.Drawing.Point(4, 24);
            this.lblMaxReturn.Name = "lblMaxReturn";
            this.lblMaxReturn.Size = new System.Drawing.Size(172, 19);
            this.lblMaxReturn.TabIndex = 16;
            this.lblMaxReturn.Text = "0";
            this.lblMaxReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalInt
            // 
            this.lblTotalInt.BackColor = System.Drawing.Color.White;
            this.lblTotalInt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalInt.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalInt.Location = new System.Drawing.Point(4, 93);
            this.lblTotalInt.Name = "lblTotalInt";
            this.lblTotalInt.Size = new System.Drawing.Size(172, 19);
            this.lblTotalInt.TabIndex = 15;
            this.lblTotalInt.Text = "0";
            this.lblTotalInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRatio
            // 
            this.lblRatio.BackColor = System.Drawing.Color.White;
            this.lblRatio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRatio.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRatio.Location = new System.Drawing.Point(4, 1);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(172, 19);
            this.lblRatio.TabIndex = 14;
            this.lblRatio.Text = "0";
            this.lblRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(183, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "החזר כולל";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(183, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "החזר חודשי מינימלי";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(183, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "החזר חודשי מקסימלי";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(183, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "יחס לשקל";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(402, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "יתרת קרן (כולל הצמדה)";
            this.chart1.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdPayments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 577);
            this.panel1.TabIndex = 10;
            // 
            // grdPayments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grdPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPayments.BackgroundColor = System.Drawing.Color.White;
            this.grdPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPayments.ColumnHeadersHeight = 30;
            this.grdPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPayments.EnableHeadersVisualStyles = false;
            this.grdPayments.GridColor = System.Drawing.SystemColors.ControlLight;
            this.grdPayments.Location = new System.Drawing.Point(0, 0);
            this.grdPayments.Name = "grdPayments";
            this.grdPayments.ReadOnly = true;
            this.grdPayments.RowHeadersVisible = false;
            this.grdPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
            this.grdPayments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPayments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPayments.Size = new System.Drawing.Size(598, 577);
            this.grdPayments.TabIndex = 8;
            this.grdPayments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPayments_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(606, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 577);
            this.panel2.TabIndex = 11;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart2.Location = new System.Drawing.Point(0, 300);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(402, 300);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "תשלום חודשי";
            this.chart2.Titles.Add(title2);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowHide.Location = new System.Drawing.Point(0, 143);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(90, 24);
            this.btnShowHide.TabIndex = 12;
            this.btnShowHide.Text = "הסתר טבלה";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(903, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "סך ההלוואה:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotal.Location = new System.Drawing.Point(818, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 24);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCourseResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "frmCourseResult";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "לוח תשלומים";
            this.Load += new System.EventHandler(this.frmCourseResult_Load);
            this.panel3.ResumeLayout(false);
            this.grdSum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPayments)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel grdSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalReturn;
        private System.Windows.Forms.Label lblMinReturn;
        private System.Windows.Forms.Label lblMaxReturn;
        private System.Windows.Forms.Label lblTotalInt;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblPeriodMonth;
        private System.Windows.Forms.Label lblPeriodYears;
        private System.Windows.Forms.Label lblLoanPercentage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblTotalFund;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label13;
    }
}