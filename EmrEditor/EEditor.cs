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
using ToolFunction;

namespace EMRE
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]//　　注意： 类定义前需要加上下面两行，否则调用失败！
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EEditor : UserControl
    {
        /// <summary>
        /// 是否启用留痕模式
        /// </summary>
        public static bool leaveMark = true;
        public Command command;
        private string strTempletPath = Application.StartupPath + "\\新建模板" + DateTime.Now.ToString();
        /// <summary>
        /// 是否为新建模板标识，当为新建模板时会弹出savefiledialoge,否则会用openfiledialoge的路径
        /// 默认为是新建模板
        /// </summary>
        private bool isNew = true;
        public EEditor()
        {
            InitializeComponent();
            string _strEditorPath = Application.StartupPath + @"/Editor/index.html";
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
            MessageBox.Show(result.ToString());
        }

        private void 写入内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("setContent");
        }

        private void 追加内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object[] o = new object[1];
            o[0] = true;
            object result = this.wb_editor.Document.InvokeScript("setContent", o);
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
            SetToolStripMenuItemCheckStatus(rowspacingUp, toolStripMenuItem2);
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
            OpenFileDialog ofdpic = new OpenFileDialog();
            ofdpic.ShowDialog();
            ofdpic.Filter = "标签|*.jpg;*.png;*.gif";
            CommonFunction.SetFtpWeb("192.168.70.99", "", "Administrator", "Whl05043016");
            //string path = Application.StartupPath + "\\Images\\" + CommonFunction.Upload(ofdpic.FileName);
            string path = "ftp://192.168.70.99/" + CommonFunction.Upload(ofdpic.FileName);
            //Dictionary<string,string> dict = new Dictionary<string,string>();
            //dict.Add("src","a/b/c.jpg");
            //dict.Add("width","100");
            //dict.Add("height","100");
            command.Invoke("insertimage", wb_editor, path);
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
            //command.Invoke("preview", wb_editor);
            string s = Application.StartupPath + "\\preview.html";
            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
            CommonFunction.SaveTemplet(result.ToString(), s, false);
            FilePreview.uriString = s;
            FilePreview fp = new FilePreview();
            fp.Show();


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

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            int _rownum = 0, _colnum = 0;
            if (int.TryParse(rowNum.Text, out _rownum) && int.TryParse(colNum.Text, out _colnum))
            {
                command.Invoke("inserttable", wb_editor, _rownum, _colnum);
            }

        }

        private void deletetable_Click(object sender, EventArgs e)
        {
            command.Invoke("deletetable", wb_editor);

        }

        private void insertparagraphbeforetable_Click(object sender, EventArgs e)
        {
            command.Invoke("insertparagraphbeforetable", wb_editor);

        }

        private void insertrow_Click(object sender, EventArgs e)
        {
            command.Invoke("insertrow", wb_editor);
        }

        private void deleterow_Click(object sender, EventArgs e)
        {
            command.Invoke("deleterow", wb_editor);
        }

        private void insertcol_Click(object sender, EventArgs e)
        {
            command.Invoke("insertcol", wb_editor);
        }

        private void deletecol_Click(object sender, EventArgs e)
        {
            command.Invoke("deletecol", wb_editor);
        }

        private void mergecells_Click(object sender, EventArgs e)
        {
            command.Invoke("mergecells", wb_editor);
        }

        private void mergeright_Click(object sender, EventArgs e)
        {
            command.Invoke("mergeright", wb_editor);
        }

        private void mergedown_Click(object sender, EventArgs e)
        {
            command.Invoke("mergedown", wb_editor);
        }

        private void splittocells_Click(object sender, EventArgs e)
        {
            command.Invoke("splittocells", wb_editor);
        }

        private void splittorows_Click(object sender, EventArgs e)
        {
            command.Invoke("splittorows", wb_editor);
        }

        private void splittocols_Click(object sender, EventArgs e)
        {
            command.Invoke("splittocols", wb_editor);
        }


        private void cleardoc_Click(object sender, EventArgs e)
        {
            command.Invoke("cleardoc", wb_editor);
        }

        public void SaveFile()
        {
            if (isNew)
            {
                sfd_templet.ShowDialog();
                strTempletPath = sfd_templet.FileName;
            }
            object result = this.wb_editor.Document.InvokeScript("getAllHtml");
            CommonFunction.SaveTemplet(result.ToString(), strTempletPath);
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            isNew = false;
            ofd_templet.ShowDialog();
            strTempletPath = ofd_templet.FileName;
            object[] o = new object[1];
            o[0] = CommonFunction.OpenTemplet(strTempletPath);
            command.Invoke("cleardoc", wb_editor);
            object result = this.wb_editor.Document.InvokeScript("insertHtml", o);
        }

        private void createnew_Click(object sender, EventArgs e)
        {
            isNew = true;
            command.Invoke("cleardoc", wb_editor);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = false;
            SaveFile();
        }

        private void wb_editor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            SetCommandStatus();
            if (!leaveMark)
            {
                return;
            }

            object result = this.wb_editor.Document.InvokeScript("getText");
            object[] o = new object[1];
            o[0] = e;
            if (result != null && result.ToString() != "" && e.KeyCode == Keys.Back)
            {
                command.Invoke("strikethrough", wb_editor);
                command.Invoke("forecolor", wb_editor, ColorTranslator.ToHtml(Color.Red));
                this.wb_editor.Document.InvokeScript("setblur", o);
            }
            else if (result != null && result.ToString() != "" && e.KeyCode != Keys.Back)
            {
                this.wb_editor.Document.InvokeScript("setblur", o);
            }
            //command.Invoke("setblur", wb_editor);
            //command.Invoke("isFocus", wb_editor);
            //        //setblur	编辑器失去焦点
            //        result = browser.Document.InvokeScript("setblur", o);
            //        //isFocus	编辑器获取焦点
            //        result = browser.Document.InvokeScript("isFocus", o);

            //object result = this.wb_editor.Document.InvokeScript("getText");
            //if (result.ToString() != "" && e.KeyCode == Keys.Back)
            //{
            //    command.Invoke("strikethrough", wb_editor);
            //    command.Invoke("forecolor", wb_editor, ColorTranslator.ToHtml(Color.Red));
            //    this.wb_editor.Document.InvokeScript("setDisabled");

            //}
            //else
            //{
            //    this.wb_editor.Document.InvokeScript("setDisabled");
            //}
        }

        private void 插入标签元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("insertHtmlTag");
        }

        public void InsertHtml(string value)
        {
            object[] o = new object[1];
            o[0] = value;
            object result = this.wb_editor.Document.InvokeScript("insertHtml", o);
        }

        private void 编辑器失去焦点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object[] o = new object[1];
            o[0] = e;
            object result = this.wb_editor.Document.InvokeScript("setblur", o);
        }


        private void 编辑器获取焦点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object result = this.wb_editor.Document.InvokeScript("setFocus");
        }

        private void 数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatData fd = new FormatData(this);
            fd.Show();
        }

        private void 留痕模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (留痕模式ToolStripMenuItem.Checked)
            {
                leaveMark = true;
            }
            else
            {
                leaveMark = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = null;
            List<string> HasExecuteCommandList = command.QueryCommandState(wb_editor);
            ToolStripButton tb = (ToolStripButton)sender;
            ToolStrip ts = tb.Owner;
            foreach (var item in ts.Items)
            {
                string type = item.GetType().Name.ToString();
                if ("ToolStripButton" == type)
                {
                    tsb = (ToolStripButton)item;
                }
                if (HasExecuteCommandList.Contains(tsb.Name.ToUpper()))
                {
                    tsb.BackColor = Color.Red;
                }

            }
        }


        public void SetCommandStatus()
        {
            ToolStripButton tsb = null;
            List<string> HasExecuteCommandList = command.QueryCommandState(wb_editor);
           
            foreach (var item in toolStrip2.Items)
            {
                string type = item.GetType().Name.ToString();
                if ("ToolStripButton" == type)
                {
                    tsb = (ToolStripButton)item;
                }
                if (HasExecuteCommandList.Contains(tsb.Name.ToUpper()))
                {
                    tsb.BackColor = Color.Red;
                }

            }

            foreach (var item in toolStrip1.Items)
            {
                string type = item.GetType().Name.ToString();
                if ("ToolStripButton" == type)
                {
                    tsb = (ToolStripButton)item;
                }
                if (HasExecuteCommandList.Contains(tsb.Name.ToUpper()))
                {
                    tsb.BackColor = Color.Red;
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            command.QueryCommandValue(wb_editor);
        }



    }
}
