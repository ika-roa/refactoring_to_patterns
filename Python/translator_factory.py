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


def app(message: str):
    my_translator = FrenchTranslator()
    print(f"App: Launched with {type(my_translator).__name__}")

    app_module = AppModule(my_translator)
    return app_module.pretty_print_output(message)


if __name__ == "__main__":
    app("car")
