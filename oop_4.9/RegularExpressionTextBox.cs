using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;

namespace oop_4._9
{
    class RegularExpressionTextBox : TextBox//описание свойств компонентов
    {
        private Color NormalBackColor;
        [Category("Data")]//указывает, в каакую категорию в редакторе свойств поместить свойство
        [Browsable(true)]//указывает, отображать ли свойство в редакторе свойств
        public string RegularExoression { get; set; }
        [Category("Appearance")]
        [Browsable(true)]
        public Color BackColorError { get; set; }
        [Category("Appearance")]
        [Browsable(true)]
        public Color ForeColorError { get; set; }
        [Category("Appearance")]
        [Browsable(true)]
        public Color BackColorNormal { get; set; }
        [Category("Appearance")]
        [Browsable(true)]
        public Color ForeColorNormal { get; set; }

        [Browsable(false)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        [Browsable(false)]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        public RegularExpressionTextBox() : base()
        {
            NormalBackColor = BackColor;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            Regex regex = new Regex(RegularExoression);
            if (regex.Match(this.Text).Success)
            {// Match - Представляет результаты из отдельного совпадения регулярного выражения.
                base.OnLostFocus(e);
            }//Success - Возвращает значение, указывающее, является ли сопоставление выполняется успешно
            else this.Focus();//Задает фокус ввода на элементе управления.
        }

        protected override void OnKeyUp(KeyEventArgs e)//при нажатии клавиши
        {
            Regex regex = new Regex(RegularExoression);
            if (!regex.Match(this.Text).Success)
            {
                BackColor = BackColorError;
                ForeColor = ForeColorError;
            }
            else
            {
                BackColor = NormalBackColor;
                ForeColor = ForeColorNormal;
            }
            base.OnKeyUp(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RegularExpressionTextBox
            // 
            this.TextChanged += new System.EventHandler(this.RegularExpressionTextBox_TextChanged);
            this.ResumeLayout(false);

        }

        private void RegularExpressionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
