namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainSplitCont = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ContainerLbl = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resultBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.ChSightBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.powBtn = new System.Windows.Forms.Button();
            this.oppositeBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.CEbtn = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тёмнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitCont)).BeginInit();
            this.MainSplitCont.Panel1.SuspendLayout();
            this.MainSplitCont.Panel2.SuspendLayout();
            this.MainSplitCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitCont
            // 
            this.MainSplitCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainSplitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitCont.Location = new System.Drawing.Point(0, 28);
            this.MainSplitCont.Name = "MainSplitCont";
            this.MainSplitCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitCont.Panel1
            // 
            this.MainSplitCont.Panel1.Controls.Add(this.splitContainer1);
            // 
            // MainSplitCont.Panel2
            // 
            this.MainSplitCont.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.MainSplitCont.Size = new System.Drawing.Size(511, 650);
            this.MainSplitCont.SplitterDistance = 201;
            this.MainSplitCont.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.ContainerLbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResultBox);
            this.splitContainer1.Size = new System.Drawing.Size(509, 199);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 1;
            // 
            // ContainerLbl
            // 
            this.ContainerLbl.BackColor = System.Drawing.Color.White;
            this.ContainerLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ContainerLbl.Location = new System.Drawing.Point(0, 0);
            this.ContainerLbl.Name = "ContainerLbl";
            this.ContainerLbl.Size = new System.Drawing.Size(509, 52);
            this.ContainerLbl.TabIndex = 0;
            this.ContainerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.White;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.HideSelection = false;
            this.ResultBox.Location = new System.Drawing.Point(0, 0);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(509, 143);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResultBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResultBox_MouseClick);
            this.ResultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputValidation);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.resultBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dotBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.zeroBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ChSightBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.plusBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.threeBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.twoBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.oneBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.minusBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.sixBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.fiveBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fourBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplicationBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.nineBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.eightBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sevenBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sqrtBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.powBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.oppositeBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BackBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CEbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.percentBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.resultBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBtn.Location = new System.Drawing.Point(385, 369);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(120, 70);
            this.resultBtn.TabIndex = 23;
            this.resultBtn.Text = "=";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.BackColor = System.Drawing.Color.LightGray;
            this.dotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotBtn.Location = new System.Drawing.Point(258, 369);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(120, 70);
            this.dotBtn.TabIndex = 22;
            this.dotBtn.Text = ",";
            this.dotBtn.UseVisualStyleBackColor = false;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.Color.LightGray;
            this.zeroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroBtn.Location = new System.Drawing.Point(131, 369);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(120, 70);
            this.zeroBtn.TabIndex = 21;
            this.zeroBtn.Tag = "";
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // ChSightBtn
            // 
            this.ChSightBtn.BackColor = System.Drawing.Color.LightGray;
            this.ChSightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChSightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChSightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChSightBtn.Location = new System.Drawing.Point(4, 369);
            this.ChSightBtn.Name = "ChSightBtn";
            this.ChSightBtn.Size = new System.Drawing.Size(120, 70);
            this.ChSightBtn.TabIndex = 20;
            this.ChSightBtn.UseVisualStyleBackColor = false;
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(385, 296);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(120, 66);
            this.plusBtn.TabIndex = 19;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActionBtns_MouseClick);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.Color.LightGray;
            this.threeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeBtn.Location = new System.Drawing.Point(258, 296);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(120, 66);
            this.threeBtn.TabIndex = 18;
            this.threeBtn.Tag = "";
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.Color.LightGray;
            this.twoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoBtn.Location = new System.Drawing.Point(131, 296);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(120, 66);
            this.twoBtn.TabIndex = 17;
            this.twoBtn.Tag = "";
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.Color.LightGray;
            this.oneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneBtn.Location = new System.Drawing.Point(4, 296);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(120, 66);
            this.oneBtn.TabIndex = 16;
            this.oneBtn.Tag = "";
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBtn.Location = new System.Drawing.Point(385, 223);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(120, 66);
            this.minusBtn.TabIndex = 15;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActionBtns_MouseClick);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.Color.LightGray;
            this.sixBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixBtn.Location = new System.Drawing.Point(258, 223);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(120, 66);
            this.sixBtn.TabIndex = 14;
            this.sixBtn.Tag = "";
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.Color.LightGray;
            this.fiveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveBtn.Location = new System.Drawing.Point(131, 223);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(120, 66);
            this.fiveBtn.TabIndex = 13;
            this.fiveBtn.Tag = "";
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.Color.LightGray;
            this.fourBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourBtn.Location = new System.Drawing.Point(4, 223);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(120, 66);
            this.fourBtn.TabIndex = 12;
            this.fourBtn.Tag = "";
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multiplicationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationBtn.Location = new System.Drawing.Point(385, 150);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(120, 66);
            this.multiplicationBtn.TabIndex = 11;
            this.multiplicationBtn.Text = "*";
            this.multiplicationBtn.UseVisualStyleBackColor = false;
            this.multiplicationBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActionBtns_MouseClick);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.Color.LightGray;
            this.nineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineBtn.Location = new System.Drawing.Point(258, 150);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(120, 66);
            this.nineBtn.TabIndex = 10;
            this.nineBtn.Tag = "";
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.Color.LightGray;
            this.eightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightBtn.Location = new System.Drawing.Point(131, 150);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(120, 66);
            this.eightBtn.TabIndex = 9;
            this.eightBtn.Tag = "";
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.Color.LightGray;
            this.sevenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenBtn.Location = new System.Drawing.Point(4, 150);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(120, 66);
            this.sevenBtn.TabIndex = 8;
            this.sevenBtn.Tag = "";
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DigitButtons_MouseClick);
            // 
            // divideBtn
            // 
            this.divideBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideBtn.Location = new System.Drawing.Point(385, 77);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(120, 66);
            this.divideBtn.TabIndex = 7;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActionBtns_MouseClick);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sqrtBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqrtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtBtn.Location = new System.Drawing.Point(258, 77);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(120, 66);
            this.sqrtBtn.TabIndex = 6;
            this.sqrtBtn.Text = "√x";
            this.sqrtBtn.UseVisualStyleBackColor = false;
            this.sqrtBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpecFunctions_MouseClick);
            // 
            // powBtn
            // 
            this.powBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.powBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powBtn.Location = new System.Drawing.Point(131, 77);
            this.powBtn.Name = "powBtn";
            this.powBtn.Size = new System.Drawing.Size(120, 66);
            this.powBtn.TabIndex = 5;
            this.powBtn.Text = "x^2";
            this.powBtn.UseVisualStyleBackColor = false;
            this.powBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpecFunctions_MouseClick);
            // 
            // oppositeBtn
            // 
            this.oppositeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oppositeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oppositeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oppositeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oppositeBtn.Location = new System.Drawing.Point(4, 77);
            this.oppositeBtn.Name = "oppositeBtn";
            this.oppositeBtn.Size = new System.Drawing.Size(120, 66);
            this.oppositeBtn.TabIndex = 4;
            this.oppositeBtn.Text = "1/x";
            this.oppositeBtn.UseVisualStyleBackColor = false;
            this.oppositeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpecFunctions_MouseClick);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(385, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(120, 66);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Cbtn
            // 
            this.Cbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cbtn.Location = new System.Drawing.Point(258, 4);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(120, 66);
            this.Cbtn.TabIndex = 2;
            this.Cbtn.Text = "C";
            this.Cbtn.UseVisualStyleBackColor = false;
            this.Cbtn.Click += new System.EventHandler(this.ClearAll);
            // 
            // CEbtn
            // 
            this.CEbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CEbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEbtn.Location = new System.Drawing.Point(131, 4);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(120, 66);
            this.CEbtn.TabIndex = 1;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = false;
            this.CEbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearEnter);
            // 
            // percentBtn
            // 
            this.percentBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.percentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentBtn.Location = new System.Drawing.Point(4, 4);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(120, 66);
            this.percentBtn.TabIndex = 0;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = false;
            this.percentBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpecFunctions_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.светлаяToolStripMenuItem,
            this.тёмнаяToolStripMenuItem});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // тёмнаяToolStripMenuItem
            // 
            this.тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            this.тёмнаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.тёмнаяToolStripMenuItem.Text = "Тёмная";
            this.тёмнаяToolStripMenuItem.Click += new System.EventHandler(this.тёмнаяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(511, 678);
            this.Controls.Add(this.MainSplitCont);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.MainSplitCont.Panel1.ResumeLayout(false);
            this.MainSplitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitCont)).EndInit();
            this.MainSplitCont.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitCont;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button ChSightBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.Button powBtn;
        private System.Windows.Forms.Button oppositeBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ContainerLbl;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тёмнаяToolStripMenuItem;
    }
}

