using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using lab6visual.ViewModels;
using System;
using Avalonia.Interactivity;

namespace lab6visual.Views
{
    public partial class TaskListView : UserControl
    {
        public TaskListView()
        {
            InitializeComponent();
            this.FindControl<DatePicker>("DateP").SelectedDateChanged += delegate
            {
                DateTimeOffset? selectedDate = this.FindControl<DatePicker>("DateP").SelectedDate;
                var context = this.DataContext as TaskListViewModel;
                if (context != null)
                    context.CurrentDate = selectedDate;
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
