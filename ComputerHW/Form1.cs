using System.Collections.ObjectModel;

namespace ComputerHW
{
    public partial class Form1 : Form
    {
        private Category[] categories;
        private ObservableCollection<Product> products;

        public decimal TotalToPay
        {
            get
            {
                return CartProductsList.Items.OfType<Product>().Sum(e => e.Price);
            }
        }

        public Form1()
        {
            InitializeComponent();

            categories = new Category[]
            {
                new Category { Name = "All", Id = "-1"},
                new Category{ Name = "Laptops"},
                new Category{ Name = "Headphones"},
                new Category{ Name = "Smartphones"}
            };

            products = new ObservableCollection<Product>()
            {
                new Product{ Name = "Asus V13", Category = categories[1], Price = 899, Quantity = 70},
                new Product{ Name = "Lenovo q4531", Category = categories[1], Price = 1250, Quantity = 17},
                new Product{ Name = "Sony W56", Category = categories[3], Price = 299, Quantity = 180},
                new Product{ Name = "Samsung Galaxy S5", Category = categories[3], Price = 345, Quantity = 36},
                new Product{ Name = "Iphone 11 Pro", Category = categories[3], Price = 456, Quantity = 39}
            };

            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "Id";

            ProductsListBox.SelectionMode = SelectionMode.MultiExtended;

            FillListBox();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void FillListBox()
        {
            if (CategoryComboBox.SelectedValue == "-1")
            {
                ProductsListBox.DataSource = products.ToList();
            }
            else
            {
                ProductsListBox.DataSource = products.Where(e => e.Category.Id.Equals(CategoryComboBox.SelectedValue)).ToList();
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = ProductsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                CartProductsList.Items.AddRange(selectedProducts);
                TotalToPayTextBox.Text = $"Total to pay: {TotalToPay.ToString()}";
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = ProductsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                DetailsForm detailsForm = new DetailsForm(selectedProducts);
                var result = detailsForm.ShowDialog();
                FillListBox();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = CartProductsList.SelectedIndex;
            if (index != -1)
            {
                CartProductsList.Items.RemoveAt(index);
                TotalToPayTextBox.Text = $"Total to pay: {TotalToPay.ToString()}";
            }
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            if (TotalToPay > 0)
            {
                MessageBox.Show($"Order is finished. Total to pay: {TotalToPay}", "Pay Method");
            }
        }
    }
}
