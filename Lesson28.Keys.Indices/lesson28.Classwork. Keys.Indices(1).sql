insert into Category(Title)
values ('TV'), ('Smartphones'), ('Cars');

insert into Products(CategoryId, Title, Price)
values 
(1, 'LG', 1000), (1, 'Samsung', 2000),
(2, 'iPhone', 1000), (2, 'Xiaomi', 2000),
(3, 'Tesla', 1000), (3, 'BMW', 2000)

insert into Customer (Name)
values ('Nikita')

insert into Orders (CustomerId, DeliveryMethod)
values (1, 'Pick-up')

insert into OrderItems (ProductId, OrderId, Count)
values
(1, 1, 2),
(3, 1, 1)

select c.Title, p.Title, p.Price from Products p
	inner join Category c on (c.Id = p.CategoryId)

select c.Title, p.Title, p.Price from Products p
	inner join Category c on (c.Id = p.CategoryId)
where c.Title != 'Smartphones'

select c.Name, o.DeliveryMethod, p.Title, p.Price, oi.Count, oi.Count * p.Price from Orders o
	inner join Customer c on (o.CustomerId = c.Id)
	inner join OrderItems oi on (oi.OrderId = o.Id)
	inner join Products p on (oi.ProductId = p.Id)
	inner join Category ct on (p.CategoryId = ct.Id)
where c.Name = 'Nikita'


select * from Orders