use Ermakovich_UNIVER

create table STUDENT2(
�����_������� int NOT NULL primary key,
������� nvarchar(30) not null,
��� nvarchar(30) not null,
�������� nvarchar(30) not null,
����_�������� date not null,
����_����������� date not null,
��� nvarchar(1) not null,
);

insert into STUDENT2
	values  (3214,'���1','���1','���1','12.02.2001','24.09.2019','�'),
			(2344,'Dev1','Dev1','Dev1','30.05.1995','18.01.2017','�'),
			(6797,'Dev2','Dev2','Dev2','27.10.2002','18.01.2019','�'),
			(4238,'Dev3','Dev3','Dev3','11.07.1999','30.08.2019','�'),
			(3218,'���2','���2','���2','12.02.1997','24.09.2019','�');


select * from STUDENT2 where ��� = '�' and ((DATEDIFF(day,����_��������,����_�����������)/365)>=18)


