using ScientificArticleManagerWPF.Model;

namespace ScientificArticleManagerWPF.ViewModel
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
