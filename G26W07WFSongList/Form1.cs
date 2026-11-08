using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace G26W07WFSongList {

    public partial class Form1 : Form {
        private AppDbContext _db = new AppDbContext();

        public Form1() {
            InitializeComponent();

            _db.Database.EnsureCreated();

            if (!_db.Movies.Any()) {
                List<Movie> initialMovies = [
                    new("인셉션", "크리스토퍼 놀란", 5),
                    new("파묘", "장재현", 5),
                    new("아바타: 물의 길", "제임스 카메론", 4),
                    new("기생충", "봉준호", 5),
                    new("오펜하이머", "크리스토퍼 놀란", 5),
                    new("범죄도시4", "허명행", 3),
                    new("인터스텔라", "크리스토퍼 놀란", 5),
                    new("포레스트 검프", "로버트 저메키스", 5),
                    new("센과 치히로의 행방불명", "미야자키 하야오", 5),
                    new("다크 나이트", "크리스토퍼 놀란", 5),
                    new("라라랜드", "데이미언 셔젤", 4),
                    new("스파이더맨: 어크로스 더 유니버스", "조아킴 도스 산토스", 5),
                    new("엘리멘탈", "피터 손", 4),
                    new("어벤져스: 엔드게임", "루소 형제", 5),
                    new("헤어질 결심", "박찬욱", 5),
                    new("탑건: 매버릭", "조셉 코신스키", 5),
                    new("듄: 파트 2", "드니 빌뇌브", 5),
                    new("코코", "리 언크리치", 4),
                    new("글래디에이터", "리들리 스콧", 4),
                    new("월-E", "앤드루 스탠턴", 5)
                ];

                _db.Movies.AddRange(initialMovies);
                _db.SaveChanges();
            }

            LoadMovies();
        }

        private void LoadMovies() {
            listMovie.Items.Clear();

            string keyword = txtFilter.Text.Trim().ToLower();

            var movies = _db.Movies
                .Where(m => m.Title.ToLower().Contains(keyword) ||
                            m.Director.ToLower().Contains(keyword))
                .OrderByDescending(m => m.Rating)
                .ToList();

            foreach (var movie in movies)
                listMovie.Items.Add(movie);
        }

        private void OnAdd(object sender, EventArgs e) {
            string title = txtTitle.Text.Trim();
            string director = txtDirector.Text.Trim();

            if (title.Length == 0 || director.Length == 0) {
                MessageBox.Show("제목과 감독을 모두 입력하세요.");
                return;
            }

            if (!int.TryParse(txtRating.Text, out int rating) || rating < 1 || rating > 5) {
                MessageBox.Show("평점은 1~5 사이의 숫자로 입력하세요.");
                txtRating.SelectAll();
                txtRating.Focus();
                return;
            }

            var movie = new Movie(title, director, rating);

            _db.Movies.Add(movie);
            _db.SaveChanges();

            LoadMovies();

            txtTitle.Clear();
            txtDirector.Clear();
            txtRating.Clear();
            txtTitle.Focus();
        }

        private void OnDelete(object sender, EventArgs e) {
            if (listMovie.SelectedItem is not Movie movie)
                return;

            var result = MessageBox.Show(
                $"{movie.ToString()}\n\n영화를 삭제할까요?",
                "삭제 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            _db.Movies.Remove(movie);
            _db.SaveChanges();

            LoadMovies();

            txtSelected.Clear();
            btnDelete.Enabled = false;
        }

        private void OnChanged(object sender, EventArgs e) {
            if (listMovie.SelectedItem is not Movie movie) {
                txtSelected.Clear();
                btnDelete.Enabled = false;
                return;
            }

            txtSelected.Text = movie.ToString();
            btnDelete.Enabled = true;
        }

        private void OnYouTube(object sender, EventArgs e) {
            if (listMovie.SelectedItem is not Movie movie)
                return;

            string query = Uri.EscapeDataString($"영화 {movie.Title} 예고편");

            Process.Start(new ProcessStartInfo(
                $"https://www.youtube.com/results?search_query={query}") {
                UseShellExecute = true
            });
        }

        private void OnFilterChanged(object sender, EventArgs e) {
            LoadMovies();
        }
    }

    public record Movie(string Title, string Director, int Rating) {
        public int Id { get; init; }

        public override string ToString() => $"{Title} [{Director}] (⭐{Rating})";
    }

    public class AppDbContext : DbContext {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=movies.db");
        }
    }
}