using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Работы". При необходимости она может быть перемещена или удалена.
            this.работыTableAdapter.Fill(this.dataSet1.Работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.dataSet1.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.dataSet1.Запчасти);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.dataSet1.Ремонт);

            dataGridView_Repairs.Columns["iDсотрудникDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_Repairs.Columns["iDклиентDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_Repairs.Columns["iDзапчастьDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_Repairs.Columns["iDработаDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_Parts.Columns["iDзапчастьDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Clients.Columns["iDклиентDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Jobs.Columns["iDработаDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Staff.Columns["iDсотрудникDataGridViewTextBoxColumn1"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            CenterToScreen ();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataRepairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ремонтTableAdapter.Update(this.dataSet1.Ремонт);
        }

        private void dataGridView_Repairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.работыTableAdapter.Update(this.dataSet1.Работы);
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            this.запчастиTableAdapter.Update(this.dataSet1.Запчасти);
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.Update(this.dataSet1.Клиенты);
        }

        private void btnSave5_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Update(this.dataSet1.Сотрудники);
        }
    }
}
