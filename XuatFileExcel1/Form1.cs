using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace XuatFileExcel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlybanhangDataSet.tblChitietHDBan' table. You can move, or remove it, as needed.
            this.tblChitietHDBanTableAdapter.Fill(this.quanlybanhangDataSet.tblChitietHDBan);

        }

        private void TblChitietHDBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblChitietHDBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlybanhangDataSet);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exBook =
            exApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)exBook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range tenCuaHang = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, 1];
            tenCuaHang.Font.Size = 12;
            tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Color = Color.Blue;
            tenCuaHang.Value = "CỬA HÀNG BÁN ĐỒ LƯU NIỆM BÌNH AN";
            Microsoft.Office.Interop.Excel.Range dcCuaHang = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[2, 1];
            dcCuaHang.Font.Size = 12;
            dcCuaHang.Font.Bold = true;
            dcCuaHang.Font.Color = Color.Blue;
            dcCuaHang.Value = "Địa chỉ: 37B - TT Đông Anh - Hà Nội";
            Microsoft.Office.Interop.Excel.Range dtCuaHang = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[3, 1];
            dtCuaHang.Font.Size = 12;
            dtCuaHang.Font.Bold = true;
            dtCuaHang.Font.Color = Color.Blue;
            dtCuaHang.Value = "Điện thoại: 0976967619";
            Microsoft.Office.Interop.Excel.Range header = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[5, 2];
            exSheet.get_Range("B5:G5").Merge(true);
            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "DANH SÁCH CÁC MẶT HÀNG";
            //Định dạng tiêu đề bảng

            exSheet.get_Range("A7:G7").Font.Bold = true;
            exSheet.get_Range("A7:G7").HorizontalAlignment =
           Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A7").Value = "STT";
            exSheet.get_Range("B7").Value = "Mã hàng";
            exSheet.get_Range("C7").Value = "Tên hàng";
            exSheet.get_Range("C7").ColumnWidth = 20;
            exSheet.get_Range("D7").Value = "Chất liệu";
            exSheet.get_Range("E7").Value = "Số lượng";
            exSheet.get_Range("F7").Value = "Giá nhập";
            exSheet.get_Range("G7").Value = "Giá bán";
            //In dữ liệu
            for (int i = 0; i < dtHang.Rows.Count; i++)
            {
                exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i +
               8).ToString()).Font.Bold = false;
                exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                exSheet.get_Range("B" + (i + 8).ToString()).Value = dtHang.Rows[i].Cells[0].Value;
                exSheet.get_Range("C" + (i + 8).ToString()).Value = dtHang.Rows[i].Cells[1].Value;
                exSheet.get_Range("D" + (i + 8).ToString()).Value = dtHang.Rows[i].Cells[2].Value;
                exSheet.get_Range("E" + (i + 8).ToString()).Value = dtHang.Rows[i].Cells[3].Value;
                exSheet.get_Range("F" + (i + 8).ToString()).Value = dtHang.Rows[i].Cells[4].Value;
                exSheet.get_Range("G" + (i + 8).ToString()).Value = dtHang.Rows[i].Cells[5].Value;
            }
            exSheet.Name = "Hang";
            exBook.Activate(); //Kích hoạt file Excel
                               //Thiết lập các thuộc tính của SaveFileDialog
                               //Thiết lập các thuộc tính của SaveFileDialog
            saveFileDialog1.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".xls";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                exBook.SaveAs(saveFileDialog1.FileName.ToString());//Lưu file Excel
            exApp.Quit();//Thoát khỏi ứng dụng


        }

        
    }
}
