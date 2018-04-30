create database ChallengeDb;

go

use ChallengeDb;

create schema Orders;

--drop table Orders.Orders

create table Orders.Orders (
	ID int primary key not null,
	ProductID int unique not null,
	CustomerID int unique not null,


		
);

create table Orders.Products (
	ID int primary key not null,
	name nvarChar(100) not null,
	price int not null,
	constraint FK_Products_Orders foreign key (ID) references Orders.Orders(ProductID)
		
);

create table Orders.Customers (
	ID int primary key not null,
	firstName nvarChar(100) not null,
	lastName nvarChar(100) not null,
	constraint FK_Customers_Orders foreign key (ID) references Orders.Orders (CustomerID)

	
	);


	INSERT into Orders.Orders
    VALUES (1,1,1);

	INSERT into Orders.Orders
    VALUES (2,2,2);

	INSERT into Orders.Orders
	VALUES (3,3,3);


	Insert into Orders.Products
	VALUES (1, 'Louis', 43);

	Insert into Orders.Products
	VALUES (2, 'Mike', 500);

	Insert into Orders.Products
	VALUES (3, 'Davis', 3);
