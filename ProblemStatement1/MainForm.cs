using System;
using System.Windows.Forms;

namespace ProblemStatement1
{
    public partial class MainForm : Form
    {
        private Cart _cart;

        public MainForm()
        {
            InitializeComponent();
            InitInstances();
            InitDummyData();
            InitDataBindings();
        }        

        private void InitInstances()
        {
            this._cart = new Cart();

            this.dgvAllProducts.AutoGenerateColumns = false;
            this.dgvCartList.AutoGenerateColumns = false;
            this.dgvPromotionOne.AutoGenerateColumns = false;
            this.dgvPromotionTwo.AutoGenerateColumns = false;
        }

        private void InitDummyData()
        {
            Store.Instance.AddProductToStore("A", 50);
            Store.Instance.AddProductToStore("B", 30);
            Store.Instance.AddProductToStore("C", 20);
            Store.Instance.AddProductToStore("D", 15);

            PromotionFactory.Instance.AddNewPromotionOne("A", 3, 130);
            PromotionFactory.Instance.AddNewPromotionOne("B", 2, 45);

            PromotionFactory.Instance.AddNewPromotionTwo("C", "D", 30);
        }

        private void InitDataBindings()
        {

            var source = new BindingSource();
            source.DataSource = Store.Instance.AllProducts;
            dgvAllProducts.DataSource = source;


            source = new BindingSource();
            source.DataSource = Store.Instance.AllProducts;
            cbboxSelectProduct.DataSource = source;

            source = new BindingSource();
            source.DataSource = Store.Instance.AllProducts;
            cbboxPromotion1Product.DataSource = source;

            source = new BindingSource();
            source.DataSource = Store.Instance.AllProducts;
            cbboxPromotion2Product1.DataSource = source;

            source = new BindingSource();
            source.DataSource = Store.Instance.AllProducts;
            cbboxPromotion2Product2.DataSource = source;

            source = new BindingSource();
            source.DataSource = _cart.AllPurchases;
            dgvCartList.DataSource = source;

            source = new BindingSource();
            source.DataSource = PromotionFactory.Instance.PromotionOneInstance.Data;
            dgvPromotionOne.DataSource = source;

            source = new BindingSource();
            source.DataSource = PromotionFactory.Instance.PromotionTwoInstance.Data;
            dgvPromotionTwo.DataSource = source;
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            bool changesMade = Store.Instance.AddProductToStore(txtboxNewProductName.Text, numNewProductPrice.Value);
            InitDataBindings();
            RefreshData(changesMade);
        }

        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            _cart.AddPurchaseToCart(
                    cbboxSelectProduct.SelectedValue.ToString()
                    , Convert.ToInt32(Math.Round(numQuantity.Value, 0))
                 );
            InitDataBindings();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (_cart.AllPurchases != null && _cart.AllPurchases.Count > 0)
            {
                Billing.Instance.Bill(_cart);
                this.rtbFinalBill.Text = Billing.Instance.FinalBill;
            }
        }

        private void btnAddPromotionOne_Click(object sender, EventArgs e)
        {
            bool changesMade = PromotionFactory.Instance.AddNewPromotionOne(
                cbboxPromotion1Product.Text,
                Convert.ToInt32(Math.Round(numProm1Units.Value, 0)),
                numProm1OffferPrice.Value
             );
            InitDataBindings();
            RefreshData(changesMade);
        }

        private void RefreshData(bool changesMade)
        {
            if (changesMade)
            {
                this._cart.ClearPurchases();
                rtbFinalBill.Clear();
                InitDataBindings();
            }
        }

        private void btnAddPromotionTwo_Click(object sender, EventArgs e)
        {
            bool changesMade = PromotionFactory.Instance.AddNewPromotionTwo(
                cbboxPromotion2Product1.Text,
                cbboxPromotion2Product2.Text,
                numProm2OfferPrice.Value
            );
            InitDataBindings();
            RefreshData(changesMade);
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            numQuantity.Value = Convert.ToInt32(Math.Round(numQuantity.Value, 0));
        }

        private void dgvAllProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Store.Instance.RemoveProductFromStore(Store.Instance.AllProducts[e.RowIndex]);
                InitDataBindings();
                RefreshData(true);
            }
        }

        private void dgvPromotionOne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                PromotionFactory.Instance.RemovePromotionOne(PromotionFactory.Instance.PromotionOneInstance.Data[e.RowIndex]);
                InitDataBindings();
                RefreshData(true);
            }
        }

        private void dgvPromotionTwo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                PromotionFactory.Instance.RemovePromotionTwo(PromotionFactory.Instance.PromotionTwoInstance.Data[e.RowIndex]);
                InitDataBindings();
                RefreshData(true);
            }
        }

        private void dgvCartList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                this._cart.RemovePurchaseFromCart(this._cart.AllPurchases[e.RowIndex]);
                InitDataBindings();
            }
        }
    }
}
