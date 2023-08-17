using ScientificArticleManagerWPF.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ScientificArticleManagerWPF.ViewModel
{
    internal class ArticleViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ScientificArticle> Articles { get; set; }
        private ScientificArticle? _selectedArticle;

        public ScientificArticle? SelectedArticle
        {
            get => _selectedArticle;
            set
            {
                _selectedArticle = value;
                OnPropertyChanged(nameof(SelectedArticle));
            }
        }

        public ArticleViewModel()
        {
            var articles = MockScientificArticleRepository.Instance.GetArticles();
            Articles = new ObservableCollection<ScientificArticle>(articles);

            _selectedArticle = Articles[2];
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
