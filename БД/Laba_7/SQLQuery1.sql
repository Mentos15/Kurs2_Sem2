use UNIVER

--Task 1
select min(AUDITORIUM.AUDITORIUM_CAPACITY) [Min_size],
	   max(AUDITORIUM.AUDITORIUM_CAPACITY) [Max_size],
	   count(*)[Aud_count],
	   sum(AUDITORIUM.AUDITORIUM_CAPACITY)[All_sum_audit],
	   avg(AUDITORIUM.AUDITORIUM_CAPACITY)[Avg_size]
from AUDITORIUM

--Task 2 ������ �� AUDIT_TYPENAME?

select AUDITORIUM_TYPE,
	   min(AUDITORIUM.AUDITORIUM_CAPACITY) [�����������_������_���������],
	   max(AUDITORIUM.AUDITORIUM_CAPACITY) [������������_������_���������],
	   count(*)[����������_���������],
	   sum(AUDITORIUM.AUDITORIUM_CAPACITY)[���������_����������_����],
	   avg(AUDITORIUM.AUDITORIUM_CAPACITY)[�������_����������_����]	
from AUDITORIUM group by AUDITORIUM_TYPE

--Task 3
select *
from(select case when NOTE between 4 and 5 then '4-5'
when NOTE between 6 and 7 then '6-7'
when NOTE between 8 and 9 then '8-9'
else '10' end[�������],count(*)[����������]
from PROGRESS group by case
when NOTE between 4 and 5 then '4-5'
when NOTE between 6 and 7 then '6-7'
when NOTE between 8 and 9 then '8-9'
else '10' end) as T order by case[�������]
when '4-5' then 4
when '6-7' then 3
when '8-9' then 2
else 1 end

--Task 4 �� ��� ���������

select FACULTY.FACULTY,GROUPS.PROFESSION,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
--from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP inner join PROGRESS on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
--group by FACULTY.FACULTY,GROUPS.PROFESSION
from PROGRESS inner join STUDENT on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT inner join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP inner join FACULTY on GROUPS.FACULTY = FACULTY.FACULTY 
group by FACULTY.FACULTY,GROUPS.PROFESSION


--Task 5
use UNIVER
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '���'
group by rollup (FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE)

 --Task 6 
 use UNIVER
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '���'
group by cube(FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE)

 --Task 7 �� ��������
 use UNIVER
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '���'
group by FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE
union ALL
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '����'
group by FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE

 --Task 8 
 use UNIVER
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '���'
group by FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE
intersect
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '����'
group by FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE

 --Task 9 
 use UNIVER
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '���'
group by FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE
except
select FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,round(avg(cast(PROGRESS.NOTE as float(4))),2)[�������_�������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where FACULTY.FACULTY = '����'
group by FACULTY.FACULTY,GROUPS.PROFESSION,PROGRESS.SUBJECT,PROGRESS.NOTE

--Task 10

select p1.SUBJECT,p1.NOTE,
(select count(*) from PROGRESS p2 where p2.SUBJECT = p1.SUBJECT and p2.NOTE = p1.NOTE)[����������]
from PROGRESS p1
group by p1.SUBJECT,p1.NOTE
having NOTE between 8 and 9