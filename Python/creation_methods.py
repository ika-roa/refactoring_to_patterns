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
