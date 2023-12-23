namespace DaugavpilsSiltumtikliBasicCalculator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            nameof(DeterminationOfHydrogenPage),
            typeof(DeterminationOfHydrogenPage)
        );

        Routing.RegisterRoute(nameof(DeterminationOfOxygenPage), typeof(DeterminationOfOxygenPage));

        Routing.RegisterRoute(
            nameof(DeterminationOfNitrogenPage),
            typeof(DeterminationOfNitrogenPage)
        );
    }
}
