
using System;
using System.Collections.Generic;

namespace ScientificArticleManagerWPF.Models
{
    internal class MockScientificArticleRepository
    {
        public static MockScientificArticleRepository Instance { get; } = new MockScientificArticleRepository();

        private MockScientificArticleRepository() { }

        private readonly List<ScientificArticle> _articles = new()
        {
            new ScientificArticle(
                "Exploring Quantum Computing",
                new ScientificArticleAuthorsList
                {
                    new ScientificArticleAuthor("Alice", "Johnson", "Institute of Physics", "PhD")
                },
                "This article delves into the principles of quantum computing...",
                new DateTime(2023, 1, 15),
                new List<string> { "quantum computing", "physics" },
                "doi-12345",
                "Johnson, A. (2023). Exploring Quantum Computing. Institute of Physics."
            ),
            new ScientificArticle(
                "Advancements in Artificial Intelligence",
                new ScientificArticleAuthorsList
                {
                    new ScientificArticleAuthor("Robert", "Smith", "AI Research Institute", "PhD")
                },
                "This paper discusses recent breakthroughs in AI and machine learning...",
                new DateTime(2023, 2, 20),
                new List<string> { "artificial intelligence", "machine learning" },
                "doi-67890",
                "Smith, R. (2023). Advancements in Artificial Intelligence. AI Research Institute."
            ),
            new ScientificArticle(
                "Climate Change and Global Impacts",
                new ScientificArticleAuthorsList
                {
                    new ScientificArticleAuthor("Emily", "Davis", "Environmental Institute", "PhD"),
                    new ScientificArticleAuthor("James", "Brown", "Climate Research Center", "MSc")
                },
                "This study analyzes the effects of climate change on various ecosystems...",
                new DateTime(2023, 3, 10),
                new List<string> { "climate change", "environment", "ecosystems" },
                "doi-54321",
                "Davis, E., & Brown, J. (2023). Climate Change and Global Impacts. Environmental Institute, Climate Research Center."
            ),
        };

        public List<ScientificArticle> GetArticles() => _articles;
    }
}
