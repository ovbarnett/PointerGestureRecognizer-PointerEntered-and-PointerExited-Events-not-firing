namespace MauiApp_PointerGestureRecognizers_Example
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

        async void OnPointerEntered(object sender, PointerEventArgs e)
        {
            // Handle the pointer entered event
            await DisplayAlert("OnPointerEntered Fired", "OnPointerEntered Fired","ok");
        }

        async void OnPointerExited(object sender, PointerEventArgs e)
        {
            // Handle the pointer exited event
            await DisplayAlert("OnPointerExited Fired", "OnPointerExited Fired", "ok");
        }

        async void Image_Tapped(object sender, EventArgs e)
        {
            // Handle the pointer exited event
            await DisplayAlert("Image_Tapped Fired", "Image_Tapped Fired", "ok");
        }
        

    }
}