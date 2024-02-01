class AppModule:
    def __init__(self, translator):
        self.translator = translator

    def pretty_print_output(self, message):
        result = self.translator.translate(message)
        return f"-*- {result} -*-"


class FrenchTranslator:
    def __init__(self):
        self.translations = {"car": "voiture"}

    def translate(self, message) -> str:
        return self.translations.get(message)


class SpanishTranslator:
    def __init__(self):
        self.translations = {"car": "coche"}

    def translate(self, message) -> str:
        return self.translations.get(message)


class PortugueseTranslator:
    def __init__(self):
        self.translations = {"car": "carro"}

    def translate(self, message) -> str:
        return self.translations.get(message)


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
