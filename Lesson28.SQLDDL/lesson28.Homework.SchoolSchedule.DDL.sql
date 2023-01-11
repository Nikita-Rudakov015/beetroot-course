create table SchoolSchedule
(
	Id int identity(1,1) primary key,
	NameSubject varchar(30) Not null,
	Duration_minutes int Not Null,
	NameOfTeacher varchar(20) Not Null,
	LastNameOfTeacher varchar(20) Not Null,
	NumOfRoom int Not Null
);

insert into SchoolSchedule (NameSubject, Duration_minutes, NameOfTeacher, LastNameOfTeacher, NumOfRoom) values 
('Physics',			   45, 'Oksana',   'Myhaylivna',    311),
('Ukrainian Language', 45, 'Ludmyla',  'Borisivna',     418),
('Ukrainian History',  45, 'Svetlana', 'Genadievna',    312),
('Physical Education', 45, 'Irina',    'Oleksandrivna', 109),
('Mathematics',        45, 'Vera',     'Vasylivna',     213),
('World History',  45, 'Svetlana', 'Genadievna',    312);

select * from SchoolSchedule