using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace Lab8_RestaurantManagementProject
{
    public partial class MainForm : Form
    {
        //Danh sách toàn cục bảng Category
        List<Category> listcategory = new List<Category>();
        // Danh sách toàn cục bảng Food
        List<Food> listfood = new List<Food>();
        // Đối tượng Food đang chọn hiện hành
        Food foodCurrent = new Food();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods

        private void LoadCategory()
        {
            //Gọi đối tượng CategoryBL từ tầng BusinessLogic
            CategoryBL categoryBL = new CategoryBL();
            // Lấy dữ liệu gán cho biến toàn cục listCategory
            listcategory = categoryBL.GetAll();
            // Chuyển vào Combobox với dữ liệu là ID, hiển thị là Name
            cbbCategory.DataSource = listcategory;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        public void LoadFoodDataToListView()
        {
            //Gọi đối tượng FoodBL từ tầng BusinessLogic
            FoodBL foodBL = new FoodBL();
            listfood = foodBL.GetAll();

            int count = 1; // Biến số thứ tự

            lvFood.Items.Clear();

            foreach (var item in listfood)
            {
                ListViewItem lvitem = new ListViewItem(count.ToString());

                // Đưa dữ liệu Name, Unit, price vào cột tiếp theo
                lvitem.SubItems.Add(item.Name);
                lvitem.SubItems.Add(item.Unit);
                lvitem.SubItems.Add(item.Price.ToString());

                // Theo dữ liệu của bảng Category ID, lấy Name để hiển thị
                string foodname = listcategory.Find(x => x.ID == item.FoodCategoryID).Name;

                lvitem.SubItems.Add(foodname);
                lvitem.SubItems.Add(item.Notes);

                lvFood.Items.Add(lvitem);
                count++;
            }
        }
        public int InsertFood()
        {
            //Khai báo đối tượng Food từ tầng DataAccess
            Food food = new Food();
            food.ID = 0;

            if (txbname.Text == "" || txbunit.Text == "" || txbprice.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            }
            else
            {
                //Nhận giá trị Name, Unit, và Notes từ người dùng nhập vào
                food.Name = txbname.Text;
                food.Unit = txbunit.Text;
                food.Notes = txbnotes.Text;
                // Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    // Cố gắng lấy giá trị
                    price = int.Parse(txbprice.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    price = 0;
                }
                food.Price = price;
                // Giá trị FoodCategoryID được lấy từ ComboBox
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                // Khao báo đối tượng FoodBL từ tầng Business
                FoodBL foodBL = new FoodBL();
                // Chèn dữ liệu vào bảng
                return foodBL.Insert(food);
            }
            return -1;
        }
        #endregion


        #region Events

        private void btnadd_Click(object sender, EventArgs e)
        {
            // Gọi phương thức thêm dữ liệu
            int result = InsertFood();
            if (result > 0) // Nếu thêm thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Thêm dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                LoadFoodDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void lvFood_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lvFood.Items.Count; i++)
            {
                if (lvFood.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    foodCurrent = listfood[i];
                    txbname.Text = foodCurrent.Name;
                    txbunit.Text = foodCurrent.Unit;
                    txbprice.Text = foodCurrent.Price.ToString();
                    txbnotes.Text = foodCurrent.Notes;

                    // Lấy index của Combobox theo FoodCategoryID
                    cbbCategory.SelectedIndex = listcategory.FindIndex(x => x.ID == foodCurrent.ID);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDataToListView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có chắc chắn xoá hay không? Nếu đồng ý thì
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Khai báo đối tượng FoodBL từ BusinessLogic
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)// Nếu xoá thành công
                {
                    MessageBox.Show("Xoá thực phẩm thành công");
                    // Tải tữ liệu lên ListView
                    LoadFoodDataToListView();
                }
                else MessageBox.Show("Xoá không thành công");
            }
        }
        /// <summary>
        /// Phương thức cập nhật dữ liệu cho bảng Food
        /// </summary>
        /// <returns>Trả về dương nếu cập nhật thành công, ngược lại là số âm</returns>
        public int UpdateFood()
        {
            //Khai báo đối tượng Food và lấy đối tượng hiện hành
            Food food = foodCurrent;
            // Kiểm tra nếu các ô nhập khác rỗng
            if (txbname.Text == "" || txbunit.Text == "" || txbprice    .Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                //Nhận giá trị Name, Unit, và Notes khi người dùng sửa
                food.Name = txbname.Text;
                food.Unit = txbunit.Text;
                food.Notes = txbnotes.Text;
                //Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    // Chuyển giá trị từ kiểu văn bản qua kiểu int
                    price = int.Parse(txbprice.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    price = 0;
                }
                food.Price = price;
                // Giá trị FoodCategoryID được lấy từ ComboBox
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                // Khao báo đối tượng FoodBL từ tầng Business
                FoodBL foodBL = new FoodBL();
                // Cập nhật dữ liệu trong bảng
                return foodBL.Update(food);
            }
            return -1;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Gọi phương thức cập nhật dữ liệu
            int result = UpdateFood();
            if (result > 0) // Nếu cập nhật thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Cập nhật dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                LoadFoodDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }
    }
}
