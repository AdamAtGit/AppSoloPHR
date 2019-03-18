using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHRApp.Classes
{
    public class Title
    {
        [SQLite.PrimaryKey]
        public string TitleName { get; set; }
        public string Category { get; set; }
        public string TtsRaw { get; set; }
        public string FileUri { get; set; }
        public string Uses { get; set; }

        public List<Title> GetTitles()
        {
            List<Title> titles = new List<Title>();

            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                var query = db.Table<Title>().OrderBy(t => t.TitleName);

                foreach (var title in query)
                {
                    titles.Add(title);
                }
            }

            return titles;
        }

        public void UpdateTitle(Title title)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    db.Update(title);
                }
                catch (Exception) { }
            }
        }

        public void DeleteTitle(Title title)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    db.Delete(title);
                }
                catch (Exception) { }
            }
        }

        public void InsertTitle(Title title)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    var existingTitle = (db.Table<Title>()
                        .Where(t => t.TitleName == title.TitleName))
                        .SingleOrDefault();

                    if (existingTitle != null)
                    {
                        existingTitle.Category = title.Category;
                        existingTitle.TtsRaw = title.Category;
                        existingTitle.FileUri = title.TtsRaw;
                        existingTitle.Uses = title.Uses;

                        this.UpdateTitle(existingTitle);
                    }
                    else
                    {
                        db.Insert(title);
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
