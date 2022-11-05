create database LanguageCenter
go
use LanguageCenter
go

-- Step to create schema
-- Category
create table Categories(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(20) not null
);
go


insert into Categories values('category 1');
insert into Categories values('category 2');
insert into Categories values('category 3');
insert into Categories values('category 4');


-- Language
create table Levels(
	ID int IDENTITY(1,1) primary key,
	Code char(2),
	Name nvarchar(20) not null
);
go

insert into Levels values('L1','basic');
insert into Levels values('L2','intermediate');
insert into Levels values('L3','advance');

-- Level
create table Languages(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(20) not null
);
go

insert into Languages values('English');

-- Course
create table Courses(
	ID int IDENTITY(1,1) primary key,
	Lessons int not null,
	Description nvarchar(100),
	Term nvarchar(100),
	Language_ID int,
	Level_ID int,
	Category_ID int,
	foreign key(Language_ID) references Languages(ID),
	foreign key(Level_ID) references Levels(ID),
	foreign key(Category_ID) references Categories(ID)
);
go

insert into Courses values(1,'description','term',1,1,1);
insert into Courses values(2,'description','term',1,1,1);
insert into Courses values(3,'description','term',1,1,1);
insert into Courses values(4,'description','term',1,1,1);

-- Accounts
create table Accounts (
	ID int IDENTITY(1,1) primary key not null,
	Username varchar(100) unique not null,
	Password varchar(100),
	Is_Active bit not null,
	Activestatus nvarchar(50),
	roleID int
);
go
--select * from Accounts where Accounts.Username = 'hocsinh1'

/*drop table Students
drop table Teachers
drop table Staff

select Accounts.roleID from Accounts where Accounts.Username = 'hocsinh1'*/

insert into Accounts values('hocsinh1','Mtl@91202',1,'',3);
insert into Accounts values('hocsinh2','Mtl@91202',0,'',3);
insert into Accounts values('teacher1','Mtl@91202',0,'',4);
insert into Accounts values('teacher2','Mtl@91202',1,'',4);
insert into Accounts values('admin1','Mtl@91202',1,'',1);
insert into Accounts values('admin2','Mtl@91202',0,'',1);
insert into Accounts values('Staff1','Mtl@91202',0,'',2);
insert into Accounts values('Staff2','Mtl@91202',0,'',2);

-- Student 
create table Students(
	ID int IDENTITY(1,1) primary key,
	Username varchar(100) unique not null,
	Date_Birth date,
	Address nvarchar(100) not null,
	First_Name nvarchar(50) not null,
	Last_Name nvarchar(50) not null,
	Email varchar(50) unique not null,
	Phone varchar(15) unique not null,
	check(10 <= len(Phone) and len(Phone) <= 11),
	foreign key(Username) references Accounts(Username)
);
go 

insert into Students values('hocsinh1','01-31-2002','1 vo van ngan','huong','pham','qhuong123@gmail.com','1234567890');
insert into Students values('hocsinh2','02-14-2002','1 vo van ngan','Linh','Tran','linhtran43@gmail.com','1234567490');

--select * from Students where Students.Username = 'hocsinh1'
-- Teacher
create table Teachers(
	ID int IDENTITY(1,1) primary key,
	Username varchar(100) unique not null,
	Date_Birth date,
	Address nvarchar(100) not null,
	First_Name nvarchar(50) not null,
	Last_Name nvarchar(50) not null,
	Email varchar(50) unique not null,
	Phone varchar(15) unique not null,
	check(10 <= len(Phone) and len(Phone) <= 11),
	foreign key(Username) references Accounts(Username)
);
go

insert into Teachers values('teacher1','02-02-1987','12 Nguyen Dinh Chieu','Nam','Pham Hoang','namph123@gmail.com','1234567890');
insert into Teachers values('teacher2','03-03-1977','210 Luong The Vinh','Truc','Nguyen Nha','trucnguyen45@gmail.com','1244567890');


-- Staff 
create table Staff(
	ID int IDENTITY(1,1) primary key,
	Username varchar(100) unique not null,
	Position nvarchar(50) not null,
	Date_Birth date,
	Address nvarchar(100) not null,
	First_Name nvarchar(50) not null,
	Last_Name nvarchar(50) not null,
	Email varchar(50) unique not null,
	Phone varchar(15) unique not null,
	check(10 <= len(Phone) and len(Phone) <= 11),
	foreign key(Username) references Accounts(Username)
);
go
insert into Staff values('Staff1','lau cong','01-12-2000','345 Tran Dai Nghia','Lien','Nguyen','liennguyen123@gmail.com','1234567890');
insert into Staff values('Staff2','bao ve','07-15-1999','345 Le Loi','Hoang','Tran','tranhoang123@gmail.com','1234566890');

insert into Staff values('admin1','quan tri vien','09-19-2002','10 Nguyen An Ninh','Linh','Chu Khanh','linhck54@gmail.com','1234543890');
insert into Staff values('admin2','quan tri vien','06-01-2002','67 Nguyen Luong Bang','Long','Nguyen','longnguyen123@gmail.com','1234555890');

-- Class
create table Classes(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(100) not null,
	Start_Date date not null,
	End_Date date not null,
	Price money not null check (Price >= 0),
	Teacher_ID int,
	Course_ID int,
	foreign key(Teacher_ID) references Teachers(ID),
	foreign key(Course_ID) references Courses(ID)
);
go

insert into Classes values('IELTS 01','01-01-2020','03-03-2020',5000000,1,1);
insert into Classes values('IELTS 02','01-01-2020','03-03-2020',5000000,1,2);
insert into Classes values('IELTS 03','01-01-2020','03-03-2020',5000000,2,3);
insert into Classes values('IELTS 04','01-01-2020','03-03-2020',5000000,2,4);


-- Class_student
create table Class_Students(
	ID int IDENTITY(1,1) primary key,
	Class_ID int,
	Student_ID int,
	foreign key(Class_ID) references Classes(ID),
	foreign key(Student_ID) references Students(ID)
);
go

insert into Class_Students values(1,1);
insert into Class_Students values(1,2);

-- Weekday
create table Weekdays(
	ID int IDENTITY(1,1) primary key,
	Name varchar(100)
);
go

insert into Weekdays values('Monday');
insert into Weekdays values('Tuesday');
insert into Weekdays values('Wednesday');
insert into Weekdays values('Thursday');
insert into Weekdays values('Friday');
insert into Weekdays values('Saturday');
insert into Weekdays values('Sunday');

-- Class_weekday
create table Class_Weekdays(
	Class_ID int,
	Course_ID int,
	Weekday_ID int,
	Hours int not null check(Hours >= 0 and Hours <= 168),
	foreign key(Class_ID) references Classes(ID),
	foreign key(Weekday_ID) references Weekdays(ID),
	foreign key(Course_ID) references Courses(ID)
);
go 

insert into Class_Weekdays values(1,1,1,1);
insert into Class_Weekdays values(1,2,2,2);
insert into Class_Weekdays values(1,3,3,3);
insert into Class_Weekdays values(2,4,4,4);
insert into Class_Weekdays values(2,1,5,5);
insert into Class_Weekdays values(2,2,6,6);

-- Payment_method
create table Payment_Methods(
	ID int IDENTITY(1,1) primary key,
	Name nvarchar(100) not null
);
go
insert into Payment_Methods values('Unpaid');
insert into Payment_Methods values('Banking');
insert into Payment_Methods values('Cash');
-- Payment
create table Payments(
	ID int IDENTITY(1,1) primary key,
	Payment_Date datetime not null,
	Amount money not null check(Amount >= 0),
	Payment_Method_ID int,
	Status bit not null,
	Paymentstatus nvarchar(50),
	Student_ID int,
	Class_ID int,
	foreign key(Payment_Method_ID) references Payment_Methods(ID),
	foreign key(Student_ID) references Students(ID),
	foreign key(Class_ID) references Classes(ID)
);
go
--kịch bản 
--tạo một trigger mỗi khi insert một Student_account ta tự động insert một row Payments với các giá trị mặc định
--khi một student thực hiện thanh toán ta update row đó 

insert into Payments values('02-01-2020',5000000,3,1,'',1,1);
insert into Payments values('03-01-2020',6000000,1,0,'',2,1);

--CONSTRAINTS:
-- ràng buộc check password phải có chữ hoa, chữ thường, số, một vài loại kí tự đặc biệt và hơn 7 ký tự
alter table Accounts add constraint CheckPassword_Accounts check (Password like '%[0-9]%' 
and Password like '%[A-Z]%' collate Latin1_General_BIN2
and Password like '%[!@#$%^&*()-_+=.,;:~]%' and len(Password)>7);

--ràng buộc mount và price phải >=0
alter table Payments add constraint checkPayment check (Amount >= 0);
alter table Classes add constraint checkPriceClasses check (Price >= 0);

-- ràng buộc check email đúng format và không chứa một vài ký tự đặc biệt
alter table Students add constraint checkEmailStudent check (Email like '%_@__%.__%'and Email not like '% %'
and PATINDEX('%[^a-z,0-9,@,.,]%', Email) = 0);

alter table Staff add constraint checkEmailStaff check (Email like '%_@__%.__%'and Email not like '% %'
and PATINDEX('%[^a-z,0-9,@,.,]%', Email) = 0);

alter table Teachers add constraint checkEmailTeacher check (Email like '%_@__%.__%'and Email not like '% %'
and PATINDEX('%[^a-z,0-9,@,.,]%', Email) = 0);




-- check tên và vị trí 
alter table Languages add constraint checkNameLanguage check (PATINDEX('%[^a-z, ]%', Name) = 0);
alter table Payment_Methods add constraint checkNamePaymentMethods check (PATINDEX('%[^a-z, ]%', Name) = 0);
alter table Students add constraint checkNameStudents check ((PATINDEX('%[^a-z, ]%', First_Name) = 0) and (PATINDEX('%[^a-z, ]%', Last_Name) = 0));
alter table Teachers add constraint checkNameTeacher check ((PATINDEX('%[^a-z, ]%', First_Name) = 0) and (PATINDEX('%[^a-z, ]%', Last_Name) = 0));
alter table Staff add constraint checkNameStaff check ((PATINDEX('%[^a-z, ]%', First_Name) = 0) and (PATINDEX('%[^a-z, ]%', Last_Name) = 0));
alter table Staff add constraint checkStaffPosition check (PATINDEX('%[^a-z, ]%', Position) = 0);
alter table Weekdays add constraint checkDayName check (name like 'Monday' or name like 'Tuesday' or name like 'Wednesday' or name like 'Thursday' or name like 'Friday'
or name like 'Saturday' or name like 'Sunday');


-- check ngày hoàn thành khóa học phải sau này bắt đầu 
alter table Classes add constraint checkDayStartEnd check (Start_Date < End_Date);

go

--TRIGGERS:
-- tạo thêm cột kiểu nvarchar để ghi rõ is_activated và trigger tự động ghi tình trạng với bit 0 và 1, tạo trước khi chạy trigger!
create trigger checkActive on Accounts
after insert as
begin
update Accounts
set Activestatus= 'Đã kích hoạt' where Is_Active=1
update Staff_Accounts
set Activestatus= 'Chưa kích hoạt' where Is_Active=0
end
go


-- check trạng thái thanh toán học phí, tạo cột PaymentStatus trước khi chạy trigger
create trigger CheckPaymentStatus on Payments
after insert as
begin
update Payments
set PaymentStatus= 'Đã thanh toán' where Status=1
update Payments
set PaymentStatus= 'Chưa thanh toán' where Status=0
end
go


-- VIEWS:
-- thông tin cá nhân của nhân viên
create view AllOf_Staff as
select Staff.ID, Staff.First_Name, Staff.Last_Name, Staff.Date_Birth, Staff.Address, Staff.Position, Staff.Email, Staff.Phone, Staff.Username, 
Accounts.Password, Accounts.Activestatus from Staff inner join Accounts on Staff.Username = Accounts.Username
go


-- thông tin cá nhân của giáo viên
create view AllOf_Teacher as
select Teachers.ID, Teachers.First_Name, Teachers.Last_Name,Teachers.Date_Birth, Teachers.Address, Teachers.Email, Teachers.Phone, Teachers.Username, 
Accounts.Password, Accounts.Activestatus from Teachers inner join Accounts on Teachers.Username = Accounts.Username
go

-- thông tin cá nhân của học viên
create view AllOf_Student as
select Students.ID, Students.First_Name, Students.Last_Name,Students.Date_Birth,Students.Address, Students.Email, Students.Phone, 
Accounts.Activestatus, Students.Username, Accounts.Password, Classes.Name as ClassName from
Students inner join Accounts on Students.Username=Accounts.Username inner join Class_Students on Class_Students.Student_ID = Students.ID
inner join Classes on Classes.ID=Class_Students.Class_ID
go


-- thông tin học phí của học viên
create view AllOf_PAYMENT as
select Students.ID, Students.First_Name, Students.Last_Name, Students.Date_Birth, Students.Address, Students.Email, Students.Phone, 
Payments.PaymentStatus, Payments.Amount, Payments.Payment_Date, Payment_Methods.Name as PaymentMethod, Classes.Name as ClassName
from
Students inner join Payments on Students.ID=Payments.Student_ID inner join Payment_Methods on Payment_Methods.ID = Payments.Payment_Method_ID
inner join Classes on Classes.ID=Payments.Class_ID
go


-- thông tin các lớp học
create view AllOf_Class as
select Classes.ID, Classes.Name as ClassName, Classes.Start_Date, Classes.End_Date, Classes.Price,
Courses.Lessons, Courses.Description, Courses.Term, Languages.Name as LanguageName, Levels.Name as LevelName, Categories.Name as CategoryName
from
Classes inner join Courses on Classes.Course_ID=Courses.ID inner join Languages on Languages.ID = Courses.Language_ID inner join Levels on Levels.ID=Courses.Level_ID
inner join Categories on Categories.ID=Courses.Category_ID
go

-- PROCEDURES:
--_ tìm kiếm các khóa học dựa vào id ngôn ngữ
CREATE PROCEDURE TIMKIEM_KHOAHOC_LanguageID @id_nn int
as
select Courses.Lessons, Courses.Description, Courses.Term, Courses.Level_ID, Courses.Category_ID
from Courses where language_id=@id_nn;

--drop procedure TIMKIEM_KHOAHOC_LanguageID

--exec TIMKIEM_KHOAHOC_LanguageID 1;
go
--_ tìm kiếm thông tin nhân viên và tài khoản dựa vào id 
CREATE PROCEDURE TIMKIEM_NHANVIEN_ID @idnv int
as
select Staff.First_Name, Staff.Last_Name, Staff.Date_Birth, Staff.Address, Staff.Position, Staff.Email, Staff.Phone, Staff.Username, 
Accounts.Password, Accounts.Activestatus from Staff inner join Accounts on Staff.Username=Accounts.Username
go
--exec TIMKIEM_NHANVIEN_ID 1;

--_ tìm kiếm thông tin nhân viên dựa vào vị trí 
CREATE PROCEDURE TIMKIEM_NHANVIEN_POSITION @vitri nvarchar(50)
as
select Staff.ID, Staff.First_Name, Staff.Last_Name, Staff.Date_Birth, Staff.Address, Staff.Email, Staff.Phone, Staff.Username, Accounts.Password, Accounts.Activestatus
from Staff inner join Accounts on Staff.Username=Accounts.Username
where Position=@vitri;
go
--exec TIMKIEM_NHANVIEN_POSITION 'le tan';

--_ tìm kiếm thông tin giáo viên và tài khoản dựa vào id 
CREATE PROCEDURE TIMKIEM_GIAOVIEN_ID @idgv int
as
select Teachers.First_Name, Teachers.Last_Name, Teachers.Date_Birth, Teachers.Address, Teachers.Email, Teachers.Phone, Teachers.Username,
Accounts.Password, Accounts.Activestatus from Teachers inner join Accounts on Teachers.Username=Accounts.Username
where Teachers.ID=@idgv;
go
--exec TIMKIEM_GIAOVIEN_ID 1;

--_ tìm kiếm thông tin cá nhân, tài khoản, lớp học và tên giáo viên của học viên dựa vào id
CREATE PROCEDURE TIMKIEM_HOCVIEN_ID @idhv int
as
select Students.First_Name as Student_First_Name, Students.Last_Name as Student_Last_Name, Students.Date_Birth, Students.Address, Students.Email, 
Students.Phone, Accounts.Activestatus, Students.Username, Accounts.Password, Classes.Name as Class_Name, Teachers.First_Name as Teacher_First_Name, Teachers.Last_Name as Teacher_Last_Name
from Students inner join Accounts on Students.Username = Accounts.Username
inner join Class_Students on Class_Students.Student_ID=Students.ID inner join Classes on Class_Students.ID= Classes.ID
inner join Teachers on Teachers.ID = Classes.Teacher_ID
where Students.ID=@idhv;
go
--exec TIMKIEM_HOCVIEN_ID 1;

--_ tìm kiếm thông tin cá nhân, tài khoản, lớp học và tên giáo viên của học viên dựa vào tên học viên
CREATE PROCEDURE TIMKIEM_HOCVIEN_NAME @firstname nvarchar(50), @lastname nvarchar(50)
as
select Students.ID, Students.Date_Birth, Students.Address, Students.Email, 
Students.Phone, Accounts.Activestatus, Students.Username, Accounts.Password, Classes.Name as Class_Name, Teachers.First_Name as Teacher_First_Name, Teachers.Last_Name as Teacher_Last_Name
from Students inner join Accounts on Students.Username = Accounts.Username
inner join Class_Students on Class_Students.Student_ID=Students.ID inner join Classes on Class_Students.ID= Classes.ID
inner join Teachers on Teachers.ID = Classes.Teacher_ID
where Students.First_Name=@firstname and Students.Last_Name=@lastname;
go

--exec TIMKIEM_HOCVIEN_NAME 'le', 'minh tuong';

--_ kiểm tra thông tin thanh toán học phí của học viên dự vào id
CREATE PROCEDURE CHECKHOCPHI_ID @idhv int
as
select Students.First_Name as Student_FirstName, Students.Last_Name as Student_LastName, Students.Date_Birth, Students.Address, Students.Email,
Students.Phone, PaymentStatus, Amount, Payment_Date, Payment_Methods.Name as PaymentMethod
from Students inner join Payments on Students.ID = Payments.Student_ID inner join Payment_Methods on Payments.Payment_Method_ID= Payment_Methods.ID
where Students.ID=@idhv
go

--exec CHECKHOCPHI_ID 1

--_ kiểm tra thông tin thanh toán học phí của học viên dự vào tên học viên
CREATE PROCEDURE CHECKHOCPHI_NAME @firstname nvarchar(50), @lastname nvarchar(50)
as
select Students.ID, Students.Date_Birth, Students.Address, Students.Email,Students.Phone, PaymentStatus, Amount, Payment_Date, Payment_Methods.Name as PaymentMethod
from Students inner join Payments on Students.ID = Payments.Student_ID inner join Payment_Methods on Payments.Payment_Method_ID= Payment_Methods.ID
where Students.First_Name=@firstname and Students.Last_Name=@lastname;
go
--exec CHECKHOCPHI_NAME 'le', 'minh tuong';

--FUNCTIONS:
--_ kiểm tra tình trạng lớp học đã bắt đầu, đang, hay đã kết thúc
create function FNC_CHECKDATE_CLASSES(@startdate as date, @enddate as date)
returns nvarchar(100)
as begin
declare @result as nvarchar(100) = ''
declare @nowdate as date = getdate()

if @enddate < @nowdate
set @result = 'Da ket thuc khoa hoc'
else if @enddate > @nowdate and @startdate < @nowdate
set @result = 'Dang mo khoa hoc'
else
set @result = 'Chua bat dau khoa hoc'
return @result
end
go

/*select Teachers.ID, name, price, Teachers.First_Name as Teacher_FirstName, Teachers.Last_Name as Teacher_LastName , dbo.FNC_CHECKDATE_CLASSES(Classes.Start_Date, Classes.End_Date) Status
from Classes inner join Teachers on Teachers.ID=Classes.Teacher_ID;*/

-- _ tính lương giáo viên theo stt level, stt category (Lương = 1 củ * id_cate * id_level)
create function FNC_LUONG_GV (@id_cate as int, @id_level as int )
returns int
as begin
declare @salary as int
set @salary = 1000000*@id_cate*@id_level
return @salary
end;
go

/*select teachers.id, teachers.First_Name, teachers.Last_Name, Teachers.Email, Teachers.Phone,SUM(dbo.FNC_LUONG_GV(Categories.ID, Levels.ID)) SALARY
from 
Teachers inner join Classes on Teachers.id=Classes.teacher_id
inner join Courses on Classes.course_id = Courses.id
inner join Levels on Levels.id=Courses.level_id inner join
Categories on Categories.id=Courses.category_id
group by teachers.id, teachers.First_Name, teachers.Last_Name, Teachers.Email, Teachers.Phone*/

/*_ tính lương nhân viên theo từng vai trò (marketing, HR, sales, training, receptionist, guard, cleaning*/
create function FNC_LUONG_NHANVIEN(@vitri as nvarchar(50))
returns int
as begin
declare @luong as int
declare @base as int = 1000000
if @vitri = 'marketing' set @luong = @base * 6
else if @vitri = 'HR' set @luong = @base * 5.5
else if @vitri = 'sales' set @luong = @base * 7
else if @vitri = 'training' set @luong = @base * 6.5
else if @vitri = 'receptionist' set @luong = @base * 3.5
else if @vitri = 'guard' set @luong = @base * 3
else set @luong = @base * 3
return @luong
end
go
--select *, dbo.FNC_LUONG_NHANVIEN(position) SALARY from Staff;


-- *** updated 9/10/2022 ***

-- ==== FUNCTIONS ====
create function TeacherNameByID (@id int)
returns nvarchar(100)
as
begin
declare @name nvarchar(100)
set @name = (select concat(Teachers.First_Name,' ',Teachers.Last_Name) 
			from Teachers where Teachers.ID = @id)
return @name
end

go
create function ClassNameByID (@id int)
returns nvarchar(100)
as begin
declare @name nvarchar(100)
set @name = (select Classes.Name from Classes where Classes.ID = @id)
return @name
end
go
--select [dbo].ClassNameByID(1)


-- ==== PROCEDURES ====
--Lấy danh sách học sinh trong một lớp
create procedure getStudents_byClassID @id int
as 
select Class_Students.Class_ID, Classes.Name as 'Class name',Student_ID, concat(Students.First_Name,' ',Students.Last_Name) as 'Student name'
from Students inner join (Class_Students inner join Classes on Class_Students.Class_ID = Classes.ID)
on Students.ID = Class_Students.ID
where Classes.ID = @id
go
--exec getStudents_byClassID 1

--Lấy thời khóa biểu theo lớp
create procedure getThoiKhoaBieu_byClassID @class_id int
as
select Classes.ID as 'Class ID', Classes.Name as 'Class Name', [dbo].TeacherNameByID(Classes.Teacher_ID) as 'Teacher Name', Weekdays.Name, Class_Weekdays.Hours
from Classes inner join (Class_Weekdays inner join Weekdays on Class_Weekdays.Weekday_ID = Weekdays.ID)
on Classes.ID = Class_Weekdays.Class_ID
where Class_ID = @class_id
go
exec getThoiKhoaBieu_byClassID 2

go
/*
-- Đoạn này không chạy nè :v
create procedure getStudentsPayment_byClassID @class_id int
as
with new_table as (select Payments.Status,Payments.Paymentstatus, Students.ID as 'Student ID', 
	   [dbo].ClassNameByID(1) as 'Class Name',
	   concat(Students.First_Name,' ',Students.Last_Name) as 'Name',
	   Students.Address, Students.Email, Students.Phone,
	   ROW_NUMBER() over (partition by Students.ID order by Students.ID) row_num
from Payments inner join Class_Students on Payments.Class_ID = Class_Students.Class_ID
			  inner join Students on Class_Students.Student_ID = Students.ID
			  inner join Accounts on Accounts.Username = Students.Username
where Class_Students.Class_ID = 1 )
delete from new_table where row_num >1
go

exec getStudentsPayment_byClassID 3

go
----------------------------------
*/

select Payments.Status,Payments.Paymentstatus, Students.ID as 'Student ID', 
	   [dbo].ClassNameByID(1) as 'Class Name',
	   concat(Students.First_Name,' ',Students.Last_Name) as 'Name',
	   Students.Address, Students.Email, Students.Phone
from Payments inner join Class_Students on Payments.Class_ID = Class_Students.Class_ID
			  inner join Students on Class_Students.Student_ID = Students.ID
where Class_Students.Class_ID = 1
group by Payments.Status,Payments.Paymentstatus,Students.ID,Students.First_Name, Students.Last_Name,
		 Students.Address, Students.Email, Students.Phone, Class_Students.Student_ID,Payments.Class_ID,
		 Class_Students.Class_ID
having count(Students.ID) > 1
