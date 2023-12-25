namespace DaugavpilsSiltumtikliBasicCalculator.ViewModel;

public partial class DeterminationOfHydrogenViewModel : BaseViewModel
{
    [ObservableProperty]
    private string resultValue;

    [ObservableProperty]
    private decimal hydrogenContentValue;

    [ObservableProperty]
    private decimal ashContentValue;

    private decimal selectedHydrogenValue;

    public decimal SelectedHydrogenValue
    {
        get => selectedHydrogenValue;
        set
        {
            if (value == 0)
            {
                selectedHydrogenValue = value;
            }
            else if (value == 1)
            {
                selectedHydrogenValue = value;
                HydrogenContentValue = 6.2m;
            }
            else if (value == 2)
            {
                selectedHydrogenValue = value;
                HydrogenContentValue = 6.2m;
            }
            else if (value == 3)
            {
                selectedHydrogenValue = value;
                HydrogenContentValue = 6.1m;
            }
            else if (value == 4)
            {
                selectedHydrogenValue = value;
                HydrogenContentValue = 6.1m;
            }
            else if (value == 5)
            {
                selectedHydrogenValue = value;
                HydrogenContentValue = 6.3m;
            }
        }
    }

    private decimal result;

    public DeterminationOfHydrogenViewModel()
    {
        ResultValue = string.Empty;
    }

    [RelayCommand]
    private async Task CalculateHydrogen()
    {
        await ValidateUserProvidedValues(hydrogenContentValue, ashContentValue);

        if (isUserProvidedValuesValid)
        {
            result = hydrogenContentValue * ((100 - ashContentValue) / 100);
            ResultValue = Convert.ToString(result) + "%";
        }
    }
}
