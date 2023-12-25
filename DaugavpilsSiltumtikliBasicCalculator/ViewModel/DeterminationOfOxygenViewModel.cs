namespace DaugavpilsSiltumtikliBasicCalculator.ViewModel;

public partial class DeterminationOfOxygenViewModel : BaseViewModel
{
    [ObservableProperty]
    private string resultValue;

    [ObservableProperty]
    private decimal oxygenContentValue;

    [ObservableProperty]
    private decimal ashContentValue;

    private byte selectedOxygenValue;

    public byte SelectedOxygenValue
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
        ResultValue = string.Empty;
    }

    [RelayCommand]
    private async Task CalculateOxygen()
    {
        await ValidateUserProvidedValues(oxygenContentValue, ashContentValue);

        if (isUserProvidedValuesValid)
        {
            result = oxygenContentValue * ((100 - ashContentValue) / 100);
            ResultValue = Convert.ToString(result) + "%";
        }
    }
}
