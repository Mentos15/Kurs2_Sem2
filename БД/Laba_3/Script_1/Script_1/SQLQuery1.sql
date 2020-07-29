use Ermakovich_UNIVER


select count(*) from STUDENT;

select * from STUDENT where номер_зачетки < 3000;

select distinct top(4) номер_группы from STUDENT order by номер_группы

update STUDENT set номер_группы = 5;

select * from STUDENT;

select * from STUDENT where номер_зачетки between 2000 and 4000;

select * from STUDENT where фамилия_студента like 'Г%'

DROP table STUDENT;



