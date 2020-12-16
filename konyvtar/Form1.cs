using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using konyvtar.Models.Manager;
using konyvtar.Models.Records;

namespace konyvtar
{
    public partial class Form1 : Form
    {

        KonyvekTabla konyvManager;
        List<Konyvek> records_KonyvekList;
        KiadokTabla kiadoManager;
        List<Kiadok> records_KiadokList;


        public Form1()
        {
            InitializeComponent();
            konyvManager = new KonyvekTabla();
            records_KonyvekList = new List<Konyvek>();
            kiadoManager = new KiadokTabla();
            records_KiadokList = new List<Kiadok>();
            backgroundWorker1.RunWorkerAsync();

            InitializeDataGridView();
            InitializeDataGridView2();

        }

        // WORKER

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            records_KonyvekList = konyvManager.Select();
            records_KiadokList = kiadoManager.Select();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
            FillDataGridView2();
        }


        // BESZÚRÁS GOMBOK
        private void btn_Beszuras_Click(object sender, EventArgs e)
        {

            Konyvek konyv = new Konyvek()
            {
                Raktari_szam = tb_Raktari_szam.Text,
                Kiado_id = tb_Kiado.Text,
                Cim = tb_Cim.Text,
                Kiadas_eve = tb_Kiadas_eve.Text,
                Mufaj = (Mufaj)cb_Mufaj.SelectedItem
            };
            konyvManager.Insert(konyv);
            backgroundWorker1.RunWorkerAsync();

            MessageBox.Show("Sikeres könyv hozzáadás!");
            tb_Konyv_id.Clear();
            tb_Raktari_szam.Clear();
            tb_Kiado.Clear();
            tb_Cim.Clear();
        }

        private void btn_Kiado_Beszuras_Click(object sender, EventArgs e)
        {
            try
            {
                Kiadok kiado = new Kiadok()
                {
                    Id = tb_Kiado_Nev.Text,
                    Nev = tb_Kiado_Nev.Text
                };
                kiadoManager.Insert(kiado);
                backgroundWorker1.RunWorkerAsync();

                MessageBox.Show("Sikeres kiadó hozzáadás!");
                tb_Kiado_Nev.Clear();
            }
            catch(InvalidRaktariSzamException)
            {
                MessageBox.Show("A raktári szám mező helytelen");
            }
            catch(InvalidKiadoException)
            {
                MessageBox.Show("A kiadó mező helytelen");
            }
            catch(InvalidCimException)
            {
                MessageBox.Show("A cím helytelen");
            }

        }

        // UPDATE GOMBOK

        private void btn_Kiado_Update_Click(object sender, EventArgs e)
        {



            Kiadok temp = new Kiadok()
            {
                Id = dgv_Kiadok.CurrentRow.Cells["id"].Value.ToString(),
                Nev = tb_Kiado_Nev.Text
            };
            kiadoManager.Update(temp);
            backgroundWorker1.RunWorkerAsync();
            MessageBox.Show(string.Format("Updatelve"));

        }

        private void btn_Update_Konyv_Click(object sender, EventArgs e)
        {
            int UpdateSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Konyvek.SelectedRows)
            {
                Konyvek UpdateRekord = new Konyvek();
                UpdateRekord.Id = selectedRows.Cells["id"].Value.ToString();
                konyvManager.Update(UpdateRekord);
            }
            MessageBox.Show(string.Format("{0} sor lett updatelve", UpdateSorok));
            backgroundWorker1.RunWorkerAsync();
        }

        // TÖRLÉS GOMBOK

        private void btn_Torles_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Konyvek.SelectedRows)
            {
                Konyvek TorlendoRekord = new Konyvek();
                TorlendoRekord.Id = selectedRows.Cells["id"].Value.ToString();

                ToroltSorok += konyvManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor lett törölve", ToroltSorok));
            if (ToroltSorok != 0)
            {
                backgroundWorker1.RunWorkerAsync();
            }
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
                backgroundWorker1.RunWorkerAsync();
            }
        }

        // FORM 1 COMMANDOK

        private void Form1_Load_1(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            cb_Mufaj.DataSource = Enum.GetValues(typeof(Mufaj));

            InitializeDataGridView();
        }

        // INITIALIZE DGV

        private void InitializeDataGridView()
        {
            dgv_Konyvek.Rows.Clear();
            dgv_Konyvek.Columns.Clear();

            DataGridViewColumn IdColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "id",
                HeaderText = "Könyv ID",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Konyvek.Columns.Add(IdColumn);

            DataGridViewColumn Raktari_szamColumn = new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "raktari_szam",
                HeaderText = "Raktári Szám",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            };
            dgv_Konyvek.Columns.Add(Raktari_szamColumn);

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

        // FILL DGV-K

        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[records_KonyvekList.Count];

            for (int i = 0; i < records_KonyvekList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell IdCell = new DataGridViewTextBoxCell();
                IdCell.Value = records_KonyvekList[i].Id;
                dataGridViewRow.Cells.Add(IdCell);

                DataGridViewCell Raktari_szamCell = new DataGridViewTextBoxCell();
                Raktari_szamCell.Value = records_KonyvekList[i].Raktari_szam;
                dataGridViewRow.Cells.Add(Raktari_szamCell);

                DataGridViewCell KiadoCell = new DataGridViewTextBoxCell();
                KiadoCell.Value = records_KonyvekList[i].Kiado_id;
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

        private void FillDataGridView2()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[records_KiadokList.Count];

            for (int i = 0; i < records_KiadokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell IdCell = new DataGridViewTextBoxCell();
                IdCell.Value = records_KiadokList[i].Id;
                dataGridViewRow.Cells.Add(IdCell);

                DataGridViewCell NevCell = new DataGridViewTextBoxCell();
                NevCell.Value = records_KiadokList[i].Nev;
                dataGridViewRow.Cells.Add(NevCell);


                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_Kiadok.Rows.Clear();
            dgv_Kiadok.Rows.AddRange(dataGridViewRows);
        }


        // LEAVE UTASÍTÁSOK
        private void tb_Konyv_id_Leave(object sender, EventArgs e)
        {
            string actual = tb_Konyv_id.Text;
             konyvManager.CheckKonyv_id(actual);
         //  tb_Konyv_id.BackColor = Correct ? Color.Green : Color.Red;
        }

        private void tb_Raktari_szam_Leave(object sender, EventArgs e)
        {
            string actual = tb_Raktari_szam.Text;
            konyvManager.CheckRaktari_szam(actual);
         //  tb_Raktari_szam.BackColor = Correct ? Color.Green : Color.Red;
        }

        private void tb_Kiado_Id_Leave(object sender, EventArgs e)
        {
            string actual = tb_Kiado_Nev.Text;
            kiadoManager.CheckKiado_id(actual);
          //  tb_Kiado_Id.BackColor = Correct ? Color.Green : Color.Red;
        }
    }
}
