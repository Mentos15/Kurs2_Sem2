use Ermakovich_UNIVER

create table STUDENT2(
номер_зачетки int NOT NULL primary key,
фамилия nvarchar(30) not null,
имя nvarchar(30) not null,
отчество nvarchar(30) not null,
дата_рождения date not null,
дата_поступления date not null,
пол nvarchar(1) not null,
);

insert into STUDENT2
	values  (3214,'Пар1','Пар1','Пар1','12.02.2001','24.09.2019','м'),
			(2344,'Dev1','Dev1','Dev1','30.05.1995','18.01.2017','ж'),
			(6797,'Dev2','Dev2','Dev2','27.10.2002','18.01.2019','ж'),
			(4238,'Dev3','Dev3','Dev3','11.07.1999','30.08.2019','ж'),
			(3218,'Пар2','Пар2','Пар2','12.02.1997','24.09.2019','м');


select * from STUDENT2 where пол = 'ж' and ((DATEDIFF(day,дата_рождения,дата_поступления)/365)>=18)


