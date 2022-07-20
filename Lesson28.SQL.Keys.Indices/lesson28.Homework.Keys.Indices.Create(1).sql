create table Books (
Id int identity(1,1) primary key Not Null,
Name varchar(40) Not Null,
GenreOfBooksId int foreign key references GenreOfBooks(Id) Not Null
);


Create table GenreOfBooks (
Id int identity(1,1) primary key Not Null,
NameOfGenre varchar(20) Not Null,
);

create table Authors(
Id int identity(1,1) primary key Not Null,
Name varchar (30) Not Null,
);

alter table Authors
add NameOfBookId int foreign key references Books(Id) Not Null;

create table CountOfEachBook(
Id int identity(1,1) primary key Not Null,
BooksId int foreign key references Books(Id) Not Null,
AuthorsId int foreign key references Authors(Id) Not Null,
Count int Not Null,
);

create table Customers(
Id int identity(1,1) primary key Not Null,
Name varchar(20) Not Null,
LastName varchar(20) Not Null,
);

create table HistoryBooks (
Id int identity(1,1) primary key Not Null,
WhenBook date Not Null,
WhichBook int foreign key references Books(Id) Not Null,
WhomBook int foreign key references Customers(Id) Not Null,
);

