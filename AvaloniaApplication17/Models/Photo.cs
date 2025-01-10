using System;
using Avalonia.Media.Imaging;
using AvaloniaApplication17.ViewModels;

namespace AvaloniaApplication17.Models;

public class Photo
{
    public Uri Uri { get; set; }
    public string Description { get; set; }
    
    public Bitmap Image => ImageHelper.LoadFromResource(Uri);
}