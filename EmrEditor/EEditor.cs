using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using EmrEditor;
using System.IO;

namespace EMRE
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]//　　注意： 类定义前需要加上下面两行，否则调用失败！
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EEditor : UserControl
    {

        public Command command; 
        public EEditor()
        {
            InitializeComponent();
            string _strEditorPath = Application.StartupPath+@"/Editor/index.html";
            System.IO.FileInfo file = new System.IO.FileInfo(_strEditorPath);

            // WebBrowser控件显示的网页路径
            wb_editor.Url = new Uri(file.FullName);
            // 将当前类设置为可由脚本访问
            wb_editor.ObjectForScripting = this;

            command = new Command();

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

       

        private void toolStripButton39_Click(object sender, EventArgs e)
        {
            //字体加粗
            //object result = this.wb_editor.Document.InvokeScript("bold");
            command.Invoke("bold", wb_editor);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingUp,toolStripMenuItem2);
        }

        /// <summary>
        /// 设置ToolStripMenuItem的勾选状态，使其实现单选功能
        /// </summary>
        /// <param name="menu">ToolStripSplitButton 母项</param>
        /// <param name="menuitem">子项</param>
        public void SetToolStripMenuItemCheckStatus(ToolStripSplitButton menu, ToolStripMenuItem menuitem)
        {
            if (menuitem.Checked)
            {
                foreach (ToolStripMenuItem item in menu.DropDownItems)
                {
                    if (item != menuitem)
                    {
                        item.Checked = false;
                    }

                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingUp, toolStripMenuItem3);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingUp, toolStripMenuItem4);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingUp, toolStripMenuItem5);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingUp, toolStripMenuItem6);
        }

        private void italic_Click(object sender, EventArgs e)
        {
            //斜体
            command.Invoke("italic", wb_editor);
        }

        private void underline_Click(object sender, EventArgs e)
        {
            //斜体
            command.Invoke("underline", wb_editor);
        }

        private void fontborder_Click(object sender, EventArgs e)
        {
            command.Invoke("fontborder", wb_editor);
        }

        private void strikethrough_Click(object sender, EventArgs e)
        {
            command.Invoke("strikethrough", wb_editor);
            
        }

        private void superscript_Click(object sender, EventArgs e)
        {
            command.Invoke("superscript", wb_editor);
        }

        private void subscript_Click(object sender, EventArgs e)
        {
            command.Invoke("subscript", wb_editor);
        }

        private void indent_Click(object sender, EventArgs e)
        {
            command.Invoke("indent", wb_editor);
            
        }

        private void justifyleft_Click(object sender, EventArgs e)
        {
            command.Invoke("justify", wb_editor, "left");
        }

        private void justifymid_Click(object sender, EventArgs e)
        {
            command.Invoke("justify", wb_editor, "center");
        }

        private void justifyfirght_Click(object sender, EventArgs e)
        {
            command.Invoke("justify", wb_editor, "right");
        }

        private void justifyboth_Click(object sender, EventArgs e)
        {
            command.Invoke("justify", wb_editor, "both");
        }

        

       
        private void insertimage_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("src","a/b/c.jpg");
            dict.Add("width","100");
            dict.Add("height","100");
            command.Invoke("insertimage", wb_editor, dict);
        }

        private void touppercase_Click(object sender, EventArgs e)
        {
            command.Invoke("touppercase", wb_editor);
        }

        private void tolowercase_Click(object sender, EventArgs e)
        {
            command.Invoke("tolowercase", wb_editor);
        }

        private void date_Click(object sender, EventArgs e)
        {
            command.Invoke("date", wb_editor);
        }

        private void time_Click(object sender, EventArgs e)
        {
            command.Invoke("time", wb_editor);
        }

        private void undo_Click(object sender, EventArgs e)
        {
            command.Invoke("undo", wb_editor);
        }

        private void redo_Click(object sender, EventArgs e)
        {
            command.Invoke("redo", wb_editor);
        }

        private void print_Click(object sender, EventArgs e)
        {
            command.Invoke("print", wb_editor);
        }

        private void preview_Click(object sender, EventArgs e)
        {
            command.Invoke("preview", wb_editor);
        }

        private void pagesplit_Click(object sender, EventArgs e)
        {
            command.Invoke("pagebreak", wb_editor);
        }


        private void fontcolor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            Color selectedColor = colorDialog.Color;
            fontcolor.BackColor = selectedColor;
            string _strColor = ColorTranslator.ToHtml(selectedColor);
            command.Invoke("forecolor", wb_editor, _strColor);
        }

        private void backcolor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            Color selectedColor = colorDialog.Color;
            backcolor.BackColor = selectedColor;
            string _strColor = ColorTranslator.ToHtml(selectedColor);
            command.Invoke("backcolor", wb_editor, _strColor);
        }

        private void fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.Invoke("fontsize", wb_editor, fontsize.Text);
        }

        private void fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.Invoke("fontfamily", wb_editor, fontfamily.Text);
        }

        private void Paragraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Paragraph.Text.Contains("-"))
            {
                string fontsize = Paragraph.Text.Split('-')[1].ToString();
                command.Invoke("paragraph", wb_editor, fontsize);
            }
            
        }



        private void InsertOrderedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(insertorderedlist, (ToolStripMenuItem)sender);
            command.Invoke("insertorderedlist", wb_editor, ((ToolStripMenuItem)sender).Tag);
        }

        private void InsertUnorderedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(insertunorderedlist, (ToolStripMenuItem)sender);
            command.Invoke("insertunorderedlist", wb_editor, ((ToolStripMenuItem)sender).Tag);
        }
        private void RowSpacingUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingUp, (ToolStripMenuItem)sender);
            command.Invoke("rowspacingtop", wb_editor, ((ToolStripMenuItem)sender).Text);
        }
        private void RowSpacingDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(rowspacingDown, (ToolStripMenuItem)sender);
            command.Invoke("rowspacingbottom", wb_editor, ((ToolStripMenuItem)sender).Text);
        }
        private void LineHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetToolStripMenuItemCheckStatus(lineheight, (ToolStripMenuItem)sender);
            command.Invoke("lineheight", wb_editor, ((ToolStripMenuItem)sender).Text);
        }

        private void horizontal_Click(object sender, EventArgs e)
        {
            command.Invoke("horizontal", wb_editor);
        }
        


      

        

       
    }
}
