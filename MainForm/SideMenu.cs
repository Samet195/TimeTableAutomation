using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableAutomation {
    partial class MainForm {
        private void RenderSideMenuEntries() {
            trvw_sidepanel.BeginUpdate();

            var node_faculties = new TreeNode("Fakülteler") {
                Tag = GroupTags.Faculties,
                StateImageKey = "faculties"
            };
            var node_lecturers = new TreeNode("Hocalar") {
                Tag = GroupTags.Lecturers,
                StateImageKey = "lecturers"
            };

            foreach (DataRow faculty in db.GetFaculties().Rows) {
                var node_faculty = new TreeNode(get_field(faculty)) {
                    Tag = get_id(faculty),
                    StateImageKey = "faculty"
                };

                var node_faculty_departments = new TreeNode("Bölümler") {
                    Tag = GroupTags.Deoartments,
                    StateImageKey = "departments"
                };
                var node_faculty_classrooms = new TreeNode("Derslikler") {
                    Tag = GroupTags.Classrooms,
                    StateImageKey = "classroom"
                };

                foreach (DataRow department in db.GetDepartments(get_id(faculty)).Rows) {
                    var node_department = new TreeNode(get_field(department)) {
                        Tag = get_id(department),
                        StateImageKey = "department"
                    };
                    var node_department_programs = new TreeNode("Programlar") {
                        Tag = GroupTags.Programs,
                        StateImageKey = "program"
                    };

                    foreach (DataRow program in db.GetPrograms(get_id(department)).Rows) {
                        var node_program = new TreeNode(get_field(program)) {
                            Tag = get_id(program),
                            StateImageKey = "program"
                        };
                        var node_program_lessons = new TreeNode("Dersler") {
                            Tag = GroupTags.Lessons,
                            StateImageKey = "lesson"
                        };
                        var node_program_classes = new TreeNode("Sınıflar") {
                            Tag = GroupTags.Classes,
                            StateImageKey = "class"
                        };

                        foreach (DataRow lesson in db.GetLessons(get_id(program)).Rows) {
                            var node_lesson = new TreeNode(get_field(lesson)) {
                                Tag = get_id(lesson),
                                StateImageKey = "lesson"
                            };
                            node_program_lessons.Nodes.Add(node_lesson);
                        }

                        foreach (DataRow @class in db.GetClasses(get_id(program)).Rows) {
                            var node_class = new TreeNode($"{get_field(@class, "grade")}/{get_field(@class, "branch")}") {
                                Tag = get_id(@class),
                                StateImageKey = "class"
                            };
                            node_program_classes.Nodes.Add(node_class);
                        }

                        node_program.Nodes.Add(node_program_classes);
                        node_program.Nodes.Add(node_program_lessons);
                        node_department_programs.Nodes.Add(node_program);
                    }

                    node_department.Nodes.Add(node_department_programs);
                    node_faculty_departments.Nodes.Add(node_department);
                    node_faculty.Nodes.Add(node_faculty_departments);
                }

                foreach (DataRow classroom in db.GetClassrooms(get_id(faculty)).Rows) {
                    var node_classroom = new TreeNode(get_field(classroom, "code")) {
                        Tag = get_id(classroom),
                        StateImageKey = get_field(classroom, "type_id") == "4" ? "it_lab" : "classroom"
                    };

                    node_faculty_classrooms.Nodes.Add(node_classroom);
                }

                node_faculty.Nodes.Add(node_faculty_classrooms);

                node_faculties.Nodes.Add(node_faculty);
            }

            foreach (DataRow lecturer in db.GetLecturers().Rows) {
                var node_lecturer = new TreeNode($"{get_field(lecturer, "name")} {get_field(lecturer, "surname")}") {
                    Tag = get_id(lecturer),
                    StateImageKey = is_lecturer_male(lecturer) ? "lecturer_man" : "lecturer_woman"
                };
                node_lecturers.Nodes.Add(node_lecturer);
            }

            trvw_sidepanel.Nodes.Add(node_faculties);
            trvw_sidepanel.Nodes.Add(node_lecturers);
            trvw_sidepanel.EndUpdate();

            trvw_sidepanel.ExpandAll();
        }
    }
}
