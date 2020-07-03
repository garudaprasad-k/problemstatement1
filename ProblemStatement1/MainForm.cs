using System;
using System.Windows.Forms;

namespace ProblemStatement1
{
    public partial class MainForm : Form
    {
        private Cart _cart;
        private Store _store;
        private PromotionFactory _promotion;
        private Billing _billing;

        public MainForm()
        {
            InitializeComponent();
            InitInstances();
            InitDataBindings();
        }

        private void InitInstances()
        {
            this._cart = new Cart();
            this._store = Store.Instance();
            this._promotion = PromotionFactory.Instance();

            this.dgvAllProducts.AutoGenerateColumns = false;
            this.dgvCartList.AutoGenerateColumns = false;
            this.dgvPromotionOne.AutoGenerateColumns = false;
            this.dgvPromotionTwo.AutoGenerateColumns = false;
        }        

        private void InitDataBindings()
        {

            var source = new BindingSource();
            source.DataSource = _store.AllProducts;
            dgvAllProducts.DataSource = source;


            source = new BindingSource();
            source.DataSource = _store.AllProducts;
            cbboxSelectProduct.DataSource = source;

            source = new BindingSource();
            source.DataSource = _store.AllProducts;
            cbboxPromotion1Product.DataSource = source;

            source = new BindingSource();
            source.DataSource = _store.AllProducts;
            cbboxPromotion2Product1.DataSource = source;

            source = new BindingSource();
            source.DataSource = _store.AllProducts;
            cbboxPromotion2Product2.DataSource = source;

            source = new BindingSource();
            source.DataSource = _cart.AllPurchases;
            dgvCartList.DataSource = source;

            source = new BindingSource();
            source.DataSource = _promotion.PromotionOneInstance.Data;
            dgvPromotionOne.DataSource = source;

            source = new BindingSource();
            source.DataSource = _promotion.PromotionTwoInstance.Data;
            dgvPromotionTwo.DataSource = source;
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            bool changesMade = this._store.addProductToStore(txtboxNewProductName.Text, numNewProductPrice.Value);
            InitDataBindings();
            RefreshData(changesMade);
        }

        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            _cart.AddProductToCart(
                    cbboxSelectProduct.SelectedValue.ToString()
                    , Convert.ToInt32(Math.Round(numQuantity.Value, 0))
                 );
            InitDataBindings();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (_cart.AllPurchases != null && _cart.AllPurchases.Count > 0)
            {
                this._billing = new Billing(_cart);
                this._billing.bill();
                this.rtbFinalBill.Text = _billing.FinalBill;
            }
        }

        private void btnAddPromotionOne_Click(object sender, EventArgs e)
        {
            bool changesMade = _promotion.addNewPromotionOne(
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
            bool changesMade = _promotion.addNewPromotionTwo(
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
                this._store.RemoveProductFromStore(this._store.AllProducts[e.RowIndex]);
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
                this._promotion.removePromotionOne(this._promotion.PromotionOneInstance.Data[e.RowIndex]);
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
                this._promotion.removePromotionTwo(this._promotion.PromotionTwoInstance.Data[e.RowIndex]);
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
