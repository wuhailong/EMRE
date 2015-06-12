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
            string _strEditorPath = Application.StartupPath + @"\Editor\index.html";
            System.IO.FileInfo file = new System.IO.FileInfo(_strEditorPath);

            // WebBrowser控件显示的网页路径
            wb_editor.Url = new Uri(file.FullName);
            // 将当前类设置为可由脚本访问
            wb_editor.ObjectForScripting = this;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //object[] o = new object[1];
            //o[0] = "测试";
            //object result = this.wb_editor.Document.InvokeScript("ShowMessage", o);

            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
            
        }

        #region 菜单
        
       
        private void 获取整个htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
        }

        private void 获取内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getContent");
        }

        private void 写入内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("setContent");
        }

        private void 追加内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object[] o = new object[1];
            o[0] = true;
            object result = this.wb_editor.Document.InvokeScript("setContent",o);
        }

        private void 获取纯文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getContentTxt");
        }

        private void 获取带格式文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getPlainTxt");
        }

        private void 判断是否有内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("hasContent");
        }

        private void 获取选中文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getText");
        }

        private void 可以编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("setEnabled");
        }

        private void 不可编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("setDisabled");
        }

        private void 创建编辑器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("createEditor");
        }

        private void 删除编辑器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("deleteEditor");
        }

       
        private void 使编辑器获取焦点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
        }

        private void 使编辑器失去焦点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
        }

        private void 编辑器是否有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
        }

        private void 清空草稿箱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("clearLocalData");
        }

        private void 获取草稿箱内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("getLocalData");
        }

        private void 插入给定内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("insertHtml");

        }
        #endregion

        

       
    }
}
