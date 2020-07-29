use UNIVER

--Task 1
select PULPIT.PULPIT_NAME 
from FACULTY,PULPIT where PULPIT.FACULTY = FACULTY.FACULTY and FACULTY.FACULTY
in (select PROFESSION.FACULTY from PROFESSION where (PROFESSION_NAME like '%технология%' or PROFESSION_NAME like '%технологии%' ) )

--Task 2
select PULPIT.PULPIT_NAME 
from FACULTY inner join PULPIT on PULPIT.FACULTY = FACULTY.FACULTY  where  FACULTY.FACULTY 
in (select PROFESSION.FACULTY from PROFESSION where (PROFESSION_NAME like '%технология%' or PROFESSION_NAME like '%технологии%' ))

--Task 3 не факт что правильно
select PULPIT.PULPIT_NAME 
from FACULTY inner join PULPIT on PULPIT.FACULTY = FACULTY.FACULTY 
inner join PROFESSION on PROFESSION.FACULTY = FACULTY.FACULTY where (PROFESSION_NAME like '%технология%' or PROFESSION_NAME like '%технологии%' )

--Task 4
--select AUDITORIUM.AUDITORIUM_CAPACITY,AUDITORIUM.AUDITORIUM_TYPE
--from AUDITORIUM a where 

--Task 5
select FACULTY.FACULTY_NAME from FACULTY where not exists (select * from PULPIT where PULPIT.FACULTY != FACULTY.FACULTY ) 


--Task 6

select top 1
(select avg(PROGRESS.NOTE) from PROGRESS where PROGRESS.SUBJECT like 'ОАиП')[ОАиП],
(select avg(PROGRESS.NOTE) from PROGRESS where PROGRESS.SUBJECT like 'БД')[БД],
(select avg(PROGRESS.NOTE) from PROGRESS where PROGRESS.SUBJECT like 'СУБД')[СУБД]
from PROGRESS

--Task 7
select