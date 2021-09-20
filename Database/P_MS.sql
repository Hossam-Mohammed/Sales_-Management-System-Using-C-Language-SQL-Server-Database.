--Stored Procedure to Login Function
Create Proc SP_LOGIN
@ID nvarchar(40), @Pass nvarchar(16)
As
Select * From Users 
Where ID = @ID And Pass = @Pass

--Stored Procedure to Select All Categories in ComboBox
Go
Create Proc SP_GETALLCATEGORIES
As
Select * From Categories

--Stored Procedure to Insert Products into Database
Go
Create Proc SP_ADDPRODUCT
@ID_Product nvarchar(10),
@LBL_Product nvarchar(60),
@Qtn_Product int,
@Price_Product decimal,
@Image_Product image,
@ID_Cat int
As
Insert Into Products
(
ID_Product,
LBL_Product,
Qtn_Product,
Price_Product,
Image_Product,
ID_Cat
)Values
(
@ID_Product,
@LBL_Product,
@Qtn_Product,
@Price_Product,
@Image_Product,
@ID_Cat
)
--Stored Procedure to Check Verified ID Product
Go
Create Proc SP_VERIFYIDPRODUCT
@ID_Product nvarchar(10)
As
Select * From Products 
Where ID_Product = @ID_Product

--Stored Procedure to Show Product Data in Grud View
Go
Create Proc SP_SHOWALLPRODUCT
As
SELECT [ID_Product] as ID
      ,[LBL_Product] as ProductName
      ,[Qtn_Product] as Quantity
      ,[Price_Product] as Price
      ,[Image_Product] as Picture
      ,[Name_Category] as Category
  FROM [dbo].[Products]
Inner Join Categories
On Categories.ID_Category = Products.ID_Cat

--Create Stored Procedure to Search Data
Create Proc SP_VERIFYIDPRODUCT
@ID_Product nvarchar(10)
As
Select * From Products 
Where ID_Product = @ID_Product

--Stored Procedure to Show Product Data in Grud View
Go
Create Proc SP_SEARCHPRODUCT
@ID nvarchar(10)
As
SELECT [ID_Product] as ID
      ,[LBL_Product] as ProductName
      ,[Qtn_Product] as Quantity
      ,[Price_Product] as Price
      ,[Image_Product] as Picture
      ,[Name_Category] as Category
  FROM [dbo].[Products]
Inner Join Categories
On Categories.ID_Category = Products.ID_Cat
Where
[ID_Product] +
[LBL_Product] +
Convert(nvarchar,[Qtn_Product]) +
Convert(nvarchar,[Price_Product]) +
[Name_Category] 
Like '%' + @ID + '%'

--Stored Procedure to Delete Product
Go
Create Proc SP_DELETEPRODUCT
@ID nvarchar(10)
As
Delete From Products Where ID_Product = @ID

--Stored Procedure to Get Image to Update Form
Go
Create Proc SP_GETIMAGE
@ID nvarchar(10)
As
Select Image_Product From Products
Where ID_Product = @ID

--Stored Procedure to Update Product
Go
Create Proc SP_UPDATEPRODUCT
@ID_Product nvarchar(10),
@LBL_Product nvarchar(60),
@Qtn_Product int,
@Price_Product decimal,
@Image_Product image,
@ID_Cat int
As 
Update Products
set[ID_Product] = @ID_Product,
[LBL_Product] = @LBL_Product,
[Qtn_Product] = @Qtn_Product,
[Price_Product] = @Price_Product,
[Image_Product] = @Image_Product,
[ID_Cat] = @ID_Cat
Where ID_Product = @ID_Product

--Stored Procedure to Add New User
Go
Create Proc SP_ADD_USER
@ID nvarchar(40), @Pass nvarchar(16), @Access nvarchar(6)
As
INSERT INTO [dbo].[Users]
           ([ID]
           ,[Pass]
           ,[Access])
     VALUES
           (@ID
           ,@Pass
           ,@Access)

--Stored Procedure to Search in Users
Go
Create Proc SP_SEARCH
@KeyWord nvarchar (50)
As
SELECT [ID] as 'Username'
      ,[Pass] as 'Password'
      ,[Access] as 'User Access'
  FROM [dbo].[Users]
Where [ID] + [Pass] + [Access] Like '%' + @KeyWord + '%'

--Stored Procedure to Edit Users
Go
Create Proc SP_Edit_USER
@ID nvarchar(40), @Pass nvarchar(16), @Access nvarchar(6)
As
UPDATE [dbo].[Users]
   SET [ID] = @ID
      ,[Pass] = @Pass
      ,[Access] = @Access
 WHERE [ID] = @ID

 --Stored PRocedure to Delete User
Go
Create Proc SP_DELETEUSER
 @ID nvarchar(40)
 As
 Delete From Users
 Where [ID] = @ID
  --Stored Procedure to Add Employee
 Go
 Create Proc SP_ADDEMPLOYEE
 @EID int,
 @EFName nvarchar(15),
 @ELName nvarchar(15),
 @EPh nvarchar(14),
 @EMail nvarchar(40),
 @EAd nvarchar(60),
 @ESal decimal(18,0),
 @EDedc decimal(18,0),
 @ENSal int
 as
INSERT INTO [dbo].[Employees]
           ([ID_Employee]
           ,[First_Name]
           ,[Last_Name]
           ,[Tele_Emp]
           ,[Email_Emp]
           ,[Adress_Emp]
           ,[Salary_Emp]
           ,[Deduction_Emp]
           ,[NetSal_Emp])
     VALUES
           (@EID
           ,@EFName
           ,@ELName
           ,@EPh
           ,@EMail
           ,@EAd
           ,@ESal
           ,@EDedc
           ,@ENSal)
GO
--Stored Procedure to Show All Employees
Create Proc SP_SHOWEMPLOYEE
as
SELECT [ID_Employee] as 'Employee ID'
      ,[First_Name] as 'First Name'
      ,[Last_Name] as 'Last Name'
      ,[Tele_Emp] as 'Phone Number'
      ,[Email_Emp] as 'E-Mail'
      ,[Adress_Emp] as 'Adress'
      ,[Salary_Emp] as 'Salary'
      ,[Deduction_Emp] as 'Deduction'
      ,[NetSal_Emp] as 'NetSalary'
  FROM [dbo].[Employees]
GO
--Stored Procedure to Edit Selected Employee
Create Proc SP_EDITEMPLOYEE
 @EID int,
 @EFName nvarchar(15),
 @ELName nvarchar(15),
 @EPh nvarchar(14),
 @EMail nvarchar(40),
 @EAd nvarchar(60),
 @ESal decimal(18,0),
 @EDedc decimal(18,0),
 @ENSal int
 as
UPDATE [dbo].[Employees]
   SET [ID_Employee] = @EID
      ,[First_Name] = @EFName
      ,[Last_Name] = @ELName
      ,[Tele_Emp] = @EPh
      ,[Email_Emp] = @EMail
      ,[Adress_Emp] = @EAd
      ,[Salary_Emp] = @ESal
      ,[Deduction_Emp] = @EDedc
      ,[NetSal_Emp] = @ENSal
 WHERE [ID_Employee] = @EID
GO
--Stored Procedure to Delete Selected Employee
Go
Create Proc SP_DELETEEMPLOYEE
@EID int
as
Delete From Employees
Where ID_Employee = @EID
Go
--Stored Procedure to Get Max Oreder ID
Create Proc SP_GETLASTORDERID
as
Select isnull(max(ID_Order)+1,1) from Orders
Go
--Stored Procedure to Save Order Information
Create Proc SP_ADDORDER
@Id_Order int,
@Desc_Order nvarchar(300),
@D_Order date,
@Id_Emp int,
@Id_User nvarchar(40)
as
INSERT INTO [dbo].[Orders]
           ([ID_Order]
           ,[Order_Desc]
           ,[Date_Order]
           ,[ID_Emp]
           ,[ID_User])
     VALUES
           (@Id_Order
           ,@Desc_Order
           ,@D_Order
           ,@Id_Emp
           ,@Id_User)
Go
Create Proc SP_GETEMPLOYEES
as
Select * From Employees
Go
Create Proc SP_ADDORDERDETAILS
@Id_Pro nvarchar(10),
@Id_Ord int,
@Qte int,
@Pro_Price nvarchar(50),
@Disct float,
@Pro_Amount nvarchar(50),
@T_Amount nvarchar(50)
as
INSERT INTO [dbo].[OrderDetails]
           ([ID_Pro]
           ,[ID_Ord]
           ,[QTE]
           ,[Price]
           ,[Discount]
           ,[Amount]
           ,[Total_Amount])
     VALUES
           (@Id_Pro
           ,@Id_Ord
           ,@Qte
           ,@Pro_Price
           ,@Disct
           ,@Pro_Amount
           ,@T_Amount)
Update Products set Qtn_Product = Qtn_Product - @Qte
Where ID_Product = @Id_Pro
GO
Create Proc SP_VERIFYQTN
@Id_Product nvarchar(60),
@Qtn_Entered int
as
Select * From Products
Where ID_Product = @Id_Product and Qtn_Product >= @Qtn_Entered

--Stored Procedure Print
Go
Create Proc SP_GETSELECTEDPRO
@Id_Product nvarchar(10)
as
SELECT [ID_Product]
      ,[LBL_Product]
      ,[Qtn_Product]
      ,[Price_Product]
      ,[Image_Product]
      ,[Name_Category]
  FROM [dbo].[Products]
inner join Categories
on Categories.ID_Category = Products.ID_Cat
where ID_Product = @Id_Product
GO
Create Proc SP_GETORDERDETAILS
@Id_Ord int
as
SELECT OrderDetails.[ID_Pro] as 'Product ID'
      ,[ID_Ord] as 'Check Number'
      ,[QTE] as 'Quantity'
      ,[Price] as 'Price'
      ,[Discount]
      ,[Amount] 
      ,[Total_Amount]
	  ,[Date_Order] as 'Check Date'
	  ,[Order_Desc] as 'Check Descrription'
	  ,[First_Name] + ' '+[Last_Name] as 'Full Name'
  FROM [dbo].[OrderDetails]
inner join Orders
on Orders.ID_Order = OrderDetails.ID_Ord
inner join Employees
on Employees.ID_Employee = Orders.ID_Emp
inner join Products
on Products.ID_Product = OrderDetails.ID_Pro
where ID_Order = @Id_Ord
GO
Create Proc SP_GETORDERDETAILS_PRINT
@Id_Ord int
as
SELECT OrderDetails.[ID_Pro] as 'Product ID'
      ,[ID_Ord] as 'Check Number'
      ,[QTE] as 'Quantity'
      ,[Price] as 'Price'
      ,[Discount]
      ,[Amount] 
      ,[Total_Amount]
	  ,[Date_Order] as 'Check Date'
	  ,[Order_Desc] as 'Check Descrription'
	  ,[First_Name] + ' '+[Last_Name] as 'Full Name'
  FROM [dbo].[OrderDetails]
inner join Orders
on Orders.ID_Order = OrderDetails.ID_Ord
inner join Employees
on Employees.ID_Employee = Orders.ID_Emp
inner join Products
on Products.ID_Product = OrderDetails.ID_Pro
Go