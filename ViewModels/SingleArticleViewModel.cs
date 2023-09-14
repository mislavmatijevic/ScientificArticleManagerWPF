using ScientificArticleManagerWPF.Models;

namespace ScientificArticleManagerWPF.ViewModels
{
    class SingleArticleViewModel : ViewModel
    {
        public ScientificArticle Article { get; set; }

        public SingleArticleViewModel(ScientificArticle article)
        {
            Article = article;
        }
    }
}
