class Translator:
    def __init__(self):
        self.translations = {}

    def translate(self, message):
        return self.translations.get(message)


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


class AppModule:
    def __init__(self, translator):
        self.translator = translator

    def pretty_print_output(self, message):
        result = self.translator.translate(message)
        return f"-*- {result} -*-"


def app(message: str, language: str) -> str:
    my_translator = None

    if language == "french":
        my_translator = FrenchTranslator()
    elif language == "spanish":
        my_translator = SpanishTranslator()
    elif language == "portuguese":
        my_translator = PortugueseTranslator()

    print(f"App: Launched with {type(my_translator).__name__}")

    app_module = AppModule(my_translator)
    return app_module.pretty_print_output(message)
