using System;
using System.Linq;
using System.Windows;
using GameStore2.ModelContext;
using GameStore2.Models;

namespace GameStore2
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowsBuilder.ShowMainWindow();
            InitDB();
            base.OnStartup(e);
        }

        void InitDB()
        {
            try
            {
                using(DBContext db = new())
                {
                    db.Database.Initialize(false);
                    // Код для удаления базы данных
                    /*foreach (var u in db.User)
                    {
                        db.User.Remove(u);
                    }
                    foreach (var g in db.Game)
                    {
                        db.Game.Remove(g);
                    }*/
                    db.SaveChanges();
                    if (db.User.Count() == 0 && db.Game.Count() == 0)
                    {
                        string imagePath = @"Images/Games/";
                        Game CSGO = new Game(1, "Counter Strike: Global Offensive", 1200, imagePath + "CSGO.jpg");
                        db.Game.Add(CSGO);
                        Game Cyberpunk = new Game(2, "Cyberpunk 2077", 1500, imagePath + "Cyberpunk.jpg");
                        db.Game.Add(Cyberpunk);
                        Game Dishonored = new Game(3, "Dishonored", 400, imagePath + "Dishonored.jpg");
                        db.Game.Add(Dishonored);
                        Game Spire = new Game(3, "Slay the Spire", 450, imagePath + "Slay the Spire.jpeg");
                        db.Game.Add(Dishonored);
                        Game DOOMEternal = new Game(3, "DOOM Eternal", 1800, imagePath + "DOOM Eternal.jpg");
                        db.Game.Add(Dishonored);
                        Game DeadCells = new Game(3, "Dead Cells", 500, imagePath + "Dead Cells.jpeg");
                        db.Game.Add(Dishonored);

                        User qwerty123 = new User(1, "qwerty123", "qwerty123@mail.ru", "qwerty123", 1000);
                        db.User.Add(qwerty123);
                        User Anarch_1st = new User(1, "Anarch_1st", "shurik.li.2006@mail.ru", "Bsp3K91F", 100);
                        db.User.Add(Anarch_1st);

                        //Added games in users
                        qwerty123.Games.Add(CSGO);
                        qwerty123.Games.Add(Cyberpunk);
                        qwerty123.Games.Add(Dishonored);
                        qwerty123.Games.Add(DOOMEternal);
                        qwerty123.Games.Add(DeadCells);
                        qwerty123.Games.Add(Spire);

                        Anarch_1st.Games.Add(CSGO);
                        Anarch_1st.Games.Add(DeadCells);
                        Anarch_1st.Games.Add(Dishonored);
                        Anarch_1st.Games.Add(Spire);


                        db.SaveChanges();
                        MessageBox.Show("Инициализации БД прошла успешно!");
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Ошибка инициализации БД: {e.Message}");
            }
        }
    }
}
