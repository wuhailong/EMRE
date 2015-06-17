namespace EmrEditor
{
    partial class FormatData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("文本框");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("数字框");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("时间");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("时间");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("下拉框");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("弹出列表");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("描述");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("固定文本");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("宏元素");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("按钮");
            this.tv_data = new System.Windows.Forms.TreeView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_click = new System.Windows.Forms.RichTextBox();
            this.rtb_dbclick = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tv_data
            // 
            this.tv_data.Location = new System.Drawing.Point(12, 12);
            this.tv_data.Name = "tv_data";
            treeNode1.Name = "text";
            treeNode1.Text = "文本框";
            treeNode2.Name = "num";
            treeNode2.Text = "数字框";
            treeNode3.Name = "date";
            treeNode3.Text = "时间";
            treeNode4.Name = "time";
            treeNode4.Text = "时间";
            treeNode5.Name = "combox";
            treeNode5.Text = "下拉框";
            treeNode6.Name = "dialoge";
            treeNode6.Text = "弹出列表";
            treeNode7.Name = "richtextbox";
            treeNode7.Text = "描述";
            treeNode8.Name = "soldtext";
            treeNode8.Text = "固定文本";
            treeNode9.Name = "macroelement";
            treeNode9.Text = "宏元素";
            treeNode10.Name = "button";
            treeNode10.Text = "按钮";
            this.tv_data.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.tv_data.Size = new System.Drawing.Size(193, 356);
            this.tv_data.TabIndex = 2;
            this.tv_data.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_data_AfterSelect);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(283, 11);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(183, 21);
            this.txt_name.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(309, 345);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(213, 345);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "onlclick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "ondblclick";
            // 
            // rtb_click
            // 
            this.rtb_click.Location = new System.Drawing.Point(297, 66);
            this.rtb_click.Name = "rtb_click";
            this.rtb_click.Size = new System.Drawing.Size(169, 96);
            this.rtb_click.TabIndex = 9;
            this.rtb_click.Text = "";
            // 
            // rtb_dbclick
            // 
            this.rtb_dbclick.Location = new System.Drawing.Point(309, 208);
            this.rtb_dbclick.Name = "rtb_dbclick";
            this.rtb_dbclick.Size = new System.Drawing.Size(169, 96);
            this.rtb_dbclick.TabIndex = 9;
            this.rtb_dbclick.Text = "";
            // 
            // FormatData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.rtb_dbclick);
            this.Controls.Add(this.rtb_click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.tv_data);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormatData";
            this.Text = "数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_data;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_click;
        private System.Windows.Forms.RichTextBox rtb_dbclick;
    }
}