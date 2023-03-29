using Attendance_app.Classes;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Attendance_app
{
    public partial class Attendance : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private String[,] Auto = { { "Subject 1" , "Subject 2" , "Subject 3" , "Subject 4" , "Subject 5" , "Subject 6"}, { "Subject 1", "Subject 2", "Subject 3", "Subject 4", "Subject 5", "Subject 6" } ,
        { "Subject 1" , "Subject 2" , "Subject 3" , "Subject 4" , "Subject 5" , "Subject 6"} , { "Subject 1" , "Subject 2" , "Subject 3" , "Subject 4" , "Subject 5" , "Subject 6"} };

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Attendance()
        {
            InitializeComponent();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var formPopup = new Form2();
            formPopup.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Item_Controller controller = new Item_Controller();
            string Query = "INSERT INTO Attendance VALUES ( '" + Day.SelectedItem.ToString() + "' , '" + Name.Text + "' , '" + Dep.SelectedItem.ToString() + "' , '" + Subject.SelectedItem.ToString() + "' , '" + Year.SelectedItem.ToString() + "')";
            try
            {
                controller.SetData(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}