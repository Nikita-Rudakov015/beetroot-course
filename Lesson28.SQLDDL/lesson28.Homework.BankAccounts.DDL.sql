create table BankAccounts (
Id int identity(1,1) Not Null,
Name varchar(20) Not Null,
LastName varchar(20) Not Null,
BankAccounts money Not Null,
Escrow money Not Null
);

insert into BankAccounts (Name, LastName, BankAccounts, Escrow) values 
('Serhii',	'Olefir',		$5000, $400),
('Olena',	'Pilyta',		$6000, $1400),
('Andrii',	'Mykytenko',	$4900, $1000),
('Dmytro',	'Chentsov',		$5500, $700),
('Vova',	'Radchenko',	$7000, $450),
('Mykyta',	'Zakharov',		$3500, $750),
('Maryan',	'Kovalevych',	$4000, $900)

select * from BankAccounts