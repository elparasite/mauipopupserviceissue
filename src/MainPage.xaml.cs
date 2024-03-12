using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using PopupServiceIssue.ViewModels;

namespace PopupServiceIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void popupButton_Clicked(object sender, EventArgs e)
        {
            var myVm = new MyPopupViewModel
            {
                Message = "My message"
            };
            _ = await new PopupService().ShowPopupAsync(myVm);
        }
    }

}
