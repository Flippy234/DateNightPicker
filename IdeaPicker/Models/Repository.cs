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
        Seed();
    }

    private void Seed()
    {
        if (_database.Table<DateNight>().Count() > 0) return;

        SeedDateNight(new DateNight { Name = "Dinner and Movie", Description = "Go to Dinner and see a movie" });
        SeedDateNight(new DateNight{ Name = "Hiking Trip", Description = "Go walking and sight seeing on a trail" });
        SeedDateNight(new DateNight{ Name = "Coffee", Description = "Go to a local coffee shop and drink coffee" });
        SeedDateNight(new DateNight{ Name = "Picnic", Description = "Lay on the beach and start a picnic" });
        SeedDateNight(new DateNight{ Name = "Axe Throwing", Description = "Throwing Axes at targets" });
        SeedDateNight(new DateNight{ Name = "Mario Kart", Description = "Play round(s) of Mario Kart" });
        SeedDateNight(new DateNight{ Name = "Bowling", Description = "Go to your local bar / bowling alley for some fun!" });
    }

    public DateNight GetRandomDate()
    {
        var all = GetDates();
        if (all.Count == 0) return null;
        var rand = new Random();
        return all[rand.Next(all.Count)];
    }
    

    public List<DateNight> GetDates()
    {
        return _database.Table<DateNight>().ToList();
    }

    private void SeedDateNight(DateNight dateNight)
    {
        _database.Insert(dateNight);
    }
}