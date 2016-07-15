using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailGonder
{

    public partial class SelectedFileTool : UserControl
    {
        private string _fileName;
        public string FilePath { get; set; }

        //public RichTextBox Parent { get; set; }
        public SelectedFilePanel Parent { get; set; }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                lblFileName.Text = value;
            }
        }

        public SelectedFileTool()
        {
            InitializeComponent();
        }

        private void btnCancelAttach_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Parent.RefreshLocation(); 
        }
    }
}
