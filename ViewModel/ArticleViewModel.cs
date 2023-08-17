using ScientificArticleManagerWPF.Model;
using System.Collections.ObjectModel;

namespace ScientificArticleManagerWPF.ViewModel
{
    internal class ArticleViewModel
    {
        public ObservableCollection<ScientificArticle> Articles { get; set; }

        public ArticleViewModel()
        {
            var articles = MockScientificArticleRepository.Instance.GetArticles();
            Articles = new ObservableCollection<ScientificArticle>(articles);
        }
    }
}
