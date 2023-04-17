using CommunityToolkit.Maui.Core.Platform;

namespace MauiToolkitKeyboardExtensionsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            if (KeyboardExtensions.IsSoftKeyboardShowing(myEntry))
            {
                await KeyboardExtensions.HideKeyboardAsync(myEntry, default);
            }
            else
            {
                await KeyboardExtensions.ShowKeyboardAsync(myEntry, default);
            }
        }
    }
}