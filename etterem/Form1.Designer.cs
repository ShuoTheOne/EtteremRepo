namespace etterem
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
            this.dgv_Konyvek = new System.Windows.Forms.DataGridView();
            this.lblKonyv_id = new System.Windows.Forms.Label();
            this.btn_Torles = new System.Windows.Forms.Button();
            this.btn_Beszuras = new System.Windows.Forms.Button();
            this.lblRaktari_szam = new System.Windows.Forms.Label();
            this.lblKiado = new System.Windows.Forms.Label();
            this.lblCim = new System.Windows.Forms.Label();
            this.lblKiadas_eve = new System.Windows.Forms.Label();
            this.lblMufaj = new System.Windows.Forms.Label();
            this.tb_Konyv_id = new System.Windows.Forms.TextBox();
            this.tb_Raktari_szam = new System.Windows.Forms.TextBox();
            this.tb_Kiado = new System.Windows.Forms.TextBox();
            this.tb_Cim = new System.Windows.Forms.TextBox();
            this.dt_Kiadas_eve = new System.Windows.Forms.DateTimePicker();
            this.cb_Mufaj = new System.Windows.Forms.ComboBox();
            this.lbl_Kiado_Id = new System.Windows.Forms.Label();
            this.lbl_Kiado_Nev = new System.Windows.Forms.Label();
            this.tb_Kiado_Id = new System.Windows.Forms.TextBox();
            this.tb_Kiado_Nev = new System.Windows.Forms.TextBox();
            this.dgv_Kiadok = new System.Windows.Forms.DataGridView();
            this.btn_Kiado_Beszuras = new System.Windows.Forms.Button();
            this.btn_Kiado_Torles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kiadok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Konyvek
            // 
            this.dgv_Konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Konyvek.Location = new System.Drawing.Point(50, 12);
            this.dgv_Konyvek.Name = "dgv_Konyvek";
            this.dgv_Konyvek.Size = new System.Drawing.Size(643, 261);
            this.dgv_Konyvek.TabIndex = 0;
            // 
            // lblKonyv_id
            // 
            this.lblKonyv_id.AutoSize = true;
            this.lblKonyv_id.Location = new System.Drawing.Point(50, 298);
            this.lblKonyv_id.Name = "lblKonyv_id";
            this.lblKonyv_id.Size = new System.Drawing.Size(51, 13);
            this.lblKonyv_id.TabIndex = 1;
            this.lblKonyv_id.Text = "Könyv ID";
            // 
            // btn_Torles
            // 
            this.btn_Torles.Location = new System.Drawing.Point(511, 369);
            this.btn_Torles.Name = "btn_Torles";
            this.btn_Torles.Size = new System.Drawing.Size(144, 38);
            this.btn_Torles.TabIndex = 2;
            this.btn_Torles.Text = "Könyv Törlés";
            this.btn_Torles.UseVisualStyleBackColor = true;
            this.btn_Torles.Click += new System.EventHandler(this.btn_Torles_Click);
            // 
            // btn_Beszuras
            // 
            this.btn_Beszuras.Location = new System.Drawing.Point(348, 369);
            this.btn_Beszuras.Name = "btn_Beszuras";
            this.btn_Beszuras.Size = new System.Drawing.Size(146, 38);
            this.btn_Beszuras.TabIndex = 3;
            this.btn_Beszuras.Text = "Könyv Beszúrás";
            this.btn_Beszuras.UseVisualStyleBackColor = true;
            this.btn_Beszuras.Click += new System.EventHandler(this.btn_Beszuras_Click);
            // 
            // lblRaktari_szam
            // 
            this.lblRaktari_szam.AutoSize = true;
            this.lblRaktari_szam.Location = new System.Drawing.Point(50, 323);
            this.lblRaktari_szam.Name = "lblRaktari_szam";
            this.lblRaktari_szam.Size = new System.Drawing.Size(70, 13);
            this.lblRaktari_szam.TabIndex = 4;
            this.lblRaktari_szam.Text = "Raktári Szám";
            // 
            // lblKiado
            // 
            this.lblKiado.AutoSize = true;
            this.lblKiado.Location = new System.Drawing.Point(50, 351);
            this.lblKiado.Name = "lblKiado";
            this.lblKiado.Size = new System.Drawing.Size(34, 13);
            this.lblKiado.TabIndex = 5;
            this.lblKiado.Text = "Kiadó";
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Location = new System.Drawing.Point(50, 382);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(26, 13);
            this.lblCim.TabIndex = 6;
            this.lblCim.Text = "Cím";
            // 
            // lblKiadas_eve
            // 
            this.lblKiadas_eve.AutoSize = true;
            this.lblKiadas_eve.Location = new System.Drawing.Point(356, 298);
            this.lblKiadas_eve.Name = "lblKiadas_eve";
            this.lblKiadas_eve.Size = new System.Drawing.Size(60, 13);
            this.lblKiadas_eve.TabIndex = 7;
            this.lblKiadas_eve.Text = "Kiadás éve";
            // 
            // lblMufaj
            // 
            this.lblMufaj.AutoSize = true;
            this.lblMufaj.Location = new System.Drawing.Point(370, 328);
            this.lblMufaj.Name = "lblMufaj";
            this.lblMufaj.Size = new System.Drawing.Size(33, 13);
            this.lblMufaj.TabIndex = 8;
            this.lblMufaj.Text = "Műfaj";
            // 
            // tb_Konyv_id
            // 
            this.tb_Konyv_id.Location = new System.Drawing.Point(126, 295);
            this.tb_Konyv_id.Name = "tb_Konyv_id";
            this.tb_Konyv_id.Size = new System.Drawing.Size(182, 20);
            this.tb_Konyv_id.TabIndex = 9;
            this.tb_Konyv_id.Leave += new System.EventHandler(this.tb_Konyv_id_Leave);
            // 
            // tb_Raktari_szam
            // 
            this.tb_Raktari_szam.Location = new System.Drawing.Point(126, 321);
            this.tb_Raktari_szam.Name = "tb_Raktari_szam";
            this.tb_Raktari_szam.Size = new System.Drawing.Size(182, 20);
            this.tb_Raktari_szam.TabIndex = 10;
            this.tb_Raktari_szam.Leave += new System.EventHandler(this.tb_Raktari_szam_Leave);
            // 
            // tb_Kiado
            // 
            this.tb_Kiado.Location = new System.Drawing.Point(126, 348);
            this.tb_Kiado.Name = "tb_Kiado";
            this.tb_Kiado.Size = new System.Drawing.Size(182, 20);
            this.tb_Kiado.TabIndex = 11;
            // 
            // tb_Cim
            // 
            this.tb_Cim.Location = new System.Drawing.Point(126, 379);
            this.tb_Cim.Name = "tb_Cim";
            this.tb_Cim.Size = new System.Drawing.Size(182, 20);
            this.tb_Cim.TabIndex = 12;
            // 
            // dt_Kiadas_eve
            // 
            this.dt_Kiadas_eve.Location = new System.Drawing.Point(451, 292);
            this.dt_Kiadas_eve.Name = "dt_Kiadas_eve";
            this.dt_Kiadas_eve.Size = new System.Drawing.Size(227, 20);
            this.dt_Kiadas_eve.TabIndex = 13;
            // 
            // cb_Mufaj
            // 
            this.cb_Mufaj.FormattingEnabled = true;
            this.cb_Mufaj.Location = new System.Drawing.Point(451, 323);
            this.cb_Mufaj.Name = "cb_Mufaj";
            this.cb_Mufaj.Size = new System.Drawing.Size(227, 21);
            this.cb_Mufaj.TabIndex = 14;
            // 
            // lbl_Kiado_Id
            // 
            this.lbl_Kiado_Id.AutoSize = true;
            this.lbl_Kiado_Id.Location = new System.Drawing.Point(814, 299);
            this.lbl_Kiado_Id.Name = "lbl_Kiado_Id";
            this.lbl_Kiado_Id.Size = new System.Drawing.Size(48, 13);
            this.lbl_Kiado_Id.TabIndex = 15;
            this.lbl_Kiado_Id.Text = "Kiadó ID";
            // 
            // lbl_Kiado_Nev
            // 
            this.lbl_Kiado_Nev.AutoSize = true;
            this.lbl_Kiado_Nev.Location = new System.Drawing.Point(814, 331);
            this.lbl_Kiado_Nev.Name = "lbl_Kiado_Nev";
            this.lbl_Kiado_Nev.Size = new System.Drawing.Size(57, 13);
            this.lbl_Kiado_Nev.TabIndex = 16;
            this.lbl_Kiado_Nev.Text = "Kiado Név";
            // 
            // tb_Kiado_Id
            // 
            this.tb_Kiado_Id.Location = new System.Drawing.Point(911, 295);
            this.tb_Kiado_Id.Name = "tb_Kiado_Id";
            this.tb_Kiado_Id.Size = new System.Drawing.Size(100, 20);
            this.tb_Kiado_Id.TabIndex = 17;
            // 
            // tb_Kiado_Nev
            // 
            this.tb_Kiado_Nev.Location = new System.Drawing.Point(911, 331);
            this.tb_Kiado_Nev.Name = "tb_Kiado_Nev";
            this.tb_Kiado_Nev.Size = new System.Drawing.Size(100, 20);
            this.tb_Kiado_Nev.TabIndex = 18;
            // 
            // dgv_Kiadok
            // 
            this.dgv_Kiadok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kiadok.Location = new System.Drawing.Point(751, 12);
            this.dgv_Kiadok.Name = "dgv_Kiadok";
            this.dgv_Kiadok.Size = new System.Drawing.Size(365, 261);
            this.dgv_Kiadok.TabIndex = 19;
            // 
            // btn_Kiado_Beszuras
            // 
            this.btn_Kiado_Beszuras.Location = new System.Drawing.Point(817, 371);
            this.btn_Kiado_Beszuras.Name = "btn_Kiado_Beszuras";
            this.btn_Kiado_Beszuras.Size = new System.Drawing.Size(110, 36);
            this.btn_Kiado_Beszuras.TabIndex = 20;
            this.btn_Kiado_Beszuras.Text = "Kiadó Beszúrás";
            this.btn_Kiado_Beszuras.UseVisualStyleBackColor = true;
            this.btn_Kiado_Beszuras.Click += new System.EventHandler(this.btn_Kiado_Beszuras_Click);
            // 
            // btn_Kiado_Torles
            // 
            this.btn_Kiado_Torles.Location = new System.Drawing.Point(954, 370);
            this.btn_Kiado_Torles.Name = "btn_Kiado_Torles";
            this.btn_Kiado_Torles.Size = new System.Drawing.Size(110, 36);
            this.btn_Kiado_Torles.TabIndex = 21;
            this.btn_Kiado_Torles.Text = "Kiadó Törlés";
            this.btn_Kiado_Torles.UseVisualStyleBackColor = true;
            this.btn_Kiado_Torles.Click += new System.EventHandler(this.btn_Kiado_Torles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 428);
            this.Controls.Add(this.btn_Kiado_Torles);
            this.Controls.Add(this.btn_Kiado_Beszuras);
            this.Controls.Add(this.dgv_Kiadok);
            this.Controls.Add(this.tb_Kiado_Nev);
            this.Controls.Add(this.tb_Kiado_Id);
            this.Controls.Add(this.lbl_Kiado_Nev);
            this.Controls.Add(this.lbl_Kiado_Id);
            this.Controls.Add(this.cb_Mufaj);
            this.Controls.Add(this.dt_Kiadas_eve);
            this.Controls.Add(this.tb_Cim);
            this.Controls.Add(this.tb_Kiado);
            this.Controls.Add(this.tb_Raktari_szam);
            this.Controls.Add(this.tb_Konyv_id);
            this.Controls.Add(this.lblMufaj);
            this.Controls.Add(this.lblKiadas_eve);
            this.Controls.Add(this.lblCim);
            this.Controls.Add(this.lblKiado);
            this.Controls.Add(this.lblRaktari_szam);
            this.Controls.Add(this.btn_Beszuras);
            this.Controls.Add(this.btn_Torles);
            this.Controls.Add(this.lblKonyv_id);
            this.Controls.Add(this.dgv_Konyvek);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kiadok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Konyvek;
        private System.Windows.Forms.Label lblKonyv_id;
        private System.Windows.Forms.Button btn_Torles;
        private System.Windows.Forms.Button btn_Beszuras;
        private System.Windows.Forms.Label lblRaktari_szam;
        private System.Windows.Forms.Label lblKiado;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblKiadas_eve;
        private System.Windows.Forms.Label lblMufaj;
        private System.Windows.Forms.TextBox tb_Konyv_id;
        private System.Windows.Forms.TextBox tb_Raktari_szam;
        private System.Windows.Forms.TextBox tb_Kiado;
        private System.Windows.Forms.TextBox tb_Cim;
        private System.Windows.Forms.DateTimePicker dt_Kiadas_eve;
        private System.Windows.Forms.ComboBox cb_Mufaj;
        private System.Windows.Forms.Label lbl_Kiado_Id;
        private System.Windows.Forms.Label lbl_Kiado_Nev;
        private System.Windows.Forms.TextBox tb_Kiado_Id;
        private System.Windows.Forms.TextBox tb_Kiado_Nev;
        private System.Windows.Forms.DataGridView dgv_Kiadok;
        private System.Windows.Forms.Button btn_Kiado_Beszuras;
        private System.Windows.Forms.Button btn_Kiado_Torles;
    }
}

