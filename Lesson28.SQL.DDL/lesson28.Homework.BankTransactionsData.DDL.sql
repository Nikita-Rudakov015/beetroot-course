create table TransactionsData (
Id int identity(1,1) Not Null,
NameCard varchar(20) Not Null,
LastNameCard varchar(20) Not Null,
NumCard bigint Not Null,
CVV tinyint Not Null,
ValidityPeriod datetime Not Null
);

alter table TransactionsData
alter column ValidityPeriod date;

alter table TransactionsData
alter column CVV smallint;

insert into TransactionsData (NameCard, LastNameCard, NumCard, CVV, ValidityPeriod) values
('Serhii',	'Olefir',	  4491429479220943,	343, '2030-12-04'),
('Olena',	'Pilyta',	  4491493242948614,	093, '2028-08-26'),
('Andrii',	'Mykytenko',  4491671020661358,	889, '2033-11-14'),
('Dmytro',	'Chentsov',	  4491134606801440,	412, '2030-10-04'),
('Vova',	'Radchenko',  4491467153066274,	956, '2028-01-24'),
('Mykyta',	'Zakharov',	  4491451068290421,	891, '2033-05-07'),
('Maryan',	'Kovalevych', 4491145017853504,	715, '2031-03-22')

select * from TransactionsData