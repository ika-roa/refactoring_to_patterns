class Translator:
    def __init__(self):
        self.translations = {}

    def translate(self, message):
        return self.translations.get(message)


class EnglishTranslator(Translator):
    def __init__(self):
        super().__init__()

    def translate(self, message):
        return message


class FrenchTranslator(Translator):
    def __init__(self):
        super().__init__()
        self.translations = {"car": "voiture"}


class SpanishTranslator(Translator):
    def __init__(self):
        super().__init__()
        self.translations = {"car": "coche"}


class PortugueseTranslator(Translator):
    def __init__(self):
        super().__init__()
        self.translations = {"car": "carro"}


class TranslatorFactory:
    def __init__(self, language):
        self.language = language
        self.translators = {"english": EnglishTranslator,
                            "french": FrenchTranslator,
                            "spanish": SpanishTranslator,
                            "portuguese": PortugueseTranslator
                            }

    def create(self):
        return self.translators[self.language]()


class AppModule:
    def __init__(self, translator):
        self.translator = translator

    def pretty_print_output(self, message):
        result = self.translator.translate(message)
        return f"-*- {result} -*-"


def app(message: str, language: str) -> str:
    my_translator = TranslatorFactory(language).create()

    print(f"App: Launched with {type(my_translator).__name__}")

    app_module = AppModule(my_translator)
    return app_module.pretty_print_output(message)
