using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailGonder
{
    public partial class Frm_AliciEkle : Form
    {
        public Frm_AliciEkle()
        {
            InitializeComponent();
            new RehberBLL.Common().Deneme();
        }
    }
}
