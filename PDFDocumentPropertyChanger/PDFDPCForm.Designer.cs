namespace PDFDocumentPropertyChanger
{
    partial class PDFDocumentPropertyChangerMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_PDFStorePath = new System.Windows.Forms.GroupBox();
            this.button_PDFStorePath = new System.Windows.Forms.Button();
            this.textBox_PDFStorePath = new System.Windows.Forms.TextBox();
            this.button_getPDFFocs = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_PW = new System.Windows.Forms.GroupBox();
            this.checkBox_isPWSet = new System.Windows.Forms.CheckBox();
            this.button_PWView = new System.Windows.Forms.Button();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.groupBox_DocProp = new System.Windows.Forms.GroupBox();
            this.textBox_Keywords = new System.Windows.Forms.TextBox();
            this.label_Keywords = new System.Windows.Forms.Label();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.label_Subject = new System.Windows.Forms.Label();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label_Author = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Change = new System.Windows.Forms.Button();
            this.textBox_AllFiles = new System.Windows.Forms.TextBox();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.groupBox_prop = new System.Windows.Forms.GroupBox();
            this.groupBox_Log = new System.Windows.Forms.GroupBox();
            this.groupBox_Reset = new System.Windows.Forms.GroupBox();
            this.button_ClearLog = new System.Windows.Forms.Button();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.groupBox_PDFStorePath.SuspendLayout();
            this.groupBox_PW.SuspendLayout();
            this.groupBox_DocProp.SuspendLayout();
            this.groupBox_prop.SuspendLayout();
            this.groupBox_Log.SuspendLayout();
            this.groupBox_Reset.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_PDFStorePath
            // 
            this.groupBox_PDFStorePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_PDFStorePath.Controls.Add(this.button_PDFStorePath);
            this.groupBox_PDFStorePath.Controls.Add(this.textBox_PDFStorePath);
            this.groupBox_PDFStorePath.Controls.Add(this.button_getPDFFocs);
            this.groupBox_PDFStorePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_PDFStorePath.Location = new System.Drawing.Point(0, 0);
            this.groupBox_PDFStorePath.Name = "groupBox_PDFStorePath";
            this.groupBox_PDFStorePath.Size = new System.Drawing.Size(819, 86);
            this.groupBox_PDFStorePath.TabIndex = 0;
            this.groupBox_PDFStorePath.TabStop = false;
            this.groupBox_PDFStorePath.Text = "PDF格納フォルダ";
            // 
            // button_PDFStorePath
            // 
            this.button_PDFStorePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_PDFStorePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PDFStorePath.Location = new System.Drawing.Point(684, 23);
            this.button_PDFStorePath.Name = "button_PDFStorePath";
            this.button_PDFStorePath.Size = new System.Drawing.Size(132, 28);
            this.button_PDFStorePath.TabIndex = 1;
            this.button_PDFStorePath.Text = "参照(&O)";
            this.button_PDFStorePath.UseVisualStyleBackColor = true;
            this.button_PDFStorePath.Click += new System.EventHandler(this.button_PDFStorePath_Click);
            // 
            // textBox_PDFStorePath
            // 
            this.textBox_PDFStorePath.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_PDFStorePath.Location = new System.Drawing.Point(3, 23);
            this.textBox_PDFStorePath.Name = "textBox_PDFStorePath";
            this.textBox_PDFStorePath.Size = new System.Drawing.Size(677, 27);
            this.textBox_PDFStorePath.TabIndex = 0;
            this.textBox_PDFStorePath.WordWrap = false;
            // 
            // button_getPDFFocs
            // 
            this.button_getPDFFocs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_getPDFFocs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_getPDFFocs.Location = new System.Drawing.Point(3, 51);
            this.button_getPDFFocs.Name = "button_getPDFFocs";
            this.button_getPDFFocs.Size = new System.Drawing.Size(813, 32);
            this.button_getPDFFocs.TabIndex = 2;
            this.button_getPDFFocs.Text = "PDF一覧を取得(&G)";
            this.button_getPDFFocs.UseVisualStyleBackColor = true;
            this.button_getPDFFocs.Click += new System.EventHandler(this.button_getPDFFocs_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Status.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Status.Location = new System.Drawing.Point(0, 604);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(211, 18);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "PDF格納フォルダを入力してください";
            // 
            // groupBox_PW
            // 
            this.groupBox_PW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_PW.Controls.Add(this.checkBox_isPWSet);
            this.groupBox_PW.Controls.Add(this.button_PWView);
            this.groupBox_PW.Controls.Add(this.textBox_PW);
            this.groupBox_PW.Controls.Add(this.label_PW);
            this.groupBox_PW.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_PW.Location = new System.Drawing.Point(3, 23);
            this.groupBox_PW.Name = "groupBox_PW";
            this.groupBox_PW.Size = new System.Drawing.Size(372, 171);
            this.groupBox_PW.TabIndex = 3;
            this.groupBox_PW.TabStop = false;
            this.groupBox_PW.Text = "パスワード設定";
            // 
            // checkBox_isPWSet
            // 
            this.checkBox_isPWSet.AutoSize = true;
            this.checkBox_isPWSet.Checked = true;
            this.checkBox_isPWSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_isPWSet.Location = new System.Drawing.Point(3, 23);
            this.checkBox_isPWSet.Name = "checkBox_isPWSet";
            this.checkBox_isPWSet.Size = new System.Drawing.Size(315, 25);
            this.checkBox_isPWSet.TabIndex = 3;
            this.checkBox_isPWSet.Text = "パスワードとセキュリティ項目を設定する(&P)";
            this.checkBox_isPWSet.UseVisualStyleBackColor = true;
            // 
            // button_PWView
            // 
            this.button_PWView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_PWView.Location = new System.Drawing.Point(242, 112);
            this.button_PWView.Name = "button_PWView";
            this.button_PWView.Size = new System.Drawing.Size(118, 30);
            this.button_PWView.TabIndex = 5;
            this.button_PWView.Text = "PWを表示(&V)";
            this.button_PWView.UseVisualStyleBackColor = true;
            this.button_PWView.Click += new System.EventHandler(this.button_PWView_Click);
            // 
            // textBox_PW
            // 
            this.textBox_PW.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textBox_PW.Location = new System.Drawing.Point(25, 79);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(335, 27);
            this.textBox_PW.TabIndex = 4;
            this.textBox_PW.UseSystemPasswordChar = true;
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(21, 56);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(136, 21);
            this.label_PW.TabIndex = 0;
            this.label_PW.Text = "設定するパスワード";
            // 
            // groupBox_DocProp
            // 
            this.groupBox_DocProp.AutoSize = true;
            this.groupBox_DocProp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_DocProp.Controls.Add(this.textBox_Keywords);
            this.groupBox_DocProp.Controls.Add(this.label_Keywords);
            this.groupBox_DocProp.Controls.Add(this.textBox_Subject);
            this.groupBox_DocProp.Controls.Add(this.label_Subject);
            this.groupBox_DocProp.Controls.Add(this.textBox_Author);
            this.groupBox_DocProp.Controls.Add(this.label_Author);
            this.groupBox_DocProp.Controls.Add(this.textBox_Title);
            this.groupBox_DocProp.Controls.Add(this.label_Title);
            this.groupBox_DocProp.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_DocProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_DocProp.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox_DocProp.Location = new System.Drawing.Point(377, 23);
            this.groupBox_DocProp.Name = "groupBox_DocProp";
            this.groupBox_DocProp.Size = new System.Drawing.Size(439, 171);
            this.groupBox_DocProp.TabIndex = 4;
            this.groupBox_DocProp.TabStop = false;
            this.groupBox_DocProp.Text = "文書のプロパティ";
            // 
            // textBox_Keywords
            // 
            this.textBox_Keywords.Location = new System.Drawing.Point(92, 136);
            this.textBox_Keywords.Name = "textBox_Keywords";
            this.textBox_Keywords.Size = new System.Drawing.Size(341, 25);
            this.textBox_Keywords.TabIndex = 9;
            // 
            // label_Keywords
            // 
            this.label_Keywords.AutoSize = true;
            this.label_Keywords.Location = new System.Drawing.Point(18, 139);
            this.label_Keywords.Name = "label_Keywords";
            this.label_Keywords.Size = new System.Drawing.Size(68, 18);
            this.label_Keywords.TabIndex = 6;
            this.label_Keywords.Text = "キーワード";
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Location = new System.Drawing.Point(92, 100);
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(341, 25);
            this.textBox_Subject.TabIndex = 8;
            // 
            // label_Subject
            // 
            this.label_Subject.AutoSize = true;
            this.label_Subject.Location = new System.Drawing.Point(6, 103);
            this.label_Subject.Name = "label_Subject";
            this.label_Subject.Size = new System.Drawing.Size(80, 18);
            this.label_Subject.TabIndex = 4;
            this.label_Subject.Text = "サブタイトル";
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(92, 64);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(341, 25);
            this.textBox_Author.TabIndex = 7;
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(42, 67);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(44, 18);
            this.label_Author.TabIndex = 2;
            this.label_Author.Text = "作成者";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(92, 28);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(341, 25);
            this.textBox_Title.TabIndex = 6;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(30, 31);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(56, 18);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "タイトル";
            // 
            // button_Change
            // 
            this.button_Change.AutoSize = true;
            this.button_Change.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Change.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Change.Location = new System.Drawing.Point(3, 194);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(813, 31);
            this.button_Change.TabIndex = 10;
            this.button_Change.Text = "プロパティを変更(&D)";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // textBox_AllFiles
            // 
            this.textBox_AllFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_AllFiles.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_AllFiles.Location = new System.Drawing.Point(3, 23);
            this.textBox_AllFiles.Multiline = true;
            this.textBox_AllFiles.Name = "textBox_AllFiles";
            this.textBox_AllFiles.ReadOnly = true;
            this.textBox_AllFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_AllFiles.Size = new System.Drawing.Size(251, 213);
            this.textBox_AllFiles.TabIndex = 11;
            // 
            // textBox_Log
            // 
            this.textBox_Log.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_Log.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Log.Location = new System.Drawing.Point(258, 23);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Log.Size = new System.Drawing.Size(558, 213);
            this.textBox_Log.TabIndex = 12;
            // 
            // groupBox_prop
            // 
            this.groupBox_prop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_prop.Controls.Add(this.groupBox_PW);
            this.groupBox_prop.Controls.Add(this.groupBox_DocProp);
            this.groupBox_prop.Controls.Add(this.button_Change);
            this.groupBox_prop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_prop.Location = new System.Drawing.Point(0, 86);
            this.groupBox_prop.Name = "groupBox_prop";
            this.groupBox_prop.Size = new System.Drawing.Size(819, 228);
            this.groupBox_prop.TabIndex = 8;
            this.groupBox_prop.TabStop = false;
            this.groupBox_prop.Text = "プロパティ";
            // 
            // groupBox_Log
            // 
            this.groupBox_Log.Controls.Add(this.textBox_AllFiles);
            this.groupBox_Log.Controls.Add(this.textBox_Log);
            this.groupBox_Log.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Log.Location = new System.Drawing.Point(0, 314);
            this.groupBox_Log.Name = "groupBox_Log";
            this.groupBox_Log.Size = new System.Drawing.Size(819, 239);
            this.groupBox_Log.TabIndex = 9;
            this.groupBox_Log.TabStop = false;
            this.groupBox_Log.Text = "動作";
            // 
            // groupBox_Reset
            // 
            this.groupBox_Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Reset.Controls.Add(this.button_ClearLog);
            this.groupBox_Reset.Controls.Add(this.button_ClearAll);
            this.groupBox_Reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Reset.Location = new System.Drawing.Point(0, 552);
            this.groupBox_Reset.Name = "groupBox_Reset";
            this.groupBox_Reset.Size = new System.Drawing.Size(819, 52);
            this.groupBox_Reset.TabIndex = 10;
            this.groupBox_Reset.TabStop = false;
            this.groupBox_Reset.Text = "Reset";
            // 
            // button_ClearLog
            // 
            this.button_ClearLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ClearLog.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ClearLog.Location = new System.Drawing.Point(410, 23);
            this.button_ClearLog.Name = "button_ClearLog";
            this.button_ClearLog.Size = new System.Drawing.Size(406, 26);
            this.button_ClearLog.TabIndex = 14;
            this.button_ClearLog.Text = "Clear Log";
            this.button_ClearLog.UseVisualStyleBackColor = true;
            this.button_ClearLog.Click += new System.EventHandler(this.button_ClearLog_Click);
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ClearAll.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ClearAll.Location = new System.Drawing.Point(3, 23);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(400, 26);
            this.button_ClearAll.TabIndex = 13;
            this.button_ClearAll.Text = "Clear ALL";
            this.button_ClearAll.UseVisualStyleBackColor = true;
            this.button_ClearAll.Click += new System.EventHandler(this.button_ClearAll_Click);
            // 
            // PDFDocumentPropertyChangerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(819, 622);
            this.Controls.Add(this.groupBox_Reset);
            this.Controls.Add(this.groupBox_Log);
            this.Controls.Add(this.groupBox_prop);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.groupBox_PDFStorePath);
            this.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(835, 615);
            this.Name = "PDFDocumentPropertyChangerMain";
            this.Text = "PDF DocsProp Changer";
            this.groupBox_PDFStorePath.ResumeLayout(false);
            this.groupBox_PDFStorePath.PerformLayout();
            this.groupBox_PW.ResumeLayout(false);
            this.groupBox_PW.PerformLayout();
            this.groupBox_DocProp.ResumeLayout(false);
            this.groupBox_DocProp.PerformLayout();
            this.groupBox_prop.ResumeLayout(false);
            this.groupBox_prop.PerformLayout();
            this.groupBox_Log.ResumeLayout(false);
            this.groupBox_Log.PerformLayout();
            this.groupBox_Reset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PDFStorePath;
        private System.Windows.Forms.TextBox textBox_PDFStorePath;
        private System.Windows.Forms.Button button_PDFStorePath;
        private System.Windows.Forms.Button button_getPDFFocs;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.GroupBox groupBox_PW;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.GroupBox groupBox_DocProp;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_PWView;
        private System.Windows.Forms.TextBox textBox_Keywords;
        private System.Windows.Forms.Label label_Keywords;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.Label label_Subject;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.TextBox textBox_AllFiles;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.CheckBox checkBox_isPWSet;
        private System.Windows.Forms.GroupBox groupBox_prop;
        private System.Windows.Forms.GroupBox groupBox_Log;
        private System.Windows.Forms.GroupBox groupBox_Reset;
        private System.Windows.Forms.Button button_ClearLog;
        private System.Windows.Forms.Button button_ClearAll;
    }
}

