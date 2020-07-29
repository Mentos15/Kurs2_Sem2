--Task 1
select * from STUDENT
select * from GROUPS

go
create function COUNT_STUDENTS(@faculti varchar(20)) returns int 
as begin declare @rc int = 0;
set @rc = (select count(IDSTUDENT) from STUDENT s join GROUPS g on s.IDGROUP =g.IDGROUP where g.FACULTY = @faculti ) ;
return @rc;
end;
go

declare @faculti int = dbo.COUNT_STUDENTS('ИДиП');
print 'Количество студентов = '+ cast (@faculti as varchar(4))


--Task 2



go
create FUNCTION FSUBJECTS(@p varchar(20)) returns varchar(300) 
     as
     begin  
     declare @tv char(20);  
     declare @t varchar(300) = 'Предметы на кафедре: ';  
     declare ZkTovar CURSOR LOCAL 
     for select SUBJECT from SUBJECT where PULPIT = @p;
     open ZkTovar;	  
     fetch  ZkTovar into @tv;   	 
     while @@fetch_status = 0                                     
     begin 
         set @t = @t + ', ' + rtrim(@tv);         
         FETCH  ZkTovar into @tv; 
     end;    
     return @t;
     end;  
	 go

select PULPIT,  dbo.FSUBJECTS(PULPIT)  from PULPIT;
select * from SUBJECT


--Task 3

select * from FACULTY
select * from PULPIT
go
create function FFACPUL(@f varchar(50), @c varchar(50)) returns table
as return 
select f.FACULTY,c.PULPIT from FACULTY f left outer join PULPIT c  on f.FACULTY = c.FACULTY
where f.FACULTY = ISNULL(@f,f.FACULTY) and c.PULPIT= ISNULL(@c, c.PULPIT);
go

select * from dbo.FFACPUL(NULL,NULL);
select * from dbo.FFACPUL('ИДиП',NULL);
select * from dbo.FFACPUL(NULL,'ЛМиЛЗ');

select * from dbo.FFACPUL('ИДиП','БФ');

--Task 4

select * from TEACHER

go
create function FCTEACHER(@p varchar(50)) returns int 
as begin
declare @rc int = (select count(*) from TEACHER where PULPIT = ISNULL(@p, PULPIT));
return @rc;
end;
go

select PULPIT,dbo.FCTEACHER(PULPIT)[Количество преподавателей] from PULPIT

--Task 5 
go
  create function FACULTY_REPORT(@c int) returns @fr table
  ( [Факультет] varchar(50), [Количество кафедр] int, [Количество групп]  int, 
	                                                                 [Количество студентов] int, [Количество специальностей] int )
	as begin declare cc CURSOR static for select FACULTY from FACULTY 
	where dbo.COUNT_STUDENTS(FACULTY) > @c; 
	       declare @f varchar(30);
	       open cc;  
                 fetch cc into @f;
	       while @@fetch_status = 0
	       begin
	            insert @fr values( @f,  (select count(PULPIT) from PULPIT where FACULTY = @f),
	            (select count(IDGROUP) from GROUPS where FACULTY = @f),   dbo.COUNT_STUDENTS(@f),
	            (select count(PROFESSION) from PROFESSION where FACULTY = @f)   ); 
	            fetch cc into @f;  
	       end;   
                 return; 
	end;
	go



select * from dbo.FACULTY_REPORT(25) 