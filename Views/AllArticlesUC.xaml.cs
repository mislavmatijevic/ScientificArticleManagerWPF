using ScientificArticleManagerWPF.Models;
using ScientificArticleManagerWPF.Views.Commands;
using System.Windows.Controls;
using System.Windows.Input;

namespace ScientificArticleManagerWPF.Views
{
    /// <summary>
    /// Interaction logic for ArticlesView.xaml
    /// </summary>
    public partial class ArticlesView : UserControl
    {
        public ArticlesView()
        {
            InitializeComponent();
            OpenEditViewCommand = new ButtonCommand(OnArticleSelectedForEditing, ArticleExists);
        }

        public ICommand OpenEditViewCommand { get; init; }

        private bool ArticleExists(object? parameter)
        {
            return parameter != null && parameter is ScientificArticle;
        }

        public void OnArticleSelectedForEditing(object parameter)
        {
            if (parameter is ScientificArticle selectedArticleForEditting)
            {
                var editArticleWindow = new EditArticleWindow(selectedArticleForEditting);
                editArticleWindow.Show();
            }
        }
    }
}
