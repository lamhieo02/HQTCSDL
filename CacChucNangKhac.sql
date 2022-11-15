
use LanguageCenter3
go

-- Search List Class by CourseName | note: select (cl.*) -> only select fields from table Class
create function dbo.SearchClassesByCName(@courseName nvarchar(40))
returns table
as
	return (select cl.* 
			from Classes cl inner join Courses c on cl.Course_ID = c.ID 
			where lower(c.Name) = lower(@courseName) );
go

-- Search Course By Range Price (a-b)
create function dbo.SearchCourseByPrice(@lowerBound int,  @upperBound int)
returns table
as
	return (select * 
			from Courses 
			where Price >= @lowerBound and Price <= @upperBound);
go

-- Search Teacher By Name
create procedure dbo.SearchTeacherName(@teacherName nvarchar(50))
as
	select * 
	from Teachers
	where lower(Name) = lower(@teacherName)
go	

-- Search Class By Name
create procedure dbo.SearchClassByName(@classname nvarchar(100))
as 
	select * 
	from Classes
	where lower(Name) = lower(@classname);
go

-- Search Info Teacher Is Teaching That Class
create procedure dbo.SearchInfoTeacherByClass (@classname nvarchar(100))
as
	select t.* 
	from Classes c inner join Teachers t on c.Username = t.Username
	where c.Name = @classname
go
