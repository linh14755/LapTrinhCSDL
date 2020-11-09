 



create database Lab6_Basic_Command
go
use Lab6_Basic_Command
go
create table Category
(
	ID int identity primary key,
	[Name] nvarchar(100),
	[Type] nvarchar(100)
)
create table Food
(
	ID int identity primary key,
	[Name] nvarchar(100),
	Units nvarchar(100),
	FoodCategoryID int references Category(ID),
	price nvarchar(100),
	notes nvarchar(100)
)

go

insert into Category(Name,Type) values	(N'Khai Vị',1)
insert into Category(Name,Type) values	(N'Hải Sản',1)
insert into Category(Name,Type) values	(N'Gà',1)
insert into Category(Name,Type) values	(N'Cơm',1)
insert into Category(Name,Type) values	(N'Thịt',1)
insert into Category(Name,Type) values	(N'Rau',1)
insert into Category(Name,Type) values	(N'Canh',1)
insert into Category(Name,Type) values	(N'Lẩu',1)
insert into Category(Name,Type) values	(N'Bia',0)
insert into Category(Name,Type) values	(N'Nước Ngọt',0)
go
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Rau muống xào tỏi',N'Đĩa',6,20000,NULL)
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Cơm Chiên Dương Châu',N'Đĩa Nhỏ',4,40000,N'3 người ăn')
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Cơm Chiên Dương Châu',N'Đĩa Lớn',4,45000,N'5 người ăn')
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Ếch chui Rơm',N'Đĩa',2,75000,NULL)
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Sò lông nướng mỡ hành',N'Đĩa',2,80000,NULL)
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Càng cua hấp',N'Đĩa',2,100000,NULL)
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Canh Cải Tô',N'Đĩa',8,20000,NULL)
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Gà nướng muối ớt',N'Con',3,180000,NULL)
insert into Food(Name,Units,FoodCategoryID,price,notes) values(N'Bia 333',N'Chai',10,12000,NULL)
go
select * from Category
select * from Food
select * from Food where FoodCategoryID = @categoryid