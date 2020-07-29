CREATE TABLE Job(
	Job_ID int PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Start_Location varchar(50),
	End_Location varchar(50),
	Job_Date datetime,
	Load_ID int FOREIGN KEY REFERENCES Load(Load_ID),
	Customer_ID int FOREIGN KEY REFERENCES Customer(Customer_ID)
);
