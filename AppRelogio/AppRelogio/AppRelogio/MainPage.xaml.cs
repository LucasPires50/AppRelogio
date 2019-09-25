using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace AppRelogio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Timer relogio;
        public MainPage()
        {
            InitializeComponent();
            relogio = new Timer();
            relogio.Interval = 1000;
            relogio.Elapsed += Relogio_Elapsed;
            relogio.Start();     
        }
        
        private void Relogio_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                AtualizaHoraAtual();
            });
            
        }

        public void AtualizaHoraAtual()
        {
              lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BntAzul_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Blue;
            lblHoras.TextColor = Color.White;
        }
        private void BntAmarelo_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Yellow;
            lblHoras.TextColor = Color.Orange;
        }
        private void BntPreto_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Black;
            lblHoras.TextColor = Color.Red;
        }
        private void BntVerde_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Green;
            lblHoras.TextColor = Color.Fuchsia;
        }
    }
}
