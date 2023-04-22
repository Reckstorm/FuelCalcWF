using System.Diagnostics;

namespace FuelCalcWF
{
    public partial class Form1 : Form
    {
        private double _distance = 0;
        private double _value = 0;
        private double _price = 0;
        private double _FuelVolume = 0;
        public Form1()
        {
            InitializeComponent();
            Load += RenderWindow;
        }

        private void RenderWindow(object sender, EventArgs e)
        {
            Label price = new Label();
            Label distance = new Label();
            Label value = new Label();
            Label fuelVolume = new Label();
            Label priceTrip = new Label();

            TextBox priceBox = new TextBox();
            TextBox distanceBox = new TextBox();
            TextBox valueBox = new TextBox();

            Button calculate = new Button();

            price.Text = "Price:";
            price.Location = new Point(0, 0);
            price.Width = 100;
            this.Controls.Add(price);

            distance.Text = "Distance:";
            distance.Location = new Point(0, 40);
            distance.Width = 100;
            this.Controls.Add(distance);

            value.Text = "Value:";
            value.Location = new Point(0, 80);
            value.Width = 100;
            this.Controls.Add(value);

            priceBox.Location = new Point(110, 0);
            priceBox.Width = 100;
            this.Controls.Add(priceBox);

            distanceBox.Location = new Point(110, 40);
            distanceBox.Width = 100;
            this.Controls.Add(distanceBox);

            valueBox.Location = new Point(110, 80);
            valueBox.Width = 100;
            this.Controls.Add(valueBox);

            fuelVolume.Location = new Point(10, 150);
            fuelVolume.Width = 100;
            fuelVolume.Text = "Fuel: ";
            this.Controls.Add(fuelVolume);

            priceTrip.Location = new Point(110, 150);
            priceTrip.Width = 100;
            priceTrip.Text = "Price: ";
            this.Controls.Add(priceTrip);

            calculate.Size = new Size(80, 30);
            calculate.Location = new Point(50, 120);
            calculate.Text = "Calculate";
            calculate.Click += (s, e) =>
            {
                double.TryParse(distanceBox.Text, out _distance);
                double.TryParse(valueBox.Text, out _value);
                double.TryParse(priceBox.Text, out _price);

                _FuelVolume = FuelVolume();
                fuelVolume.Text = $"{fuelVolume.Text}{_FuelVolume}";
                priceTrip.Text = $"{priceTrip.Text}{PriceTrip()}";
            };
            this.Controls.Add(calculate);


        }

        private double FuelVolume()
        {
            return  _distance * (_value / 100);
        }

        private double PriceTrip()
        {
            return _FuelVolume * _price;
        }
    }
}