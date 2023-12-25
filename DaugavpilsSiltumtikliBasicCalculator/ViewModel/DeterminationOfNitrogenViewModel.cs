namespace DaugavpilsSiltumtikliBasicCalculator.ViewModel;

public partial class DeterminationOfNitrogenViewModel : BaseViewModel
{
    [ObservableProperty]
    private string resultValue;

    [ObservableProperty]
    private decimal nitrogenContentValue;

    [ObservableProperty]
    private decimal ashContentValue;

    private byte selectedNitrogenValue;

    public byte SelectedNitrogenValue
    {
        get => selectedNitrogenValue;
        set
        {
            if (value == 0)
            {
                selectedNitrogenValue = value;
            }
            else if (value == 1)
            {
                selectedNitrogenValue = value;
                NitrogenContentValue = 0.1m;
            }
            else if (value == 2)
            {
                selectedNitrogenValue = value;
                NitrogenContentValue = 0.2m;
            }
            else if (value == 3)
            {
                selectedNitrogenValue = value;
                NitrogenContentValue = 0.5m;
            }
            else if (value == 4)
            {
                selectedNitrogenValue = value;
                NitrogenContentValue = 0.4m;
            }
            else if (value == 5)
            {
                selectedNitrogenValue = value;
                NitrogenContentValue = 0.5m;
            }
        }
    }

    private decimal result;

    public DeterminationOfNitrogenViewModel()
    {
        ResultValue = string.Empty;
    }

    [RelayCommand]
    private async Task CalculateNitrogen()
    {
        await ValidateUserProvidedValues(nitrogenContentValue, ashContentValue);

        if (isUserProvidedValuesValid)
        {
            result = nitrogenContentValue * ((100 - ashContentValue) / 100);
            ResultValue = Convert.ToString(result);
        }
    }
}
