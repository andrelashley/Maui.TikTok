using Maui.TikTok.Models;
using Microsoft.Maui;
using System.Collections.ObjectModel;

namespace Maui.TikTok.Pages;

public partial class HomePage : ContentPage
{
    private ObservableCollection<Video> Videos;

    public HomePage()
    {
        InitializeComponent();

        BindingContext = this;

        Videos = new ObservableCollection<Video> 
        {
            new Video { Title = "Hello World", Uri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4" },
            new Video { Title = "Hello World", Uri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4" },
            new Video { Title = "Hello World", Uri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4" },
        };

        CvVideos.ItemsSource = Videos;
    }

    private void OnHeartTapped(object sender, EventArgs e)
    {
        var heartIcon = sender as Image;

        if (heartIcon != null)
        {
            var currentSource = heartIcon.Source as FileImageSource;

            if (currentSource != null && currentSource.File == "ic_heart_empty.png")
            {
                heartIcon.Source = "ic_heart_filled.png";
            }
            else
            {
                heartIcon.Source = "ic_heart_empty.png";
            }
        }
    }

    private void ItemsView_OnScrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        // Handle scrolling logic if necessary
    }
}