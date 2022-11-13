create database LanguageCenter_DEMO2
go
use LanguageCenter_DEMO2
go

-- Courses
create table Courses(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(40) not null,
	Target float not null,
	No_Lessons int not null check (No_Lessons >= 0),
	Price int not null check(Price >= 0),
);
go


create table Roles(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(50) not null,
);
go


-- Accounts
create table Accounts (
	Username varchar(100) primary key,
	Password varchar(100)  not null,
	Is_Active bit not null,
	RoleID int references Roles(ID) not null,
);
go


-- Student 
create table Students(
	Username varchar(100) primary key,
	Date_Birth date not null,
	Address nvarchar(100) not null,
	Name nvarchar(50) not null,
	Email varchar(50) unique not null,
	Phone varchar(11) unique not null,
	check(10 = len(Phone) or len(Phone) = 11),
	foreign key(Username) references Accounts(Username)  on update cascade ,
);
go 

-- Teacher
create table Teachers(
	Username varchar(100) primary key,
	Date_Birth date not null,
	Address nvarchar(100) not null,
	Name nvarchar(50) not null,
	Email varchar(50) unique not null,
	Phone varchar(11) unique not null,
	check(10 = len(Phone) or len(Phone) = 11),
	foreign key(Username) references Accounts(Username) on update cascade ,
);
go

-- Staff 
create table Staff(
	Username varchar(100) primary key,
	Date_Birth date not null,
	Address nvarchar(100) not null,
	Name nvarchar(50) not null,
	Email varchar(50) unique not null,
	Phone varchar(11) unique not null,
	Position nvarchar(40) not null,
	check(10 = len(Phone) or len(Phone) = 11),
	foreign key(Username) references Accounts(Username) on update cascade ,
);
go

-- Classes
create table Classes(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(100) not null,
	Start_Date date not null,
	End_Date date not null,
	Username varchar(100) not null,
	Course_ID int not null,
	WeekDays varchar(10) not null,
	Start_Time time not null,
	End_Time time not null,
	foreign key(Username) references Teachers(Username)  on update cascade ,
	foreign key(Course_ID) references Courses(ID),
);
go

-- Class_student
create table Class_Students(
	ID int IDENTITY(1,1) primary key,
	Class_ID int not null,
	Username varchar(100) not null,
	foreign key(Class_ID) references Classes(ID),
	foreign key(Username) references Students(Username)  on update cascade ,
);
go

-- Payment_method
create table Payment_Methods(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(100) not null
);
go

-- Payment
create table Payments(
	ID int IDENTITY(1,1) primary key,
	Payment_Date date not null,
	Amount int not null check(Amount >= 0),
	Payment_Method_ID int not null,
	Status bit not null,
	Username varchar(100) not null,
	foreign key(Payment_Method_ID) references Payment_Methods(ID),
	foreign key(Username) references Students(Username) on update cascade ,
);
go


--CONSTRAINTS:

-- ràng buộc check password phải có chữ hoa, chữ thường, số, một vài loại kí tự đặc biệt và hơn 7 ký tự
alter table Accounts add constraint CheckPassword_Accounts check (Password like '%[0-9]%' 
and Password like '%[A-Z]%' collate Latin1_General_BIN2
and Password like '%[!@#$%^&*()-_+=.,;:~]%' and len(Password)>7);


-- ràng buộc check email đúng format và không chứa một vài ký tự đặc biệt
alter table Students add constraint checkEmailStudent check (Email like '%_@__%.__%'and Email not like '% %'
and PATINDEX('%[^a-z,0-9,@,.,]%', Email) = 0);

alter table Staff add constraint checkEmailStaff check (Email like '%_@__%.__%'and Email not like '% %'
and PATINDEX('%[^a-z,0-9,@,.,]%', Email) = 0);

alter table Teachers add constraint checkEmailTeacher check (Email like '%_@__%.__%'and Email not like '% %'
and PATINDEX('%[^a-z,0-9,@,.,]%', Email) = 0);

--ràng buộc check sđt chỉ chứa số
alter table Students add constraint checkPhoneStudent check (PATINDEX('%[^0-9]%', Phone) = 0);

alter table Staff add constraint checkPhoneStaff check (PATINDEX('%[^0-9]%', Phone) = 0);

alter table Teachers add constraint checkPhoneTeacher check (PATINDEX('%[^0-9]%', Phone) = 0);

-- check lịch học
alter table Classes add constraint checkDay check (PATINDEX('%[^2-7, -]%', Weekdays) = 0);

-- check thời gian của lớp học
alter table Classes add constraint checkDayStartEnd check (Start_Date < End_Date);

alter table Classes add constraint checkTimeStartEnd check (Start_Time < End_Time);
go

--trigger kiểm tra thang điểm theo khóa học

create trigger checkTargetCourse on Courses
after insert as
declare @name nvarchar(40), @target float
select @name = ne.Name, @target = ne.Target
from inserted ne
begin
if @target < 0
rollback
else
begin
if @name like '%IELTS%'
if @target > 9
rollback
if @name like '%TOEIC%'
begin
if @name like '%LR%'
if @target > 990
rollback
if @name like '%SW%'
if @target >400
rollback
end
end
end
go


------------------------NHẬP DỮ LIỆU---------------
insert into Courses values ('TOEIC SW',400,29,5000000);
insert into Courses values ('TOEIC LR',900,66,7000000);
insert into Courses values ('IELTS',7.0,50,10000000);
insert into Courses values ('',0,0,0);

select * from Courses;


insert into Roles values ('Admin');
insert into Roles values ('Staff');
insert into Roles values ('Teacher');
insert into Roles values ('Student');
insert into Roles values ('');

select * from Roles;


insert into Accounts values ('admin01', 'Mtl@091202', 1, 1);
insert into Accounts values ('admin02', 'Mtl@091202', 0, 1);
insert into Accounts values ('staff01', 'Mtl@091202', 1, 2);
insert into Accounts values ('staff02', 'Mtl@091202', 0, 2);
insert into Accounts values ('teacher01', 'Mtl@091202', 1, 3);
insert into Accounts values ('teacher02', 'Mtl@091202', 0, 3);
insert into Accounts values ('student01', 'Mtl@091202', 1, 4);
insert into Accounts values ('student02', 'Mtl@091202', 0, 4);
insert into Accounts values ('','Mtl@091202',0,5);

select * from Accounts;


insert into Students values ('student01', '12-09-2002', 'Hoang Dieu 2', 'Le Minh Tuong', 'mtl@gmail.com', '0834091202');
insert into Students values ('student02', '07-07-2002', 'So 1 Vo Van Ngan', 'Minh Tuong Le', 'mtmtmt@gmail.com', '0941194574');
insert into Students values ('', '01-01-2002', '', '', 'abc@gmail.com', '0000000000');

select Username, Name, convert (varchar(100),Date_Birth, 103) as Date_Birth, Address,  Email, Phone from Students;


insert into Teachers values ('teacher01', '12-09-1990', 'Hoang Dieu 2', 'John Dept', 'johndt@gmail.com', '0342925953');
insert into Teachers values ('teacher02', '07-07-1997', 'So 1 Vo Van Ngan', 'Marco Simp', 'marcosp@gmail.com', '0827107089');
insert into Teachers values ('', '01-01-2002', '', '', 'abc@gmail.com', '0000000000');

select Username, Name, convert (varchar(100),Date_Birth, 103) as Date_Birth, Address,  Email, Phone from Teachers;


insert into Staff values ('staff01', '12-09-1975', 'Hoang Dieu 2', 'Yone', 'yone@gmail.com', '0909090090', 'HR');
insert into Staff values ('staff02', '07-07-2004', 'So 1 Vo Van Ngan', 'Yasuo', 'yasuo@gmail.com', '0909123456', 'Receptionist');
insert into Staff values ('admin01', '12-09-1975', 'Hoang Dieu 2', 'Ringo', 'ringo@gmail.com', '0909095090', 'Administrator');
insert into Staff values ('admin02', '07-07-2004', 'So 1 Vo Van Ngan', 'Yuri', 'yuri@gmail.com', '0889123456', 'Administrator');

select Username, Name, convert (varchar(100),Date_Birth, 103) as Date_Birth, Address,  Email, Phone from Staff;


insert into Classes values ('Lop 01', '02-05-2022', '11-11-2022', 'teacher01', 1, '2-4-6', '17:0:0', '20:0:0');
insert into Classes values ('Lop 02', '02-05-2022', '01-11-2023', 'teacher01', 2, '2-4-6', '13:0:0', '16:0:0');
insert into Classes values ('Lop 03', '07-05-2022', '12-11-2022', 'teacher02', 3, '3-5-7', '17:0:0', '20:0:0');
insert into Classes values ('', '01-01-2002', '02-01-2002', '', 4, '3-5-7', '0:0:0', '1:0:0');

select ID, Name, convert (varchar(100),Start_Date, 103) as Start_Date, convert (varchar(100),End_Date, 103) as End_Date, Username,
Course_ID, WeekDays, convert (varchar(100),Start_Time, 108) as Start_Time, convert (varchar(100),End_Time, 108) as End_Time from Classes


insert into Class_Students values (1, 'student01');
insert into Class_Students values (2, 'student01');
insert into Class_Students values (1, 'student02');
insert into Class_Students values (3, 'student02');
insert into Class_Students values (4, '');

select * from Class_Students;


insert into Payment_Methods values ('Mobile Banking');
insert into Payment_Methods values ('Cast');
insert into Payment_Methods values ('Visa');
insert into Payment_Methods values ('');

select * from Payment_Methods;


insert into Payments values ('02-03-2022',5000000,2,1,'student01');
insert into Payments values ('02-04-2022',7000000,3,1,'student01');
insert into Payments values ('02-05-2022',5000000,1,1,'student02');
insert into Payments values ('07-01-2022',10000000,1,1,'student02');
insert into Payments values ('01-01-2002',0,4,0,'');

select ID, Username, convert (varchar(100),Payment_Date, 103) as Payment_Date, Amount, Payment_Method_ID, Status from Payments;

-----------------------------------------------------------------