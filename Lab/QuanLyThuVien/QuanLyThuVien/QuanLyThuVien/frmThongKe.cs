using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanLyThuVien
{
    public partial class frmThongKe : Form
    {
        List<MuonSach> l = new List<MuonSach>();
        public frmThongKe()
        {
            InitializeComponent();
            rdNgayMuon.Checked = true;
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;
            Loads();
        }
        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
        }

        private void LoadListView(List<MuonSach> l)
        {
            lvThongKe.Items.Clear();
            foreach (var m in l)
            {
                ListViewItem lvitem = new ListViewItem(m.sophieumuon);
                lvitem.SubItems.Add(m.madg);
                lvitem.SubItems.Add(m.masach);
                lvitem.SubItems.Add(m.ngaymuon.ToShortDateString());
                lvitem.SubItems.Add(m.ngaytra.ToShortDateString());
                lvitem.SubItems.Add(m.tienphat.ToString());
                lvitem.SubItems.Add(m.ghichu);

                lvThongKe.Items.Add(lvitem);
            }
        }
        private void Loads()
        {
            l = MuonTraDAO.instance.GetDSDaTra();
            LoadListView(l);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            List<MuonSach> l = new List<MuonSach>();
            if (rdNgayMuon.Checked) l = MuonTraDAO.instance.GetDSMuonTraByNgayMuon(dtpFromDate.Value, dtpToDate.Value);
            if (rdNgayTra.Checked) l = MuonTraDAO.instance.GetDSMuonTraByNgayTra(dtpFromDate.Value, dtpToDate.Value);
            LoadListView(l);
            this.l = l;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBoxCT("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Báo cáo thống kê";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Sheet1");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    // đặt tên cho sheet
                    ws.Name = "Sheet1";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Mã Phiếu Mượn",
                                                "Mã ĐG",
                                                "Mã Sách",
                                                "Ngày Mượn",
                                                "Ngày Trả",
                                                "Tiền Phạt",
                                                "Ghi chú"
                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Thống Kê Danh Sách Phiếu Mượn";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.White);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // lấy ra danh sách UserInfo từ ItemSource của DataGrid
                    List<MuonSach> userList = l;

                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in userList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.sophieumuon;
                        ws.Cells[rowIndex, colIndex++].Value = item.madg;
                        ws.Cells[rowIndex, colIndex++].Value = item.masach;

                        // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        ws.Cells[rowIndex, colIndex++].Value = item.ngaymuon.ToShortDateString();
                        ws.Cells[rowIndex, colIndex++].Value = item.ngaytra.ToShortDateString();

                        ws.Cells[rowIndex, colIndex++].Value = item.tienphat;
                        ws.Cells[rowIndex, colIndex++].Value = item.ghichu;
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBoxCT("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi khi lưu file!");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
