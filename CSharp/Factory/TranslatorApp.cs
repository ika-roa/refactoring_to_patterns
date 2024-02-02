namespace Factory;

public class TranslatorApp
{
    private readonly Translator _translator;
    private readonly string _message;

    public TranslatorApp(Translator translator, string message)
    {
        _translator = translator;
        _message = message;
    }
    public string Run()
    {
        var output = "";
        output += $"App is launched with {_translator.GetType().Name}.\n";
        
        var module = new AppModule(_translator);
        output += module.PrettyPrintOutput(_message);
        return output;
    }
}

internal class AppModule
{
    private readonly Translator _translator;

    public AppModule(Translator translator)
    {
        _translator = translator;
    }

    public string PrettyPrintOutput(string message)
    {
        var result = _translator.Translate(message);
        return $"*-* {result} *-*";
    }
}

public class Translator
{
    protected virtual Dictionary<string, string> Translations { get; } = new();

    public string Translate(string message)
    {
        return Translations.GetValueOrDefault(message, "No entry found!");
    }
}

public class FrenchTranslator : Translator
{
    protected override Dictionary<string, string> Translations { get; } = new() { { "car", "voiture" } };
}

}