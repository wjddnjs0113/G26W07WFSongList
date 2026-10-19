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
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(12, 12);
            listSong.Name = "listSong";
            listSong.Size = new Size(776, 424);
            listSong.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 442);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(339, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(591, 442);
            txtRating.MaxLength = 1;
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(96, 27);
            txtRating.TabIndex = 2;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(357, 442);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(228, 27);
            txtArtist.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(693, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 514);
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
    }
}
