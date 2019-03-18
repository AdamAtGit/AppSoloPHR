using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHRApp.Classes
{
    public class PlayList
    {
        [SQLite.PrimaryKey]
        public string PlName { get; set; }
        public string Theme { get; set; }
        public DateTime PlayDateTime { get; set; }
        public bool IsPrivate { get; set; }
        public string Description { get; set; }
        public string TitleName { get; set; }

        public List<PlayList> GetPlayLists(Title title)//Gist - how making the 1 to Many
        {
            List<PlayList> playLists = new List<PlayList>();

            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                var query = db.Table<PlayList>()
                    .Where(pl => pl.TitleName == title.TitleName)//Gist - how making the 1 to Many
                    .OrderBy(pl => pl.PlName);

                foreach (var playList in query)
                {
                    playLists.Add(playList);
                }
            }
            return playLists;
        }

        public void UpdatePlayList(PlayList playList)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    db.Update(playList);
                }
                catch (Exception) { }
            }
        }

        public void DeletePlayList(PlayList playList)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    db.Delete(playList);
                }
                catch (Exception) { }
            }
        }

        public void InsertPlayList(PlayList playList)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    var existingPlayList = (db.Table<PlayList>()
                        .Where(pl => pl.PlName == playList.PlName))
                        .SingleOrDefault();

                    if (existingPlayList != null)
                    {
                        existingPlayList.PlName = playList.PlName;
                        existingPlayList.Theme = playList.Theme;
                        existingPlayList.PlayDateTime = playList.PlayDateTime;
                        existingPlayList.IsPrivate = playList.IsPrivate;
                        existingPlayList.Description = playList.Description;

                        this.UpdatePlayList(playList);
                    }
                    else
                    {
                        db.Insert(playList);
                    }
                }
                catch (Exception) { }
            }
        }


    }
}
