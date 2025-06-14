using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Film> Films { get; set; }
        public ObservableCollection<Film> FavFilms { get; set; }
        public ICommand AddFilmCommand { get; }
        public ICommand DeleteFilmCommand { get; }
        public ICommand AddToFavFilmCommand { get; }
        public ICommand DeleteFromFavFilmCommand { get; }

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация коллекции задач
            Films = new ObservableCollection<Film>();
            FavFilms = new ObservableCollection<Film>();

            // Инициализация команд
            AddFilmCommand = new RelayCommand(_ => AddFilm());
            DeleteFilmCommand = new RelayCommand(DeleteFilm);
            AddToFavFilmCommand = new RelayCommand(AddToFavCommand);
            DeleteFromFavFilmCommand = new RelayCommand(DeleteFavCommand);

            // Установка контекста данных
            DataContext = this;
        }

        private void AddFilm()
        {
            if (!string.IsNullOrWhiteSpace(FilmInput.Text))
            {
                // Создаем новый фильм
                var film = new Film
                {
                    Name = FilmInput.Text,
                    DeleteCommand = DeleteFilmCommand, // Привязываем команду удаления
                    AddToFavCommand = AddToFavFilmCommand,
                    DeleteFromFavCommand = DeleteFromFavFilmCommand

                };
                Films.Add(film);

                // Очищаем поле ввода
                FilmInput.Clear();
            }
        }

        private void DeleteFilm(object parameter)
        {
            if (parameter is Film film)
            {
                Films.Remove(film);
                FavFilms.Remove(film);
            }
        }

        private void AddToFavCommand(object parameter)
        {
            if (parameter is Film film)
            {
                var lol = FavFilms.Where(f => f.Name == film.Name);
                if (lol.Count() == 0)
                {
                    FavFilms.Add(film);
                }
            }
        }

        private void DeleteFavCommand(object parameter)
        {

            if (parameter is Film film)
            {
                FavFilms.Remove(film);
            }
        }
    }

    public class Film
    {
        public string Name { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddToFavCommand { get; set; }
        public ICommand DeleteFromFavCommand { get; set; }
    }
}
