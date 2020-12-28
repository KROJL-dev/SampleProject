﻿using PropertyChanged;
using System.Collections.Generic;

namespace SampleProject.Backend.Model
{
    /// <summary>
    /// You dont need to fill all field.Only if you have same on api\info ypu get from site
    /// </summary>
    [AddINotifyPropertyChangedInterface]//attribute what dedicated to fix all the problems with INotifyPropertyChanged interface(you dont need to call RaisePropertyChanged() on every property)
    public class Playlist : ModelBase
    {
        public Playlist(string songName, string artistName, string duration, string imageURL)
        {
            SongName = songName;
            ArtistName = artistName;
            Duration = duration;
            ImageUrl = imageURL;
        }
        public string SongName{ get;set; }
        public string Id { get; set; }
        public List<Track> AllTracks { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string Album { get; set; }
    }
}
