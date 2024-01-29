from Python.creation_methods import Student, Teacher


class TestStudentWithDifferentTypeConstructors:
    def test_that_class_is_initialized_correctly_with_standard_constructor(self):
        student = Student(1, "Bob")
        assert student.id == 1
        assert student.first_name == "Bob"

    def test_that_class_is_initialized_correctly_with_string_constructor(self):
        student = Student.from_string("1, Bob")
        assert student.id == 1
        assert student.first_name == "Bob"

    def test_that_class_is_initialized_correctly_with_list_constructor(self):
        student = Student.from_list([1, "Bob"])
        assert student.id == 1
        assert student.first_name == "Bob"


class TestTeacherWithConstructorOverloading:
    def test_that_class_is_initialized_correctly_with_default_constructor(self):
        teacher = Teacher(1, "Bob")
        assert teacher.id == 1
        assert teacher.name == "Bob"
        assert teacher.has_car == False
        assert teacher.category == "junior"
