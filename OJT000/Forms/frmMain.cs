using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  
    Form    :frmMain
    @Author : ACA
*/

namespace OJT000.Forms
{
    public partial class frmMain : Form
    {
        // データベース接続の宣言変数
        SqlConnection con1=Common.OpenConnection();

        public frmMain()
        {
            InitializeComponent();
        }

        // 「frmMain」の読み込み中
        private void frmMain_Load(object sender, EventArgs e)
        {

            lblChkProductError.Text = "";
            lblInsertError.Text = "";
            pCheckProduct.Visible = true;
            pInsertProduct.Visible = false;
            pUpdateProduct.Visible = false;
        }

        // generate serial numbers
        private void generateSerialNumbers()
        {
            int rowCount = dataGridView1.Rows.Count;
            if (rowCount >= 1)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[2].Value = (i + 1).ToString();
                }
            }
        }

        // 「削除」 ボタンの クリックアクション
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedItem = new List<string>();
                DataGridViewRow drow = new DataGridViewRow();

                // チェックされたIDは「selectedItem」リストに保存されます
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    drow = dataGridView1.Rows[i];
                    if (Convert.ToBoolean(drow.Cells[1].Value) == true)         //　チェックされているかどうか
                    {
                        string id = drow.Cells[0].Value.ToString();
                        selectedItem.Add(id);                                   //　チェックされている場合、ID を「selectedItem」リストに追加します  
                    }
                }

                if (selectedItem.Count <= 0)                                    // レコードはチェックされません
                {
                    lblChkProductError.Text = "削除したいプロダクトを選択してください。";
                }
                else                                                            // レコードがチェックされます
                {
                    lblChkProductError.Text = "";
                    DialogResult DialogResult = MessageBox.Show("選択したレコードを削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)                       // ユーザーの確認が「はい」の場合
                    {
                        Common.OpenConnection();
                        foreach (string s in selectedItem)                      // foreach ループを使用して、リストに格納されているレコードを削除します。
                        {
                            Common.cmd = new SqlCommand("update product set is_delete=1 where id='" + s + "'", con1);
                            int result = Common.cmd.ExecuteNonQuery();
                        }
                        Common.closeConnection();

                        this.productTableAdapter.FillNotDeleted(this.acdbDataSet.product);
                        // generate serial numbers
                        generateSerialNumbers();
                    }
                    else                                                        // ユーザーの確認が「いいえ」の場合
                    {
                        // レコードのチェックを外します
                        for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                        {
                            drow = dataGridView1.Rows[i];
                            drow.Cells[1].Value = false;                           //　すべてのレコードのチェックを外す
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        // 「ログアウト」 リンクの クリックアクション
        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        // 「プロダクトを挿入」 リンクの クリックアクション
        private void lblInsertProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 関連するパネルのみを表示
            pCheckProduct.Visible = false;
            pInsertProduct.Visible = true;
            pUpdateProduct.Visible = false;

            lblCheckProduct.BackColor = Color.Lavender;
            lblInsertProduct.BackColor = Color.White;
            lblUpdateProduct.BackColor = Color.Lavender;

            txtProductCode.Text = setNewProductCode();                      // 新しい「プロダクトコード」を設定 
            txtProductName.Text = "";
            dtOrderDate.CustomFormat = " ";

            // ラベルテキストをクリアする
            lblInsertError.Text = "";
        }

        // 「プロダクトを更新する」 リンクの クリックアクション
        private void lblUpdateProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 関連するパネルのみを表示
            pCheckProduct.Visible = false;
            pInsertProduct.Visible = false;
            pUpdateProduct.Visible = true;

            lblCheckProduct.BackColor = Color.Lavender;
            lblInsertProduct.BackColor = Color.Lavender;
            lblUpdateProduct.BackColor = Color.White;

            //　[プロダクトの更新] パネルのデータを読み込む
            firstLoadUpdateProduct();

        }

        // 「プロダクトを確認」 リンクの クリックアクション
        private void lblCheckProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            removeDataGridViewData(dataGridView1);

            // 関連するパネルのみを表示
            pCheckProduct.Visible = true;
            pInsertProduct.Visible = false;
            pUpdateProduct.Visible = false;

            lblCheckProduct.BackColor = Color.White;
            lblInsertProduct.BackColor = Color.Lavender;
            lblUpdateProduct.BackColor = Color.Lavender;

            // generate serial numbers
            generateSerialNumbers();
            lblChkProductError.Text = "";
        }

        // remove DataGridView Data
        private void removeDataGridViewData(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                for(int i = dgv.Rows.Count - 1; i >= 0; i--)
                {
                    var dr = dgv.Rows[i];
                    dgv.Rows.Remove(dr);
                }
            }
            //int i = dgv.Rows.Count-1; i >=0; i--
        }

        // プロダクトコードを設定
        private String setNewProductCode()
        {
            String productCode = "";

            Common.OpenConnection();
            String selectQuery = "SELECT IDENT_CURRENT('product');";  // 最後のインデックスのクエリ
            SqlCommand cmd = new SqlCommand(selectQuery, con1);
            int i = int.Parse(cmd.ExecuteScalar().ToString());
            Common.closeConnection();

            // プレフィックスの設定
            String prefix = "";

            if (i == 1)
            {
                Common.OpenConnection();
                selectQuery = "SELECT count (*) FROM product;";  // 最後のインデックスのクエリ
                cmd = new SqlCommand(selectQuery, con1);
                int recordCount = int.Parse(cmd.ExecuteScalar().ToString());
                Common.closeConnection();

                if (recordCount == 0)
                {
                    productCode = "P0001";
                    return productCode;
                }
                else
                {
                    productCode = "P0002";
                    return productCode;
                }
                
            }
            else
            {
                i++;

                if (i < 10)
                {
                    prefix = "P000";
                }
                else if (i < 100)
                {
                    prefix = "P00";
                }
                else if (i < 1000)
                {
                    prefix = "P0";
                }
                else
                    prefix = "P";


                productCode = prefix + i;

                return productCode;
            }
        }

        //「挿入」 ボタンの クリックアクション
        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                String productName = txtProductName.Text;
                String orderDate = dtOrderDate.Text;

                // 入力データの検証
                if (productName == "")
                {
                    lblInsertError.Text = "プロダクト名は必須なので記入してください。";
                }
                else if (dtOrderDate.CustomFormat==" ")
                {
                    lblInsertError.Text = "注文日は必須なので記入してください。";
                }
                else 
                {
                    Common.OpenConnection();                                                     // 「インサートプロダクト」のクエリ
                    string insertQuery = "INSERT INTO product(product_name,order_date) VALUES(N'" + productName + "','" + orderDate + "')";

                    Common.cmd = new SqlCommand(insertQuery, con1);
                    Common.cmd.ExecuteNonQuery();
                    MessageBox.Show("挿入に成功。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Common.closeConnection();

                    // 次の挿入のために初期データをリセットする
                    txtProductCode.Text = setNewProductCode();
                    txtProductName.Text = "";
                    dtOrderDate.CustomFormat = " ";
                    lblInsertError.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }


        //「更新」 ボタンの クリックアクション
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbProductCode.SelectedIndex == 0)                               // プロダクトコードが選択されていません
            {
                lblUpdateError.Text = "更新するプロダクトを一つ選択してください。";
            }
            else                                                                // プロダクトコードを選択
            {
                lblUpdateError.Text = "";
                string selectedProductCode = cbProductCode.SelectedItem.ToString();
                string productNameUpd = txtProductNameUpd.Text;
                string orderDateUpd = dtOrderDateUpd.Text;

                if (productNameUpd == "")                                       // プロダクト名が空です
                {
                    lblUpdateError.Text = "プロダクト名は必須なので記入してください。";
                }
                else                                                            //プロダクト名が入ります
                {
                    try
                    {
                        lblUpdateError.Text = "";
                        Common.OpenConnection();                                                    // 更新のクエリ
                        string updateQuery = "update product set product_name=N'" + productNameUpd + "',order_date='" + orderDateUpd + "' where product_id='" + selectedProductCode + "';";

                        Common.cmd = new SqlCommand(updateQuery, con1);
                        Common.cmd.ExecuteNonQuery();
                        MessageBox.Show("更新に成功。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Common.closeConnection();

                        // 初期状態を再度設定する
                        firstLoadUpdateProduct();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

        }

        // [プロダクトを更新する] パネル の初期ロード
        private void firstLoadUpdateProduct()
        {

            // TODO: This line of code loads data into the 'acdbDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.FillNotDeleted(this.acdbDataSet.product);

            fillProductCode();

            cbProductCode.SelectedItem = "選択してください";
            txtProductNameUpd.Text = "";
            txtProductNameUpd.Enabled = false;
            dtOrderDateUpd.CustomFormat = " ";
            dtOrderDateUpd.Enabled = false;

            lblUpdateError.Text = "";
        }

        // コンボボックス「cbProductCode」にデータを埋める
        private void fillProductCode()
        {
            // コンボボックスの項目をクリアする
            cbProductCode.Items.Clear();

            // 「コンボボックス」にデータを埋める
            cbProductCode.Items.Add("選択してください");
            foreach (DataRow obj in acdbDataSet.Tables[0].Rows)
            {
                cbProductCode.Items.Add(obj[1]);
            }
        }

        //「selected index changed」 の クリックアクション
        private void cbProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUpdateError.Text = "";

            if (cbProductCode.SelectedIndex == 0)
            {
                txtProductNameUpd.Text = "";
                txtProductNameUpd.Enabled = false;
                dtOrderDateUpd.CustomFormat = " ";
                dtOrderDateUpd.Enabled = false;
            }
            else
            {
                // 有効化を「プロダクト名」と「注文日」に設定
                txtProductNameUpd.Enabled = true;
                dtOrderDateUpd.Enabled = true;
                dtOrderDateUpd.CustomFormat = "yyyy-MM-dd";

                foreach (DataRow dr in acdbDataSet.Tables[0].Rows)
                {
                    if (cbProductCode.SelectedItem.ToString().Equals(dr[1].ToString()))
                    {
                        txtProductNameUpd.Text = dr[2].ToString();
                        dtOrderDateUpd.Text = dr[3].ToString();
                        break;
                    }
                }
            }

        }

        private void fillNotDeletedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillNotDeleted(this.acdbDataSet.product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'acdbDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.FillNotDeleted(this.acdbDataSet.product);

            // generate serial numbers
            generateSerialNumbers();

            lblChkProductError.Text = "";
            lblInsertError.Text = "";
        }

        private void dtOrderDateUpd_ValueChanged(object sender, EventArgs e)
        {
            dtOrderDateUpd.CustomFormat = "yyyy-MM-dd";
        }


        private void dtOrderDate_ValueChanged(object sender, EventArgs e)
        {
            dtOrderDate.CustomFormat = "yyyy-MM-dd";
        }

        private void dtOrderDate_DropDown(object sender, EventArgs e)
        {
            //dtOrderDate.CustomFormat = "yyyy-MM-dd";
            dtOrderDate.Value = DateTime.Today;
        }
    }
}
