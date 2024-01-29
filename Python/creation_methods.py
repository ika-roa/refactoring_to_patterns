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

    def print_information(self):
        print(f"The student {self.first_name} has id {self.id}.")


if __name__ == "__main__":
    # Class called via normal constructor
    student_1 = Student(1, "John")
    student_1.print_information()

    # Classes called via alternate constructors
    student_2 = Student.from_string("2, Bob")
    student_2.print_information()

    student_3 = Student.from_list([3, "Judy"])
    student_3.print_information()
