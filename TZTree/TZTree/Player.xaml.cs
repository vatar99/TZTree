using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TZTree
{
    public partial class Player : ContentPage
    {
        LibVLC _libvlc;
        public Player()
        {
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();

            var media = new Media(_libvlc, "https://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();

        }
    }
}