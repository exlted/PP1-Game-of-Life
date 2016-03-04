using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CustomControl1 : Panel
    {
        public CustomControl1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}