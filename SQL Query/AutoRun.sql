CREATE TABLE Customer(
	Customer_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Customer_Name varchar(100),
	Customer_Address varchar(100),
	Customer_ContactNo int,
	Customer_type varchar(50),
);

CREATE TABLE Product(
	Product_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Product_Name varchar(50),
	Product_type varchar(50),
);

CREATE TABLE Load(
	Load_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Load_type varchar(50),
	Load_Date datetime,
	Product_ID int FOREIGN KEY REFERENCES Product(Product_ID)
);

CREATE TABLE Job(
	Job_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Start_Location varchar(50),
	End_Location varchar(50),
	Job_Date datetime,
	Load_ID int FOREIGN KEY REFERENCES Load(Load_ID),
	Customer_ID int FOREIGN KEY REFERENCES Customer(Customer_ID)
);

CREATE TABLE Payment(
	Pay_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Pay_Type varchar(50),
	Pay_Date datetime,
	Amount money,
	Job_ID int FOREIGN KEY REFERENCES Job(Job_ID),
	Customer_ID int FOREIGN KEY REFERENCES Customer(Customer_ID)
);
