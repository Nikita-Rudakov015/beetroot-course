create table PhoneBook 
(
	Id int Identity(1,1) primary key,
	FirstName varchar (20) Not Null,
	LastName varchar (20) Not Null,
	PhoneNumber bigint Not Null,
	Adress varchar (30) default null
);

insert into PhoneBook (FirstName, LastName, PhoneNumber) values
('Serhii',	'Olefir',		306343),
('Olena',	'Pilyta',		380093),
('Andrii',	'Mykytenko',	385889),
('Dmytro',	'Chentsov',		380412),
('Vova',	'Radchenko',	380956),
('Mykyta',	'Zakharov',		380891),
('Maryan',	'Kovalevych',	380715)


select * from PhoneBook
