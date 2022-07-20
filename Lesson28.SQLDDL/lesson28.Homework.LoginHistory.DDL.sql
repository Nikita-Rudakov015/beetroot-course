create table LoginHistory(
	Id int identity(1,1) Primary Key,
	Logins varchar(30) Not Null,
	Passwords varchar(35) Not Null,
	LoginHistory datetime Not Null,
	Email varchar(40) default null,
	Age tinyint default null
);

insert into LoginHistory (Logins, Passwords, LoginHistory) values 
('SerOl01',		'seniorbigboss8532',		'2022-06-23T12:45:37.123' ),
('OlenPIL02',	'pilsmartbeetroot23ol',		'2022-06-20T09:25:30.341'),
('AndMyk03',	'andmmiddleqa6313',			'2022-07-01T17:15:27.263'),
('DmytChen04',	'dmchlrncsharps1034',		'2022-06-29T18:50:10.906'),
('VovRad05',	'vvrdbigbeard241423',		'2022-06-26T07:10:18.331'),
('MykZakh06',	'mzpoplavskyi1235',			'2022-07-01T15:30:12.589'),
('MarKov07',	'markovsqlpostgress3413',	'2022-06-23T12:45:37.123')

select * from LoginHistory