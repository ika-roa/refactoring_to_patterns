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
        assert teacher.has_car is False
        assert teacher.category == "junior"

    def test_that_class_is_initialized_correctly_with_custom_constructor(self):
        teacher = self.create_senior_teacher(teacher_id=2, name="John", has_car=True)
        assert teacher.id == 2
        assert teacher.name == "John"
        assert teacher.has_car is True
        assert teacher.category == "senior"

    def test_that_class_is_initialized_correctly_with_mixed_constructor(self):
        teacher = self.create_senior_teacher(teacher_id=3, name="Mary")
        assert teacher.id == 3
        assert teacher.name == "Mary"
        assert teacher.has_car is False
        assert teacher.category == "senior"

    def create_senior_teacher(self, teacher_id: int, name: str, has_car: bool = False):
        return Teacher(teacher_id, name, has_car, category="senior")
