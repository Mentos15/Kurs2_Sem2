use Ermakovich_UNIVER

create table STUDENT(
�����_������� int NOT NULL primary key,
�������_�������� nvarchar(30) not null,
�����_������ int not null
);


alter table STUDENT add ����_����������� date;

alter table STUDENT drop column ����_�����������;

insert into STUDENT (�����_�������,�������_��������,�����_������)
	VALUES(2753,'�������',8),
		  (3629,'������',2),
		  (8423,'������������', 4),
		  (1212,'��������',8);


create table RESULTS(
ID int primary key identity(1,1),
student_name nvarchar(30) not null,
matematika int not null,
programming int not null,
fizra int not null,
aver_value as (matematika+programming+fizra)/3.0
);

insert into RESULTS(student_name,matematika,programming,fizra)
	values('Artem',4,6,7),
		  ('Dima',8,9,9),
		  ('vova',5,9,7);
 