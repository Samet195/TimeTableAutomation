using System.Data;

namespace TimeTableAutomation {
    partial class Database {
        public DataTable GetEntries() {
            return ExecuteQuery("entries");
        }

        public DataTable GetFaculties() {
            return ExecuteQuery("faculties");
        }

        public DataTable GetDepartments(int faculty_id) {
            return ExecuteQuery("departments", where: $"faculty_id={faculty_id}");
        }

        public DataTable GetPrograms(int department_id) {
            return ExecuteQuery("programs", where: $"department_id={department_id}");
        }

        public DataTable GetLessons(int program_id) {
            return ExecuteQuery("lessons", where: $"program_id={program_id}");
        }

        public DataTable GetClasses(int program_id) {
            return ExecuteQuery("classes", where: $"program_id={program_id}");
        }

        public DataTable GetClassrooms(int faculty_id) {
            return ExecuteQuery("classrooms", where: $"faculty_id={faculty_id}");
        }

        public DataTable GetLecturers() {
            return ExecuteQuery("lecturers");
        }
        public DataTable GetClassView(int class_id ) {
            return ExecuteQuery($"v_entry_by_class", where: $"id={class_id}");
        }

        public DataTable GetClassroomView(int classroom_id) {
            return ExecuteQuery("v_entry_by_classroom", where: $"id={classroom_id}");
        }

        public DataTable GetLecturerView(int lecturer_id) {
            return ExecuteQuery("v_entry_by_lecturer", where: $"id={lecturer_id}");
        }
    }
}