
--Task 1 
create view [�������������]
as select TEACHER[���],
TEACHER_NAME[���_�������������],
PULPIT[���],
GENDER[�������]
from TEACHER

--Task 2 �� ����� ��� ���������� �������
create view[����������_������]
as select  FACULTY_NAME[���������],
(select count(*) from PULPIT where FACULTY.FACULTY = PULPIT.FACULTY)[����������_������]
from FACULTY join PULPIT on  FACULTY.FACULTY = PULPIT.FACULTY

--Task 3 � ������������ ��������� ����� � �� ����� ���?

	create view[���������2]
	as select AUDITORIUM.AUDITORIUM[���],
	AUDITORIUM_TYPE.AUDITORIUM_TYPENAME[������������_���������]
	from AUDITORIUM join AUDITORIUM_TYPE on AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
	where AUDITORIUM_TYPE.AUDITORIUM_TYPE like '��%'

--Task 4 
create view[����������_���������2]
as select AUDITORIUM.AUDITORIUM[���],
AUDITORIUM_TYPE.AUDITORIUM_TYPENAME[������������_���������]
from AUDITORIUM join AUDITORIUM_TYPE on AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
where AUDITORIUM.AUDITORIUM_TYPE like '��%' with check option

go
insert ����������_���������2 values (236-1,'��')
--Task 5
create view [����������]
as select TOP 10 SUBJECT.SUBJECT[���],
SUBJECT.SUBJECT_NAME[������������_����������],
SUBJECT.PULPIT[���_�������]
from SUBJECT order by SUBJECT_NAME

--Task 6 �� ��� �� ���� �����
alter view [����������_������] with schemabinding
as select 