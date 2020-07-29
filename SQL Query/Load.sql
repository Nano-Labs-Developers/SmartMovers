CREATE TABLE Load(
	Load_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Load_type varchar(50),
	Load_Date datetime,
	Product_ID int FOREIGN KEY REFERENCES Product(Product_ID)
);
