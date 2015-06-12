using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;

namespace EMRE
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]//　　注意： 类定义前需要加上下面两行，否则调用失败！
    [System.Runtime.InteropServices.ComVisibleAttribute(true)] 
    public partial class EMRE : Form
    {
        public EMRE()
        {
            InitializeComponent();
            string _strEditorPath = Application.StartupPath+@"/Editor/index.html";
            System.IO.FileInfo file = new System.IO.FileInfo(_strEditorPath);
            EEditor editor = new EEditor();
            this.Controls.Add(editor);
            editor.Dock = DockStyle.Fill;
            

        }



      
        

       
    }
}
