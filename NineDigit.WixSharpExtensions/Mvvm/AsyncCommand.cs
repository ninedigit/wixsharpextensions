using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NineDigit.WixSharpExtensions.Mvvm
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }

    public interface IAsyncCommand<T> : ICommand
    {
        Task ExecuteAsync(T parameter);
        bool CanExecute(T parameter);
    }

    public sealed class AsyncCommand : IAsyncCommand
    {
        public event EventHandler? CanExecuteChanged;

        bool isExecuting;
        readonly Func<Task> execute;
        readonly Func<bool>? canExecute;
        readonly IErrorHandler? errorHandler;

        public AsyncCommand(
            Func<Task> execute,
            Func<bool>? canExecute = null,
            IErrorHandler? errorHandler = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
            this.errorHandler = errorHandler;
        }

        public bool IsExecuting
        {
            get => this.isExecuting;
            private set
            {
                if (this.isExecuting != value)
                {
                    this.isExecuting = value;
                    this.RaiseCanExecuteChanged();
                }
            }
        }

        public bool CanExecute()
            => !this.IsExecuting && (canExecute?.Invoke() ?? true);

        public async Task ExecuteAsync()
        {
            if (!this.CanExecute())
                return;

            try
            {
                this.IsExecuting = true;
                await execute().ConfigureAwait(false);
            }
            finally
            {
                this.IsExecuting = false;
            }
        }

        public void RaiseCanExecuteChanged()
            => DispatcherHelper.InvokeOnUI(() => this.CanExecuteChanged?.Invoke(this, EventArgs.Empty));

        bool ICommand.CanExecute(object parameter)
            => this.CanExecute();

        void ICommand.Execute(object parameter)
            => this.ExecuteAsync().FireAndForgetSafeAsync(this.errorHandler);
    }

    public sealed class AsyncCommand<T> : IAsyncCommand<T>
    {
        public event EventHandler? CanExecuteChanged;

        bool isExecuting;
        readonly Func<T, Task> execute;
        readonly Func<T, bool>? canExecute;
        readonly IErrorHandler? errorHandler;

        public AsyncCommand(Func<T, Task> execute, Func<T, bool>? canExecute = null, IErrorHandler? errorHandler = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
            this.errorHandler = errorHandler;
        }

        public bool IsExecuting
        {
            get => this.isExecuting;
            private set
            {
                if (this.isExecuting != value)
                {
                    this.isExecuting = value;
                    this.RaiseCanExecuteChanged();
                }
            }
        }

        public bool CanExecute(T parameter)
            => !this.IsExecuting && (this.canExecute?.Invoke(parameter) ?? true);

        public async Task ExecuteAsync(T parameter)
        {
            if (!this.CanExecute(parameter))
                return;

            try
            {
                this.IsExecuting = true;
                await execute(parameter).ConfigureAwait(false);
            }
            finally
            {
                this.IsExecuting = false;
            }
        }

        public void RaiseCanExecuteChanged()
            => DispatcherHelper.InvokeOnUI(() => this.CanExecuteChanged?.Invoke(this, EventArgs.Empty));

        bool ICommand.CanExecute(object parameter)
            => CanExecute((T)parameter);

        void ICommand.Execute(object parameter)
            => this.ExecuteAsync((T)parameter).FireAndForgetSafeAsync(errorHandler);
    }
}