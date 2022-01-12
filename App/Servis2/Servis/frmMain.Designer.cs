
namespace Servis
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabService = new System.Windows.Forms.TabControl();
            this.Repairs = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Repairs = new System.Windows.Forms.DataGridView();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Servis.DataSet1();
            this.btnSave = new System.Windows.Forms.Button();
            this.tapParts = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Parts = new System.Windows.Forms.DataGridView();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Clients = new System.Windows.Forms.DataGridView();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.tabJobs = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Jobs = new System.Windows.Forms.DataGridView();
            this.btnSave4 = new System.Windows.Forms.Button();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Staff = new System.Windows.Forms.DataGridView();
            this.btnSave5 = new System.Windows.Forms.Button();
            this.ремонтTableAdapter = new Servis.DataSet1TableAdapters.РемонтTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастиTableAdapter = new Servis.DataSet1TableAdapters.ЗапчастиTableAdapter();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Servis.DataSet1TableAdapters.КлиентыTableAdapter();
            this.iDзапчастьDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиезапчастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьзапчастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работыTableAdapter = new Servis.DataSet1TableAdapters.РаботыTableAdapter();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Servis.DataSet1TableAdapters.СотрудникиTableAdapter();
            this.iDсотрудникDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDработаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеработыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDсотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDклиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDзапчастьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDработаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаремонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьРубDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDклиентDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabService.SuspendLayout();
            this.Repairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tapParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parts)).BeginInit();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).BeginInit();
            this.tabJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jobs)).BeginInit();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(476, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 26);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.splitContainer1.Location = new System.Drawing.Point(123, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabService);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Size = new System.Drawing.Size(1039, 486);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.Repairs);
            this.tabService.Controls.Add(this.tapParts);
            this.tabService.Controls.Add(this.tabClients);
            this.tabService.Controls.Add(this.tabJobs);
            this.tabService.Controls.Add(this.tabStaff);
            this.tabService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabService.Location = new System.Drawing.Point(0, 0);
            this.tabService.Name = "tabService";
            this.tabService.SelectedIndex = 0;
            this.tabService.Size = new System.Drawing.Size(1039, 418);
            this.tabService.TabIndex = 0;
            // 
            // Repairs
            // 
            this.Repairs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Repairs.Controls.Add(this.splitContainer2);
            this.Repairs.ForeColor = System.Drawing.Color.Black;
            this.Repairs.Location = new System.Drawing.Point(4, 22);
            this.Repairs.Name = "Repairs";
            this.Repairs.Padding = new System.Windows.Forms.Padding(3);
            this.Repairs.Size = new System.Drawing.Size(1031, 392);
            this.Repairs.TabIndex = 0;
            this.Repairs.Text = "Ремонты";
            this.Repairs.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(30, 36);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView_Repairs);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSave);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(970, 328);
            this.splitContainer2.SplitterDistance = 743;
            this.splitContainer2.TabIndex = 3;
            // 
            // dataGridView_Repairs
            // 
            this.dataGridView_Repairs.AutoGenerateColumns = false;
            this.dataGridView_Repairs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Repairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Repairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDсотрудникDataGridViewTextBoxColumn,
            this.iDклиентDataGridViewTextBoxColumn,
            this.iDзапчастьDataGridViewTextBoxColumn,
            this.iDработаDataGridViewTextBoxColumn,
            this.датаремонтаDataGridViewTextBoxColumn,
            this.наименованиеработыDataGridViewTextBoxColumn,
            this.стоимостьРубDataGridViewTextBoxColumn});
            this.dataGridView_Repairs.DataSource = this.ремонтBindingSource;
            this.dataGridView_Repairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Repairs.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Repairs.Name = "dataGridView_Repairs";
            this.dataGridView_Repairs.Size = new System.Drawing.Size(743, 328);
            this.dataGridView_Repairs.TabIndex = 0;
            this.dataGridView_Repairs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Repairs_CellContentClick);
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave.Location = new System.Drawing.Point(72, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button5_Click);
            // 
            // tapParts
            // 
            this.tapParts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tapParts.Controls.Add(this.splitContainer3);
            this.tapParts.Location = new System.Drawing.Point(4, 22);
            this.tapParts.Name = "tapParts";
            this.tapParts.Padding = new System.Windows.Forms.Padding(3);
            this.tapParts.Size = new System.Drawing.Size(1031, 392);
            this.tapParts.TabIndex = 1;
            this.tapParts.Text = "Запчасти";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(133, 81);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView_Parts);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnSave2);
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(762, 155);
            this.splitContainer3.SplitterDistance = 583;
            this.splitContainer3.TabIndex = 3;
            // 
            // dataGridView_Parts
            // 
            this.dataGridView_Parts.AutoGenerateColumns = false;
            this.dataGridView_Parts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDзапчастьDataGridViewTextBoxColumn1,
            this.наименованиезапчастиDataGridViewTextBoxColumn,
            this.стоимостьзапчастиDataGridViewTextBoxColumn});
            this.dataGridView_Parts.DataSource = this.запчастиBindingSource;
            this.dataGridView_Parts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Parts.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Parts.Name = "dataGridView_Parts";
            this.dataGridView_Parts.Size = new System.Drawing.Size(583, 155);
            this.dataGridView_Parts.TabIndex = 0;
            // 
            // btnSave2
            // 
            this.btnSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave2.BackColor = System.Drawing.Color.Black;
            this.btnSave2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave2.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave2.Location = new System.Drawing.Point(46, 60);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(83, 38);
            this.btnSave2.TabIndex = 0;
            this.btnSave2.Text = "Сохранить";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // tabClients
            // 
            this.tabClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabClients.Controls.Add(this.splitContainer4);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(1031, 392);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Клиенты";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Location = new System.Drawing.Point(20, 25);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView_Clients);
            this.splitContainer4.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnSave3);
            this.splitContainer4.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer4.Size = new System.Drawing.Size(983, 342);
            this.splitContainer4.SplitterDistance = 753;
            this.splitContainer4.TabIndex = 3;
            // 
            // dataGridView_Clients
            // 
            this.dataGridView_Clients.AutoGenerateColumns = false;
            this.dataGridView_Clients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDклиентDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView_Clients.DataSource = this.клиентыBindingSource;
            this.dataGridView_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Clients.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Clients.Name = "dataGridView_Clients";
            this.dataGridView_Clients.Size = new System.Drawing.Size(753, 342);
            this.dataGridView_Clients.TabIndex = 0;
            // 
            // btnSave3
            // 
            this.btnSave3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave3.BackColor = System.Drawing.Color.Black;
            this.btnSave3.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave3.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave3.Location = new System.Drawing.Point(56, 146);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(111, 58);
            this.btnSave3.TabIndex = 0;
            this.btnSave3.Text = "Сохранить";
            this.btnSave3.UseVisualStyleBackColor = false;
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // tabJobs
            // 
            this.tabJobs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabJobs.Controls.Add(this.splitContainer5);
            this.tabJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabJobs.Location = new System.Drawing.Point(4, 22);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobs.Size = new System.Drawing.Size(1031, 392);
            this.tabJobs.TabIndex = 3;
            this.tabJobs.Text = "Работы";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Location = new System.Drawing.Point(167, 105);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dataGridView_Jobs);
            this.splitContainer5.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnSave4);
            this.splitContainer5.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer5.Size = new System.Drawing.Size(688, 154);
            this.splitContainer5.SplitterDistance = 527;
            this.splitContainer5.TabIndex = 3;
            // 
            // dataGridView_Jobs
            // 
            this.dataGridView_Jobs.AutoGenerateColumns = false;
            this.dataGridView_Jobs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Jobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Jobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDработаDataGridViewTextBoxColumn1,
            this.наименованиеработыDataGridViewTextBoxColumn1,
            this.стоимостьработыDataGridViewTextBoxColumn});
            this.dataGridView_Jobs.DataSource = this.работыBindingSource;
            this.dataGridView_Jobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Jobs.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Jobs.Name = "dataGridView_Jobs";
            this.dataGridView_Jobs.Size = new System.Drawing.Size(527, 154);
            this.dataGridView_Jobs.TabIndex = 0;
            // 
            // btnSave4
            // 
            this.btnSave4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave4.BackColor = System.Drawing.Color.Black;
            this.btnSave4.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave4.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave4.Location = new System.Drawing.Point(41, 58);
            this.btnSave4.Name = "btnSave4";
            this.btnSave4.Size = new System.Drawing.Size(83, 38);
            this.btnSave4.TabIndex = 0;
            this.btnSave4.Text = "Сохранить";
            this.btnSave4.UseVisualStyleBackColor = false;
            this.btnSave4.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabStaff
            // 
            this.tabStaff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStaff.Controls.Add(this.splitContainer6);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(1031, 392);
            this.tabStaff.TabIndex = 4;
            this.tabStaff.Text = "Сотрудники";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Location = new System.Drawing.Point(51, 117);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.dataGridView_Staff);
            this.splitContainer6.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.btnSave5);
            this.splitContainer6.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer6.Size = new System.Drawing.Size(862, 122);
            this.splitContainer6.SplitterDistance = 660;
            this.splitContainer6.TabIndex = 2;
            // 
            // dataGridView_Staff
            // 
            this.dataGridView_Staff.AutoGenerateColumns = false;
            this.dataGridView_Staff.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDсотрудникDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.датарожденияDataGridViewTextBoxColumn1,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView_Staff.DataSource = this.сотрудникиBindingSource;
            this.dataGridView_Staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Staff.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Staff.Name = "dataGridView_Staff";
            this.dataGridView_Staff.Size = new System.Drawing.Size(660, 122);
            this.dataGridView_Staff.TabIndex = 0;
            // 
            // btnSave5
            // 
            this.btnSave5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave5.BackColor = System.Drawing.Color.Black;
            this.btnSave5.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave5.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave5.Location = new System.Drawing.Point(58, 40);
            this.btnSave5.Name = "btnSave5";
            this.btnSave5.Size = new System.Drawing.Size(83, 38);
            this.btnSave5.TabIndex = 0;
            this.btnSave5.Text = "Сохранить";
            this.btnSave5.UseVisualStyleBackColor = false;
            this.btnSave5.Click += new System.EventHandler(this.btnSave5_Click);
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // запчастиBindingSource
            // 
            this.запчастиBindingSource.DataMember = "Запчасти";
            this.запчастиBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // запчастиTableAdapter
            // 
            this.запчастиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // iDзапчастьDataGridViewTextBoxColumn1
            // 
            this.iDзапчастьDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDзапчастьDataGridViewTextBoxColumn1.DataPropertyName = "ID_запчасть";
            this.iDзапчастьDataGridViewTextBoxColumn1.HeaderText = "ID_запчасть";
            this.iDзапчастьDataGridViewTextBoxColumn1.Name = "iDзапчастьDataGridViewTextBoxColumn1";
            this.iDзапчастьDataGridViewTextBoxColumn1.Width = 95;
            // 
            // наименованиезапчастиDataGridViewTextBoxColumn
            // 
            this.наименованиезапчастиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.наименованиезапчастиDataGridViewTextBoxColumn.DataPropertyName = "Наименованиезапчасти";
            this.наименованиезапчастиDataGridViewTextBoxColumn.HeaderText = "Наименованиезапчасти";
            this.наименованиезапчастиDataGridViewTextBoxColumn.Name = "наименованиезапчастиDataGridViewTextBoxColumn";
            this.наименованиезапчастиDataGridViewTextBoxColumn.Width = 154;
            // 
            // стоимостьзапчастиDataGridViewTextBoxColumn
            // 
            this.стоимостьзапчастиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьзапчастиDataGridViewTextBoxColumn.DataPropertyName = "Стоимостьзапчасти";
            this.стоимостьзапчастиDataGridViewTextBoxColumn.HeaderText = "Стоимостьзапчасти";
            this.стоимостьзапчастиDataGridViewTextBoxColumn.Name = "стоимостьзапчастиDataGridViewTextBoxColumn";
            // 
            // работыBindingSource
            // 
            this.работыBindingSource.DataMember = "Работы";
            this.работыBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // работыTableAdapter
            // 
            this.работыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // iDсотрудникDataGridViewTextBoxColumn1
            // 
            this.iDсотрудникDataGridViewTextBoxColumn1.DataPropertyName = "ID_сотрудник";
            this.iDсотрудникDataGridViewTextBoxColumn1.HeaderText = "ID_сотрудник";
            this.iDсотрудникDataGridViewTextBoxColumn1.Name = "iDсотрудникDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.Width = 81;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            this.имяDataGridViewTextBoxColumn1.Width = 54;
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            this.отчествоDataGridViewTextBoxColumn1.Width = 79;
            // 
            // датарожденияDataGridViewTextBoxColumn1
            // 
            this.датарожденияDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.датарожденияDataGridViewTextBoxColumn1.DataPropertyName = "Датарождения";
            this.датарожденияDataGridViewTextBoxColumn1.HeaderText = "Датарождения";
            this.датарожденияDataGridViewTextBoxColumn1.Name = "датарожденияDataGridViewTextBoxColumn1";
            this.датарожденияDataGridViewTextBoxColumn1.Width = 108;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // iDработаDataGridViewTextBoxColumn1
            // 
            this.iDработаDataGridViewTextBoxColumn1.DataPropertyName = "ID_работа";
            this.iDработаDataGridViewTextBoxColumn1.HeaderText = "ID_работа";
            this.iDработаDataGridViewTextBoxColumn1.Name = "iDработаDataGridViewTextBoxColumn1";
            // 
            // наименованиеработыDataGridViewTextBoxColumn1
            // 
            this.наименованиеработыDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.наименованиеработыDataGridViewTextBoxColumn1.DataPropertyName = "Наименованиеработы";
            this.наименованиеработыDataGridViewTextBoxColumn1.HeaderText = "Наименованиеработы";
            this.наименованиеработыDataGridViewTextBoxColumn1.Name = "наименованиеработыDataGridViewTextBoxColumn1";
            this.наименованиеработыDataGridViewTextBoxColumn1.Width = 145;
            // 
            // стоимостьработыDataGridViewTextBoxColumn
            // 
            this.стоимостьработыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьработыDataGridViewTextBoxColumn.DataPropertyName = "Стоимостьработы";
            this.стоимостьработыDataGridViewTextBoxColumn.HeaderText = "Стоимостьработы";
            this.стоимостьработыDataGridViewTextBoxColumn.Name = "стоимостьработыDataGridViewTextBoxColumn";
            // 
            // iDсотрудникDataGridViewTextBoxColumn
            // 
            this.iDсотрудникDataGridViewTextBoxColumn.DataPropertyName = "ID_сотрудник";
            this.iDсотрудникDataGridViewTextBoxColumn.HeaderText = "ID_сотрудник";
            this.iDсотрудникDataGridViewTextBoxColumn.Name = "iDсотрудникDataGridViewTextBoxColumn";
            // 
            // iDклиентDataGridViewTextBoxColumn
            // 
            this.iDклиентDataGridViewTextBoxColumn.DataPropertyName = "ID_клиент";
            this.iDклиентDataGridViewTextBoxColumn.HeaderText = "ID_клиент";
            this.iDклиентDataGridViewTextBoxColumn.Name = "iDклиентDataGridViewTextBoxColumn";
            // 
            // iDзапчастьDataGridViewTextBoxColumn
            // 
            this.iDзапчастьDataGridViewTextBoxColumn.DataPropertyName = "ID_запчасть";
            this.iDзапчастьDataGridViewTextBoxColumn.HeaderText = "ID_запчасть";
            this.iDзапчастьDataGridViewTextBoxColumn.Name = "iDзапчастьDataGridViewTextBoxColumn";
            // 
            // iDработаDataGridViewTextBoxColumn
            // 
            this.iDработаDataGridViewTextBoxColumn.DataPropertyName = "ID_работа";
            this.iDработаDataGridViewTextBoxColumn.HeaderText = "ID_работа";
            this.iDработаDataGridViewTextBoxColumn.Name = "iDработаDataGridViewTextBoxColumn";
            // 
            // датаремонтаDataGridViewTextBoxColumn
            // 
            this.датаремонтаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.датаремонтаDataGridViewTextBoxColumn.DataPropertyName = "Датаремонта";
            this.датаремонтаDataGridViewTextBoxColumn.HeaderText = "Датаремонта";
            this.датаремонтаDataGridViewTextBoxColumn.Name = "датаремонтаDataGridViewTextBoxColumn";
            this.датаремонтаDataGridViewTextBoxColumn.Width = 101;
            // 
            // наименованиеработыDataGridViewTextBoxColumn
            // 
            this.наименованиеработыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.наименованиеработыDataGridViewTextBoxColumn.DataPropertyName = "Наименованиеработы";
            this.наименованиеработыDataGridViewTextBoxColumn.HeaderText = "Наименованиеработы";
            this.наименованиеработыDataGridViewTextBoxColumn.Name = "наименованиеработыDataGridViewTextBoxColumn";
            this.наименованиеработыDataGridViewTextBoxColumn.Width = 145;
            // 
            // стоимостьРубDataGridViewTextBoxColumn
            // 
            this.стоимостьРубDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьРубDataGridViewTextBoxColumn.DataPropertyName = "СтоимостьРуб";
            this.стоимостьРубDataGridViewTextBoxColumn.HeaderText = "СтоимостьРуб";
            this.стоимостьРубDataGridViewTextBoxColumn.Name = "стоимостьРубDataGridViewTextBoxColumn";
            // 
            // iDклиентDataGridViewTextBoxColumn1
            // 
            this.iDклиентDataGridViewTextBoxColumn1.DataPropertyName = "ID_клиент";
            this.iDклиентDataGridViewTextBoxColumn1.HeaderText = "ID_клиент";
            this.iDклиентDataGridViewTextBoxColumn1.Name = "iDклиентDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 81;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 54;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 79;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Датарождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Датарождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.Width = 108;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 77;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 524);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.Repairs.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tapParts.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parts)).EndInit();
            this.tabClients.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).EndInit();
            this.tabJobs.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jobs)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabService;
        private System.Windows.Forms.TabPage Repairs;
        private System.Windows.Forms.TabPage tapParts;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabJobs;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView_Repairs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView_Parts;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView_Clients;
        private System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dataGridView_Jobs;
        private System.Windows.Forms.Button btnSave4;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView dataGridView_Staff;
        private System.Windows.Forms.Button btnSave5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private DataSet1TableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource запчастиBindingSource;
        private DataSet1TableAdapters.ЗапчастиTableAdapter запчастиTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private DataSet1TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзапчастьDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиезапчастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьзапчастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource работыBindingSource;
        private DataSet1TableAdapters.РаботыTableAdapter работыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private DataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDсотрудникDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDработаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеработыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDсотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDклиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзапчастьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDработаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаремонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьРубDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDклиентDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
    }
}

