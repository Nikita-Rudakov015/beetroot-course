create table Products(
Id int primary key identity(1,1) not null,
CategoryId int not null,
Title varchar(30) not null,
Price real not null)

alter table Products
add foreign key (CategoryId) References Category(Id);

alter table Category
add primary key (Id);

alter table OrderItems add OrderId int not null

alter table OrderItems add foreign key (OrderId) references Orders(Id)



create table Customer(
Id int primary key identity(1,1) not null,
Name varchar(30) not null);

create table Orders(
Id int primary key identity(1,1) not null,
CustomerId int foreign key references Customer(Id) not null,
DeliveryMethod varchar(30) 
);

create table OrderItems(
Id int primary key identity(1,1) not null,
ProductId int foreign key references Products(Id) not null,
Count int not null
);
