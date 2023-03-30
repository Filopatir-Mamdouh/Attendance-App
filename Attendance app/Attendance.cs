using Attendance_app.Classes;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Attendance_app
{
    public partial class Attendance : Form
    {
        private String[] DaysofWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };
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
            ShowData();
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

        private void ShowData()
        {
            Item_Controller controller = new Item_Controller();
            datatable.DataSource = controller.Display();
            datatable.Columns["id"].Visible = false;
            datatable.Columns["dayid"].Visible = false;
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "«·Õ÷Ê—";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            datatable.Columns.Add(checkColumn);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Item_Controller controller = new Item_Controller();
            try
            {
                string Query = "INSERT INTO InsertedData VALUES ( '" + DaysofWeek[Day.SelectedIndex] + "' , '" + Name.Text + "' , '" + Dep.SelectedItem.ToString() + "' , '" + "Subject" + "' , '" + Year.SelectedItem.ToString() + "')";
                controller.SetData(Query);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_DataMemberChanged(object sender, EventArgs e)
        {

        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = datatable[column, row];
            DataGridViewCell cell2 = datatable[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void datatable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void datatable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = datatable.AdvancedCellBorderStyle.Top;
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            datatable.AutoGenerateColumns = false;
        }

        private void Attendance_Enter(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}