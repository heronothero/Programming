using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название песни не может быть пустым.");
                }
                title = value;
            }
        }
        private string artist;
        public string Artist
        {
            get { return artist; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Поле исполнителя не может быть пустым");
                }
                artist = value;
            }
        }
        private int durationSeconds;
        public int DurationSeconds
        {
            get { return durationSeconds; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Продолжительность песни должна быть больше 0");
                }
                durationSeconds = value;
            }
        }
        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public Song()
        {
            Title = "";
            Artist = "";
            DurationSeconds = 0;
            Genre = "";
        }
        public Song(string title, string artist, int durationSeconds, string genre)
        {
            Title = title;
            Artist = artist;
            DurationSeconds = durationSeconds;
            Genre = genre;
        }
    }
}
