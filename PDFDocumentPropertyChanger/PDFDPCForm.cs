using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;

namespace PDFDocumentPropertyChanger
{
    public partial class PDFDocumentPropertyChangerMain : Form
    {
        // ファイル一覧取得用
        private const string EXT_PDF = "*.pdf";
        // メッセージダイアログ用
        private const string MSG_ERRTEXT1 = "PDF格納フォルダを入力してください", MSG_ERRTITLE1 = "入力不備",
                             MSG_ERRTEXT2 = "指定フォルダ内にPDFファイルが存在していません", MSG_ERRTITLE2 = "該当ファイルなし",
                             MSG_ERRTEXT3 = "PDFファイルの一覧を取得してから実行してください", MSG_ERRTITLE3 = "ファイル一覧未取得",
                             MSG_ERRTEXT4 = "設定するパスワードを入力してください", MSG_ERRTITLE4 = "項目未入力",
                             MSG_ERRTEXT5 = "パスワード・セキュリティ設定にチェックが無い状態で\r\n設定するパスワードが入力されています", MSG_ERRTITLE5 = "項目不備",
                             MSG_ERR_EXP = "例外が発生しました\n", MSG_ERR_EXP_T = "例外発生";

        // ステータスラベル用
        private const string ST_MSG1 = "PDF格納フォルダを入力してください", ST_MSG2 = "PDF格納フォルダが選択されました",
                             ST_MSG3 = "ファイル一覧を取得しました", ST_MSG4 = "プロパティの変更が完了しました";

        // 格納ファイルのパス取得用
        string[] files = null;
        // 各項目のテキスト取得用
        string PW, title, author, subject, keywords;

        // Init
        public PDFDocumentPropertyChangerMain()
        {
            InitializeComponent();
        }

        // すべてのテキストボックスのテキストを消去
        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            textBox_PDFStorePath.Clear();
            textBox_PW.Clear();
            textBox_Title.Clear();
            textBox_Author.Clear();
            textBox_Subject.Clear();
            textBox_Keywords.Clear();
            textBox_AllFiles.Clear();
            textBox_Log.Clear();
        }

        // ログ・ファイル一覧を消去
        private void button_ClearLog_Click(object sender, EventArgs e)
        {
            textBox_AllFiles.Clear();
            textBox_Log.Clear();
        }

        // 文書プロパティを変更（プロパティを変更ボタン押下）
        private void button_Change_Click(object sender, EventArgs e)
        {
            // 入力不備の場合は処理せず返す

            // 格納パスが入力されていない場合
            if (textBox_PDFStorePath.Text == string.Empty)
            {
                // エラーメッセージを表示
                MessageBox.Show(this, MSG_ERRTEXT1, MSG_ERRTITLE1, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label_Status.Text = ST_MSG1;
                return;
            }
            // ファイルパスがnullまたは該当ファイルが存在しない場合
            if (files == null || files.Length == 0)
            {
                MessageBox.Show(this, MSG_ERRTEXT3, MSG_ERRTITLE3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            PW = textBox_PW.Text;

            // セキュリティ設定チェックあり、設定パスワード未入力の場合
            if (checkBox_isPWSet.Checked == true && PW.Equals(string.Empty))
            {
                MessageBox.Show(this, MSG_ERRTEXT4, MSG_ERRTITLE4, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // セキュリティ設定チェックなし、設定パスワードに入力がある場合
            else if (checkBox_isPWSet.Checked == false && !PW.Equals(string.Empty))
            {
                MessageBox.Show(this, MSG_ERRTEXT5, MSG_ERRTITLE5, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 各項目を取得
            title = textBox_Title.Text; // タイトル
            author = textBox_Author.Text; // 作成者
            subject = textBox_Subject.Text; // サブタイトル
            keywords = textBox_Keywords.Text; // キーワード

            // プロパティ変更
            for (int i = 0; i < files.Length; i++)
            {
                DecriptPdfDoc(files[i], PW, title, author, subject, keywords);
            }

            label_Status.Text = ST_MSG4;
            
        }

        // 設定パスワードの文字列表示
        private void button_PWView_Click(object sender, EventArgs e)
        {
            textBox_PW.UseSystemPasswordChar = false;
        }

        // フォルダ参照ダイアログ（参照ボタン押下）
        private void button_PDFStorePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // 上部に表示する説明テキストを指定する
            fbd.Description = "PDF格納フォルダを選択";
            // ルートフォルダを指定する（デフォルトでDesktop）
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            
            // ダイアログオープン時の選択フォルダを指定（デフォルトでマイドキュメント）
            fbd.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            // ユーザーが新しいフォルダを作成できるようにする
            fbd.ShowNewFolderButton = true;

            // ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                // 選択されたフォルダをTextBoxへ入力
                textBox_PDFStorePath.Text = fbd.SelectedPath;
                label_Status.Text = ST_MSG2;
            }
        }

        // PDFファイルの一覧を取得（PDF一覧を取得を押下）
        private void button_getPDFFocs_Click(object sender, EventArgs e)
        {
            // エラー・例外は処理を返す

            // PDF格納フォルダが入力されていない場合はreturn
            if (textBox_PDFStorePath.Text == string.Empty)
            {
                // エラーメッセージを表示
                MessageBox.Show(this, MSG_ERRTEXT1, MSG_ERRTITLE1, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label_Status.Text = ST_MSG1;
                return;
            }
            else
            {
                try
                {
                    // 配列にファイル一覧を取得
                    files = Directory.GetFiles(textBox_PDFStorePath.Text, EXT_PDF, SearchOption.TopDirectoryOnly);

                    // 該当ファイルがない場合
                    if (files.Length == 0)
                    {
                        MessageBox.Show(this, MSG_ERRTEXT2, MSG_ERRTITLE2, MessageBoxButtons.OK, MessageBoxIcon.Question);
                        label_Status.Text = ST_MSG1;
                        return;
                    }

                    // ファイル名書き出し
                    for (int i = 0; i < files.Length; i++)
                    {
                        textBox_AllFiles.Text += (Path.GetFileName(files[i]) + "\r\n");
                    }

                    label_Status.Text = ST_MSG3;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, MSG_ERR_EXP + "\r\n" + ex.Message, MSG_ERR_EXP_T, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }

        // PDFファイルオープン・パスワード,プロパティ変更、PDFファイル置換
        void DecriptPdfDoc(string PdfSrcPath, string PW, string title, string author, string subject, string keywords)
        {
            PdfReader reader;
            int PageNum; // ページ数取得用
            int i = 0; // カウント用
            bool setB = false; // プロパティ変更用

            string PdfDstPath = Path.GetTempPath() + Path.GetFileName(PdfSrcPath);

            try
            {
                reader = new PdfReader(PdfSrcPath);

                Document doc = new Document();

                // 一時ファイルのフォルダを取得し、置換用PDFファイルを作成
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(PdfDstPath, FileMode.Create));

                textBox_Log.Text += "start:" + Path.GetFileName(PdfSrcPath) + "/page(s)" + reader.NumberOfPages + "\r\n";


                // パスワードを設定する場合
                if (checkBox_isPWSet.Checked == true && !PW.Equals(string.Empty))
                {
                    writer.Open();

                    // セキュリティ設定
                    writer.SetEncryption(
                        PdfWriter.STRENGTH40BITS, //暗号化強度(40bitでAcrobat3.0)
                        "", // ユーザー(閲覧)パスワード
                        PW, // オーナー(編集)パスワード
                            // セキュリティ設定
                        PdfWriter.AllowCopy | // 内容のコピーと抽出
                        PdfWriter.AllowPrinting | // 印刷
                        PdfWriter.AllowModifyContents | // 文書の変更
                                                        /* PdfWriter.AllowModifyAnnotations |  注釈 */
                        PdfWriter.AllowFillIn | // フォームフィールドの入力と署名
                        PdfWriter.AllowScreenReaders | // アクセシビリティを有効にする
                        PdfWriter.AllowAssembly // 文章アセンブリ
                    );
                }
                else if (checkBox_isPWSet.Checked == false && !PW.Equals(string.Empty))
                {
                    MessageBox.Show(this, MSG_ERRTEXT5, MSG_ERRTITLE5, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                

                doc.Open();

                PdfContentByte content = writer.DirectContent;
                PageNum = reader.NumberOfPages;

                // 全ページの内容を一時ファイルに設定
                while (i < PageNum)
                {
                    doc.NewPage();
                    PdfImportedPage iPage = writer.GetImportedPage(reader, ++i);
                    content.AddTemplate(iPage, 0, 0);
                }

                // プロパティ項目

                // タイトル
                if (!reader.Info.ContainsKey("Title"))
                {
                    textBox_Log.Text += "Title:No key→" + title + "\r\n";
                    setB = doc.AddTitle(title);

                }
                else if (title.Equals(string.Empty))
                {
                    textBox_Log.Text += "Title:" + reader.Info["Title"] + "→変更なし" + "\r\n";
                    setB = doc.AddTitle(reader.Info["Title"]);
                }
                else if (!title.Equals(string.Empty))
                {
                    textBox_Log.Text += "Title:" + reader.Info["Title"] + "→" + title + "\r\n";
                    setB = doc.AddTitle(title);
                }


                // 作成者
                if (!reader.Info.ContainsKey("Author"))
                {
                    textBox_Log.Text += "Author:No key→" + author + "\r\n";
                    setB = doc.AddAuthor(author);
                }
                else if (author.Equals(string.Empty))
                {
                    textBox_Log.Text += "Author:" + reader.Info["Author"] + "→変更なし" + "\r\n";
                    setB = doc.AddAuthor(reader.Info["Author"]);
                }
                else if (!author.Equals(string.Empty))
                {
                    textBox_Log.Text += "Author:" + reader.Info["Author"] + "→" + author + "\r\n";
                    setB = doc.AddAuthor(author);
                }

                // サブタイトル
                if (!reader.Info.ContainsKey("Subject"))
                {
                    textBox_Log.Text += "Subject:No key→" + subject + "\r\n";
                    setB = doc.AddSubject(subject);
                }
                else if (subject.Equals(string.Empty))
                {
                    textBox_Log.Text += "Subject:" + reader.Info["Subject"] + "→変更なし" + "\r\n";
                    setB = doc.AddSubject(reader.Info["Subject"]);
                }
                else if (!subject.Equals(string.Empty))
                {
                    textBox_Log.Text += "Subject:" + reader.Info["Subject"] + "→" + subject + "\r\n";
                    setB = doc.AddSubject(subject);
                }


                // キーワード
                if (!reader.Info.ContainsKey("Keywords"))
                {
                    textBox_Log.Text += "Keywords:No key→" + keywords + "\r\n";
                    setB = doc.AddKeywords(keywords);
                }
                else if (keywords.Equals(string.Empty))
                {
                    textBox_Log.Text += "Keywords:" + reader.Info["Keywords"] + "→変更なし" + "\r\n";
                    setB = doc.AddKeywords(reader.Info["Keywords"]);
                }
                else if (!keywords.Equals(string.Empty))
                {
                    textBox_Log.Text += "Keywords:" + reader.Info["Keywords"] + "→" + keywords + "\r\n";
                    setB = doc.AddKeywords(keywords);
                }


                doc.Close();
                reader.Close();
                writer.Close();

                // PDFファイル入れ替え
                File.Delete(PdfSrcPath); // 元のファイルを削除
                File.Move(PdfDstPath, PdfSrcPath); // 一時ファイルを移動

                textBox_Log.Text += Path.GetFileNameWithoutExtension(PdfSrcPath) + ":Prop set done.\r\n\r\n";

            }
            catch (Exception e)
            {
                textBox_Log.Text += MSG_ERR_EXP + "\r\n" + e.Message + "\r\n\r\n";
            }
        }
    }
}
