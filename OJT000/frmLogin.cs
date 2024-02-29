using OJT000.Forms;
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
    Form    :frmLogin
    @Author : ACA
*/

namespace OJT000
{
    public partial class frmLogin : Form
    {
        // データベース接続の宣言変数
        SqlConnection con;

        // 宣言 & 初期化 
        String dbUserName = "";
        String dbPassword = "";
        String dbUserId = "";

        public frmLogin()
        {
            InitializeComponent();
        }



        // 「ログイン」 ボタンの クリックアクション
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 宣言 & 初期化
                String username = txtUserName.Text;
                String password = txtPassword.Text;
                lblLoginError.Text = "";

                if (username == "" && password == "")                               // ユーザー名とパスワードが空です
                {
                    lblLoginError.Text = "ユーザー名 とパスワード を入力してください。";
                }
                else if (username == "" || password == "")                          //ユーザー名かパスワードが空です
                {
                    if (username == "")                                             //ユーザー名が空です
                    {
                        lblLoginError.Text = "ユーザー名 を入力してください。";
                    }
                    else                                                           //パスワードが空です
                    {
                        lblLoginError.Text = "パスワードを入力してください。";
                    }
                }
                else                                                                // 入力の検証が正しい
                {

                    con=Common.OpenConnection();
                    String loginQuery = "select * from admin where admin_name=N'" + username + "'";                      // 「admin」テーブルのデータを取得する　クエリ
                    Common.cmd = new SqlCommand(loginQuery, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Common.cmd);
                    DataTable ds = new DataTable();
                    dataAdapter.Fill(ds);
                    Common.cmd.ExecuteNonQuery();
                    Common.closeConnection();

                    int rowCount = ds.Rows.Count;

                    if (rowCount <= 0)                                              // ユーザー名が正しくありません
                    {
                        lblLoginError.Text = "ユーザ情報が存在していません。";
                    }
                    else                                                            // ユーザー名は正しいです。                                   
                    {
                        dbUserId = ds.Rows[0][0].ToString();
                        dbUserName = ds.Rows[0][1].ToString();
                        dbPassword = ds.Rows[0][2].ToString();

                        dbUserId = dbUserId.Replace("-", string.Empty);

                        //パスワードを解読する
                        Common com = new Common();
                        dbPassword = com.Decrypt(dbPassword, dbUserId).ToString();

                        if (dbUserName == username && dbPassword == password)       // ユーザー名とパスワードを確認する
                        {
                            this.Hide();
                            frmMain mainForm = new frmMain();
                            mainForm.Show();                                        // ユーザ情報があるとき、 メイン画面を表示する
                        }
                        else                                                        // パスワードが正しくありません
                        {
                            lblLoginError.Text = "パスワードが正しくありません。";
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }


        // 「」 ボタンの クリックアクション
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup signUp = new frmSignup();
            signUp.Show();                                                      // 「サインアップ」 画面を表示する
        }


        // 「frmLogin」の読み込み中
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblLoginError.Text = "";                                            // エラーメッセージのテキストをクリアする
            //con = Common.OpenConnection();                                      // データベース接続を取得する
        }
    }
}
