CREATE TABLE Teacher (
    id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    surname VARCHAR(50) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    subject VARCHAR(50) NOT NULL
);

CREATE TABLE Pupil (
    id INT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    class VARCHAR(10) NOT NULL
);

CREATE TABLE Teacher_Pupil (
    teacher_id INT NOT NULL,
    pupil_id INT NOT NULL,
    PRIMARY KEY (teacher_id, pupil_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(id),
    FOREIGN KEY (pupil_id) REFERENCES Pupil(id)
);


SELECT t.*
FROM Teacher t
INNER JOIN Teacher_Pupil tp ON tp.teacher_id = t.id
INNER JOIN Pupil p ON p.id = tp.pupil_id
WHERE p.first_name = 'Giorgi';