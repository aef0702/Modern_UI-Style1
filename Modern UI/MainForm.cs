using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Modern_UI
{
    public partial class MainForm : Form
    {
        #region Form 설정
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0)); //Form의 Round처리 (Reight부분을 변경하면 Round처리됨)
        }
        Color formcolor = Color.FromArgb(82, 109, 130);

        Size mixsize = new Size(654, 451);
#endregion
        #region Buttion 색상
        private void butdisColor()
        {
            Color Disable = Color.FromArgb(39, 55, 77); //비활성화 색상
            Color Fontdisable = Color.FromArgb(157, 178, 191); //비활성화 폰트색상
            this.Form1_but.BackColor = Disable;
            this.Form2_but.BackColor = Disable;
            this.Form3_but.BackColor = Disable;
            this.Setting_but.BackColor = Disable;

            //기본 폰트 색상
            this.Form1_but.ForeColor = Fontdisable;
            this.Form2_but.ForeColor = Fontdisable;
            this.Form3_but.ForeColor = Fontdisable;
            this.Setting_but.ForeColor = Fontdisable;
        }
        Color Active = Color.FromArgb(82, 109, 130); //버튼 활성화 색상
        Color FontActive = Color.FromArgb(0,0,0); //버튼 활성화 색상
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1_but_Click( sender, e );
        }

        private void Form1_but_Click(object sender, EventArgs e)
        {
            butdisColor();
            this.Form1_but.BackColor = Active;
            this.Form1_but.ForeColor = FontActive;

            this.FormpaL.Controls.Clear();
            Form1 form = new Form1()
            {
                Dock = DockStyle.Fill, //변경금지
                TopLevel = false, //변경금지
                TopMost = true, //변경금지
                MinimumSize = mixsize, //Form 설정부분에서 Size값 변경
                Size = mixsize, //Form 설정부분에서 Size값 변경

                BackColor = formcolor //BackColor는 Form의 배경을 지정하므로 예외시 주석처리하여 사용가능

            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.FormpaL.Controls.Add(form);
            form.Show();
        }

        private void Form2_but_Click(object sender, EventArgs e)
        {
            butdisColor();
            this.Form2_but.BackColor = Active;
            this.Form2_but.ForeColor = FontActive;

            this.FormpaL.Controls.Clear();
            Form2 form = new Form2()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                MinimumSize = mixsize,
                Size = mixsize,

                BackColor = formcolor
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.FormpaL.Controls.Add(form);
            form.Show();
        }

        private void Form3_but_Click(object sender, EventArgs e)
        {
            butdisColor();
            this.Form3_but.BackColor = Active;
            this.Form3_but.ForeColor = FontActive;

            this.FormpaL.Controls.Clear();
            Form3 form = new Form3()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                MinimumSize = mixsize,
                Size = mixsize,

                BackColor = formcolor
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.FormpaL.Controls.Add(form);
            form.Show();
        }

        private void Setting_but_Click(object sender, EventArgs e)
        {
            butdisColor();
            this.Setting_but.BackColor = Active;
            this.Setting_but.ForeColor = FontActive;

            this.FormpaL.Controls.Clear();
            Setting form = new Setting()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                MinimumSize = mixsize,
                Size = mixsize,

                BackColor = formcolor
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.FormpaL.Controls.Add(form);
            form.Show();
        }
    }
}
