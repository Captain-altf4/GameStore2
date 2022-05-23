using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using GameStore2.ModelContext;
using GameStore2.Models;

namespace GameStore2.Views
{
    public partial class LibraryControl : UserControl
    {
        public LibraryControl()
        {
            InitializeComponent();
            FillGrid();
        }

        void FillGrid()
        {
            using (DBContext db = new DBContext())
            {
                //Creating Columns
                List<ColumnDefinition> columns = new List<ColumnDefinition>();
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

                //Creating Rows
                List<RowDefinition> rows = new List<RowDefinition>();
                int rowsCount = db.Game.Count() / columnsCount + 1;

                for (int i = 0; i < rowsCount; i++)
                {
                    rows.Add(new RowDefinition());
                    rows[i * 2].Height = new GridLength(30, GridUnitType.Star);
                    rows.Add(new RowDefinition());
                    rows[i * 2 + 1].Height = new GridLength(130);
                }
                columns.Add(new ColumnDefinition());
                columns[columns.Count - 1].Width = new GridLength(30, GridUnitType.Star);

                //Add Rows & Columns
                for (int i = 0; i < columns.Count; i++)
                {
                    MainGrid.ColumnDefinitions.Add(columns[i]);
                }
                for (int i = 0; i < rows.Count; i++)
                {
                    MainGrid.RowDefinitions.Add(rows[i]);
                }

                //Add Games in Window
                int columnNum = 1;
                int rowNum = 1;
                User currentUser = db.User.Where(u => u.Login == CurrentUser.Login).FirstOrDefault();
                foreach (Game game in currentUser.Games)
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

                    Image image = new Image();
                    BitmapImage logo = DataTransform.ByteToJpg(game.Image);
                    image.Source = logo;

                    sp.Children.Add(image);
                    sp.Children.Add(name);
                    sp.Children.Add(price);
                    MainGrid.Children.Add(sp);

                    if (columnNum + 2 >= columnsCount * 2)
                    {
                        columnNum = 1;
                        rowNum += 2;
                    }
                    else
                        columnNum += 2;
                }
            }
        }
    }
}
