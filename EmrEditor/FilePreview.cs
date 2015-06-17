using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmrEditor
{
    public partial class FilePreview : Form
    {
        public static string uriString = "";

        public FilePreview()
        {
            InitializeComponent();
        }

        private void FilePreview_Load(object sender, EventArgs e)
        {
            wb_preview.Url = new Uri(uriString);
        }
    }
}
