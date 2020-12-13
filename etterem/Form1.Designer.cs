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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Konyvek
            // 
            this.dgv_Konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Konyvek.Location = new System.Drawing.Point(50, 12);
            this.dgv_Konyvek.Name = "dgv_Konyvek";
            this.dgv_Konyvek.Size = new System.Drawing.Size(706, 261);
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
            this.btn_Torles.Location = new System.Drawing.Point(354, 369);
            this.btn_Torles.Name = "btn_Torles";
            this.btn_Torles.Size = new System.Drawing.Size(87, 38);
            this.btn_Torles.TabIndex = 2;
            this.btn_Torles.Text = "Törlés";
            this.btn_Torles.UseVisualStyleBackColor = true;
            this.btn_Torles.Click += new System.EventHandler(this.btn_Torles_Click);
            // 
            // btn_Beszuras
            // 
            this.btn_Beszuras.Location = new System.Drawing.Point(354, 298);
            this.btn_Beszuras.Name = "btn_Beszuras";
            this.btn_Beszuras.Size = new System.Drawing.Size(87, 38);
            this.btn_Beszuras.TabIndex = 3;
            this.btn_Beszuras.Text = "Beszúrás";
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
            this.lblKiadas_eve.Location = new System.Drawing.Point(495, 321);
            this.lblKiadas_eve.Name = "lblKiadas_eve";
            this.lblKiadas_eve.Size = new System.Drawing.Size(60, 13);
            this.lblKiadas_eve.TabIndex = 7;
            this.lblKiadas_eve.Text = "Kiadás éve";
            // 
            // lblMufaj
            // 
            this.lblMufaj.AutoSize = true;
            this.lblMufaj.Location = new System.Drawing.Point(51, 414);
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
            this.dt_Kiadas_eve.Location = new System.Drawing.Point(561, 318);
            this.dt_Kiadas_eve.Name = "dt_Kiadas_eve";
            this.dt_Kiadas_eve.Size = new System.Drawing.Size(200, 20);
            this.dt_Kiadas_eve.TabIndex = 13;
            // 
            // cb_Mufaj
            // 
            this.cb_Mufaj.FormattingEnabled = true;
            this.cb_Mufaj.Location = new System.Drawing.Point(126, 414);
            this.cb_Mufaj.Name = "cb_Mufaj";
            this.cb_Mufaj.Size = new System.Drawing.Size(182, 21);
            this.cb_Mufaj.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

