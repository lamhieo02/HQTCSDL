
-- Add Course

create procedure AddCourse @name nvarchar(40), @target float, @no_Lessons int, @price int
as 
	insert into Courses values(@name, @target, @no_Lessons, @price)
go

-- Update Course

create procedure UpdateCourse @id int, @name nvarchar(40), @target float, @no_lessons int, @price int
as
	update Courses set Name = @name, Target = @target, No_Lessons = @no_lessons, Price = @price where ID = @id
go

-- Search Course By Id
create procedure SearchCourseByID @id int
as
	select * from Courses where ID = @id
go

-- Add Teacher 
create procedure AddTeacher @username varchar(100), @date_Birth date, @address nvarchar(100),
@name nvarchar(50), @email varchar(50), @phone varchar(11)
as
	insert into Teachers values(@username, @date_Birth, @address, @name, @email, @phone)
go

-- Update Teacher
create procedure UpdateTeacher @username varchar(100), @date_Birth date, @address nvarchar(100),
@name nvarchar(50), @email varchar(50), @phone varchar(11)
as
	update Teachers set Date_Birth = @date_Birth, Address = @address, Name = @name, Email = @email,
	Phone = @phone where Username = @username
go

-- Search Teacher By Username
create procedure SearchTeacherByUsername @username varchar(100)
as 
	select * from Teachers where Username = @username
go

-- Add Class
create procedure AddClass @name nvarchar(100), @start_Date date, @end_Date date, @teacher_ID varchar(100),
@course_ID int, @weekDays varchar(10), @start_Time time, @end_Time time, @classRoom varchar(20)
as
	insert into Classes values(@name, @start_Date, @end_Date, @teacher_ID, @course_ID, @weekDays,
	@start_Time, @end_Time, @classRoom, 0)
go

-- Update Class By Id
-- Không cập nhật số lượng học viên đang học trong lớp, vì số lượng học viên sẽ được cập nhật dựa theo table Class_Student
create procedure UpdateClass @id int, @name nvarchar(100), @start_Date date, @end_Date date, @teacher_ID varchar(100),
@course_ID int, @weekDays varchar(10), @start_Time time, @end_Time time
as
	update Classes set Name = @name, Start_Date = @start_Date, 
	End_Date = @end_Date, Username = @teacher_ID, Course_ID = @course_ID,WeekDays = @weekDays,
	Start_Time = @start_Time, End_Time = @end_Time where ID = @id
go

--Search Class By ID

create procedure SearchClassByID @id int
as
	select * from Classes where ID = @id
go
