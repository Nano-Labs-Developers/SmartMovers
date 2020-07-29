CREATE TABLE Customer(
	Customer_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Customer_Name varchar(100),
	Customer_Address varchar(100),
	Customer_ContactNo int,
	Customer_type varchar(50),
);
