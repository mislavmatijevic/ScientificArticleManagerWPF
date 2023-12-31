﻿using ScientificArticleManagerWPF.Models;
using ScientificArticleManagerWPF.ViewModels;
using System.Windows;

namespace ScientificArticleManagerWPF.Views
{
    /// <summary>
    /// Interaction logic for EditArticleWindow.xaml
    /// </summary>
    public partial class EditArticleWindow : Window
    {
        internal EditArticleWindow(ScientificArticle selectedArticleForEditting)
        {
            var viewModel = new SingleArticleViewModel(selectedArticleForEditting);
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
