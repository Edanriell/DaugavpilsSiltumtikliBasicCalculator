namespace DaugavpilsSiltumtikliBasicCalculator.ViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    [RelayCommand]
    async Task GoToDeterminationOfHydrogen()
    {
        await Shell.Current.GoToAsync(nameof(DeterminationOfHydrogenPage), true);
    }

    [RelayCommand]
    async Task GoToDeterminationOfOxygen()
    {
        await Shell.Current.GoToAsync(nameof(DeterminationOfOxygenPage), true);
    }

    [RelayCommand]
    async Task GoToDeterminationOfNitrogen()
    {
        await Shell.Current.GoToAsync(nameof(DeterminationOfNitrogenPage), true);
    }
}
