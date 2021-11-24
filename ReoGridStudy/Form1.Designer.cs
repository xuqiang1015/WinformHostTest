namespace ReoGridStudy
{
    partial class Form1
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
            this.m_gridCtrl = new unvell.ReoGrid.ReoGridControl();
            this.SuspendLayout();
            // 
            // m_gridCtrl
            // 
            this.m_gridCtrl.BackColor = System.Drawing.Color.White;
            this.m_gridCtrl.ColumnHeaderContextMenuStrip = null;
            this.m_gridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gridCtrl.LeadHeaderContextMenuStrip = null;
            this.m_gridCtrl.Location = new System.Drawing.Point(0, 0);
            this.m_gridCtrl.Margin = new System.Windows.Forms.Padding(6);
            this.m_gridCtrl.Name = "m_gridCtrl";
            this.m_gridCtrl.RowHeaderContextMenuStrip = null;
            this.m_gridCtrl.Script = null;
            this.m_gridCtrl.SheetTabContextMenuStrip = null;
            this.m_gridCtrl.SheetTabNewButtonVisible = true;
            this.m_gridCtrl.SheetTabVisible = true;
            this.m_gridCtrl.SheetTabWidth = 120;
            this.m_gridCtrl.ShowScrollEndSpacing = true;
            this.m_gridCtrl.Size = new System.Drawing.Size(1535, 1039);
            this.m_gridCtrl.TabIndex = 2;
            this.m_gridCtrl.Text = "ReoGridControl";
            this.m_gridCtrl.Click += new System.EventHandler(this.m_gridCtrl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 1039);
            this.Controls.Add(this.m_gridCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private unvell.ReoGrid.ReoGridControl m_gridCtrl;
    }
}

