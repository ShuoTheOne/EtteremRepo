using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using etterem.Models.Manager;
using etterem.Models.Records;

namespace etterem
{
    public partial class Form1 : Form
    {

        KonyvekTabla konyvManager;
        List<Konyvek> records_KonyvekList;
        BackgroundWorker bgWorker;

        KiadokTabla kiadoManager;
        List<Kiadok> records_KiadokList;
        BackgroundWorker bgWorker2;

        public Form1()
        {
            InitializeComponent();
            konyvManager = new KonyvekTabla();
            records_KonyvekList = new List<Konyvek>();
            bgWorker = new BackgroundWorker();

            kiadoManager = new KiadokTabla();
            records_KiadokList = new List<Kiadok>();
            bgWorker2 = new BackgroundWorker();


            InitializeDataGridView();
            InitializeDataGridView2();
        }

        private void btn_Torles_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Konyvek.SelectedRows)
            {
                Konyvek TorlendoRekord = new Konyvek();
                TorlendoRekord.Konyv_id = selectedRows.Cells["konyv_id"].Value.ToString();

                ToroltSorok += konyvManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor lett törölve", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void btn_Beszuras_Click(object sender, EventArgs e)
        {
            Konyvek konyv = new Konyvek()
            {
                Konyv_id = tb_Konyv_id.Text,
                Raktari_szam = tb_Raktari_szam.Text,
                Kiado = tb_Kiado.Text,
                Cim = tb_Cim.Text,
                Mufaj = (Mufaj)cb_Mufaj.SelectedItem,
                Kiadas_eve = dt_Kiadas_eve.Value
            };
            konyvManager.Insert(konyv);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Sikeres könyv hozzáadás!");
            tb_Konyv_id.Clear();
            tb_Raktari_szam.Clear();
            tb_Kiado.Clear();
            tb_Cim.Clear();
        }

       
        private void Form1_Show(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            bgWorker2.RunWorkerAsync();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker2.WorkerSupportsCancellation = true;

            dt_Kiadas_eve.CustomFormat = "yyyy";
            dt_Kiadas_eve.ShowUpDown = true;
            cb_Mufaj.DataSource = Enum.GetValues(typeof(Mufaj));

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgv_Konyvek.Rows.Clear();
            dgv_Konyvek.Columns.Clear();

            DataGridViewColumn Konyv_idColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
            Name = "konyv_id",
                HeaderText = "Könyv ID",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Konyvek.Columns.Add(Konyv_idColumn);

            DataGridViewColumn KiadoColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "kiado",
                HeaderText = "Kiadó",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Konyvek.Columns.Add(KiadoColumn);

            DataGridViewColumn CimColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "cim",
                HeaderText = "Cím",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            dgv_Konyvek.Columns.Add(CimColumn);

            DataGridViewColumn MufajColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "mufaj",
                HeaderText = "Műfaj",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Konyvek.Columns.Add(MufajColumn);

            DataGridViewColumn Kiadas_eveColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "kiadas_eve",
                HeaderText = "Kiadás Éve",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Konyvek.Columns.Add(Kiadas_eveColumn);
        }

        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }


        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            records_KonyvekList = konyvManager.Select();
        }

        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[records_KonyvekList.Count];

            for (int i = 0; i < records_KonyvekList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell Konyv_idCell = new DataGridViewTextBoxCell();
                Konyv_idCell.Value = records_KonyvekList[i].Konyv_id;
                dataGridViewRow.Cells.Add(Konyv_idCell);

                DataGridViewCell Raktari_szamCell = new DataGridViewTextBoxCell();
                Raktari_szamCell.Value = records_KonyvekList[i].Raktari_szam;
                dataGridViewRow.Cells.Add(Raktari_szamCell);

                DataGridViewCell KiadoCell = new DataGridViewTextBoxCell();
                KiadoCell.Value = records_KonyvekList[i].Kiado;
                dataGridViewRow.Cells.Add(KiadoCell);

                DataGridViewCell CimCell = new DataGridViewTextBoxCell();
                CimCell.Value = records_KonyvekList[i].Cim;
                dataGridViewRow.Cells.Add(CimCell);

                DataGridViewCell MufajCell = new DataGridViewTextBoxCell();
                MufajCell.Value = records_KonyvekList[i].Mufaj;
                dataGridViewRow.Cells.Add(MufajCell);

                DataGridViewCell Kiadas_eveCell = new DataGridViewTextBoxCell();
                Kiadas_eveCell.Value = records_KonyvekList[i].Kiadas_eve;
                dataGridViewRow.Cells.Add(Kiadas_eveCell);


                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_Konyvek.Rows.Clear();
            dgv_Konyvek.Rows.AddRange(dataGridViewRows);
        }

        private void tb_Konyv_id_Leave(object sender, EventArgs e)
        {
            string actual = tb_Konyv_id.Text;
            bool Correct = konyvManager.CheckKonyv_id(actual);
           tb_Konyv_id.BackColor = Correct ? Color.Green : Color.Red;
        }

        private void tb_Raktari_szam_Leave(object sender, EventArgs e)
        {
            string actual = tb_Raktari_szam.Text;
            bool Correct = konyvManager.CheckRaktari_szam(actual);
            tb_Raktari_szam.BackColor = Correct ? Color.Green : Color.Red;
        }

        private void tb_Kiado_Id_Leave(object sender, EventArgs e)
        {
            string actual = tb_Kiado_Id.Text;
              bool Correct = kiadoManager.CheckKiado_id(actual);
              tb_Kiado_Id.BackColor = Correct ? Color.Green : Color.Red;
        }

        private void btn_Kiado_Beszuras_Click(object sender, EventArgs e)
        {
            Kiadok kiado = new Kiadok()
            {
                Id = tb_Kiado_Id.Text,
                Nev = tb_Kiado_Nev.Text,
            };
            kiadoManager.Insert(kiado);
            bgWorker2.RunWorkerAsync();

            MessageBox.Show("Sikeres kiadó hozzáadás!");
            tb_Kiado_Id.Clear();
            tb_Kiado_Nev.Clear();
        }

        private void btn_Kiado_Torles_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Kiadok.SelectedRows)
            {
                Kiadok TorlendoRekord = new Kiadok();
                TorlendoRekord.Id = selectedRows.Cells["id"].Value.ToString();

                ToroltSorok += kiadoManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor lett törölve", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void InitializeDataGridView2()
        {
            dgv_Kiadok.Rows.Clear();
            dgv_Kiadok.Columns.Clear();

            DataGridViewColumn IdColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "id",
                HeaderText = "Kiadó ID",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Kiadok.Columns.Add(IdColumn);

            DataGridViewColumn NevColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "nev",
                HeaderText = "Név",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Kiadok.Columns.Add(NevColumn);
        }

        private void BgWorker_RunWorkerComplete2(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView2();
        }


        private void BgWorker_DoWork2(object sender, DoWorkEventArgs e)
        {
            records_KiadokList = kiadoManager.Select();
        }

        private void FillDataGridView2()
        {
            DataGridViewRow[] dataGridViewRows2 = new DataGridViewRow[records_KiadokList.Count];

            for (int i = 0; i < records_KiadokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell IdCell = new DataGridViewTextBoxCell();
                IdCell.Value = records_KiadokList[i].Id;
                dataGridViewRow.Cells.Add(IdCell);

                DataGridViewCell NevCell = new DataGridViewTextBoxCell();
                NevCell.Value = records_KiadokList[i].Nev;
                dataGridViewRow.Cells.Add(NevCell);


                dataGridViewRows2[i] = dataGridViewRow;
            }
            dgv_Kiadok.Rows.Clear();
            dgv_Kiadok.Rows.AddRange(dataGridViewRows2);
        }       
    }
}
