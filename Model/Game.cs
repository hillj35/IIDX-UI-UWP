using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;

namespace iidx_ui_uwp.Model
{
    class Game
    {
        #region Properties
        private string gameName;
        private string gameSubName;
        private BitmapImage imageSrc;

        public string GameName
        {
            get
            {
                return gameName;
            }
            
            set
            {
                gameName = value;
            }
        }

        public string GameSubName
        {
            get
            {
                return gameSubName;
            }

            set
            {
                gameSubName = value;
            }
        }

        public BitmapImage ImageSrc
        {
            get
            {
                return imageSrc;
            }

            set
            {
                imageSrc = value;
            }
        }
        #endregion

        public Game(string name, string subName, BitmapImage image)
        {
            gameName = name;
            gameSubName = subName;
            imageSrc = image;
        }

        public static ObservableCollection<Game> GetGames()
        {
            ObservableCollection<Game> games = new ObservableCollection<Game>();
            StreamReader file = new StreamReader(@"./Config/GameList.txt");
            string line;

            while((line = file.ReadLine()) != null)
            {
                string[] splitLine = line.Split(',');
                games.Add(new Game(splitLine[0], splitLine[1], new BitmapImage(new Uri("ms-appx:///" + splitLine[2]))));
            }

            return games;
        }
    }
}
