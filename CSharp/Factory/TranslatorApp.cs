﻿namespace Factory;

public class TranslatorApp
{
    private readonly string _message;
    private readonly Translator _translator;

    public TranslatorApp(string language, string message)
    {
        if (language == "french")
        {
            _translator = new FrenchTranslator();
        }
        else
        {
            _translator = new SpanishTranslator();
        }
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

internal class Translator
{
    protected virtual Dictionary<string, string> Translations { get; } = new();

    public string Translate(string message)
    {
        return Translations.GetValueOrDefault(message, "No entry found!");
    }
}

internal class FrenchTranslator : Translator
{
    protected override Dictionary<string, string> Translations { get; } = new() { { "car", "voiture" } };
}

internal class SpanishTranslator : Translator
{
    protected override Dictionary<string, string> Translations { get; } = new(){{"car", "coche"}};
}