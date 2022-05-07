﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GameStore2.Models
{
    class Game
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public List<User> Users { get; set; }
        public Game()
        {
            Id = 0;
            Name = "";
            Price = 0;
            Image = new byte[0];
            Users = new List<User>();
        }

        public Game(int id, string name, decimal price, string imagePath)
        {
            Id = id;
            Name = name;
            Price = price;
            var image = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            Image = DataTransform.JpgToByte(image);
            Users = new List<User>();
        }
    }
}