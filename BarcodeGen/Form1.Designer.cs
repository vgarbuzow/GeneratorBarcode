
namespace BarcodeGen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.firstComboBox = new System.Windows.Forms.ComboBox();
            this.secondComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.indexComboBox = new System.Windows.Forms.ComboBox();
            this.rpoNumeric = new System.Windows.Forms.NumericUpDown();
            this.waybillNumeric = new System.Windows.Forms.NumericUpDown();
            this.interShiNumeric = new System.Windows.Forms.NumericUpDown();
            this.rpoShiButton = new System.Windows.Forms.Button();
            this.waybillShiButton = new System.Windows.Forms.Button();
            this.interShiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rpoNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interShiNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индекс ОПС";
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyBox.Location = new System.Drawing.Point(262, 24);
            this.historyBox.Multiline = true;
            this.historyBox.Name = "historyBox";
            this.historyBox.ReadOnly = true;
            this.historyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyBox.Size = new System.Drawing.Size(241, 245);
            this.historyBox.TabIndex = 14;
            this.historyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.historyBox.WordWrap = false;
            this.historyBox.TextChanged += new System.EventHandler(this.HistoryBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(324, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 31);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // firstComboBox
            // 
            this.firstComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstComboBox.FormattingEnabled = true;
            this.firstComboBox.Items.AddRange(new object[] {
            "RA",
            "LA",
            "VA",
            "CA",
            "EA",
            "UA",
            "ZA"});
            this.firstComboBox.Location = new System.Drawing.Point(58, 235);
            this.firstComboBox.Name = "firstComboBox";
            this.firstComboBox.Size = new System.Drawing.Size(44, 25);
            this.firstComboBox.TabIndex = 6;
            // 
            // secondComboBox
            // 
            this.secondComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondComboBox.FormattingEnabled = true;
            this.secondComboBox.Items.AddRange(new object[] {
            "RU",
            "EU",
            "UA"});
            this.secondComboBox.Location = new System.Drawing.Point(108, 235);
            this.secondComboBox.Name = "secondComboBox";
            this.secondComboBox.Size = new System.Drawing.Size(44, 25);
            this.secondComboBox.TabIndex = 7;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 100000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // indexComboBox
            // 
            this.indexComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexComboBox.FormattingEnabled = true;
            this.indexComboBox.Items.AddRange(new object[] {
            "105554",
            "108820",
            "109235",
            "109456",
            "111116",
            "111625",
            "117198",
            "117639",
            "140135",
            "141142",
            "142211",
            "198335"});
            this.indexComboBox.Location = new System.Drawing.Point(58, 48);
            this.indexComboBox.MaxDropDownItems = 6;
            this.indexComboBox.Name = "indexComboBox";
            this.indexComboBox.Size = new System.Drawing.Size(87, 25);
            this.indexComboBox.Sorted = true;
            this.indexComboBox.TabIndex = 1;
            // 
            // rpoNumeric
            // 
            this.rpoNumeric.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rpoNumeric.Location = new System.Drawing.Point(196, 99);
            this.rpoNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rpoNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rpoNumeric.Name = "rpoNumeric";
            this.rpoNumeric.Size = new System.Drawing.Size(47, 25);
            this.rpoNumeric.TabIndex = 3;
            this.rpoNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rpoNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // waybillNumeric
            // 
            this.waybillNumeric.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waybillNumeric.Location = new System.Drawing.Point(196, 150);
            this.waybillNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.waybillNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waybillNumeric.Name = "waybillNumeric";
            this.waybillNumeric.Size = new System.Drawing.Size(47, 25);
            this.waybillNumeric.TabIndex = 5;
            this.waybillNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waybillNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // interShiNumeric
            // 
            this.interShiNumeric.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interShiNumeric.Location = new System.Drawing.Point(196, 204);
            this.interShiNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.interShiNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interShiNumeric.Name = "interShiNumeric";
            this.interShiNumeric.Size = new System.Drawing.Size(47, 25);
            this.interShiNumeric.TabIndex = 9;
            this.interShiNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.interShiNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rpoShiButton
            // 
            this.rpoShiButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rpoShiButton.Location = new System.Drawing.Point(19, 99);
            this.rpoShiButton.Name = "rpoShiButton";
            this.rpoShiButton.Size = new System.Drawing.Size(171, 25);
            this.rpoShiButton.TabIndex = 15;
            this.rpoShiButton.Text = "ШПИ РПО";
            this.rpoShiButton.UseVisualStyleBackColor = true;
            this.rpoShiButton.Click += new System.EventHandler(this.RpoBarcode_Click);
            // 
            // waybillShiButton
            // 
            this.waybillShiButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waybillShiButton.Location = new System.Drawing.Point(19, 150);
            this.waybillShiButton.Name = "waybillShiButton";
            this.waybillShiButton.Size = new System.Drawing.Size(171, 25);
            this.waybillShiButton.TabIndex = 16;
            this.waybillShiButton.Text = "ШИ накладной (ф.16/23)";
            this.waybillShiButton.UseVisualStyleBackColor = true;
            this.waybillShiButton.Click += new System.EventHandler(this.WaybillBarcodeButton_Click);
            // 
            // interShiButton
            // 
            this.interShiButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interShiButton.Location = new System.Drawing.Point(19, 204);
            this.interShiButton.Name = "interShiButton";
            this.interShiButton.Size = new System.Drawing.Size(171, 25);
            this.interShiButton.TabIndex = 17;
            this.interShiButton.Text = "ШИ международный";
            this.interShiButton.UseVisualStyleBackColor = true;
            this.interShiButton.Click += new System.EventHandler(this.InterBarcodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(515, 328);
            this.Controls.Add(this.interShiButton);
            this.Controls.Add(this.waybillShiButton);
            this.Controls.Add(this.rpoShiButton);
            this.Controls.Add(this.interShiNumeric);
            this.Controls.Add(this.waybillNumeric);
            this.Controls.Add(this.rpoNumeric);
            this.Controls.Add(this.indexComboBox);
            this.Controls.Add(this.secondComboBox);
            this.Controls.Add(this.firstComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpoNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interShiNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox firstComboBox;
        private System.Windows.Forms.ComboBox secondComboBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox indexComboBox;
        private System.Windows.Forms.NumericUpDown rpoNumeric;
        private System.Windows.Forms.NumericUpDown waybillNumeric;
        private System.Windows.Forms.NumericUpDown interShiNumeric;
        private System.Windows.Forms.Button rpoShiButton;
        private System.Windows.Forms.Button waybillShiButton;
        private System.Windows.Forms.Button interShiButton;
    }
}

