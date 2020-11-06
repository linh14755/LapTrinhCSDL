Use RestaurantManagement
GO
--bước 5
Select*from [Table]
Select*from Bills
Select*from Food
select*from	BillDetails
select*from Category
select*from Account
select*from [Role]
select*from RoleAccount
go
----Xuất ra bảng trong bảng cột có giá trị
--Select*from[Table] where Capacity = 5
--go
----Thêm giá trị vào một bảng
--Insert into [Table] values ('6','Bàn 6','0','6')
---- Cập nhật dữ liệu 
--Update Food set Name = N'Gà Kho Xã Ớt' where Name = 'Gà Kho Xã';
----Xóa dữ liệu 
--Delete from Category;
--GO
Create procedure Category_GetAll
As
	Begin 
		Select*from Category
	End
Go

Create procedure Bills_GetAll
As
	Begin
		Select*from Bills
	End
go

Create procedure BillDetails_GetAll
As 
	Begin
		Select*from BillDetails
	End
go

Create procedure Food_GetAll
As
	Begin 
		Select*from Food 
	end
go

Create procedure Table_GetAll
As
	Begin
		Select*from [Table]
	end
go

Create procedure RoleAccount_GetAll
As
	Begin
		Select*from RoleAccount
	end
go

create procedure Role_GetAll
as
	begin	
		Select*from [Role]
	end
go

create procedure Account_GetAll
As
	begin
		select*from Account
	end

go
create procedure Category_GetByID (@ID INT)
AS
	begin
		select*from Category where ID=@ID
	end

go
create procedure Table_GetByID (@ID INT )
As
	begin
		Select*from [Table] where ID=@ID
	end
go

create procedure Bills_GetByID (@ID INT)
AS
	begin
		select*from Bills where ID = @ID
	end
go

create procedure BillDetails_GetByID (@ID INT)
As
	begin	
		Select*from BillDetails where ID = @ID
	end
go

create procedure Food_GetByID (@ID INT)
As
	begin 
		Select*from Food where ID = @ID
	end
go
create procedure Account_GetByID (@AccountName NVARCHAR(100))
As
	begin 
		Select*from Account where AccountName = @AccountName
	end
go

create procedure Roleaccount_GetByID (@RoleID INT , @Accountname NVARCHAR(100))
as
	begin
		Select*from RoleAccount where RoleID=@RoleID and AccountName=@Accountname
	end
go

create procedure Role_GetByID (@ID INT)
as
	begin
		Select*from [Role] where ID=@ID
	end
Go

create procedure Category_Update (@ID INT, @Name NVARCHAR(1000), @TYPE INT )
as
	begin
		Update Category
		SET [Name] =@Name, [Type] = @TYPE
		where ID=@ID
	end
go

create procedure Table_Update (@ID INT, @Name NVARCHAR(1000), @Status INT, @Capacity INT )
as
	begin
		Update [Table]
		Set	[Name] = @Name , [Status]=@Status,[Capacity]=@Capacity
		where ID=@ID
	end
go

create procedure Bill_Update (@ID INT, @Name NVARCHAR(1000),@TableID INT, @Amount INT, @Discount FLOAT, @Tax FLOAT, @Status BIT,@CheckoutDate SMALLDATETIME,@Account NVARCHAR(100))
as
	begin
		update Bills
		Set [Name]=@Name,[TableID]=@TableID,[Amount]=@Amount,[Discount]=@Discount,[Tax]=@Tax,[Status]=@Status,[CheckoutDate]=@CheckoutDate,[Account]=@Account
		where ID=@ID
	end
go

create procedure BillDetail_Update (@ID INT,@InvoiceID INT, @FoodID INT, @Quantity INT)
as
	begin
		update BillDetails 
		set [InvoiceID]=@InvoiceID,[FoodID]=@FoodID,[Quantity]=@Quantity
		where ID=@ID
	end
go

create procedure Food_Update (@ID INT, @Name NVARCHAR(1000),@Unit NVARCHAR(100),@Foodcategory INT,@Price INT,@Note NVARCHAR(3000))
as
	begin
		update Food
		set	[Name]=@Name,[Unit]=@Unit,[FoodCategoryID]=@Foodcategory,[Price]=@Price,[Notes]=@Note
		where ID=@ID
	end
go

create procedure Account_Update (@AccountName NVARCHAR(100), @Password NVARCHAR(200), @FullName NVARCHAR(1000),@Email NVARCHAR(1000),@Tell NVARCHAR(200),@DateCreate SMALLDATETIME)
as
	begin
		update	Account
		set [Password]=@Password,[FullName]=@FullName,[Email]=@Email,[Tell]=@Tell,[DateCreated]=@DateCreate
		where AccountName=@AccountName
	end
go

create procedure Role_Update (@ID INT, @RoleName NVARCHAR(1000),@Path NVARCHAR(3000),@Notes NVARCHAR(3000))
as
	begin
		update [Role]
		set [RoleName]=@RoleName,[Path]=@Path,[Notes]=@Notes
		where ID=@ID
	end
go

create procedure RoleAccout_Update (@RoleID INT, @AccountName NVARCHAR(100), @Actived BIT,@Notes NVARCHAR(3000))
as
	begin
		update RoleAccount
		set [AccountName]=@AccountName,[Actived]=@Actived,[Notes]=@Notes
		where RoleID=@RoleID
	end
go

create procedure Category_Insert (@ID INT OUTPUT @Name NVARCHAR(1000),@Type INT)
as
	begin
		if(NOT EXISTS (Select Name From Category where Name= @Name))
			Insert into Category (Name,Type)
						VALUES(@Name,@Type)
			SET	@ID = @@IDENTITY
	end
Go

create procedure Table_Insert (@ID INT OUTPUT @Name NVARCHAR(1000), @Status INT, @Capacity INT )
as
	begin
		if(NOT EXISTS (select Name From [Table] where Name =@Name))
			Insert into [Table] (Name,Status,Capacity)
					VALUES (@Name,@Status,@Capacity)
			SET @ID =@@IDENTITY
	end
go

create procedure Bill_insert (@ID INT OUTPUT @Name NVARCHAR(1000), @TableID INT, @Amount INT, @Discount FLOAT, @Tax FLOAT,@Status Bit, @CheckoutDate SMALLDATETIME, @Account NVARCHAR(100))
as
	begin
		if (NOT EXISTS (select Name from Bills where Name=@Name))
			Insert into Bills(Name,TableID,Amount,Discount,Tax,Status,CheckoutDate)
						values (@Name,@TableID,@Amount,@Discount,@Tax,@Status,@CheckoutDate)
			SET @ID = @@IDENTITY
	end
go

create procedure BillDetails_Insert (@ID INT OUTPUT @InvoiceID INT, @FoodID INT, @Quantity INT)
as
	begin
		insert into BillDetails (InvoiceID,FoodID,Quantity)
			values (@InvoiceID,@FoodID,@Quantity)
			SET @ID =@@IDENTITY
	end
go

create procedure Food_Insert (@ID INT OUTPUT @Name NVARCHAR(1000), @Unit NVARCHAR(100), @FoodCatagoryID INT,@Price INT, @Notes NVARCHAR(3000))
as
	begin
		If (NOT EXISTS (select Name from Food Where Name =@Name))
			Insert into Food (Name,Unit,FoodCategoryID,Price,Notes)
				values (@Name,@Unit,@FoodCatagoryID,@Price,@Notes)
			SET @ID =@@IDENTITY
	end
go

create procedure Account_e (@Password NVARCHAR(200), @Fullname NVARCHAR(1000),@Email NVARCHAR(1000),@Tell NVARCHAR(200), @AccountName NVARCHAR(100))
as
	begin
		insert into Account (AccountName,Password,FullName,Email,Tell)
			values (@AccountName,@Password,@Fullname,@Email,@Tell)
	end
go

create procedure Role_insert ( @ID INT OUTPUT @RoleName NVARCHAR(1000), @Path NVARCHAR(3000),@Notes NVARCHAR(3000))
as
	begin	
		insert into [Role] (RoleName,path,Notes)
			values (@RoleName,@Path,@Notes
		set @ID =@@IDENTITY
	end
go

create procedure RoleAccount ( @RoleID INT OUTPUT @AccountName NVARCHAR(100),@Actived BIT,@Notes NVARCHAR(3000))
as
	begin
		insert into RoleAccount (AccountName,Actived,Notes)
			values (@AccountName,@Actived,@Notes)
			SET @ID =@@IDENTITY
	end
go

create procedure category_delete (@ID INT )
as 
	begin
		DELETE FROM Category
		Where ID =@ID
	end
go

create procedure table_delete ( @ID INT )
as
	begin
		delete from [Table]
		where ID =@ID
	end 
go

create procedure Bill_delete (@ID INT)
as
	begin 
		delete from Bills
		where ID =@ID
	 end
 go

 create procedure BillDetails_delete (@ID INT )
 as 
	begin
		delete from BillDetails
		where ID =@ID
	end 
go

create procedure Food_delete (@ID INT )
as 
	begin
		delete from Food
		where ID=@ID
	end
go

create procedure Account_delete (@AccountName NVARCHAR(1000))
as
	begin
		delete from Account
		where AccountName=@AccountName
	end
go

create procedure Role_delete (@ID INT )
as
	begin 
		delete from [Role]
	end
go

create procedure RoleAccount_delete (@RoleID INT)
as
	begin
		delete from RoleAccount
		where RoleID=@RoleID
	end
go
EXEC Category_Update 13,N'Tráng Miệng',1
go
Declare @ID INT = 0;
EXEC caCategory_Insert @ID = @ID OUTPUT,
					@Name =N'Món Rau',
					@Type = 1
Select *from Category where ID =@ID
go
create procedure GetAll (@TableName NVARCHAR(200))
as
begin
	Declare @sql NVARCHAR(1000)
	Set @sql ='select * from '+@TableName
	EXEC (@sql)
end
exec GetAll 'Category'

	
	

