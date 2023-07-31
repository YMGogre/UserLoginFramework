using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginFramework
{
    /// <summary>
    /// 参考自 <see href="https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/how-to-display-option-buttons-in-a-menustrip-windows-forms?view=netframeworkdesktop-4.8">如何：在 MenuStrip 中显示选项按钮（Windows 窗体）</see>
    /// </summary>
    public partial class ToolStripRadioButtonMenuItem : ToolStripMenuItem
    {
        public ToolStripRadioButtonMenuItem()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 由所有构造函数调用以初始化 <see cref="ToolStripMenuItem.CheckOnClick"/> 为 <see langword="true"/>
        /// </summary>
        private void Initialize()
        {
            CheckOnClick = true;
        }

        /// <summary>
        /// 重写 <see cref="ToolStripMenuItem.OnCheckedChanged(EventArgs)"/> 方法可在选择新项时清除对以前所选的项的选择
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            //如果当前项已经不再处于选中状态或者其父项尚未初始化，则不执行任何操作
            if (!Checked || this.Parent == null)
            {
                this.BackColor = Color.Empty;
                return;
            }
           
            this.BackColor = Color.FromArgb(179, 215, 243);
            //清除所有兄弟节点的选中状态
            foreach(ToolStripItem item in Parent.Items)
            {
                ToolStripRadioButtonMenuItem radioItem = item as ToolStripRadioButtonMenuItem;
                if(radioItem != null && radioItem != this && radioItem.Checked) 
                { 
                    radioItem.Checked = false;

                    //同时只能选中一项，所以在这个地方返回即可
                    return;
                }
            }
        }

        /// <summary>
        /// 重写 <see cref="ToolStripMenuItem.OnClick(EventArgs)"/> 方法确保单击已选项不会清除所选内容
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            //如果当前项已经处于选中状态，则不要调用基类的方法，这会切换其值
            if (Checked) return;

            base.OnClick(e);
        }
    }
}
