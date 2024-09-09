if exists (select [name]
from sys.databases
where [name] = N'MeowgicDb')

begin
  use master;
  drop database MeowgicDb;
end

go

create database MeowgicDb;
go

use MeowgicDb;

go

create table Account
(
  Id int identity(1,1) not null,
  Email nvarchar(255) not null,
  [Password] nvarchar(max) not null,
  [Name] nvarchar(255) not null,
  Dob date,
  Gender nvarchar(50),
  Phone nvarchar(50),
  [Role] nvarchar(50) not null,
  [Status] nvarchar(100) not null,
  Rate float,
  Premium bit not null default 0,
  ImgUrl nvarchar(max), 
  primary key (Id)
);

create table Promotion
(
	Id int identity(1,1) not null,
	[Description] nvarchar(255) not null,
	DiscountPercent float not null,
	MaxDiscount float not null,
	ExpireTime datetime not null,
	[Status] nvarchar(50),
	primary key (Id)
)

create table [TarotService]
(
  Id int identity(1,1) not null,
  AccountId int not null,
  [Name] nvarchar(255) not null,
  [Description] nvarchar(255) not null,
  ImgUrl nvarchar(max), 
  Price float not null,
  Rate float not null,
  PromotionId int,
  primary key (Id),
  foreign key (AccountId) references dbo.Account(Id),
  foreign key (PromotionId) references dbo.Promotion(Id),
);

create table [Order]
(
  Id int identity(1,1) not null,
  AccountId int not null,
  TotalPrice money not null,
  OrderDate datetime not null,
  [Status] nvarchar(50) not null
  primary key (Id),
  foreign key (AccountId) references dbo.Account(Id),
);

create table [OrderDetail]
(
  Id int identity(1,1) not null,
  OrderId int not null,
  ServiceId int not null,
  Rate float,
  Feedback nvarchar(255),
  primary key (Id),
  foreign key (OrderId) references dbo.[Order](Id),
  foreign key (ServiceId) references dbo.[TarotService](Id),
);

create table Category
(
  Id int identity(1,1) not null,
  [Name] nvarchar(255) not null,
  primary key (Id)
);

create table Question
(
  Id int identity(1,1) not null,
  [Description] nvarchar(255) not null,
  CategoryId int,
  primary key (Id),
  foreign key (CategoryId) references dbo.Category(Id),
);

create table [Card]
(
  Id int identity(1,1) not null,
  [Name] nvarchar(255) not null,
  ImgUrl nvarchar(255) not null,
  primary key (Id)
);

create table CardMeaning
(
	CategoryId int not null,
	CardId int not null,
	Meaning nvarchar(255) not null,
	ReMeaning nvarchar(255),
	primary key (CategoryId, CardId),
	foreign key (CategoryId) references dbo.Category(Id),
	foreign key (CardId) references dbo.[Card](Id),
)
