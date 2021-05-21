using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UToDo.Views
{
    public class ToDoListView : UserControl
    {
        public ToDoListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}