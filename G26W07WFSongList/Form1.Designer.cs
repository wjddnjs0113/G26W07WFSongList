namespace G26W07WFSongList {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            listSong = new ListBox();
            txtTitle = new TextBox();
            txtRating = new TextBox();
            txtArtist = new TextBox();
            btnAdd = new Button();
            txtSelected = new TextBox();
            btnDelete = new Button();
            txtFilter = new TextBox();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(11, 45);
            listSong.Name = "listSong";
            listSong.Size = new Size(776, 424);
            listSong.TabIndex = 0;
            listSong.SelectedIndexChanged += OnChanged;
            listSong.DoubleClick += OnYouTube;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(11, 475);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(339, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(590, 475);
            txtRating.MaxLength = 1;
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(96, 27);
            txtRating.TabIndex = 3;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(356, 475);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(228, 27);
            txtArtist.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(692, 473);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // txtSelected
            // 
            txtSelected.Enabled = false;
            txtSelected.Location = new Point(11, 508);
            txtSelected.Name = "txtSelected";
            txtSelected.PlaceholderText = "삭제를 위해 선택된 노래";
            txtSelected.ReadOnly = true;
            txtSelected.Size = new Size(675, 27);
            txtSelected.TabIndex = 5;
            txtSelected.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(693, 507);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += OnDelete;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "제목 또는 가수 검색";
            txtFilter.Size = new Size(775, 27);
            txtFilter.TabIndex = 7;
            txtFilter.TextChanged += OnFilterChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 590);
            Controls.Add(txtFilter);
            Controls.Add(btnDelete);
            Controls.Add(txtSelected);
            Controls.Add(btnAdd);
            Controls.Add(txtArtist);
            Controls.Add(txtRating);
            Controls.Add(txtTitle);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private TextBox txtTitle;
        private TextBox txtRating;
        private TextBox txtArtist;
        private Button btnAdd;
        private TextBox txtSelected;
        private Button btnDelete;
        private TextBox txtFilter;
    }
}
