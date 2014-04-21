﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Threading;
using System.Timers;
using Yuhan.Common.Models;
using HubCrawl.Services;


namespace HubCrawl.ViewModels
{
    public class PanoramaTileViewModel : NotifyPropertyChangedBase, HubCrawl.Controls.IPanoramaTile
    {
        private IMessageBoxService messageBoxService;
        private Timer liveUpdateTileTimer = new Timer();

        public PanoramaTileViewModel(IMessageBoxService messageBoxService, string text, string imageUrl, bool isDoubleWidth)
        {
            if (isDoubleWidth)
            {
                liveUpdateTileTimer.Interval = 1000;
                liveUpdateTileTimer.Elapsed += new ElapsedEventHandler(LiveUpdateTileTimer_Elapsed);
                liveUpdateTileTimer.Start();
            }


            this.messageBoxService = messageBoxService;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.IsDoubleWidth = isDoubleWidth;
            this.TileClickedCommand = new HubCrawl.Controls.SimpleCommand<object, object>(ExecuteTileClickedCommand);
        }

        void LiveUpdateTileTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Counter < 10)
                Counter++;
            else
                Counter = 0;
            RaisePropertyChanged("Counter");
        }

        


        public int Counter { get; set; }
        public string Text { get; private set; }
        public string ImageUrl { get; private set; }
        public bool IsDoubleWidth { get; private set; }
        public ICommand TileClickedCommand { get; private set; }
 
        public void ExecuteTileClickedCommand(object parameter)
        {
            messageBoxService.ShowMessage(string.Format("you clicked {0}", this.Text));
        }

		// JH Start - See IPanoramaTile for details
		public bool IsPressed
		{
			get { return _isPressed; }
			set
			{
				if (_isPressed != value)
				{
					_isPressed = value;
					this.RaisePropertyChanged("IsPressed");
				}
			}
		}
		private bool _isPressed;
		// JH End - See IPanoramaTile for details
	}
}