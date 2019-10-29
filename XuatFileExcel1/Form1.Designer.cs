namespace XuatFileExcel1
{
    partial class Form1
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
            System.Windows.Forms.Label maHDBanLabel;
            System.Windows.Forms.Label maHangLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label giamGiaLabel;
            System.Windows.Forms.Label thanhTienLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.quanlybanhangDataSet = new XuatFileExcel1.QuanlybanhangDataSet();
            this.tblChitietHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblChitietHDBanTableAdapter = new XuatFileExcel1.QuanlybanhangDataSetTableAdapters.tblChitietHDBanTableAdapter();
            this.tableAdapterManager = new XuatFileExcel1.QuanlybanhangDataSetTableAdapters.TableAdapterManager();
            this.tblChitietHDBanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblChitietHDBanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dtHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDBanTextBox = new System.Windows.Forms.TextBox();
            this.maHangTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            this.giamGiaTextBox = new System.Windows.Forms.TextBox();
            this.thanhTienTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            maHDBanLabel = new System.Windows.Forms.Label();
            maHangLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            giamGiaLabel = new System.Windows.Forms.Label();
            thanhTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChitietHDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChitietHDBanBindingNavigator)).BeginInit();
            this.tblChitietHDBanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHang)).BeginInit();
            this.SuspendLayout();
            // 
            // maHDBanLabel
            // 
            maHDBanLabel.AutoSize = true;
            maHDBanLabel.Location = new System.Drawing.Point(431, 22);
            maHDBanLabel.Name = "maHDBanLabel";
            maHDBanLabel.Size = new System.Drawing.Size(80, 17);
            maHDBanLabel.TabIndex = 3;
            maHDBanLabel.Text = "Ma HDBan:";
            // 
            // maHangLabel
            // 
            maHangLabel.AutoSize = true;
            maHangLabel.Location = new System.Drawing.Point(431, 50);
            maHangLabel.Name = "maHangLabel";
            maHangLabel.Size = new System.Drawing.Size(69, 17);
            maHangLabel.TabIndex = 5;
            maHangLabel.Text = "Ma Hang:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(431, 78);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(73, 17);
            soLuongLabel.TabIndex = 7;
            soLuongLabel.Text = "So Luong:";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Location = new System.Drawing.Point(431, 106);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(64, 17);
            donGiaLabel.TabIndex = 9;
            donGiaLabel.Text = "Don Gia:";
            // 
            // giamGiaLabel
            // 
            giamGiaLabel.AutoSize = true;
            giamGiaLabel.Location = new System.Drawing.Point(431, 134);
            giamGiaLabel.Name = "giamGiaLabel";
            giamGiaLabel.Size = new System.Drawing.Size(71, 17);
            giamGiaLabel.TabIndex = 11;
            giamGiaLabel.Text = "Giam Gia:";
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Location = new System.Drawing.Point(431, 162);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new System.Drawing.Size(85, 17);
            thanhTienLabel.TabIndex = 13;
            thanhTienLabel.Text = "Thanh Tien:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // quanlybanhangDataSet
            // 
            this.quanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.quanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChitietHDBanBindingSource
            // 
            this.tblChitietHDBanBindingSource.DataMember = "tblChitietHDBan";
            this.tblChitietHDBanBindingSource.DataSource = this.quanlybanhangDataSet;
            // 
            // tblChitietHDBanTableAdapter
            // 
            this.tblChitietHDBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblChitietHDBanTableAdapter = this.tblChitietHDBanTableAdapter;
            this.tableAdapterManager.UpdateOrder = XuatFileExcel1.QuanlybanhangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblChitietHDBanBindingNavigator
            // 
            this.tblChitietHDBanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblChitietHDBanBindingNavigator.BindingSource = this.tblChitietHDBanBindingSource;
            this.tblChitietHDBanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblChitietHDBanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblChitietHDBanBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblChitietHDBanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblChitietHDBanBindingNavigatorSaveItem});
            this.tblChitietHDBanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblChitietHDBanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblChitietHDBanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblChitietHDBanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblChitietHDBanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblChitietHDBanBindingNavigator.Name = "tblChitietHDBanBindingNavigator";
            this.tblChitietHDBanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblChitietHDBanBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tblChitietHDBanBindingNavigator.TabIndex = 1;
            this.tblChitietHDBanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tblChitietHDBanBindingNavigatorSaveItem
            // 
            this.tblChitietHDBanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblChitietHDBanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblChitietHDBanBindingNavigatorSaveItem.Image")));
            this.tblChitietHDBanBindingNavigatorSaveItem.Name = "tblChitietHDBanBindingNavigatorSaveItem";
            this.tblChitietHDBanBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tblChitietHDBanBindingNavigatorSaveItem.Text = "Save Data";
            this.tblChitietHDBanBindingNavigatorSaveItem.Click += new System.EventHandler(this.TblChitietHDBanBindingNavigatorSaveItem_Click);
            // 
            // dtHang
            // 
            this.dtHang.AutoGenerateColumns = false;
            this.dtHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dtHang.DataSource = this.tblChitietHDBanBindingSource;
            this.dtHang.Location = new System.Drawing.Point(0, 233);
            this.dtHang.Name = "dtHang";
            this.dtHang.RowHeadersWidth = 51;
            this.dtHang.RowTemplate.Height = 24;
            this.dtHang.Size = new System.Drawing.Size(767, 220);
            this.dtHang.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHDBan";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHDBan";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaHang";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn4.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GiamGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "GiamGia";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn6.HeaderText = "ThanhTien";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // maHDBanTextBox
            // 
            this.maHDBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChitietHDBanBindingSource, "MaHDBan", true));
            this.maHDBanTextBox.Location = new System.Drawing.Point(522, 19);
            this.maHDBanTextBox.Name = "maHDBanTextBox";
            this.maHDBanTextBox.Size = new System.Drawing.Size(100, 22);
            this.maHDBanTextBox.TabIndex = 4;
            // 
            // maHangTextBox
            // 
            this.maHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChitietHDBanBindingSource, "MaHang", true));
            this.maHangTextBox.Location = new System.Drawing.Point(522, 47);
            this.maHangTextBox.Name = "maHangTextBox";
            this.maHangTextBox.Size = new System.Drawing.Size(100, 22);
            this.maHangTextBox.TabIndex = 6;
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChitietHDBanBindingSource, "SoLuong", true));
            this.soLuongTextBox.Location = new System.Drawing.Point(522, 75);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(100, 22);
            this.soLuongTextBox.TabIndex = 8;
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChitietHDBanBindingSource, "DonGia", true));
            this.donGiaTextBox.Location = new System.Drawing.Point(522, 103);
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(100, 22);
            this.donGiaTextBox.TabIndex = 10;
            // 
            // giamGiaTextBox
            // 
            this.giamGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChitietHDBanBindingSource, "GiamGia", true));
            this.giamGiaTextBox.Location = new System.Drawing.Point(522, 131);
            this.giamGiaTextBox.Name = "giamGiaTextBox";
            this.giamGiaTextBox.Size = new System.Drawing.Size(100, 22);
            this.giamGiaTextBox.TabIndex = 12;
            // 
            // thanhTienTextBox
            // 
            this.thanhTienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChitietHDBanBindingSource, "ThanhTien", true));
            this.thanhTienTextBox.Location = new System.Drawing.Point(522, 159);
            this.thanhTienTextBox.Name = "thanhTienTextBox";
            this.thanhTienTextBox.Size = new System.Drawing.Size(100, 22);
            this.thanhTienTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(maHDBanLabel);
            this.Controls.Add(this.maHDBanTextBox);
            this.Controls.Add(maHangLabel);
            this.Controls.Add(this.maHangTextBox);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.soLuongTextBox);
            this.Controls.Add(donGiaLabel);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(giamGiaLabel);
            this.Controls.Add(this.giamGiaTextBox);
            this.Controls.Add(thanhTienLabel);
            this.Controls.Add(this.thanhTienTextBox);
            this.Controls.Add(this.dtHang);
            this.Controls.Add(this.tblChitietHDBanBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChitietHDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChitietHDBanBindingNavigator)).EndInit();
            this.tblChitietHDBanBindingNavigator.ResumeLayout(false);
            this.tblChitietHDBanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.BindingSource tblChitietHDBanBindingSource;
        private QuanlybanhangDataSetTableAdapters.tblChitietHDBanTableAdapter tblChitietHDBanTableAdapter;
        private QuanlybanhangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblChitietHDBanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblChitietHDBanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dtHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox maHDBanTextBox;
        private System.Windows.Forms.TextBox maHangTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
        private System.Windows.Forms.TextBox giamGiaTextBox;
        private System.Windows.Forms.TextBox thanhTienTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

