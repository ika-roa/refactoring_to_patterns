namespace Factory;

public class TranslatorApp
{
    private readonly FrenchTranslator _translator;
    private readonly string _message;

    public TranslatorApp(FrenchTranslator translator, string message)
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
    private readonly FrenchTranslator _translator;

    public AppModule(FrenchTranslator translator)
    {
        _translator = translator;
    }

    public string PrettyPrintOutput(string message)
    {
        var result = _translator.Translate(message);
        return $"*-* {result} *-*";
    }
}

public class FrenchTranslator
{
    private readonly Dictionary<string, string> _translations = new(){{"car", "voiture"}};

    public string Translate(string message)
    {
        return _translations.GetValueOrDefault(message, "No entry found!");
    }
}