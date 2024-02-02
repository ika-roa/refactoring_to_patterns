using FluentAssertions;

namespace Factory.Tests;

public class ATranslatorApp
{
    [Test]
    public void when_run_with_a_french_translator_returns_its_translator_and_the_correct_translation_for_car()
    {
        var app = new TranslatorApp("french", "car");
        var output = app.Run();
        output.Should().Contain("FrenchTranslator");
        output.Should().Contain("*-* voiture *-*");

    }
    
    [Test]
    public void when_run_with_a_spanish_translator_returns_its_translator_and_the_correct_translation_for_car()
    {
        var app = new TranslatorApp("spanish", "car");
        var output = app.Run();
        output.Should().Contain("SpanishTranslator");
        output.Should().Contain("SpanishTranslator");
        output.Should().Contain("*-* coche *-*");
    
    }
}