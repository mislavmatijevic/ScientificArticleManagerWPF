using System.Collections.ObjectModel;
using System.Text;

namespace ScientificArticleManagerWPF.Models
{
    internal class ScientificArticleAuthorsList : Collection<ScientificArticleAuthor>
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new();

            foreach (var author in this)
            {
                stringBuilder
                    .Append(author.LastName)
                    .Append(' ')
                    .Append(author.FirstName[0])
                    .Append(", ");
            }
            stringBuilder.Remove(stringBuilder.Length - 2, 2);

            return stringBuilder.ToString();
        }
    }
}
