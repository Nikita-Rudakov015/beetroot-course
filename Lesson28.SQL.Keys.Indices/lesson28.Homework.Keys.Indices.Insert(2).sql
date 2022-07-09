insert into Authors (Name, NameOfBookId) values
('Charles Dickens', 2),
('Antoine de Saint-Exupéry', 3),
('J. K. Rowling', 4),
('Agatha Christie', 5),
('Cao Xueqin', 6),
('Umberto Eco', 7),
('H. Rider Haggard', 9),
('Jack Higgins', 10);

select * from Authors

insert into GenreOfBooks (NameOfGenre) values
('Historical fiction'),
('Novella'),
('Fantasy'),
('Mystery'),
('Family saga'),
('Adventure'),
('War'),
('Thriller');

select * from GenreOfBooks

insert into Books (Name, GenreOfBooksId) values
('A Tale of Two Cities', 1),
('The Little Prince',	 2),
('Harry Potter and the Philosopher`s Stone', 3),
('And Then There Were None', 4),
('Dream of the Red Chamber', 5),
('The Name of the Rose', 5),
('The Name of the Rose', 4),
('She: A History of Adventure', 6),
('The Eagle Has Landed', 7),
('The Eagle Has Landed', 8);

select * from Books

insert into CountOfEachBook (BooksId,AuthorsId,Count) values
(2,6,10),
(3,7,15),
(4,8,10),
(5,9,20),
(6,10,17),
(7,11,15),
(8,11,12),
(9,12,17),
(10,13,14),
(11,13,11);


insert into Customers(Name, LastName) values
('Serhii',	'Olefir'),	
('Olena',	'Pilyta'),	
('Andrii',	'Mykytenko'),
('Dmytro',	'Chentsov'),	
('Vova',	'Radchexnko'),
('Mykyta',	'Zakharov'),	
('Maryan',	'Kovalevych');

select * from Customers;

insert into HistoryBooks (WhenBook, WhichBook, WhomBook) values
('2022-12-06',2,1),
('2022-10-16',3,2),
('2022-05-26',4,3),
('2022-12-04',5,4),
('2022-11-07',6,5),
('2022-09-03',7,6),
('2022-04-04',9,7);
