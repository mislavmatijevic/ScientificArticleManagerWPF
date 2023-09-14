using ScientificArticleManagerWPF.Models;
using System.Collections.ObjectModel;

namespace ScientificArticleManagerWPF.ViewModels
{
    internal class AllArticlesViewModel : ViewModel
    {
        public ObservableCollection<ScientificArticle> Articles { get; set; }

        public AllArticlesViewModel()
        {
            var articles = MockScientificArticleRepository.Instance.GetArticles();
            Articles = new ObservableCollection<ScientificArticle>(articles);
        }
    }
}
