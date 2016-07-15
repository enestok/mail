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
    public partial class SelectedFilePanel : UserControl
    {
        public SelectedFilePanel()
        {
            InitializeComponent();
        }

        private int _ly = 10;

        public void AddTool(List<string> pathList)
        {

            foreach (var item in pathList)
            {
                var tool = new SelectedFileTool();
                tool.FileName = item.ToString();
                tool.Parent = this;

                tool.Location = new Point(5, _ly);
                this.Controls.Add(tool);

                _ly += 35;
            }
        }

        private void SelectedFilePanel_Load(object sender, EventArgs e)
        {

        }

        public void RefreshLocation()
        {
            _ly = 10;
      
            foreach (Control cntr in this.Controls)
            {
                if (cntr is SelectedFileTool)
                {
                    cntr.Location = new Point(5, _ly);

                    _ly += 40; 
                }

            }
        }


    }
}
