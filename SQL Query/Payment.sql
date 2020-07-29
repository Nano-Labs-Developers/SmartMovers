CREATE TABLE Payment(
	Pay_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Pay_Type varchar(50),
	Pay_Date datetime,
	Amount money,
	Job_ID int FOREIGN KEY REFERENCES Job(Job_ID),
	Customer_ID int FOREIGN KEY REFERENCES Customer(Customer_ID)
);
