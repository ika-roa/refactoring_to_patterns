from Python.translator_factory import FrenchTranslator, app


def test_that_french_translator_returns_correct_translation_for_car():
    translator = FrenchTranslator()
    translation = translator.translate("car")
    assert translation == "voiture"


def test_that_app_translates_to_french():
    output = app("car")
    assert "-*-" in output
    assert "voiture" in output
