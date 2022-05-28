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
    public partial class FriendsControl : UserControl
    {
        public FriendsControl()
        {
            InitializeComponent();
            FillGrid();
        }

        void FillGrid()
        {
            using (DBContext db = new DBContext())
            {
                //Creating Rows
                List<RowDefinition> rows = new List<RowDefinition>();
                int rowsCount = db.User.Count() - 1;

                for (int i = 0; i < rowsCount; i++)
                {
                    rows.Add(new RowDefinition());
                    rows[i * 2].Height = new GridLength(10, GridUnitType.Star);
                    rows.Add(new RowDefinition());
                    rows[i * 2 + 1].Height = new GridLength(130);
                }
                rows.Add(new RowDefinition());
                rows[rows.Count - 1].Height = new GridLength(10, GridUnitType.Star);
                for (int i = 0; i < rows.Count; i++)
                {
                    MainGrid.RowDefinitions.Add(rows[i]);
                }

                //Add Users in Window
                int rowNum = 1;
                foreach (User user in db.User)
                {
                    if(user.Login != CurrentUser.Login)
                    {
                        Image img = new Image();
                        BitmapImage avatar = DataTransform.ByteToJpg(user.Avatar);
                        img.Source = avatar;
                        img.SetValue(Grid.ColumnProperty, 1);
                        img.SetValue(Grid.RowProperty, rowNum);

                        Label login = new Label();
                        login.HorizontalAlignment = HorizontalAlignment.Center;
                        login.Content = user.Login;
                        img.SetValue(Grid.ColumnProperty, 3);
                        img.SetValue(Grid.RowProperty, rowNum);

                        Button button = new Button();
                        button.HorizontalAlignment = HorizontalAlignment.Center;
                        button.Content = "Добавить в друзья";
                        img.SetValue(Grid.ColumnProperty, 5);
                        img.SetValue(Grid.RowProperty, rowNum);

                        MainGrid.Children.Add(img);
                        MainGrid.Children.Add(login);
                        MainGrid.Children.Add(button);

                        rowNum += 2;
                    }
                }
            }
        }
    }
}
