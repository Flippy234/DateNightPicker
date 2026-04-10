using SQLite;

namespace IdeaPicker.Models;

public class Repository
{
    private readonly SQLiteConnection _database;

    public Repository()
    {
        var dbPath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "datenight.db");

        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<DateNight>();
    }
    

    public List<DateNight> GetDates()
    {
        return _database.Query<DateNight>("Select * from Date");
    }

    public void SeedDateNight(DateNight dateNight)
    {
        
    }
}