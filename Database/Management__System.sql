Go
Create Database Management__System
GO
Create Table Users
(
ID nvarchar(40) primary key not null,
Pass nvarchar(16) not null,
Access nvarchar(6) not null
)
GO
Create Table Categories
(
ID_Category int primary key not null,
Name_Category nvarchar(max),
)
GO
Create Table Products
(
ID_Product nvarchar(10) primary key not null,
LBL_Product nvarchar(60) not null,
Qtn_Product int,
Price_Product decimal,
Image_Product image,
ID_Cat int foreign key references Categories (ID_Category) on Delete cascade on Update cascade
)
GO
Create Table Employees
(
ID_Employee int primary key not null,
First_Name nvarchar(15),
Last_Name nvarchar(15),
Tele_Emp nvarchar(14),
Email_Emp nvarchar(40),
Adress_Emp nvarchar(60),
Salary_Emp decimal,
Deduction_Emp decimal,
NetSal_Emp int
)
GO
Create Table Orders
(
ID_Order int primary key not null,
Order_Desc nvarchar(300),
Date_Order date,
ID_Emp int foreign key references Employees (ID_Employee) on Update cascade,
ID_User nvarchar(40) foreign key references Users (ID) on Update cascade
)
GO
Create Table OrderDetails
(
ID_Pro nvarchar(10) foreign key references Products (ID_Product) on Update cascade,
ID_Ord int foreign key references Orders (ID_Order) on Update cascade,
QTE int,
Price nvarchar(50),
Discount float,
Amount nvarchar(50),
Total_Amount nvarchar(50),
primary key (ID_Pro, ID_Ord)
)
Go