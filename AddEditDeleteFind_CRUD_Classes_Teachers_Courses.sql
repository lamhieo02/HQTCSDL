
-- Add Course

create procedure AddCourse @name nvarchar(40), @target float, @no_Lessons int, @price int
as 
	insert into Courses values(@name, @target, @no_Lessons, @price)
go

-- Edit Course

create procedure EditCourse @id int, @name nvarchar(40), @target float, @no_lessons int, @price int
as
	update Courses set Name = @name, Target = @target, No_Lessons = @no_lessons, Price = @price where ID = @id
go

-- Delete Course

create procedure DeleteCourse @id int
as
	delete from Courses where ID = @id
go

-- Find Course By Id
create procedure FindCourseByID @id int
as
	select * from Courses where ID = @id
go

-- Add Teacher 
create procedure AddTeacher @username varchar(100), @date_Birth date, @address nvarchar(100),
@name nvarchar(50), @email varchar(50), @phone varchar(11)
as
	insert into Teachers values(@username, @date_Birth, @address, @name, @email, @phone)
go

-- Edit Teacher
create procedure EditTeacher @username varchar(100), @date_Birth date, @address nvarchar(100),
@name nvarchar(50), @email varchar(50), @phone varchar(11)
as
	update Teachers set Date_Birth = @date_Birth, Address = @address, Name = @name, Email = @email,
	Phone = @phone where Username = @username
go

-- Delete Teacher
create procedure DeleteTeacher @username varchar(100)
as
	delete from Teachers where Username = @username
go

-- Find Teacher By Username
create procedure FindTeacherByUsername @username varchar(100)
as 
	select * from Teachers where Username = @username
go

-- Add Class
create procedure AddClass @name nvarchar(100), @start_Date date, @end_Date date, @teacher_ID varchar(100),
@course_ID int, @weekDays varchar(10), @start_Time time, @end_Time time
as
	insert into Classes values(@name, @start_Date, @end_Date, @teacher_ID, @course_ID, @weekDays,
	@start_Time, @end_Time)
go

-- Edit Class
create procedure EditClass @id int, @name nvarchar(100), @start_Date date, @end_Date date, @teacher_ID varchar(100),
@course_ID int, @weekDays varchar(10), @start_Time time, @end_Time time
as
	update Classes set Name = @name, Start_Date = @start_Date, 
	End_Date = @end_Date, Teacher_ID = @teacher_ID, Course_ID = @course_ID,WeekDays = @weekDays,
	Start_Time = @start_Time, End_Time = @end_Time where ID = @id
go

--Delete Class

create procedure DeleteClass @id int
as
	delete from Classes where ID = @id
go

--Find Class By ID

create procedure FindClassByID @id int
as
	select * from Classes where ID = @id
go
