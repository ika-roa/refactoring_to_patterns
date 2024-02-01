from Python.translator_factory import FrenchTranslator, app, SpanishTranslator, PortugueseTranslator, EnglishTranslator


class TestTranslator:
    def test_that_english_translator_returns_correct_translation_for_car(self):
        translator = EnglishTranslator()
        translation = translator.translate("car")
        assert translation == "car"

    def test_that_french_translator_returns_correct_translation_for_car(self):
        translator = FrenchTranslator()
        translation = translator.translate("car")
        assert translation == "voiture"

    def test_that_spanish_translator_returns_correct_translation_for_car(self):
        translator = SpanishTranslator()
        translation = translator.translate("car")
        assert translation == "coche"

    def test_that_portuguese_translator_returns_correct_translation_for_car(self):
        translator = PortugueseTranslator()
        translation = translator.translate("car")
        assert translation == "carro"


class TestApp:
    def test_that_app_translates_to_english(self):
        output = app("car", "english")
        assert "-*-" in output
        assert "car" in output

    def test_that_app_translates_to_french(self):
        output = app("car", "french")
        assert "-*-" in output
        assert "voiture" in output

    def test_that_app_translates_to_spanish(self):
        output = app("car", "spanish")
        assert "-*-" in output
        assert "coche" in output

    def test_that_app_translates_to_portuguese(self):
        output = app("car", "portuguese")
        assert "-*-" in output
        assert "carro" in output
