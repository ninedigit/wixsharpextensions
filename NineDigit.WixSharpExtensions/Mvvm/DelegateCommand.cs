using System;
using System.Windows.Input;

namespace NineDigit.WixSharpExtensions.Mvvm
{
    public sealed class DelegateCommand : ICommand
    {
        readonly Action executeMethod;
        readonly Func<bool> canExecuteMethod;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action executeMethod)
            : this(executeMethod, () => true)
        { }

        public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            this.executeMethod = executeMethod ?? throw new ArgumentNullException(nameof(executeMethod));
            this.canExecuteMethod = canExecuteMethod ?? throw new ArgumentNullException(nameof(canExecuteMethod));
        }

        public void Execute() => this.executeMethod.Invoke();
        public bool CanExecute() => this.canExecuteMethod.Invoke();
        public void RaiseCanExecuteChanged()
            => DispatcherHelper.InvokeOnUI(() => this.CanExecuteChanged?.Invoke(this, EventArgs.Empty));

        bool ICommand.CanExecute(object parameter) => CanExecute();
        void ICommand.Execute(object parameter) => Execute();
    }

    public sealed class DelegateCommand<T> : ICommand
    {
        readonly Action<T> executeMethod;
        readonly Func<T, bool> canExecuteMethod;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            this.executeMethod = executeMethod ?? throw new ArgumentNullException(nameof(executeMethod));
            this.canExecuteMethod = canExecuteMethod ?? throw new ArgumentNullException(nameof(canExecuteMethod));
        }

        public void Execute(object parameter)
            => this.executeMethod.Invoke((T)parameter);

        public bool CanExecute(object parameter)
            => this.canExecuteMethod.Invoke((T)parameter);
        public void RaiseCanExecudeChanged()
            => DispatcherHelper.InvokeOnUI(() => this.CanExecuteChanged?.Invoke(this, EventArgs.Empty));
    }
}