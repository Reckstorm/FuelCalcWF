using System.Diagnostics;

namespace FuelCalcWF
{
    public partial class Form1 : Form
    {
        private double _distance = 0;
        private double _value = 0;
        private double _Price = 0;
        private double _FuelVolume = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void RenderWindow(object sender, EventArgs e)
        {
            Label price = new Label();
            Label distance = new Label();
            Label value = new Label();
        }

        private void FuelVolume()
        {
            _FuelVolume =  _distance * (_value / 100);
        }

        private double PriceTrip()
        {
            return _FuelVolume * _Price;
        }
    }
}