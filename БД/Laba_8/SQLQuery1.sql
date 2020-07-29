
--Task 1 
create view [Преподаватель]
as select TEACHER[Код],
TEACHER_NAME[Имя_Преподавателя],
PULPIT[Пол],
GENDER[Кафедры]
from TEACHER

--Task 2 не понял как количество вывести
create view[Количество_кафедр]
as select  FACULTY_NAME[Факультет],
(select count(*) from PULPIT where FACULTY.FACULTY = PULPIT.FACULTY)[Количество_кафедр]
from FACULTY join PULPIT on  FACULTY.FACULTY = PULPIT.FACULTY

--Task 3 в наименовании аудитории цифры а не текст втф?

	create view[Аудитории2]
	as select AUDITORIUM.AUDITORIUM[Код],
	AUDITORIUM_TYPE.AUDITORIUM_TYPENAME[Наименование_аудитории]
	from AUDITORIUM join AUDITORIUM_TYPE on AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
	where AUDITORIUM_TYPE.AUDITORIUM_TYPE like 'ЛК%'

--Task 4 
create view[Лекционные_аудитории2]
as select AUDITORIUM.AUDITORIUM[Код],
AUDITORIUM_TYPE.AUDITORIUM_TYPENAME[Наименование_аудитории]
from AUDITORIUM join AUDITORIUM_TYPE on AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
where AUDITORIUM.AUDITORIUM_TYPE like 'ЛК%' with check option

go
insert Лекционные_аудитории2 values (236-1,'ЛК')
--Task 5
create view [Дисциплины]
as select TOP 10 SUBJECT.SUBJECT[Код],
SUBJECT.SUBJECT_NAME[Наименование_дисциплины],
SUBJECT.PULPIT[Код_кафедры]
from SUBJECT order by SUBJECT_NAME

--Task 6 хз что от меня хотят
alter view [Количество_кафедр] with schemabinding
as select 