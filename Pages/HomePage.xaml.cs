using Maui.TikTok.Models;
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
            new Video { Title = "Hello World", Uri = "https://appspace.sfo3.cdn.digitaloceanspaces.com/workout1.mp4" },
            new Video { Title = "Hello World", Uri = "https://appspace.sfo3.cdn.digitaloceanspaces.com/workout1.mp4" },
            new Video { Title = "Hello World", Uri = "https://appspace.sfo3.cdn.digitaloceanspaces.com/workout1.mp4" },
        };

        CvVideos.ItemsSource = Videos;
    }

    private void ItemsView_OnScrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        // Handle scrolling logic if necessary
    }
}