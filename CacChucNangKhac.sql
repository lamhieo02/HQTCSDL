
use LanguageCenter
go

-- FindClass By Name
create procedure dbo.FindClassByName(@classname nvarchar(100))
as 
	(select * from Classes where lower(Name) = lower(@classname));
go

-- FindList Class by CourseName | note: select (cl.*) -> only select fields from table Class
create function dbo.FindClassesByCName(@courseName nvarchar(40))
returns table
as
	return (select cl.* from Classes cl inner join Courses c on cl.Course_ID = c.ID where lower(c.Name) = lower(@courseName) );
go

-- FindCourse By Range Price (a-b)
create function dbo.FindCourseByPrice(@lowerBound int,  @upperBound int)
returns table
as
	return (select * from Courses where Price >= @lowerBound and Price <= @upperBound);
go

-- FindTeacher By Name
create procedure dbo.FindTeacherName(@teacherName nvarchar(50))
as
	select * from Teachers where lower(Name) = lower(@teacherName)
go	