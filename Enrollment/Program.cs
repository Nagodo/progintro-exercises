public class Student {
    public string name;
    public int id;
    public Student(string nameValue, int idValue) {
        name = nameValue;
        id = idValue;
    }
    public string GetName() {
        return name;
    }
}

public class Course {
    string name;
    Student[] participants;
    int id;

    public Course(string name) {
        this.name = name;
        participants = new Student[10];
    }

    public void Enroll(Student student) {
        for (int i = 0; i < participants.Length; i++) {
            if (participants[i] == null) {
                participants[i] = student;
                return;
            }
        }
    }

    public void Remove(Student student) {
        for (int i = 0; i < participants.Length; i++) {
            if (participants[i] == student) {
                participants[i] = null;
            }
        }
    }

    public Student[] GetParticipants() {
        int participantCount = participants.Where(p => p != null).Count();
        
        Student[] participantsCopy = new Student[participantCount];

        int index = 0;
        foreach(Student student in participants) {
            if (student == null) continue;

            participantsCopy[index] = student;
        }

        return participantsCopy;
    }
}

public class EnrollmentSystem {
    public Student[] students;
    public Course[] courses;

    public void AddStudent(Student student) {
        for (int i = 0; i < students.Length; i++) {
            if (students[i] == null) {
                students[i] = student;
                return;
            }
        }

        Array.Resize(ref students, students.Length + 1);
        students[^1] = student;
    }

    public void Enroll(Student student, Course course) {
        course.Enroll(student);
    }

    public void Remove(Student student, Course course) {
        course.Remove(student);
    }

    public void ShowParticipants(Course course) {
        foreach(Student student in course.GetParticipants()) {
            Console.WriteLine(student.GetName());
        }
    }

    public Course[] GetCourses() {
        return courses; // Not a copy
    }

    public Student[] GetStudents() {
        return students; // Not a copy
    }
}