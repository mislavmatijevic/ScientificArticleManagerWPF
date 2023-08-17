using System;
using System.Collections.Generic;

namespace ScientificArticleManagerWPF.Model
{
    internal class ScientificArticle
    {
        public ScientificArticle(string title, List<ScientificArticleAuthor> authors, string articleAbstract, DateTime publicationDate, List<string> keywords, string doi, string citation)
        {
            Title = title;
            Authors = authors;
            Abstract = articleAbstract;
            PublicationDate = publicationDate;
            Keywords = keywords;
            Doi = doi;
            Citation = citation;
        }

        public string Title { get; set; }
        public List<ScientificArticleAuthor> Authors { get; set; }
        public string Abstract { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<string> Keywords { get; set; }
        public string Doi { get; set; }
        public string Citation { get; set; }
    }
}
