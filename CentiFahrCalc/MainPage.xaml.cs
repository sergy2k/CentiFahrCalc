namespace CentiFahrCalc;

public partial class MainPage : ContentPage
{
	private double _celcius;
	private double _fahrenheit;

    // C = (5 / 9) * (F - 32)
    // F = (9 / 5) * C + 32

    double CelciusToFahrenheit(double c)
	{
        //f:
        return ((9.0 / 5.0) * c + 32.0);
    }

    double FahrenheitToCelcius(double f)
    {
        //c:
        return (5.0 / 9.0) * (f - 32.0);
    }
   
    public MainPage()
	{
		InitializeComponent();
        _celcius = 0;
        _fahrenheit = CelciusToFahrenheit(_celcius); ;
        CelciusLbl.Text = _celcius.ToString("F2"); ;
        FahrenheitLbl.Text = _fahrenheit.ToString("F2");
    }
	private void OnCelsiusPlusBtnClicked(object sender, EventArgs e)
	{
        if(_celcius < Math.Ceiling(_celcius))
        {

            _celcius = Math.Ceiling(_celcius);
        }
        else
        {
            _celcius += 1;
        }
        _fahrenheit = CelciusToFahrenheit(_celcius);
        CelciusLbl.Text = _celcius.ToString("F2");
        FahrenheitLbl.Text = _fahrenheit.ToString("F2");
        SemanticScreenReader.Announce(CelciusLbl.Text);
        SemanticScreenReader.Announce(FahrenheitLbl.Text);
    }
	private void OnCelsiusMinusBtnClicked(object sender, EventArgs e)
	{
        if (_celcius > Math.Floor(_celcius))
        {

            _celcius = Math.Floor(_celcius);
        }
        else
        {
            _celcius += -1;
        }
        _fahrenheit = CelciusToFahrenheit(_celcius);
        CelciusLbl.Text = _celcius.ToString("F2");
        FahrenheitLbl.Text = _fahrenheit.ToString("F2");
        SemanticScreenReader.Announce(CelciusLbl.Text);
        SemanticScreenReader.Announce(FahrenheitLbl.Text);
    }
    private void OnFahrenheitPlusBtnClicked(object sender, EventArgs e)
	{
        if (_fahrenheit < Math.Ceiling(_fahrenheit))
        {

            _fahrenheit = Math.Ceiling(_fahrenheit);
        }
        else
        {
            _fahrenheit += 1;
        }
        _celcius = FahrenheitToCelcius(_fahrenheit);
        FahrenheitLbl.Text = _fahrenheit.ToString("F2");
        CelciusLbl.Text = _celcius.ToString("F2");
        SemanticScreenReader.Announce(FahrenheitLbl.Text);
        SemanticScreenReader.Announce(CelciusLbl.Text);
    }
    private void OnFahrenheitMinusBtnClicked(object sender, EventArgs e)
    {
        if (_fahrenheit > Math.Floor(_fahrenheit))
        {

            _fahrenheit = Math.Floor(_fahrenheit);
        }
        else
        {
            _fahrenheit -= 1;
        }
        _celcius = FahrenheitToCelcius(_fahrenheit);
        FahrenheitLbl.Text = _fahrenheit.ToString("F2");
        CelciusLbl.Text = _celcius.ToString("F2");
        SemanticScreenReader.Announce(FahrenheitLbl.Text);
        SemanticScreenReader.Announce(CelciusLbl.Text);
    }
}

