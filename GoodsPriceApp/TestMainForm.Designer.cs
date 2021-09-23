namespace GoodsPriceApp
{
    partial class TestMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.txt_show = new GoodsPriceApp.ZhmTextBox();
            this.txt_input = new GoodsPriceApp.ZhmTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(20, 20);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(214, 246);
            this.txt_output.TabIndex = 3;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(351, 54);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 4;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(22, 49);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Placeholder = "商品信息";
            this.txt_show.ReadOnly = true;
            this.txt_show.Size = new System.Drawing.Size(171, 217);
            this.txt_show.TabIndex = 7;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(22, 20);
            this.txt_input.Name = "txt_input";
            this.txt_input.Placeholder = "请输入数字";
            this.txt_input.Size = new System.Drawing.Size(171, 21);
            this.txt_input.TabIndex = 6;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_input);
            this.groupBox1.Controls.Add(this.txt_show);
            this.groupBox1.Location = new System.Drawing.Point(93, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 290);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_output);
            this.groupBox2.Location = new System.Drawing.Point(467, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 274);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "output";
            // 
            // TestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_click);
            this.Name = "TestMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.TestMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_click;
        private ZhmTextBox txt_input;
        private ZhmTextBox txt_show;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

