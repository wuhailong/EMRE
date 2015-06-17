using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMRE;

namespace EmrEditor
{
    public partial class FormatData : Form
    {
        EEditor editor = null;
        public static string OutPutLabel = "";

        public FormatData()
        {
            InitializeComponent();
        }

        public FormatData(EEditor _editor)
        {
            InitializeComponent();
            editor = _editor;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string _strSelectedNode = tv_data.SelectedNode.Text;
            switch (_strSelectedNode)
            {
                case "文本框":
                    {
                        OutPutLabel = "<input type = 'text' name = '" + txt_name.Text + "' onclick={alert('asdf')}>";
                    } break;

                default:
                    break;
            }
            editor.InsertHtml(OutPutLabel);
        }

        public void MakeLabel() { }

        private void tv_data_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
