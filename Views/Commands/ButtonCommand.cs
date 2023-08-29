﻿using System;
using System.Windows.Input;

namespace ScientificArticleManagerWPF.Views.Commands
{
    public class ButtonCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object?>? _canExecute;

        public ButtonCommand(Action<object> execute, Predicate<object?>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter!);
        }
    }
}