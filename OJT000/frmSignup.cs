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
    Form    :frmSignup
    @Author : ACA
*/

namespace OJT000
{
    public partial class frmSignup : Form
    {
        // データベース接続の宣言変数 
        SqlConnection con;

        public frmSignup()
        {
            InitializeComponent();   
            lblLoginError1.Text = "";                                       // エラーメッセージのテキストをクリアする
        }

        // 「サインアップ」 ボタンの クリックアクション
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                // 宣言 & 初期化
                String userName = txtUserName.Text;
                String passWord = txtPassword.Text;
                String conPass = txtConPass.Text;
                lblLoginError1.Text = "";

                if (userName == "" && passWord == "" && conPass == "")          // すべて入力が空白です
                {
                    lblLoginError1.Text = "ユーザ名 とパスワードは必須なので記入してください。";
                }
                else
                {
                    if (userName == "")                                         // ユーザー名が空です
                    {
                        lblLoginError1.Text = "ユーザ名 は必須なので記入してください。";
                    }
                    else
                    {                                                         // 入力ユーザー名が正しい
                                                                              // ユーザ情報があるかどうかチェックする
                        con=Common.OpenConnection();
                        String loginQuery = "select count(*) from admin where admin_name='" + userName + "'";
                        Common.cmd = new SqlCommand(loginQuery, con);
                        int rowCount = int.Parse(Common.cmd.ExecuteScalar().ToString());
                        Common.closeConnection();

                        if (rowCount >= 1)                                      // ユーザ名が存在している
                        {
                            lblLoginError1.Text = "ユーザ名が存在していますので別の名を直してください。";
                        }
                        else                                                   // ユーザー名が利用可能
                        {
                            if (passWord == "" || conPass == "")                // パスワード が入力するかどうかチェックする
                            {
                                lblLoginError1.Text = "パスワードは必須なので記入してください。";
                            }
                            else                                                // 入力パスワードが正しい
                            {
                                if (passWord != conPass)                        // 入力パスワードが合致していない                      
                                {
                                    lblLoginError1.Text = "入力パスワードが合致していません。";
                                }
                                else                                             // 入力パスワードが合致している
                                {
                                    if (passWord.Length < 6)                      // パスワードの配列の長さをチェックする
                                    {
                                        lblLoginError1.Text = "パスワードを最大6文字まで記入してください。";
                                    }
                                    else                                        // パスワードの配列の長が正しい
                                    {
                                        // データがデータベースに挿入されます
                                        Common.OpenConnection();
                                        string insertQuery = "INSERT INTO [dbo].[admin]([admin_name],[password]) VALUES(N'" + userName + "','" + passWord + "')";

                                        Common.cmd = new SqlCommand(insertQuery, con);
                                        Common.cmd.ExecuteNonQuery();

                                        // パスワードを暗号化する
                                        String selectQuery = "SELECT admin_id from admin where admin_name=N'" + userName + "'";  // 最後のインデックスのクエリ
                                        Common.cmd = new SqlCommand(selectQuery, con);
                                        String admin_id = Common.cmd.ExecuteScalar().ToString();
                                        admin_id = admin_id.Replace("-", string.Empty);

                                        Common com = new Common();
                                        passWord = com.Encrypt(passWord, admin_id).ToString();
                                        string updateQuery = "update admin set password='" + passWord + "' where admin_name=N'" + userName + "';";

                                        Common.cmd = new SqlCommand(updateQuery, con);
                                        Common.cmd.ExecuteNonQuery();

                                        Common.closeConnection();
                                        MessageBox.Show("登録に成功。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Dispose();                         //この画面を閉じる
                                        frmLogin loginForm = new frmLogin();
                                        loginForm.Show();                       // 「ログイン」画面を表示する


                                    }

                                }
                            }
                        }


                    }
                }
            } 
            catch (System.Exception ex)
             {
                MessageBox.Show(ex.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
    
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            lblLoginError1.Text = "";
            //con = Common.OpenConnection();                                  // データベース接続を取得する
        }


        // 「キャンセル」 ボタンの クリックアクション
        private void btnSignUpCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin loginForm = new frmLogin();                            //この画面を閉じる
            loginForm.Show();                                               //「ログイン」画面を表示する
        }
    }
}
