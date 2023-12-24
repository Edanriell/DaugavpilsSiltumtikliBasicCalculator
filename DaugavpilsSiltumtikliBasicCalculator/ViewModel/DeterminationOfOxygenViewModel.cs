namespace DaugavpilsSiltumtikliBasicCalculator.ViewModel;

public partial class DeterminationOfOxygenViewModel : BaseViewModel
{
    [ObservableProperty]
    private string resultValue;

    [ObservableProperty]
    private decimal oxygenContentValue;

    [ObservableProperty]
    private decimal ashContentValue;

    private decimal selectedOxygenValue;

    public decimal SelectedOxygenValue
    {
        get => selectedOxygenValue;
        set
        {
            if (value == 0)
            {
                selectedOxygenValue = value;
            }
            else if (value == 1)
            {
                selectedOxygenValue = value;
                OxygenContentValue = 43m;
            }
            else if (value == 2)
            {
                selectedOxygenValue = value;
                OxygenContentValue = 42m;
            }
            else if (value == 3)
            {
                selectedOxygenValue = value;
                OxygenContentValue = 41m;
            }
            else if (value == 4)
            {
                selectedOxygenValue = value;
                OxygenContentValue = 40m;
            }
            else if (value == 5)
            {
                selectedOxygenValue = value;
                OxygenContentValue = 44m;
            }
        }
    }

    private decimal result;

    public DeterminationOfOxygenViewModel()
    {
        Title = "Skābekļa satura noteikšana sausā šķeldā";
        ResultValue = string.Empty;
    }

    [RelayCommand]
    private async Task CalculateOxygen()
    {
        result = oxygenContentValue * ((100 - ashContentValue) / 100);
        ResultValue = Convert.ToString(result);

        await Application.Current.MainPage.DisplayAlert("Tittle", "Hello", "OK", "NotOK");
    }
}
