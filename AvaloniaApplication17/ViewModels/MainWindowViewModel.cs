using System;
using System.Collections.ObjectModel;
using AvaloniaApplication17.Models;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaApplication17.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Photo> Photos { get; set; } = [];
    [Reactive] public Photo? SelectedPhoto { get; set; }

    public MainWindowViewModel()
    {
        Photos.Add(new Photo
        {
            Uri = new Uri("avares://AvaloniaApplication17/Assets/123.jpg"),
            Description = "This is a photo"
        });
        
        Photos.Add(new Photo
        {
            Uri = new Uri("avares://AvaloniaApplication17/Assets/123.jpg"),
            Description = "This is a photo"
        });
    }
}