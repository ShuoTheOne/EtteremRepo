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

        public Form1()
        {
            InitializeComponent();
            konyvManager = new KonyvekTabla();
            records_KonyvekList = new List<Konyvek>();
            bgWorker = new BackgroundWorker();
        }



    }
}
