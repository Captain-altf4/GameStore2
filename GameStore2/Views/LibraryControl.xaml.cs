using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameStore2.ModelContext;
using GameStore2.Models;

namespace GameStore2.Views
{
    public partial class LibraryControl : UserControl
    {
        public LibraryControl()
        {
            InitializeComponent();
        }

        void FillGrid()
        {
            using (DBContext db = new DBContext())
            {
                List<ColumnDefinition> columns = new List<ColumnDefinition>();
                int gamesCount = db.Game.Count();
                int rowsCount = (gamesCount + 1) / 2;
                int columnsCount = (int)this.Width / 220;
                for (int i = 0; i < columnsCount; i++)
                {
                    columns.Add(new ColumnDefinition());
                    columns[i * 2].Width = new GridLength(40, GridUnitType.Star);
                    columns.Add(new ColumnDefinition());
                    columns[i * 2 + 1].Width = new GridLength(220);
                }
                columns.Add(new ColumnDefinition());
                columns[columns.Count - 1].Width = new GridLength(40, GridUnitType.Star);

                for (int i = 0; i < columns.Count; i++)
                {
                    MainGrid.ColumnDefinitions.Add(columns[i]);
                }

                int columnNum = 1;
                int rowNum = 1;
                int index = 0;
                foreach (Game game in db.Game)
                {
                    StackPanel sp = new StackPanel();
                    sp.SetValue(Grid.RowProperty, rowNum);
                    sp.SetValue(Grid.ColumnProperty, columnNum);

                    Label price = new Label();
                    price.HorizontalAlignment = HorizontalAlignment.Center;
                    price.Content = game.Price;

                    Label name = new Label();
                    name.HorizontalAlignment = HorizontalAlignment.Center;
                    name.Content = game.Name;

                    Image currentImage = new Image();
                    BitmapImage logo = DataTransform.ByteToJpg(game.Image);
                    currentImage.Source = logo;
                    columnNum = (columnNum == 1) ? 3 : 1; // Условие, ?, что возвращается если да, что возвращается если нет

                    sp.Children.Add(currentImage);
                    sp.Children.Add(name);
                    sp.Children.Add(price);
                    MainGrid.Children.Add(sp);

                    if ((index + 1) % 2 == 0)
                        rowNum += 2;
                    index++;
                }
            }
        }
    }
}
