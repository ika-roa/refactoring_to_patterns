class Student:
    def __init__(self, student_id, first_name):
        self.id = student_id
        self.first_name = first_name

    @classmethod
    def from_string(cls, information_string):
        student_id, name = information_string.split(", ")
        return cls(student_id, name)

    def print_information(self):
        print(f"The student {self.first_name} has id {self.id}.")


if __name__ == "__main__":
    # example 1: Class called via normal constructor
    student_1 = Student(1, "John")
    student_1.print_information()

    # example 2: Class called via alternate constructor
    student_2 = Student.from_string("2, Bob")
    student_2.print_information()
