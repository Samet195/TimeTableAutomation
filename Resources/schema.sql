PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

DROP TABLE IF EXISTS classes;
DROP TABLE IF EXISTS classroom_types;
DROP TABLE IF EXISTS classrooms;
DROP TABLE IF EXISTS departments;
DROP TABLE IF EXISTS entries;
DROP TABLE IF EXISTS faculties;
DROP TABLE IF EXISTS lecturers;
DROP TABLE IF EXISTS lessons;
DROP TABLE IF EXISTS programs;
DROP VIEW IF EXISTS v_classes;
DROP VIEW IF EXISTS v_classrooms;
DROP VIEW IF EXISTS v_departments;
DROP VIEW IF EXISTS v_entries;
DROP VIEW IF EXISTS v_entry_by_class;
DROP VIEW IF EXISTS v_entry_by_classroom;
DROP VIEW IF EXISTS v_entry_by_lecturer;
DROP VIEW IF EXISTS v_lessons;
DROP VIEW IF EXISTS v_programs;

CREATE TABLE classes (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  program_id INTEGER NOT NULL,
  grade INTEGER NOT NULL,
  branch TEXT NOT NULL,
  FOREIGN KEY (program_id) REFERENCES programs (id)
) STRICT;

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (1, 1, 1, 'A');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (2, 1, 1, 'B');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (3, 1, 2, 'A');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (4, 1, 2, 'B');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (5, 2, 1, 'A');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (6, 2, 1, 'B');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (7, 2, 1, 'C');

INSERT INTO
  classes (id, program_id, grade, branch)
VALUES
  (8, 2, 1, 'D');

CREATE TABLE classroom_types (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  name TEXT NOT NULL UNIQUE
) STRICT;

INSERT INTO
  classroom_types (id, name)
VALUES
  (1, 'Derslik');

INSERT INTO
  classroom_types (id, name)
VALUES
  (2, 'Sinema Salonu');

INSERT INTO
  classroom_types (id, name)
VALUES
  (3, 'Tasarım Atölyesi');

INSERT INTO
  classroom_types (id, name)
VALUES
  (4, 'Bilgisayar Laboratuvarı');

CREATE TABLE classrooms (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  code TEXT NOT NULL UNIQUE,
  capacity INTEGER NOT NULL,
  type_id INTEGER NOT NULL,
  faculty_id INTEGER NOT NULL,
  FOREIGN KEY (type_id) REFERENCES classroom_types (id),
  FOREIGN KEY (faculty_id) REFERENCES faculties (id)
) STRICT;

INSERT INTO
  classrooms (id, code, capacity, type_id, faculty_id)
VALUES
  (1, 'PDL', 30, 4, 1);

INSERT INTO
  classrooms (id, code, capacity, type_id, faculty_id)
VALUES
  (2, 'BGL-1', 35, 4, 1);

INSERT INTO
  classrooms (id, code, capacity, type_id, faculty_id)
VALUES
  (3, 'BGL-2', 45, 4, 1);

INSERT INTO
  classrooms (id, code, capacity, type_id, faculty_id)
VALUES
  (4, '101', 50, 1, 1);

INSERT INTO
  classrooms (id, code, capacity, type_id, faculty_id)
VALUES
  (5, '102', 35, 1, 1);

CREATE TABLE departments (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  name TEXT NOT NULL,
  head_lecturer_id INTEGER NOT NULL,
  faculty_id INTEGER NOT NULL,
  FOREIGN KEY (head_lecturer_id) REFERENCES lecturers (id),
  FOREIGN KEY (faculty_id) REFERENCES faculties (id)
) STRICT;

INSERT INTO
  departments (id, name, head_lecturer_id, faculty_id)
VALUES
  (1, 'Bilgisayar Teknolojileri', 1, 1);

INSERT INTO
  departments (id, name, head_lecturer_id, faculty_id)
VALUES
  (2, 'Mühendislik Bölümü', 3, 2);

CREATE TABLE entries (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  lesson_id INTEGER NOT NULL,
  classroom_id INTEGER NOT NULL,
  lecturer_id INTEGER NOT NULL,
  class_id INTEGER NOT NULL,
  is_locked INTEGER NOT NULL DEFAULT 0,
  is_deleted INTEGER NOT NULL DEFAULT 0,
  FOREIGN KEY (lesson_id) REFERENCES lessons (id),
  FOREIGN KEY (classroom_id) REFERENCES classrooms (id),
  FOREIGN KEY (lecturer_id) REFERENCES lecturers (id),
  FOREIGN KEY (class_id) REFERENCES classes (id)
) STRICT;

INSERT INTO
  entries (
    id,
    lesson_id,
    classroom_id,
    lecturer_id,
    class_id,
    is_locked,
    is_deleted
  )
VALUES
  (1, 1, 1, 2, 3, 0, 0);

INSERT INTO
  entries (
    id,
    lesson_id,
    classroom_id,
    lecturer_id,
    class_id,
    is_locked,
    is_deleted
  )
VALUES
  (2, 2, 2, 1, 3, 0, 0);

INSERT INTO
  entries (
    id,
    lesson_id,
    classroom_id,
    lecturer_id,
    class_id,
    is_locked,
    is_deleted
  )
VALUES
  (3, 3, 4, 3, 7, 0, 0);

CREATE TABLE faculties (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  name TEXT NOT NULL
) STRICT;

INSERT INTO
  faculties (id, name)
VALUES
  (1, 'Kastamonu Meslek Yüksekokulu');

INSERT INTO
  faculties (id, name)
VALUES
  (2, 'Mühendislik ve Mimarlik Fakültesi');

CREATE TABLE lecturers (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  name TEXT NOT NULL,
  surname TEXT NOT NULL,
  tel TEXT NOT NULL,
  email TEXT NOT NULL,
  is_male INTEGER NOT NULL
) STRICT;

INSERT INTO
  lecturers (id, name, surname, tel, email, is_male)
VALUES
  (
    1,
    'Serbun Ufuk',
    'Değer',
    '1234567890098',
    'w345tgfd',
    1
  );

INSERT INTO
  lecturers (id, name, surname, tel, email, is_male)
VALUES
  (
    2,
    'Asiye',
    'Özbek Yazıcıoğlu',
    '1234567890098',
    'w345tgfd',
    0
  );

INSERT INTO
  lecturers (id, name, surname, tel, email, is_male)
VALUES
  (
    3,
    'Kemal',
    'Paşazade',
    '1234567890098',
    'wsedrgh',
    1
  );

CREATE TABLE lessons (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  code TEXT NOT NULL UNIQUE,
  name TEXT NOT NULL,
  program_id INTEGER NOT NULL,
  FOREIGN KEY (program_id) REFERENCES programs (id)
) STRICT;

INSERT INTO
  lessons (id, code, name, program_id)
VALUES
  (1, 'BIL3452', 'Sistem Analizi', 1);

INSERT INTO
  lessons (id, code, name, program_id)
VALUES
  (2, 'BIL3254', 'Falan', 1);

INSERT INTO
  lessons (id, code, name, program_id)
VALUES
  (3, 'fbfb4e', 'efdsg', 2);

INSERT INTO
  lessons (id, code, name, program_id)
VALUES
  (4, '6yrtyhrth', 'tytııkıfghhrt', 1);

CREATE TABLE programs (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  name TEXT NOT NULL,
  department_id INTEGER NOT NULL,
  FOREIGN KEY (department_id) REFERENCES departments (id)
) STRICT;

INSERT INTO
  programs (id, name, department_id)
VALUES
  (1, 'Bilgisayar Programcılığı', 1);

INSERT INTO
  programs (id, name, department_id)
VALUES
  (2, 'Bilgisayar Mühendisliği', 2);

CREATE VIEW v_classes AS
SELECT
  A.id,
  B.name AS program,
  A.grade,
  A.branch
FROM
  classes AS A
  INNER JOIN programs AS B ON A.program_id = B.id;

CREATE VIEW v_classrooms AS
SELECT
  A.id,
  A.code,
  A.capacity,
  B.name AS type,
  C.name AS faculty
FROM
  classrooms AS A
  INNER JOIN classroom_types AS B ON A.type_id = B.id
  INNER JOIN faculties AS C ON A.faculty_id = C.id;

CREATE VIEW v_departments AS
SELECT
  A.id,
  A.name,
  B.name || " " || B.surname AS head_lecturer,
  C.name AS department
FROM
  departments AS A
  INNER JOIN lecturers AS B ON A.head_lecturer_id = B.id
  INNER JOIN faculties AS C ON A.faculty_id = C.id;

CREATE VIEW v_entries AS
SELECT
  A.id,
  B.name AS lesson,
  C.code AS classroom,
  D.name || " " || D.surname AS lecturer,
  E.grade || "/" || E.branch AS class,
  A.is_locked,
  A.is_deleted
FROM
  entries AS A
  INNER JOIN lessons AS B ON A.lesson_id = B.id
  INNER JOIN classrooms AS C ON A.classroom_id = C.id
  INNER JOIN lecturers AS D ON A.lecturer_id = D.id
  INNER JOIN classes AS E ON A.class_id = E.id;

CREATE VIEW v_entry_by_class AS
SELECT
  E.id,
  B.name AS lesson,
  C.code AS classroom,
  D.name || " " || D.surname AS lecturer,
  E.grade || "/" || E.branch AS class,
  A.is_locked,
  A.is_deleted
FROM
  entries AS A
  INNER JOIN lessons AS B ON A.lesson_id = B.id
  INNER JOIN classrooms AS C ON A.classroom_id = C.id
  INNER JOIN lecturers AS D ON A.lecturer_id = D.id
  INNER JOIN classes AS E ON A.class_id = E.id;

CREATE VIEW v_entry_by_classroom AS
SELECT
  C.id,
  B.name AS lesson,
  C.code AS classroom,
  D.name || " " || D.surname AS lecturer,
  E.grade || "/" || E.branch AS class,
  A.is_locked,
  A.is_deleted
FROM
  entries AS A
  INNER JOIN lessons AS B ON A.lesson_id = B.id
  INNER JOIN classrooms AS C ON A.classroom_id = C.id
  INNER JOIN lecturers AS D ON A.lecturer_id = D.id
  INNER JOIN classes AS E ON A.class_id = E.id;

CREATE VIEW v_entry_by_lecturer AS
SELECT
  D.id,
  B.name AS lesson,
  C.code AS classroom,
  D.name || " " || D.surname AS lecturer,
  E.grade || "/" || E.branch AS class,
  A.is_locked,
  A.is_deleted
FROM
  entries AS A
  INNER JOIN lessons AS B ON A.lesson_id = B.id
  INNER JOIN classrooms AS C ON A.classroom_id = C.id
  INNER JOIN lecturers AS D ON A.lecturer_id = D.id
  INNER JOIN classes AS E ON A.class_id = E.id;

CREATE VIEW v_lessons AS
SELECT
  A.id,
  A.code,
  A.name,
  B.name AS program
FROM
  lessons AS A
  INNER JOIN programs AS B ON A.program_id = B.id;

CREATE VIEW v_programs AS
SELECT
  A.id,
  A.name,
  B.name AS department
FROM
  programs AS A
  INNER JOIN departments AS B ON A.department_id = B.id;

COMMIT TRANSACTION;

PRAGMA foreign_keys = ON;
