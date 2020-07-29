use Ermakovich_UNIVER

create table STUDENT(
номер_зачетки int NOT NULL primary key,
фамилия_студента nvarchar(30) not null,
номер_группы int not null
);


alter table STUDENT add дата_поступления date;

alter table STUDENT drop column дата_поступления;

insert into STUDENT (номер_зачетки,фамилия_студента,номер_группы)
	VALUES(2753,'Гурский',8),
		  (3629,'Сураго',2),
		  (8423,'Колесникович', 4),
		  (1212,'Деркович',8);


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
 