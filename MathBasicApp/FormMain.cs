namespace MathBasicApp
{
    public partial class FormMain : Form
    {

        ErrorProvider errorProvider;
        public FormMain()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void process_click(object sender, EventArgs e)
        {
            double soThuNhat, soThuHai;

            errorProvider.Clear();

            if (!double.TryParse(txtstn.Text, out soThuNhat))
            {
                //MessageBox.Show("Vui lòng nhập số thứ nhất");
                errorProvider.SetError(txtstn, "Vui lòng nhập số thứ nhất");
                txtstn.Focus();
                return;
            }

            if (!double.TryParse(txtsth.Text, out soThuHai))
            {
                //MessageBox.Show("Vui lòng nhập số thứ hai");
                errorProvider.SetError(txtsth, "Vui lòng nhập số thứ hai");
                txtsth.Focus();
                return;
            }

            Button buttonCLick = (Button)sender;
            double ketqua = 0;
            string hienthi = "";

            if (buttonCLick != null)
            {
                // Ép kiểu
                // Cách 1: String tag = (string)buttonCLick.Tag;
                // Cách 2:
                String tag = buttonCLick.Tag as string;
                if (tag != null)
                {
                    if (tag == "+")
                    {
                        ketqua = soThuNhat + soThuHai;
                        hienthi = $"{soThuNhat} + {soThuHai} = {ketqua}";
                    }
                    else if (tag == "-")
                    {
                        ketqua = soThuNhat - soThuHai;
                        hienthi = $"{soThuNhat} - {soThuHai} = {ketqua}";
                    }
                    else if (tag == "*")
                    {
                        ketqua = soThuNhat * soThuHai;
                        hienthi = $"{soThuNhat} * {soThuHai} = {ketqua}";
                    }
                    else if (tag == "/")
                    {
                        ketqua = soThuNhat / soThuHai;
                        hienthi = $"{soThuNhat} / {soThuHai} = {ketqua}";
                    }
                }
            }

            rtbkq.Text = hienthi;
        }

        private void linktg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new FormAuthor();
            f.Show();
        }
    }
}