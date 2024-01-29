from Python.creation_methods import Student


class TestCreationMethods:
    def test_that_class_is_initialized_correctly_with_standard_constructor(self):
        student = Student(1, "Bob")
        assert student.id == 1
        assert student.first_name == "Bob"

    def test_that_class_is_initialized_correctly_with_string_constructor(self):
        student = Student.from_string("1, Bob")
        assert student.id == 1
        assert student.first_name == "Bob"
