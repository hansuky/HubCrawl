using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Threading;
using HubCrawl.Controls;
using HubCrawl.Services;
using Yuhan.Common.Models;
using HubCrawl.ViewModels;
using HubCrawl.WPF.Controls;

namespace HubCrawl.ViewModels.Sample
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        private Random rand = new Random(DateTime.Now.Millisecond);
        private List<DummyTileData> dummyData = new List<DummyTileData>();
        private IMessageBoxService messageBoxService;



        public MainWindowViewModel(IMessageBoxService messageBoxService)
        {
            this.messageBoxService = messageBoxService;

            //create some dummy data
            dummyData.Add(new DummyTileData("Add", @"/Resources/Images/Samples/Add.png"));
            dummyData.Add(new DummyTileData("Adobe", @"/Resources/Images/Samples/Adobe.png"));
            dummyData.Add(new DummyTileData("Android", @"/Resources/Images/Samples/Android.png"));
            dummyData.Add(new DummyTileData("Author", @"/Resources/Images/Samples/Author.png"));
            dummyData.Add(new DummyTileData("Blogger", @"/Resources/Images/Samples/Blogger.png"));
            dummyData.Add(new DummyTileData("Copy", @"/Resources/Images/Samples/Copy.png"));
            dummyData.Add(new DummyTileData("Delete", @"/Resources/Images/Samples/Delete.png"));
            dummyData.Add(new DummyTileData("Digg", @"/Resources/Images/Samples/Digg.png"));
            dummyData.Add(new DummyTileData("Edit", @"/Resources/Images/Samples/Edit.png"));
            dummyData.Add(new DummyTileData("Facebook", @"/Resources/Images/Samples/Facebook.png"));
            dummyData.Add(new DummyTileData("GMail", @"/Resources/Images/Samples/GMail.png"));
            dummyData.Add(new DummyTileData("RSS", @"/Resources/Images/Samples/RSS.png"));
            dummyData.Add(new DummyTileData("Save", @"/Resources/Images/Samples/Save.png"));
            dummyData.Add(new DummyTileData("Search", @"/Resources/Images/Samples/Search.png"));
            dummyData.Add(new DummyTileData("Trash", @"/Resources/Images/Samples/Trash.png"));
            dummyData.Add(new DummyTileData("Twitter", @"/Resources/Images/Samples/Twitter.png"));
            dummyData.Add(new DummyTileData("VisualStudio", @"/Resources/Images/Samples/VisualStudio.png"));
            dummyData.Add(new DummyTileData("Wordpress", @"/Resources/Images/Samples/Wordpress.png"));
            dummyData.Add(new DummyTileData("Yahoo", @"/Resources/Images/Samples/Yahoo.png"));
            dummyData.Add(new DummyTileData("YouTube", @"/Resources/Images/Samples/YouTube.png"));

            //Great some dummy groups
            List<PanoramaGroup> data = new List<PanoramaGroup>();
            List<IPanoramaTile> tiles = new List<IPanoramaTile>();

            for (int i = 0; i < 4; i++)
            {
                tiles.Add(CreateTile(true));
				tiles.Add(CreateTile(true));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(true));

				tiles.Add(CreateTile(true));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));

				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));

				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
            }

			data.Add(new PanoramaGroup("Settings", CollectionViewSource.GetDefaultView(tiles)));

			tiles = new List<IPanoramaTile>();

			for (int i = 0; i < 4; i++)
			{
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(true));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(true));

				tiles.Add(CreateTile(true));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(true));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));

				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));

				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
				tiles.Add(CreateTile(false));
			}

			data.Add(new PanoramaGroup("Settings 2", CollectionViewSource.GetDefaultView(tiles)));

            PanoramaItems = data;

        }


        private PanoramaTileViewModel CreateTile(bool isDoubleWidth)
        {
            DummyTileData dummyTileData = dummyData[rand.Next(dummyData.Count)];
            return new PanoramaTileViewModel(messageBoxService, 
                dummyTileData.Text, dummyTileData.ImageUrl, isDoubleWidth);
        }


        private IEnumerable<PanoramaGroup> panoramaItems;

        public IEnumerable<PanoramaGroup> PanoramaItems
        {
            get { return this.panoramaItems; }

            set
            {
                if (value != this.panoramaItems)
                {
                    this.panoramaItems = value;
                    RaisePropertyChanged("CompanyName");
                }
            }
        }
    }




    public class DummyTileData
    {
        public string Text { get; private set; }
        public string ImageUrl { get; private set; }

        public DummyTileData(string text, string imageUrl)
        {
            this.Text = text;
            this.ImageUrl = imageUrl;
        }
    }
}
