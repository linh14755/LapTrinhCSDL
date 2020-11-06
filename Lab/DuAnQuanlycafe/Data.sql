CREATE DATABASE QuanlyQuanCafe
go
use QuanlyQuanCafe
go

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

create table TableFood
(
	id int IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null  default N'Trống'-- trong|| co nguoi
)
go
create table Account
(
	UserName nvarchar(100) primary key ,
	DisplayName nvarchar(100) not null default N'Kter',
	Password nvarchar(1000) not null default 0,
	Type int not null default 0--1 admin|| 0 staff
)
go
create table FoodCategory
(
	id int IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
go
create table Food
(
	id int IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null

	foreign key (idCategory) references FoodCategory(id)
)
go
create table Bill
(
	id int IDENTITY PRIMARY KEY,
	DateCheckIN date,
	DateCheckOut date,
	idTable int not null,
	status int not null default 0 --1 da thanh toan||0 chua thanh toan

	foreign key (idTable) references TableFood(id)
)
go
create table BillInfo
(
	id int IDENTITY PRIMARY KEY,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references Bill(id),
	foreign key (idFood) references Food(id)
)
go
insert into Account	(UserName,Password) values(N'Linh','1')
insert into Account	(UserName,Password) values(N'staff','2')

go
--tạo proc USP_GetAccountByUserName

create proc USP_GetAccountByUserName
(
	@username nvarchar(100)
)
as
	begin
		select * from Account where @username = UserName
	end
go
exec USP_GetAccountByUserName N'Linh'
go
select * from Account where UserName = N'Linh' and  Password = '1'
go
--tạo table
declare @i int = 21
while @i <=25
begin
	insert into TableFood (name) values (N'Bàn ' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end
go
select * from TableFood
go
--tạo proc USP_GetTableList
create proc USP_GetTableList
as select *from TableFood;
go
exec USP_GetTableList
go
update TableFood set status = N'Có người' where id = 12;


go
--Thêm category
insert into FoodCategory(name) values (N'Hải sản')
insert into FoodCategory(name) values (N'Nông sản')
insert into FoodCategory(name) values (N'Lâm sản')
insert into FoodCategory(name) values (N'Sản sản')
insert into FoodCategory(name) values (N'Nước')
go
--Thêm food
insert into Food(name,idCategory,price) values (N'Mực một nắng nướng sa tế',1,120000)
insert into Food(name,idCategory,price) values (N'Ngêu hấp xả',1,50000)
insert into Food(name,idCategory,price) values (N'Vú dê nướng',2,60000)
insert into Food(name,idCategory,price) values (N'Heo rừng nướng',3,75000)
insert into Food(name,idCategory,price) values (N'Cơm chiên mushi',4,99999)
insert into Food(name,idCategory,price) values (N'7UP',5,15000)
insert into Food(name,idCategory,price) values (N'Cafe',5,15000)
go
--Thêm Bill
insert into Bill values (GETDATE(),null,1,0)
insert into Bill values (GETDATE(),null,2,0)
insert into Bill values (GETDATE(),GETDATE(),2,1)
select * from Bill where idTable = 2 and status = 0
select * from BillInfo
select * from Food
select * from FoodCategory
go
--Thêm BillInfor
insert into BillInfo values (1,1,2)
insert into BillInfo values (1,5,1)
insert into BillInfo values (2,1,2)
insert into BillInfo values (2,6,2)
insert into BillInfo values (3,5,2)
go
create proc USP_Login
@username nvarchar(100),@password nvarchar (100)
as
begin
	select * from Account where @username = UserName and @password = Password 
end
go
exec USP_Login N'Linh' , N'1' 

select *from Bill
select *from BillInfo
select *from TableFood
select *from Food where idCategory = 1
delete Bill	
delete BillInfo
go

alter proc USP_InsertBill
@idtable int
as
begin
		insert into Bill(DateCheckIN,DateCheckOut,idTable,status) values (GETDATE(),null,@idtable,0)	
end

exec USP_InsertBill 19

go
alter proc USP_InsertBillInfo
	@idbill int , @idfood int , @count int
as
	declare @isExistsBillInfo int , @foodcount int

	select @isExistsBillInfo = id , @foodcount = b.count  
	from BillInfo as b
	where idBill = @idbill and idFood = @idfood


	if(@isExistsBillInfo > 0) --neu ton tai id va da co mon an trong table billinfo thi chi can cap nhat count 
		begin
		declare @newcount int = @foodcount + @count
			if(@newcount >0)
				update BillInfo set count = @foodcount + @count where idfood = @idfood
			else
				delete BillInfo where idBill = @idbill and idFood = @idfood
		end
	else
		begin
			insert into BillInfo values (@idbill,@idfood,@count)
		end
go


go
alter proc USP_GetIDBillByIdTable
@idtable int
as
begin
	select * from Bill where @idtable = idTable
end
go

select * from Bill

exec USP_InsertBillInfo 1 , 1 , 1
update Bill set status = 1 where idTable = 19