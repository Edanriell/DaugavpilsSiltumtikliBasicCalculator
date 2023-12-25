namespace DaugavpilsSiltumtikliBasicCalculator.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    protected bool isUserProvidedValuesValid;

    protected async Task ValidateUserProvidedValues(decimal firstValue, decimal secondValue)
    {
        if (Convert.ToDecimal(firstValue) > 0 && Convert.ToDecimal(secondValue) > 0)
        {
            if (firstValue > 0 && firstValue <= 100 && secondValue > 0 && secondValue <= 100)
            {
                isUserProvidedValuesValid = true;
            }
            else
            {
                isUserProvidedValuesValid = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Kļūda",
                    "Abi lauki var saturēt skaitļus ne mazākus par 0 un ne lielākus par 100",
                    "OK"
                );
            }
        }
        else
        {
            isUserProvidedValuesValid = false;
            await Application.Current.MainPage.DisplayAlert(
                "Kļūda",
                "Lauki var saturēt tikai ciparus, un tie nevar būt mazāki par 0",
                "OK"
            );
        }
    }
}
