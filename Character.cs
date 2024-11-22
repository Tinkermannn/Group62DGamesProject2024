namespace Role_Playing_Game
{
    public class Character
    {
        // Properti untuk level karakter
        public int Level { get; set; } = 1;

        // Properti untuk pengalaman karakter
        public int Experience { get; set; }

        // Properti untuk pengalaman yang dibutuhkan untuk naik level
        public int ExperienceToNextLevel { get; set; } = 10;

        // Properti untuk kesehatan karakter saat ini
        public int Health { get; set; } = 20;

        // Properti untuk kesehatan maksimum karakter
        public int MaxHealth => Level * 20;

        // Properti untuk emas yang dimiliki karakter
        public int Gold { get; set; }

        // Properti untuk damage yang diberikan oleh karakter
        public int Damage { get; set; } = 8;

        // Properti untuk posisi karakter di grid (baris)
        public int I { get; set; }

        // Properti untuk posisi karakter di grid (kolom)
        public int J { get; set; }

        // Properti untuk menghitung tile berdasarkan posisi I
        public int TileI => I < 0 ? (I - 6) / 7 : I / 7;

        // Properti untuk menghitung tile berdasarkan posisi J
        public int TileJ => J < 0 ? (J - 3) / 4 : J / 4;

        // Properti untuk animasi karakter di peta
        private string[]? _mapAnimation;

        // Properti untuk mendapatkan dan mengatur animasi karakter
        public string[]? MapAnimation
        {
            get => _mapAnimation;
            set
            {
                _mapAnimation = value;
                _mapAnimationFrame = 0; // Mulai animasi dari frame pertama
            }
        }

        // Properti untuk frame animasi saat ini
        private int _mapAnimationFrame;

        // Properti untuk mengatur frame animasi yang sedang ditampilkan
        public int MapAnimationFrame
        {
            get => _mapAnimationFrame;
            set
            {
                _mapAnimationFrame = value;
                Moved = false; // Set apakah karakter sudah bergerak atau belum

                // Jika sudah mencapai akhir animasi, kembali ke posisi idle
                if (_mapAnimationFrame >= MapAnimation!.Length)
                {
                    // Cek animasi dan ganti ke animasi idle yang sesuai
                    if (_mapAnimation == Sprites.RunUp) { Moved = true; MapAnimation = Sprites.IdleUp; }
                    if (_mapAnimation == Sprites.RunDown) { Moved = true; MapAnimation = Sprites.IdleDown; }
                    if (_mapAnimation == Sprites.RunLeft) { Moved = true; MapAnimation = Sprites.IdleLeft; }
                    if (_mapAnimation == Sprites.RunRight) { Moved = true; MapAnimation = Sprites.IdleRight; }

                    _mapAnimationFrame = 0; // Reset frame animasi
                }
            }
        }

        // Properti untuk memeriksa apakah karakter sedang idle
        public bool IsIdle
        {
            get =>
                _mapAnimation == Sprites.IdleDown ||
                _mapAnimation == Sprites.IdleUp ||
                _mapAnimation == Sprites.IdleLeft ||
                _mapAnimation == Sprites.IdleRight;
        }

        // Properti untuk menampilkan animasi karakter saat ini
        public string Render =>
            _mapAnimation != null && _mapAnimationFrame < _mapAnimation.Length
                ? _mapAnimation[_mapAnimationFrame]  // Jika animasi ada, tampilkan frame saat ini
                : // Jika tidak ada animasi, tampilkan pose T
                  @" __O__ " + '\n' +
                  @"   |   " + '\n' +
                  @"   |   " + '\n' +
                  @"  | |  ";

        // Properti untuk menunjukkan apakah karakter sudah bergerak
        public bool Moved { get; set; } = false;
    }
}
