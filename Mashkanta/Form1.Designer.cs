namespace Mashkanta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.grdCourses = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestGap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStopAtPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colButton = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new Mashkanta.Controls.CurrencyTextBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourses)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(979, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "חשב";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdCourses
            // 
            this.grdCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colAmount,
            this.colInterestGap,
            this.colPeriod,
            this.colYears,
            this.colStartMonth,
            this.colStopAtPeriod,
            this.colLoanPercentage,
            this.colResult,
            this.colButton});
            this.grdCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdCourses.Location = new System.Drawing.Point(8, 33);
            this.grdCourses.Name = "grdCourses";
            this.grdCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdCourses.Size = new System.Drawing.Size(1058, 157);
            this.grdCourses.TabIndex = 2;
            this.grdCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCourses_CellContentClick);
            this.grdCourses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdCourses_CellFormatting);
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "מסלול";
            this.colType.Name = "colType";
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colType.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N0";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAmount.HeaderText = "סכום";
            this.colAmount.Name = "colAmount";
            // 
            // colInterestGap
            // 
            this.colInterestGap.DataPropertyName = "InterestGap";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colInterestGap.DefaultCellStyle = dataGridViewCellStyle2;
            this.colInterestGap.HeaderText = "ריבית/מרווח %";
            this.colInterestGap.Name = "colInterestGap";
            this.colInterestGap.Width = 120;
            // 
            // colPeriod
            // 
            this.colPeriod.DataPropertyName = "Period";
            this.colPeriod.HeaderText = "תקופה (חודשים)";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.Width = 150;
            // 
            // colYears
            // 
            this.colYears.DataPropertyName = "Years";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.colYears.DefaultCellStyle = dataGridViewCellStyle3;
            this.colYears.HeaderText = "תקופה (שנים)";
            this.colYears.Name = "colYears";
            this.colYears.ReadOnly = true;
            this.colYears.Width = 150;
            // 
            // colStartMonth
            // 
            this.colStartMonth.DataPropertyName = "StartMonth";
            this.colStartMonth.HeaderText = "חודש התחלה";
            this.colStartMonth.Name = "colStartMonth";
            // 
            // colStopAtPeriod
            // 
            this.colStopAtPeriod.DataPropertyName = "StopAtPeriod";
            this.colStopAtPeriod.HeaderText = "חודש עצירה";
            this.colStopAtPeriod.Name = "colStopAtPeriod";
            this.colStopAtPeriod.Visible = false;
            // 
            // colLoanPercentage
            // 
            this.colLoanPercentage.DataPropertyName = "LoanPercentage";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.colLoanPercentage.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLoanPercentage.HeaderText = "% מההלוואה";
            this.colLoanPercentage.Name = "colLoanPercentage";
            this.colLoanPercentage.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.DataPropertyName = "Result";
            this.colResult.HeaderText = "colResult";
            this.colResult.Name = "colResult";
            this.colResult.Visible = false;
            // 
            // colButton
            // 
            this.colButton.HeaderText = "מחזור";
            this.colButton.Name = "colButton";
            this.colButton.ReadOnly = true;
            this.colButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.grdCourses);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(9, 82);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(1074, 255);
            this.panel2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(742, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "השווה הצעות...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(875, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "שמור הצעה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "ייצוא לאקסל";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "תמהיל";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(9, 337);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(1074, 312);
            this.panel3.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "כל המסלולים";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1058, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "סך ההלוואה:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Format = "N0";
            this.txtAmount.Location = new System.Drawing.Point(952, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(111, 22);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "0";
            this.txtAmount.Value = 0D;
            // 
            // btnDemo
            // 
            this.btnDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDemo.Location = new System.Drawing.Point(862, 15);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(84, 47);
            this.btnDemo.TabIndex = 8;
            this.btnDemo.Text = "הדגמה";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDemo);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(1074, 73);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 658);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "מחשבון משכנתה";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCourses)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdCourses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestGap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYears;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStopAtPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewLinkColumn colButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private Controls.CurrencyTextBox txtAmount;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Panel panel1;
    }
}

