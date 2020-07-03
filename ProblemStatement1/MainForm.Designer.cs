using System.Windows.Forms;

namespace ProblemStatement1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.BillingTab = new System.Windows.Forms.TabPage();
            this.tlpBilling = new System.Windows.Forms.TableLayoutPanel();
            this.pnlR0C0 = new System.Windows.Forms.Panel();
            this.lblEnterQuantity = new System.Windows.Forms.Label();
            this.btnAddProductToCart = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.cbboxSelectProduct = new System.Windows.Forms.ComboBox();
            this.pnlR1C0 = new System.Windows.Forms.Panel();
            this.dgvCartList = new System.Windows.Forms.DataGridView();
            this.dgvtbcItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbcActions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.rtbFinalBill = new System.Windows.Forms.RichTextBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSettingsR1C1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbboxPromotion2Product2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numProm2OfferPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbboxPromotion2Product1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromotion2 = new System.Windows.Forms.Label();
            this.btnAddPromotionTwo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPromotionTwo = new System.Windows.Forms.DataGridView();
            this.dgvtbcProductOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcProductTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPromotion2OfferPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbcPromotionTwoAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlR0R1C0 = new System.Windows.Forms.Panel();
            this.tlpSettingsR0C0 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSettingsR1C0 = new System.Windows.Forms.Panel();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.dgvtbcProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbcDeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlSettingsR0C0 = new System.Windows.Forms.Panel();
            this.txtboxNewProductName = new System.Windows.Forms.TextBox();
            this.lblEnterPrice = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.numNewProductPrice = new System.Windows.Forms.NumericUpDown();
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.pnlSettingsR0C1 = new System.Windows.Forms.Panel();
            this.tlpSettingsR0C1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numProm1OffferPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbboxPromotion1Product = new System.Windows.Forms.ComboBox();
            this.lblPromotion1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPromotionOne = new System.Windows.Forms.Button();
            this.numProm1Units = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPromotionOne = new System.Windows.Forms.DataGridView();
            this.dgvtbcPromotionOneProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNumberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPromotionOnePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbcPromotionOneAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MainTabControl.SuspendLayout();
            this.BillingTab.SuspendLayout();
            this.tlpBilling.SuspendLayout();
            this.pnlR0C0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlR1C0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).BeginInit();
            this.SettingsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSettingsR1C1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProm2OfferPrice)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotionTwo)).BeginInit();
            this.pnlR0R1C0.SuspendLayout();
            this.tlpSettingsR0C0.SuspendLayout();
            this.pnlSettingsR1C0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.pnlSettingsR0C0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewProductPrice)).BeginInit();
            this.pnlSettingsR0C1.SuspendLayout();
            this.tlpSettingsR0C1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProm1OffferPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProm1Units)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotionOne)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.BillingTab);
            this.MainTabControl.Controls.Add(this.SettingsTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(922, 603);
            this.MainTabControl.TabIndex = 0;
            // 
            // BillingTab
            // 
            this.BillingTab.Controls.Add(this.tlpBilling);
            this.BillingTab.Location = new System.Drawing.Point(4, 22);
            this.BillingTab.Name = "BillingTab";
            this.BillingTab.Padding = new System.Windows.Forms.Padding(3);
            this.BillingTab.Size = new System.Drawing.Size(914, 577);
            this.BillingTab.TabIndex = 0;
            this.BillingTab.Text = "Billing";
            this.BillingTab.UseVisualStyleBackColor = true;
            // 
            // tlpBilling
            // 
            this.tlpBilling.ColumnCount = 2;
            this.tlpBilling.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBilling.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBilling.Controls.Add(this.pnlR0C0, 0, 0);
            this.tlpBilling.Controls.Add(this.pnlR1C0, 0, 1);
            this.tlpBilling.Controls.Add(this.btnGenerateBill, 1, 0);
            this.tlpBilling.Controls.Add(this.rtbFinalBill, 1, 1);
            this.tlpBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBilling.Location = new System.Drawing.Point(3, 3);
            this.tlpBilling.Name = "tlpBilling";
            this.tlpBilling.RowCount = 2;
            this.tlpBilling.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpBilling.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBilling.Size = new System.Drawing.Size(908, 571);
            this.tlpBilling.TabIndex = 6;
            // 
            // pnlR0C0
            // 
            this.pnlR0C0.Controls.Add(this.lblEnterQuantity);
            this.pnlR0C0.Controls.Add(this.btnAddProductToCart);
            this.pnlR0C0.Controls.Add(this.numQuantity);
            this.pnlR0C0.Controls.Add(this.lblSelectProduct);
            this.pnlR0C0.Controls.Add(this.cbboxSelectProduct);
            this.pnlR0C0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlR0C0.Location = new System.Drawing.Point(3, 3);
            this.pnlR0C0.Name = "pnlR0C0";
            this.pnlR0C0.Size = new System.Drawing.Size(448, 69);
            this.pnlR0C0.TabIndex = 0;
            // 
            // lblEnterQuantity
            // 
            this.lblEnterQuantity.AutoSize = true;
            this.lblEnterQuantity.Location = new System.Drawing.Point(153, 6);
            this.lblEnterQuantity.Name = "lblEnterQuantity";
            this.lblEnterQuantity.Size = new System.Drawing.Size(74, 13);
            this.lblEnterQuantity.TabIndex = 16;
            this.lblEnterQuantity.Text = "Enter Quantity";
            // 
            // btnAddProductToCart
            // 
            this.btnAddProductToCart.Location = new System.Drawing.Point(282, 19);
            this.btnAddProductToCart.Name = "btnAddProductToCart";
            this.btnAddProductToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductToCart.TabIndex = 15;
            this.btnAddProductToCart.Text = "Add";
            this.btnAddProductToCart.UseVisualStyleBackColor = true;
            this.btnAddProductToCart.Click += new System.EventHandler(this.btnAddProductToCart_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(156, 22);
            this.numQuantity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 14;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(3, 6);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(77, 13);
            this.lblSelectProduct.TabIndex = 13;
            this.lblSelectProduct.Text = "Select Product";
            // 
            // cbboxSelectProduct
            // 
            this.cbboxSelectProduct.DisplayMember = "ProductName";
            this.cbboxSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxSelectProduct.FormattingEnabled = true;
            this.cbboxSelectProduct.Location = new System.Drawing.Point(5, 22);
            this.cbboxSelectProduct.Name = "cbboxSelectProduct";
            this.cbboxSelectProduct.Size = new System.Drawing.Size(145, 21);
            this.cbboxSelectProduct.TabIndex = 12;
            this.cbboxSelectProduct.ValueMember = "ProductName";
            // 
            // pnlR1C0
            // 
            this.pnlR1C0.Controls.Add(this.dgvCartList);
            this.pnlR1C0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlR1C0.Location = new System.Drawing.Point(3, 78);
            this.pnlR1C0.Name = "pnlR1C0";
            this.pnlR1C0.Size = new System.Drawing.Size(448, 490);
            this.pnlR1C0.TabIndex = 1;
            // 
            // dgvCartList
            // 
            this.dgvCartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcItems,
            this.dgvtbcQuantity,
            this.dgvbcActions});
            this.dgvCartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCartList.Location = new System.Drawing.Point(0, 0);
            this.dgvCartList.Name = "dgvCartList";
            this.dgvCartList.RowHeadersVisible = false;
            this.dgvCartList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartList.Size = new System.Drawing.Size(448, 490);
            this.dgvCartList.TabIndex = 0;
            this.dgvCartList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartList_CellContentClick);
            // 
            // dgvtbcItems
            // 
            this.dgvtbcItems.DataPropertyName = "ProductName";
            this.dgvtbcItems.HeaderText = "Items";
            this.dgvtbcItems.Name = "dgvtbcItems";
            this.dgvtbcItems.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtbcQuantity
            // 
            this.dgvtbcQuantity.DataPropertyName = "Quantity";
            this.dgvtbcQuantity.HeaderText = "Quantity";
            this.dgvtbcQuantity.Name = "dgvtbcQuantity";
            this.dgvtbcQuantity.ReadOnly = true;
            this.dgvtbcQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvbcActions
            // 
            this.dgvbcActions.HeaderText = "Actions";
            this.dgvbcActions.Name = "dgvbcActions";
            this.dgvbcActions.ReadOnly = true;
            this.dgvbcActions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbcActions.Text = "Delete";
            this.dgvbcActions.UseColumnTextForButtonValue = true;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerateBill.Location = new System.Drawing.Point(761, 3);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(144, 69);
            this.btnGenerateBill.TabIndex = 17;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // rtbFinalBill
            // 
            this.rtbFinalBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFinalBill.Location = new System.Drawing.Point(457, 78);
            this.rtbFinalBill.Name = "rtbFinalBill";
            this.rtbFinalBill.Size = new System.Drawing.Size(448, 490);
            this.rtbFinalBill.TabIndex = 18;
            this.rtbFinalBill.Text = "";
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.tableLayoutPanel1);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(914, 577);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlSettingsR1C1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlR0R1C0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSettingsR0C1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlSettingsR1C1
            // 
            this.pnlSettingsR1C1.Controls.Add(this.tableLayoutPanel3);
            this.pnlSettingsR1C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsR1C1.Location = new System.Drawing.Point(457, 288);
            this.pnlSettingsR1C1.Name = "pnlSettingsR1C1";
            this.pnlSettingsR1C1.Size = new System.Drawing.Size(448, 280);
            this.pnlSettingsR1C1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(448, 280);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbboxPromotion2Product2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.numProm2OfferPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbboxPromotion2Product1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblPromotion2);
            this.panel3.Controls.Add(this.btnAddPromotionTwo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 69);
            this.panel3.TabIndex = 0;
            // 
            // cbboxPromotion2Product2
            // 
            this.cbboxPromotion2Product2.DisplayMember = "ProductName";
            this.cbboxPromotion2Product2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxPromotion2Product2.FormattingEnabled = true;
            this.cbboxPromotion2Product2.Location = new System.Drawing.Point(140, 39);
            this.cbboxPromotion2Product2.Name = "cbboxPromotion2Product2";
            this.cbboxPromotion2Product2.Size = new System.Drawing.Size(125, 21);
            this.cbboxPromotion2Product2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Select Product 2";
            // 
            // numProm2OfferPrice
            // 
            this.numProm2OfferPrice.Location = new System.Drawing.Point(274, 40);
            this.numProm2OfferPrice.Name = "numProm2OfferPrice";
            this.numProm2OfferPrice.Size = new System.Drawing.Size(84, 20);
            this.numProm2OfferPrice.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter Offer Price";
            // 
            // cbboxPromotion2Product1
            // 
            this.cbboxPromotion2Product1.DisplayMember = "ProductName";
            this.cbboxPromotion2Product1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxPromotion2Product1.FormattingEnabled = true;
            this.cbboxPromotion2Product1.Location = new System.Drawing.Point(8, 40);
            this.cbboxPromotion2Product1.Name = "cbboxPromotion2Product1";
            this.cbboxPromotion2Product1.Size = new System.Drawing.Size(125, 21);
            this.cbboxPromotion2Product1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Product 1";
            // 
            // lblPromotion2
            // 
            this.lblPromotion2.AutoSize = true;
            this.lblPromotion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotion2.Location = new System.Drawing.Point(5, 4);
            this.lblPromotion2.Name = "lblPromotion2";
            this.lblPromotion2.Size = new System.Drawing.Size(106, 13);
            this.lblPromotion2.TabIndex = 15;
            this.lblPromotion2.Text = "Promotion Type 2";
            // 
            // btnAddPromotionTwo
            // 
            this.btnAddPromotionTwo.Location = new System.Drawing.Point(364, 38);
            this.btnAddPromotionTwo.Name = "btnAddPromotionTwo";
            this.btnAddPromotionTwo.Size = new System.Drawing.Size(75, 23);
            this.btnAddPromotionTwo.TabIndex = 15;
            this.btnAddPromotionTwo.Text = "Add";
            this.btnAddPromotionTwo.UseVisualStyleBackColor = true;
            this.btnAddPromotionTwo.Click += new System.EventHandler(this.btnAddPromotionTwo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvPromotionTwo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 199);
            this.panel4.TabIndex = 1;
            // 
            // dgvPromotionTwo
            // 
            this.dgvPromotionTwo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromotionTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotionTwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcProductOne,
            this.dgvtbcProductTwo,
            this.dgvtbcPromotion2OfferPrice,
            this.dgvbcPromotionTwoAction});
            this.dgvPromotionTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPromotionTwo.Location = new System.Drawing.Point(0, 0);
            this.dgvPromotionTwo.Name = "dgvPromotionTwo";
            this.dgvPromotionTwo.RowHeadersVisible = false;
            this.dgvPromotionTwo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPromotionTwo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPromotionTwo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromotionTwo.Size = new System.Drawing.Size(442, 199);
            this.dgvPromotionTwo.TabIndex = 1;
            this.dgvPromotionTwo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromotionTwo_CellContentClick);
            // 
            // dgvtbcProductOne
            // 
            this.dgvtbcProductOne.DataPropertyName = "ProductOneName";
            this.dgvtbcProductOne.HeaderText = "Product 1";
            this.dgvtbcProductOne.Name = "dgvtbcProductOne";
            this.dgvtbcProductOne.ReadOnly = true;
            this.dgvtbcProductOne.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtbcProductTwo
            // 
            this.dgvtbcProductTwo.DataPropertyName = "ProductTwoName";
            this.dgvtbcProductTwo.HeaderText = "Product 2";
            this.dgvtbcProductTwo.Name = "dgvtbcProductTwo";
            this.dgvtbcProductTwo.ReadOnly = true;
            // 
            // dgvtbcPromotion2OfferPrice
            // 
            this.dgvtbcPromotion2OfferPrice.DataPropertyName = "OfferPrice";
            this.dgvtbcPromotion2OfferPrice.HeaderText = "OfferPrice";
            this.dgvtbcPromotion2OfferPrice.Name = "dgvtbcPromotion2OfferPrice";
            this.dgvtbcPromotion2OfferPrice.ReadOnly = true;
            this.dgvtbcPromotion2OfferPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvbcPromotionTwoAction
            // 
            this.dgvbcPromotionTwoAction.HeaderText = "Actions";
            this.dgvbcPromotionTwoAction.Name = "dgvbcPromotionTwoAction";
            this.dgvbcPromotionTwoAction.ReadOnly = true;
            this.dgvbcPromotionTwoAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbcPromotionTwoAction.Text = "Delete";
            this.dgvbcPromotionTwoAction.UseColumnTextForButtonValue = true;
            // 
            // pnlR0R1C0
            // 
            this.pnlR0R1C0.Controls.Add(this.tlpSettingsR0C0);
            this.pnlR0R1C0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlR0R1C0.Location = new System.Drawing.Point(3, 3);
            this.pnlR0R1C0.Name = "pnlR0R1C0";
            this.tableLayoutPanel1.SetRowSpan(this.pnlR0R1C0, 2);
            this.pnlR0R1C0.Size = new System.Drawing.Size(448, 565);
            this.pnlR0R1C0.TabIndex = 0;
            // 
            // tlpSettingsR0C0
            // 
            this.tlpSettingsR0C0.ColumnCount = 1;
            this.tlpSettingsR0C0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingsR0C0.Controls.Add(this.pnlSettingsR1C0, 0, 1);
            this.tlpSettingsR0C0.Controls.Add(this.pnlSettingsR0C0, 0, 0);
            this.tlpSettingsR0C0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettingsR0C0.Location = new System.Drawing.Point(0, 0);
            this.tlpSettingsR0C0.Name = "tlpSettingsR0C0";
            this.tlpSettingsR0C0.RowCount = 2;
            this.tlpSettingsR0C0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpSettingsR0C0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingsR0C0.Size = new System.Drawing.Size(448, 565);
            this.tlpSettingsR0C0.TabIndex = 7;
            // 
            // pnlSettingsR1C0
            // 
            this.pnlSettingsR1C0.Controls.Add(this.dgvAllProducts);
            this.pnlSettingsR1C0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsR1C0.Location = new System.Drawing.Point(3, 78);
            this.pnlSettingsR1C0.Name = "pnlSettingsR1C0";
            this.pnlSettingsR1C0.Size = new System.Drawing.Size(442, 484);
            this.pnlSettingsR1C0.TabIndex = 1;
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcProduct,
            this.dgvtbcPrice,
            this.dgvbcDeleteProduct});
            this.dgvAllProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.RowHeadersVisible = false;
            this.dgvAllProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProducts.Size = new System.Drawing.Size(442, 484);
            this.dgvAllProducts.TabIndex = 1;
            this.dgvAllProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllProducts_CellContentClick);
            // 
            // dgvtbcProduct
            // 
            this.dgvtbcProduct.DataPropertyName = "ProductName";
            this.dgvtbcProduct.HeaderText = "Product Name";
            this.dgvtbcProduct.Name = "dgvtbcProduct";
            this.dgvtbcProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtbcPrice
            // 
            this.dgvtbcPrice.DataPropertyName = "ProductPrice";
            this.dgvtbcPrice.HeaderText = "Price";
            this.dgvtbcPrice.Name = "dgvtbcPrice";
            this.dgvtbcPrice.ReadOnly = true;
            this.dgvtbcPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvbcDeleteProduct
            // 
            this.dgvbcDeleteProduct.HeaderText = "Actions";
            this.dgvbcDeleteProduct.Name = "dgvbcDeleteProduct";
            this.dgvbcDeleteProduct.ReadOnly = true;
            this.dgvbcDeleteProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbcDeleteProduct.Text = "Delete";
            this.dgvbcDeleteProduct.UseColumnTextForButtonValue = true;
            // 
            // pnlSettingsR0C0
            // 
            this.pnlSettingsR0C0.Controls.Add(this.txtboxNewProductName);
            this.pnlSettingsR0C0.Controls.Add(this.lblEnterPrice);
            this.pnlSettingsR0C0.Controls.Add(this.btnAddNewProduct);
            this.pnlSettingsR0C0.Controls.Add(this.numNewProductPrice);
            this.pnlSettingsR0C0.Controls.Add(this.lblNewProduct);
            this.pnlSettingsR0C0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsR0C0.Location = new System.Drawing.Point(3, 3);
            this.pnlSettingsR0C0.Name = "pnlSettingsR0C0";
            this.pnlSettingsR0C0.Size = new System.Drawing.Size(442, 69);
            this.pnlSettingsR0C0.TabIndex = 3;
            // 
            // txtboxNewProductName
            // 
            this.txtboxNewProductName.Location = new System.Drawing.Point(6, 22);
            this.txtboxNewProductName.Name = "txtboxNewProductName";
            this.txtboxNewProductName.Size = new System.Drawing.Size(144, 20);
            this.txtboxNewProductName.TabIndex = 17;
            // 
            // lblEnterPrice
            // 
            this.lblEnterPrice.AutoSize = true;
            this.lblEnterPrice.Location = new System.Drawing.Point(153, 6);
            this.lblEnterPrice.Name = "lblEnterPrice";
            this.lblEnterPrice.Size = new System.Drawing.Size(59, 13);
            this.lblEnterPrice.TabIndex = 16;
            this.lblEnterPrice.Text = "Enter Price";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(282, 19);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewProduct.TabIndex = 15;
            this.btnAddNewProduct.Text = "Add";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // numNewProductPrice
            // 
            this.numNewProductPrice.Location = new System.Drawing.Point(156, 22);
            this.numNewProductPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numNewProductPrice.Name = "numNewProductPrice";
            this.numNewProductPrice.Size = new System.Drawing.Size(120, 20);
            this.numNewProductPrice.TabIndex = 14;
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Location = new System.Drawing.Point(3, 6);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(128, 13);
            this.lblNewProduct.TabIndex = 13;
            this.lblNewProduct.Text = "Enter New Product Name";
            // 
            // pnlSettingsR0C1
            // 
            this.pnlSettingsR0C1.Controls.Add(this.tlpSettingsR0C1);
            this.pnlSettingsR0C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsR0C1.Location = new System.Drawing.Point(457, 3);
            this.pnlSettingsR0C1.Name = "pnlSettingsR0C1";
            this.pnlSettingsR0C1.Size = new System.Drawing.Size(448, 279);
            this.pnlSettingsR0C1.TabIndex = 1;
            // 
            // tlpSettingsR0C1
            // 
            this.tlpSettingsR0C1.ColumnCount = 1;
            this.tlpSettingsR0C1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingsR0C1.Controls.Add(this.panel5, 0, 0);
            this.tlpSettingsR0C1.Controls.Add(this.panel6, 0, 1);
            this.tlpSettingsR0C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettingsR0C1.Location = new System.Drawing.Point(0, 0);
            this.tlpSettingsR0C1.Name = "tlpSettingsR0C1";
            this.tlpSettingsR0C1.RowCount = 2;
            this.tlpSettingsR0C1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpSettingsR0C1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingsR0C1.Size = new System.Drawing.Size(448, 279);
            this.tlpSettingsR0C1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numProm1OffferPrice);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.cbboxPromotion1Product);
            this.panel5.Controls.Add(this.lblPromotion1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnAddPromotionOne);
            this.panel5.Controls.Add(this.numProm1Units);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 69);
            this.panel5.TabIndex = 0;
            // 
            // numProm1OffferPrice
            // 
            this.numProm1OffferPrice.Location = new System.Drawing.Point(274, 42);
            this.numProm1OffferPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numProm1OffferPrice.Name = "numProm1OffferPrice";
            this.numProm1OffferPrice.Size = new System.Drawing.Size(84, 20);
            this.numProm1OffferPrice.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enter Offer Price";
            // 
            // cbboxPromotion1Product
            // 
            this.cbboxPromotion1Product.DisplayMember = "ProductName";
            this.cbboxPromotion1Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxPromotion1Product.FormattingEnabled = true;
            this.cbboxPromotion1Product.Location = new System.Drawing.Point(8, 41);
            this.cbboxPromotion1Product.Name = "cbboxPromotion1Product";
            this.cbboxPromotion1Product.Size = new System.Drawing.Size(125, 21);
            this.cbboxPromotion1Product.TabIndex = 17;
            // 
            // lblPromotion1
            // 
            this.lblPromotion1.AutoSize = true;
            this.lblPromotion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotion1.Location = new System.Drawing.Point(5, 6);
            this.lblPromotion1.Name = "lblPromotion1";
            this.lblPromotion1.Size = new System.Drawing.Size(106, 13);
            this.lblPromotion1.TabIndex = 14;
            this.lblPromotion1.Text = "Promotion Type 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Number of Products";
            // 
            // btnAddPromotionOne
            // 
            this.btnAddPromotionOne.Location = new System.Drawing.Point(364, 39);
            this.btnAddPromotionOne.Name = "btnAddPromotionOne";
            this.btnAddPromotionOne.Size = new System.Drawing.Size(75, 23);
            this.btnAddPromotionOne.TabIndex = 15;
            this.btnAddPromotionOne.Text = "Add";
            this.btnAddPromotionOne.UseVisualStyleBackColor = true;
            this.btnAddPromotionOne.Click += new System.EventHandler(this.btnAddPromotionOne_Click);
            // 
            // numProm1Units
            // 
            this.numProm1Units.Location = new System.Drawing.Point(139, 42);
            this.numProm1Units.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numProm1Units.Name = "numProm1Units";
            this.numProm1Units.Size = new System.Drawing.Size(126, 20);
            this.numProm1Units.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Product";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvPromotionOne);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(442, 198);
            this.panel6.TabIndex = 1;
            // 
            // dgvPromotionOne
            // 
            this.dgvPromotionOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromotionOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotionOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcPromotionOneProduct,
            this.dgvtbcNumberOfProducts,
            this.dgvtbcPromotionOnePrice,
            this.dgvbcPromotionOneAction});
            this.dgvPromotionOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPromotionOne.Location = new System.Drawing.Point(0, 0);
            this.dgvPromotionOne.Name = "dgvPromotionOne";
            this.dgvPromotionOne.RowHeadersVisible = false;
            this.dgvPromotionOne.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPromotionOne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPromotionOne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromotionOne.Size = new System.Drawing.Size(442, 198);
            this.dgvPromotionOne.TabIndex = 0;
            this.dgvPromotionOne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromotionOne_CellContentClick);
            // 
            // dgvtbcPromotionOneProduct
            // 
            this.dgvtbcPromotionOneProduct.DataPropertyName = "ProductName";
            this.dgvtbcPromotionOneProduct.HeaderText = "Product";
            this.dgvtbcPromotionOneProduct.Name = "dgvtbcPromotionOneProduct";
            this.dgvtbcPromotionOneProduct.ReadOnly = true;
            this.dgvtbcPromotionOneProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtbcNumberOfProducts
            // 
            this.dgvtbcNumberOfProducts.DataPropertyName = "Units";
            this.dgvtbcNumberOfProducts.HeaderText = "Number Of Products";
            this.dgvtbcNumberOfProducts.Name = "dgvtbcNumberOfProducts";
            this.dgvtbcNumberOfProducts.ReadOnly = true;
            // 
            // dgvtbcPromotionOnePrice
            // 
            this.dgvtbcPromotionOnePrice.DataPropertyName = "OfferPrice";
            this.dgvtbcPromotionOnePrice.HeaderText = "Price";
            this.dgvtbcPromotionOnePrice.Name = "dgvtbcPromotionOnePrice";
            this.dgvtbcPromotionOnePrice.ReadOnly = true;
            this.dgvtbcPromotionOnePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvbcPromotionOneAction
            // 
            this.dgvbcPromotionOneAction.HeaderText = "Actions";
            this.dgvbcPromotionOneAction.Name = "dgvbcPromotionOneAction";
            this.dgvbcPromotionOneAction.ReadOnly = true;
            this.dgvbcPromotionOneAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbcPromotionOneAction.Text = "Delete";
            this.dgvbcPromotionOneAction.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 603);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "ProblemStatement1";
            this.MainTabControl.ResumeLayout(false);
            this.BillingTab.ResumeLayout(false);
            this.tlpBilling.ResumeLayout(false);
            this.pnlR0C0.ResumeLayout(false);
            this.pnlR0C0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlR1C0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSettingsR1C1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProm2OfferPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotionTwo)).EndInit();
            this.pnlR0R1C0.ResumeLayout(false);
            this.tlpSettingsR0C0.ResumeLayout(false);
            this.pnlSettingsR1C0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.pnlSettingsR0C0.ResumeLayout(false);
            this.pnlSettingsR0C0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewProductPrice)).EndInit();
            this.pnlSettingsR0C1.ResumeLayout(false);
            this.tlpSettingsR0C1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProm1OffferPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProm1Units)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotionOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage BillingTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TableLayoutPanel tlpBilling;
        private System.Windows.Forms.Panel pnlR0C0;
        private System.Windows.Forms.Label lblEnterQuantity;
        private System.Windows.Forms.Button btnAddProductToCart;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.ComboBox cbboxSelectProduct;
        private System.Windows.Forms.Panel pnlR1C0;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.DataGridView dgvCartList;
        private System.Windows.Forms.RichTextBox rtbFinalBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlR0R1C0;
        private TableLayoutPanel tlpSettingsR0C0;
        private Panel pnlSettingsR1C1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Button btnAddPromotionTwo;
        private Panel panel4;
        private DataGridView dgvPromotionOne;
        private Panel pnlSettingsR0C1;
        private Label lblPromotion2;
        private Label lblPromotion1;
        private TableLayoutPanel tlpSettingsR0C1;
        private Panel panel5;
        private Label label3;
        private Button btnAddPromotionOne;
        private NumericUpDown numProm1Units;
        private Label label4;
        private Panel panel6;
        private ComboBox cbboxPromotion2Product2;
        private Label label6;
        private NumericUpDown numProm2OfferPrice;
        private Label label1;
        private ComboBox cbboxPromotion2Product1;
        private Label label2;
        private Panel pnlSettingsR1C0;
        private DataGridView dgvAllProducts;
        private Panel pnlSettingsR0C0;
        private TextBox txtboxNewProductName;
        private Label lblEnterPrice;
        private Button btnAddNewProduct;
        private NumericUpDown numNewProductPrice;
        private Label lblNewProduct;
        private NumericUpDown numProm1OffferPrice;
        private Label label5;
        private ComboBox cbboxPromotion1Product;
        private DataGridView dgvPromotionTwo;
        private DataGridViewTextBoxColumn dgvtbcProduct;
        private DataGridViewTextBoxColumn dgvtbcPrice;
        private DataGridViewButtonColumn dgvbcDeleteProduct;
        private DataGridViewTextBoxColumn dgvtbcItems;
        private DataGridViewTextBoxColumn dgvtbcQuantity;
        private DataGridViewButtonColumn dgvbcActions;
        private DataGridViewTextBoxColumn dgvtbcPromotionOneProduct;
        private DataGridViewTextBoxColumn dgvtbcNumberOfProducts;
        private DataGridViewTextBoxColumn dgvtbcPromotionOnePrice;
        private DataGridViewButtonColumn dgvbcPromotionOneAction;
        private DataGridViewTextBoxColumn dgvtbcProductOne;
        private DataGridViewTextBoxColumn dgvtbcProductTwo;
        private DataGridViewTextBoxColumn dgvtbcPromotion2OfferPrice;
        private DataGridViewButtonColumn dgvbcPromotionTwoAction;
    }
}

