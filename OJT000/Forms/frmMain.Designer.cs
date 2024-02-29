
namespace OJT000.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCheckProduct = new System.Windows.Forms.Panel();
            this.btnExtract = new System.Windows.Forms.Button();
            this.lblChkProductError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acdbDataSet = new OJT000.acdbDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.lblUpdateProduct = new System.Windows.Forms.LinkLabel();
            this.lblCheckProduct = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInsertProduct = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pUpdateProduct = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbProductCode = new System.Windows.Forms.ComboBox();
            this.dtOrderDateUpd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUpdateError = new System.Windows.Forms.Label();
            this.txtProductNameUpd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pInsertProduct = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblInsertError = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new OJT000.acdbDataSetTableAdapters.productTableAdapter();
            this.pCheckProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acdbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pUpdateProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pInsertProduct.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCheckProduct
            // 
            this.pCheckProduct.BackColor = System.Drawing.SystemColors.Window;
            this.pCheckProduct.Controls.Add(this.btnExtract);
            this.pCheckProduct.Controls.Add(this.lblChkProductError);
            this.pCheckProduct.Controls.Add(this.dataGridView1);
            this.pCheckProduct.Controls.Add(this.btnDelete);
            this.pCheckProduct.Location = new System.Drawing.Point(19, 55);
            this.pCheckProduct.Name = "pCheckProduct";
            this.pCheckProduct.Size = new System.Drawing.Size(619, 292);
            this.pCheckProduct.TabIndex = 6;
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.Color.LightGreen;
            this.btnExtract.Location = new System.Drawing.Point(199, 256);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(90, 30);
            this.btnExtract.TabIndex = 14;
            this.btnExtract.Text = "抽出";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // lblChkProductError
            // 
            this.lblChkProductError.AutoSize = true;
            this.lblChkProductError.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkProductError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblChkProductError.Location = new System.Drawing.Point(209, 4);
            this.lblChkProductError.Name = "lblChkProductError";
            this.lblChkProductError.Size = new System.Drawing.Size(171, 19);
            this.lblChkProductError.TabIndex = 13;
            this.lblChkProductError.Text = "lblChkProductError";
            this.lblChkProductError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChkProductError.UseMnemonic = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Check,
            this.no,
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(44, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 221);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Width = 50;
            // 
            // no
            // 
            this.no.FillWeight = 36.30587F;
            this.no.HeaderText = "#";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.FillWeight = 80F;
            this.productidDataGridViewTextBoxColumn.HeaderText = "プロダクトコード";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.productnameDataGridViewTextBoxColumn.HeaderText = "プロダクト名";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.FillWeight = 75.04167F;
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "注文日";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.acdbDataSet;
            // 
            // acdbDataSet
            // 
            this.acdbDataSet.DataSetName = "acdbDataSet";
            this.acdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(319, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Lavender;
            this.lblLogout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Red;
            this.lblLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogout.Location = new System.Drawing.Point(535, 8);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Padding = new System.Windows.Forms.Padding(8);
            this.lblLogout.Size = new System.Drawing.Size(81, 35);
            this.lblLogout.TabIndex = 7;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "ログアウト";
            this.lblLogout.VisitedLinkColor = System.Drawing.Color.MediumBlue;
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.BackColor = System.Drawing.Color.Lavender;
            this.lblUpdateProduct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblUpdateProduct.LinkColor = System.Drawing.Color.Indigo;
            this.lblUpdateProduct.Location = new System.Drawing.Point(352, 8);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Padding = new System.Windows.Forms.Padding(8);
            this.lblUpdateProduct.Size = new System.Drawing.Size(144, 35);
            this.lblUpdateProduct.TabIndex = 8;
            this.lblUpdateProduct.TabStop = true;
            this.lblUpdateProduct.Text = "プロダクトを更新する";
            this.lblUpdateProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUpdateProduct_LinkClicked);
            // 
            // lblCheckProduct
            // 
            this.lblCheckProduct.AutoSize = true;
            this.lblCheckProduct.BackColor = System.Drawing.Color.Lavender;
            this.lblCheckProduct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckProduct.ForeColor = System.Drawing.Color.Indigo;
            this.lblCheckProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCheckProduct.LinkColor = System.Drawing.Color.Indigo;
            this.lblCheckProduct.Location = new System.Drawing.Point(28, 8);
            this.lblCheckProduct.Name = "lblCheckProduct";
            this.lblCheckProduct.Padding = new System.Windows.Forms.Padding(8);
            this.lblCheckProduct.Size = new System.Drawing.Size(120, 35);
            this.lblCheckProduct.TabIndex = 9;
            this.lblCheckProduct.TabStop = true;
            this.lblCheckProduct.Text = "プロダクトを確認";
            this.lblCheckProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCheckProduct_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblInsertProduct);
            this.panel1.Controls.Add(this.lblCheckProduct);
            this.panel1.Controls.Add(this.lblUpdateProduct);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pInsertProduct);
            this.panel1.Controls.Add(this.pCheckProduct);
            this.panel1.Controls.Add(this.pUpdateProduct);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 354);
            this.panel1.TabIndex = 10;
            // 
            // lblInsertProduct
            // 
            this.lblInsertProduct.AutoSize = true;
            this.lblInsertProduct.BackColor = System.Drawing.Color.Lavender;
            this.lblInsertProduct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblInsertProduct.LinkColor = System.Drawing.Color.Indigo;
            this.lblInsertProduct.Location = new System.Drawing.Point(188, 8);
            this.lblInsertProduct.Name = "lblInsertProduct";
            this.lblInsertProduct.Padding = new System.Windows.Forms.Padding(8);
            this.lblInsertProduct.Size = new System.Drawing.Size(120, 35);
            this.lblInsertProduct.TabIndex = 0;
            this.lblInsertProduct.TabStop = true;
            this.lblInsertProduct.Text = "プロダクトを挿入";
            this.lblInsertProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInsertProduct_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 43);
            this.panel4.TabIndex = 16;
            // 
            // pUpdateProduct
            // 
            this.pUpdateProduct.BackColor = System.Drawing.SystemColors.Window;
            this.pUpdateProduct.Controls.Add(this.panel2);
            this.pUpdateProduct.Location = new System.Drawing.Point(118, 74);
            this.pUpdateProduct.Name = "pUpdateProduct";
            this.pUpdateProduct.Size = new System.Drawing.Size(391, 256);
            this.pUpdateProduct.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.cbProductCode);
            this.panel2.Controls.Add(this.dtOrderDateUpd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblUpdateError);
            this.panel2.Controls.Add(this.txtProductNameUpd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(9, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 238);
            this.panel2.TabIndex = 1;
            // 
            // cbProductCode
            // 
            this.cbProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCode.FormattingEnabled = true;
            this.cbProductCode.IntegralHeight = false;
            this.cbProductCode.Location = new System.Drawing.Point(177, 24);
            this.cbProductCode.Name = "cbProductCode";
            this.cbProductCode.Size = new System.Drawing.Size(172, 21);
            this.cbProductCode.TabIndex = 4;
            this.cbProductCode.Tag = "";
            this.cbProductCode.SelectedIndexChanged += new System.EventHandler(this.cbProductCode_SelectedIndexChanged);
            // 
            // dtOrderDateUpd
            // 
            this.dtOrderDateUpd.CustomFormat = " ";
            this.dtOrderDateUpd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOrderDateUpd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOrderDateUpd.Location = new System.Drawing.Point(177, 120);
            this.dtOrderDateUpd.Name = "dtOrderDateUpd";
            this.dtOrderDateUpd.Size = new System.Drawing.Size(172, 26);
            this.dtOrderDateUpd.TabIndex = 6;
            this.dtOrderDateUpd.ValueChanged += new System.EventHandler(this.dtOrderDateUpd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "注文日 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "プロダクトコード :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateError
            // 
            this.lblUpdateError.AutoSize = true;
            this.lblUpdateError.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUpdateError.Location = new System.Drawing.Point(17, 157);
            this.lblUpdateError.Name = "lblUpdateError";
            this.lblUpdateError.Size = new System.Drawing.Size(135, 19);
            this.lblUpdateError.TabIndex = 21;
            this.lblUpdateError.Text = "lblUpdateError";
            this.lblUpdateError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdateError.UseMnemonic = false;
            // 
            // txtProductNameUpd
            // 
            this.txtProductNameUpd.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtProductNameUpd.Location = new System.Drawing.Point(177, 71);
            this.txtProductNameUpd.Name = "txtProductNameUpd";
            this.txtProductNameUpd.Size = new System.Drawing.Size(172, 27);
            this.txtProductNameUpd.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.btnUpdate.Location = new System.Drawing.Point(141, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(17, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "プロダクト名 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pInsertProduct
            // 
            this.pInsertProduct.BackColor = System.Drawing.SystemColors.Window;
            this.pInsertProduct.Controls.Add(this.panel3);
            this.pInsertProduct.Location = new System.Drawing.Point(91, 68);
            this.pInsertProduct.Name = "pInsertProduct";
            this.pInsertProduct.Size = new System.Drawing.Size(441, 262);
            this.pInsertProduct.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.dtOrderDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Controls.Add(this.lblInsertError);
            this.panel3.Controls.Add(this.txtProductName);
            this.panel3.Controls.Add(this.txtProductCode);
            this.panel3.Controls.Add(this.btnInsertProduct);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(36, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 238);
            this.panel3.TabIndex = 0;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.CustomFormat = " ";
            this.dtOrderDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOrderDate.Location = new System.Drawing.Point(177, 120);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(172, 26);
            this.dtOrderDate.TabIndex = 2;
            this.dtOrderDate.ValueChanged += new System.EventHandler(this.dtOrderDate_ValueChanged);
            this.dtOrderDate.DropDown += new System.EventHandler(this.dtOrderDate_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "注文日 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblUserName.ForeColor = System.Drawing.Color.Indigo;
            this.lblUserName.Location = new System.Drawing.Point(17, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(121, 20);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "プロダクトコード :";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInsertError
            // 
            this.lblInsertError.AutoSize = true;
            this.lblInsertError.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblInsertError.Location = new System.Drawing.Point(17, 157);
            this.lblInsertError.Name = "lblInsertError";
            this.lblInsertError.Size = new System.Drawing.Size(135, 19);
            this.lblInsertError.TabIndex = 21;
            this.lblInsertError.Text = "lblInsertError";
            this.lblInsertError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInsertError.UseMnemonic = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtProductName.Location = new System.Drawing.Point(177, 71);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(172, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtProductCode.Location = new System.Drawing.Point(177, 22);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(172, 27);
            this.txtProductCode.TabIndex = 19;
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.BackColor = System.Drawing.Color.Lavender;
            this.btnInsertProduct.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.btnInsertProduct.Location = new System.Drawing.Point(150, 192);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(88, 32);
            this.btnInsertProduct.TabIndex = 3;
            this.btnInsertProduct.Text = "挿入";
            this.btnInsertProduct.UseVisualStyleBackColor = false;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "プロダクト名 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 355);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メイン";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pCheckProduct.ResumeLayout(false);
            this.pCheckProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acdbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pUpdateProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pInsertProduct.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pCheckProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.LinkLabel lblUpdateProduct;
        private System.Windows.Forms.LinkLabel lblCheckProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblInsertProduct;
        private acdbDataSet acdbDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private acdbDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Label lblChkProductError;
       
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Panel pInsertProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblInsertError;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Panel pUpdateProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbProductCode;
        private System.Windows.Forms.DateTimePicker dtOrderDateUpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUpdateError;
        private System.Windows.Forms.TextBox txtProductNameUpd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExtract;
    }
}