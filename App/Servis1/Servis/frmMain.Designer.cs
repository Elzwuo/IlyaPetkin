
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
            this.Exit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabService = new System.Windows.Forms.TabControl();
            this.Repair = new System.Windows.Forms.TabPage();
            this.tapParts = new System.Windows.Forms.TabPage();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.tabJobs = new System.Windows.Forms.TabPage();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataRepairs = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabService.SuspendLayout();
            this.Repair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepairs)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Exit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.Location = new System.Drawing.Point(230, 27);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.splitContainer1.Location = new System.Drawing.Point(148, 26);
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
            this.splitContainer1.Panel2.Controls.Add(this.Exit);
            this.splitContainer1.Size = new System.Drawing.Size(516, 412);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.Repair);
            this.tabService.Controls.Add(this.tapParts);
            this.tabService.Controls.Add(this.tabClients);
            this.tabService.Controls.Add(this.tabJobs);
            this.tabService.Controls.Add(this.tabStaff);
            this.tabService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabService.Location = new System.Drawing.Point(0, 0);
            this.tabService.Name = "tabService";
            this.tabService.SelectedIndex = 0;
            this.tabService.Size = new System.Drawing.Size(516, 355);
            this.tabService.TabIndex = 0;
            // 
            // Repair
            // 
            this.Repair.BackColor = System.Drawing.Color.Gainsboro;
            this.Repair.Controls.Add(this.splitContainer2);
            this.Repair.ForeColor = System.Drawing.Color.Black;
            this.Repair.Location = new System.Drawing.Point(4, 22);
            this.Repair.Name = "Repair";
            this.Repair.Padding = new System.Windows.Forms.Padding(3);
            this.Repair.Size = new System.Drawing.Size(508, 329);
            this.Repair.TabIndex = 0;
            this.Repair.Text = "Ремонт";
            this.Repair.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tapParts
            // 
            this.tapParts.BackColor = System.Drawing.Color.Bisque;
            this.tapParts.Location = new System.Drawing.Point(4, 22);
            this.tapParts.Name = "tapParts";
            this.tapParts.Padding = new System.Windows.Forms.Padding(3);
            this.tapParts.Size = new System.Drawing.Size(508, 329);
            this.tapParts.TabIndex = 1;
            this.tapParts.Text = "Запчасти";
            // 
            // tabClients
            // 
            this.tabClients.BackColor = System.Drawing.Color.Lavender;
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(508, 329);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Клиенты";
            // 
            // tabJobs
            // 
            this.tabJobs.BackColor = System.Drawing.Color.Cornsilk;
            this.tabJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabJobs.Location = new System.Drawing.Point(4, 22);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobs.Size = new System.Drawing.Size(508, 329);
            this.tabJobs.TabIndex = 3;
            this.tabJobs.Text = "Работы";
            // 
            // tabStaff
            // 
            this.tabStaff.BackColor = System.Drawing.Color.AliceBlue;
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(508, 329);
            this.tabStaff.TabIndex = 4;
            this.tabStaff.Text = "Сотрудники";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(6, 6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataRepairs);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Save);
            this.splitContainer2.Size = new System.Drawing.Size(496, 317);
            this.splitContainer2.SplitterDistance = 382;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataRepairs
            // 
            this.dataRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRepairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRepairs.Location = new System.Drawing.Point(0, 0);
            this.dataRepairs.Name = "dataRepairs";
            this.dataRepairs.Size = new System.Drawing.Size(382, 317);
            this.dataRepairs.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Black;
            this.Save.ForeColor = System.Drawing.Color.Lime;
            this.Save.Location = new System.Drawing.Point(19, 27);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.Repair.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRepairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabService;
        private System.Windows.Forms.TabPage Repair;
        private System.Windows.Forms.TabPage tapParts;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabJobs;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataRepairs;
        private System.Windows.Forms.Button Save;
    }
}

