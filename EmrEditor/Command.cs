using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Windows.Forms;
using EMRE;

namespace EmrEditor
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]//　　注意： 类定义前需要加上下面两行，否则调用失败！
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class Command
    {

        List<string> CommandList =new List<string>();
        #region 构造方法
        
        
        public Command() {
            CommandList.Add("anchor");
            CommandList.Add("autosubmit");
            CommandList.Add("autotypeset");
            CommandList.Add("bold");
            CommandList.Add("italic");
            CommandList.Add("subscript");
            CommandList.Add("superscript");
            CommandList.Add("blockquote");
            CommandList.Add("cleardoc");
            CommandList.Add("cleardoc");
            CommandList.Add("touppercase");
            CommandList.Add("tolowercase");
            CommandList.Add("customstyle");
            CommandList.Add("directionality");
            CommandList.Add("forecolor");
            CommandList.Add("backcolor");
            CommandList.Add("fontsize");
            CommandList.Add("fontfamily");
            CommandList.Add("underline");
            CommandList.Add("strikethrough");
            CommandList.Add("fontborder");
            CommandList.Add("formatmatch");
            CommandList.Add("horizontal");
            CommandList.Add("imagefloat");
            CommandList.Add("indent");
            CommandList.Add("insertcode");
            CommandList.Add("inserthtml");
            CommandList.Add("insertparagraph");
            CommandList.Add("justify");
            CommandList.Add("lineheight");
            CommandList.Add("link");
            CommandList.Add("unlink");
            CommandList.Add("insertorderedlist");
            CommandList.Add("insertunorderedlist");
            CommandList.Add("pagebreak");
            CommandList.Add("paragraph");
            CommandList.Add("rowspacingtop");
            CommandList.Add("preview");
            CommandList.Add("print");
            CommandList.Add("removeformat");
            CommandList.Add("inserttable");
            CommandList.Add("deletetable");
            CommandList.Add("insertparagraphbeforetable");
            CommandList.Add("insertrow");
            CommandList.Add("deleterow");
            CommandList.Add("mergecells");
            CommandList.Add("mergeright");
            CommandList.Add("mergedown");
            CommandList.Add("splittorows");
            CommandList.Add("splittocols");
        }
        #endregion

        #region 命令API
        

        /// <summary>
        ///	anchor	插入锚点
        /// autosubmit	提交表单
        ///	autotypeset	对当前编辑器的内容执行自动排版， 排版的行为根据config配置文件里的“autotypeset”选项进行控制。||
        ///	bold	字体加粗
        /// italic	字体倾斜
        /// subscript	下标文本，与“superscript”命令互斥
        /// superscript	上标文本，与“subscript”命令互斥
        ///	blockquote	添加引用
        ///	cleardoc	清空文档
        ///	touppercase	把选区内文本变大写，与“tolowercase”命令互斥
        ///	tolowercase	把选区内文本变小写，与“touppercase”命令互斥
        ///	customstyle	根据config配置文件里“customstyle”选项的值对匹配的标签执行样式替换。
        ///	directionality	文字输入方向
        /// fontcolor	字体颜色
        ///	backcolor	字体背景颜色
        ///	fontsize	字体大小
        ///	fontfamily	字体样式
        ///	underline	字体下划线,与删除线互斥
        /// strikethrough	字体删除线,与下划线互斥
        ///	fontborder	字体边框
        /// formatmatch	格式刷
        /// horizontal	插入分割线
        /// imagefloat	图片对齐方式
        /// insertimage	插入图片
        /// indent	缩进
        /// insertcode	插入代码
        /// inserthtml	插入html代码
        /// insertparagraph	插入段落
        /// justify	段落对齐方式
        /// lineheight	行距
        /// link	插入超链接
        /// unlink	取消超链接
        /// insertorderedlist	有序列表，与“insertunorderedlist”命令互斥
        /// insertunorderedlist	无序列表，与“insertorderedlist”命令互斥
        /// music	插入音乐
        ///	pagebreak	插入分页符
        ///	paragraph	段落格式
        /// preview	预览
        /// print	打印
        /// pasteplain	启用或取消纯文本粘贴模式
        /// removeformat	清除文字样式
        /// rowspacing	设置段间距
        /// selectall	选中所有内容
        /// source	切换源码模式和编辑模式
        /// time	插入时间，默认格式：12:59:59
        ///	date	插入日期，默认格式：2013-08-30
        /// undo	撤销上一次执行的命令
        /// redo	重做上一次执行的命令
        /// insertvideo	插入视频
        /// webapp	插入百度应用
        /// </summary>
        /// <param name="p_strType">命令字符</param>
        /// <param name="browser">在哪个WebBrowser控件中执行命令</param>
        public void Invoke(string p_strType, WebBrowser browser, params object[] prams)
        {
            object result = null;
            switch (p_strType)
            {
                case "anchor":
                    //anchor	插入锚点
                    result = browser.Document.InvokeScript("anchor");
                    break;
                case "autosubmit":
                    //autosubmit	提交表单
                    result = browser.Document.InvokeScript("autosubmit");
                    break;
                case "autotypeset":
                    //autotypeset	对当前编辑器的内容执行自动排版， 排版的行为根据config配置文件里的“autotypeset”选项进行控制。
                    result = browser.Document.InvokeScript("autotypeset");
                    break;
                case "bold":
                    //bold	字体加粗
                    result = browser.Document.InvokeScript("bold");
                    break;
                case "italic":
                    //italic	字体倾斜
                    result = browser.Document.InvokeScript("italic");
                    break;
                case "subscript":
                    //subscript	下标文本，与“superscript”命令互斥
                    result = browser.Document.InvokeScript("subscript");
                    break;
                case "superscript":
                    //superscript	上标文本，与“subscript”命令互斥
                    result = browser.Document.InvokeScript("superscript");
                    break;
                case "blockquote":
                    //blockquote	添加引用
                    result = browser.Document.InvokeScript("blockquote");
                    break;
                case "cleardoc":
                    //cleardoc	清空文档
                    result = browser.Document.InvokeScript("cleardoc");
                    break;
                case "touppercase":
                    //touppercase	把选区内文本变大写，与“tolowercase”命令互斥
                    result = browser.Document.InvokeScript("touppercase");
                    break;
                case "tolowercase":
                    //tolowercase	把选区内文本变小写，与“touppercase”命令互斥
                    result = browser.Document.InvokeScript("tolowercase");
                    break;
                case "customstyle":
                    //customstyle	根据config配置文件里“customstyle”选项的值对匹配的标签执行样式替换。
                    result = browser.Document.InvokeScript("customstyle");
                    break;
                case "directionality":
                    //directionality	文字输入方向
                    result = browser.Document.InvokeScript("directionality");
                    break;
                case "forecolor":
                    //forecolor	字体颜色
                    result = browser.Document.InvokeScript("forecolor", prams);
                    break;
                case "backcolor":
                    //backcolor	字体背景颜色
                    result = browser.Document.InvokeScript("backcolor", prams);
                    break;
                case "fontsize":
                    //fontsize	字体大小
                    result = browser.Document.InvokeScript("fontsize", prams);
                    break;
                case "fontfamily":
                    //fontfamily	字体样式
                    result = browser.Document.InvokeScript("fontfamily", prams);
                    break;
                case "underline":
                    //underline	字体下划线,与删除线互斥
                    result = browser.Document.InvokeScript("underline");
                    break;
                case "strikethrough":
                    //strikethrough	字体删除线,与下划线互斥
                    result = browser.Document.InvokeScript("strikethrough");
                    break;
                case "fontborder":
                    //fontborder	字体边框
                    result = browser.Document.InvokeScript("fontborder");
                    break;
                case "formatmatch":
                    //formatmatch	格式刷
                    result = browser.Document.InvokeScript("formatmatch");
                    break;
                case "horizontal":
                    //horizontal	插入分割线
                    result = browser.Document.InvokeScript("horizontal");
                    break;
                case "imagefloat":
                    //imagefloat	图片对齐方式
                    result = browser.Document.InvokeScript("imagefloat");
                    break;
                case "insertimage":
                    //insertimage	插入图片
                    result = browser.Document.InvokeScript("insertimage",prams);
                    break;
                case "indent":
                    //indent	缩进
                    result = browser.Document.InvokeScript("indent");
                    break;
                case "insertcode":
                    //insertcode	插入代码
                    result = browser.Document.InvokeScript("insertcode");
                    break;
                case "inserthtml":
                    //inserthtml	插入html代码
                    result = browser.Document.InvokeScript("inserthtml");
                    break;
                case "insertparagraph":
                    //insertparagraph	插入段落
                    result = browser.Document.InvokeScript("insertparagraph");
                    break;
                case "justify":
                    //justify	段落对齐方式
                    if (prams[0].ToString()=="right")
                    {
                        result = browser.Document.InvokeScript("justifyR");
                    }
                    else if (prams[0].ToString()=="left")
                    {
                        result = browser.Document.InvokeScript("justifyL");
                    }
                    else if (prams[0].ToString() == "center")
                    {
                        result = browser.Document.InvokeScript("justifyC");
                    }
                    else if (prams[0].ToString() == "both")
                    {
                        result = browser.Document.InvokeScript("justifyB");
                    }
                    
                    break;
                case "lineheight":
                    //lineheight	行距
                    result = browser.Document.InvokeScript("lineheight",prams);
                    break;
                case "link":
                    //link	插入超链接
                    result = browser.Document.InvokeScript("link");
                    break;
                case "unlink":
                    //unlink	取消超链接
                    result = browser.Document.InvokeScript("unlink");
                    break;
                case "insertorderedlist":
                    //insertorderedlist	有序列表，与“insertunorderedlist”命令互斥
                    result = browser.Document.InvokeScript("insertorderedlist", prams);
                    break;
                case "insertunorderedlist":
                    //insertunorderedlist	无序列表，与“insertorderedlist”命令互斥
                    result = browser.Document.InvokeScript("insertunorderedlist", prams);
                    break;
                case "pagebreak":
                    //pagebreak	插入分页符
                    result = browser.Document.InvokeScript("pagebreak");
                    break;
                case "paragraph":
                    //paragraph	段落格式
                    result = browser.Document.InvokeScript("paragraph", prams);
                    break;
                case "preview":
                    //preview	预览
                    result = browser.Document.InvokeScript("preview");
                    break;
                case "print":
                    //print	打印
                    result = browser.Document.InvokeScript("print");
                    break;
                case "pasteplain":
                    //pasteplain	启用或取消纯文本粘贴模式
                    result = browser.Document.InvokeScript("pasteplain");
                    break;
                case "removeformat":
                    //removeformat	清除文字样式
                    result = browser.Document.InvokeScript("removeformat");
                    break;
                case "rowspacingtop":
                    //rowspacing	设置段间距
                    result = browser.Document.InvokeScript("rowspacingtop", prams);
                    break;
                case "rowspacingbottom":
                    //rowspacing	设置段间距
                    result = browser.Document.InvokeScript("rowspacingbottom", prams);
                    break;
                  
                case "selectall":
                    //selectall	选中所有内容
                    result = browser.Document.InvokeScript("selectall");
                    break;
                case "source":
                    //source	切换源码模式和编辑模式
                    result = browser.Document.InvokeScript("source");
                    break;
                case "time":
                    //time	插入时间，默认格式：12:59:59体加粗
                    result = browser.Document.InvokeScript("time");
                    break;
                case "date":
                    //date	插入日期，默认格式：2013-08-30
                    result = browser.Document.InvokeScript("date");
                    break;
                case "undo":
                    //undo	撤销上一次执行的命令
                    result = browser.Document.InvokeScript("undo");
                    break;
                case "redo":
                    //redo	重做上一次执行的命令
                    result = browser.Document.InvokeScript("redo");
                    break;
                case "insertvideo":
                    //insertvideo	插入视频
                    result = browser.Document.InvokeScript("insertvideo");
                    break;
                case "webapp":
                    //webapp	插入百度应用
                    result = browser.Document.InvokeScript("webapp");
                    break;
                case "inserttable":
                    //webapp	插入百度应用
                    result = browser.Document.InvokeScript("inserttable",prams);
                    break;
                case "deletetable":
                    //deletetable	删除表
                    result = browser.Document.InvokeScript("deletetable");
                    break;
                case "insertparagraphbeforetable":
                    //insertparagraphbeforetable	前插入段落
                    result = browser.Document.InvokeScript("insertparagraphbeforetable");
                    break;
                case "insertrow":
                    //insertrow	前插入行
                    result = browser.Document.InvokeScript("insertrow");
                    break;
                case "deleterow":
                    //deleterow	删除行
                    result = browser.Document.InvokeScript("deleterow");
                    break;
                case "insertcol":
                    //insertcol	插入列
                    result = browser.Document.InvokeScript("insertcol");
                    break;
                case "deletecol":
                    //deletecol	删除列
                    result = browser.Document.InvokeScript("deletecol");
                    break;
                case "mergecells":
                    //mergecells	合并单元格
                    result = browser.Document.InvokeScript("mergecells");
                    break;
                case "mergeright":
                    //mergeright	向右合并
                    result = browser.Document.InvokeScript("mergeright");
                    break;
                case "mergedown":
                    //mergedown	向下合并
                    result = browser.Document.InvokeScript("mergedown");
                    break;
                case "splittocells":
                    //insertrow	前插入行
                    result = browser.Document.InvokeScript("splittocells");
                    break;
                case "splittorows":
                    //insertrow	前插入行
                    result = browser.Document.InvokeScript("splittorows");
                    break;
                case "splittocols":
                    //insertrow	前插入列
                    result = browser.Document.InvokeScript("splittocols");
                    break;
                case "insertHtmlTag":
                    //insertrow	前插入行
                    result = browser.Document.InvokeScript("insertHtmlTag");
                    break;
                case "setblur":
                    //setblur	编辑器失去焦点
                    result = browser.Document.InvokeScript("setblur", prams);
                    break;
                case "isFocus":
                    //isFocus	判断编辑器是否有焦点
                    result = browser.Document.InvokeScript("isFocus", prams);
                    break;
                case "setFocus":
                    //setFocus	编辑器获取焦点
                    result = browser.Document.InvokeScript("setFocus");
                    break;
                default:
                    break;

            }
        }

        #endregion


        /// <summary>
        /// 查询给定命令在当前选区内的状态
        /// </summary>
        /// <returns></returns>
        public List<string> QueryCommandState(WebBrowser browser)
        {
            //已经执行过 的命令
            List<string> _hasExecuteCommandList = new List<string>();
            //可以执行的命令
            List<string> _canExecuteCommandList = new List<string>();
            //无法执行的命令
            List<string> _nonExcuteCommandList = new List<string>();

            foreach (var item in CommandList)
            {
                object[] o = new object[1];
                o[0]=item;
                object result = browser.Document.InvokeScript("QueryCommandState", o);
               if (result.ToString()=="1")
               {
                   _hasExecuteCommandList.Add(item.ToUpper());
               }
               else if (result.ToString() == "0")
               {
                   _canExecuteCommandList.Add(item.ToUpper());
               }
               else if (result.ToString() == "-1")
               {
                   _nonExcuteCommandList.Add(item.ToUpper());
               }
            }
            return  _hasExecuteCommandList;
        }


       



        /// <summary>
        /// 查询给定命令在当前选区内的值， 默认返回undefined。根据命令的不同其返回值也会不同。
        /// </summary>
        public void QueryCommandValue(WebBrowser browser)
        {

            object result = browser.Document.InvokeScript("QueryCommandValue");

        }
    }
}
