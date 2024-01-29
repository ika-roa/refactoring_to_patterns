class Student:
    def __init__(self, student_id: int, first_name: str):
        self.id = student_id
        self.first_name = first_name

    @classmethod
    def from_string(cls, information_string: str):
        student_id, name = information_string.split(", ")
        return cls(int(student_id), name)

    @classmethod
    def from_list(cls, information_list: list):
        student_id, name = information_list
        return cls(student_id, name)


class Teacher:
    def __init__(self, teacher_id: int, name: str, has_car: bool = False, category: str = "junior"):
        self.id = teacher_id
        self.name = name
        self.has_car = has_car
        self.category = category

    @classmethod
    def create_senior_teacher(cls, teacher_id: int, name: str, has_car: bool = False):
        return cls(teacher_id, name, has_car, category="senior")

    @classmethod
    def create_teacher_with_car(cls, teacher_id, name, category):
        return cls(teacher_id=teacher_id, name=name, has_car=True, category=category)