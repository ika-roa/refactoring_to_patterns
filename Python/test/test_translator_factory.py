from Python.translator_factory import FrenchTranslator, app, SpanishTranslator


def test_that_french_translator_returns_correct_translation_for_car():
    translator = FrenchTranslator()
    translation = translator.translate("car")
    assert translation == "voiture"


def test_that_spanish_translator_returns_correct_translation_for_car():
    translator = SpanishTranslator()
    translation = translator.translate("car")
    assert translation == "coche"


def test_that_app_translates_to_french():
    output = app("car", "french")
    assert "-*-" in output
    assert "voiture" in output


def test_that_app_translates_to_spanish():
    output = app("car", "spanish")
    assert "-*-" in output
    assert "coche" in output
