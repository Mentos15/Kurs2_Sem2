use UNIVER

declare @i int,
		@b varchar(4) = 'БГТУ',
		@c datetime = getdate(),
		@d char(1) = 'A';


--Task 2 and 5
use UNIVER
declare @x1 numeric(18,0) = (select cast(sum(AUDITORIUM.AUDITORIUM_CAPACITY) as numeric(18,0)) from AUDITORIUM),@x2 real,
@x3 numeric, @x4 numeric, @x5 numeric

if @x1 >200
begin 
select @x2 = (select count(*) from AUDITORIUM), @x3 = (select cast(AVG(AUDITORIUM_CAPACITY)as numeric (18,0))from AUDITORIUM)
set @x4 = (select count(*) from AUDITORIUM where AUDITORIUM_CAPACITY < @x3)
select @x2 'Количество аудиторий', @x3 'Средняя вместимость', @x4 'Количество аудиторий которые меньше средней'
end
else  print'Вместимость всех аудиторий ='+str(@x1)

--Task 3

select @@ROWCOUNT as [Строк добавлено]
select @@VERSION  as [Весрия SQl]
select @@SPID  as [Системный идентификатор процесса]
select @@ERROR  as [Код последней ошибки]
select @@SERVERNAME  as [Имя сервера]
select @@TRANCOUNT as [Уровень сложности транзакции]
select @@FETCH_STATUS  as [Результата считывания строк резуль-тирующего набора]
select @@NESTLEVEL as [Уровень вложенности текущей процедуры]

--Task 4

declare @t int = 1, @x int = 2, @z float;
if(@t > @x) set @z = power(sin(@t),2)
else if(@t < @x) set @z = 4*(@t+@x)
else set @z = 1- exp(@x-2)
print @z

DECLARE @age INT, @date DATETIME = GETDATE();
SELECT *, CAST((DATEDIFF(day, STUDENT.BDAY, @date)/365.25) AS INT) FROM STUDENT
 WHERE MONTH(STUDENT.BDAY) - MONTH(@date) = 1

DECLARE @group INT = 4;
SELECT * FROM PROGRESS
 INNER JOIN STUDENT
 ON PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
 WHERE STUDENT.IDGROUP = @group AND PROGRESS.SUBJECT = 'СУБД'
 
--Task 6
select case 
	when NOTE between 0 and 4 then 'Балбес'
	when NOTE between 4 and 7 then 'Среднечет'
	when NOTE between 7 and 10 then 'Гений'
	end [Уровень знаний], IDSTUDENT
from PROGRESS



--Task 7
create table #EXPLRE
(stroka varchar(20),
 nomer varchar(20),
 countt int
);
set nocount on; -- не выводить сообщения о вводе строк
declare @k int = 1;
while @k <= 10
	begin
	insert #EXPLRE values('Строка','номер', @k);
	set @k += 1;
end;
select * from #EXPLRE

--Task 8

declare @q int = 1
	print @q+1
	print @q+2
	return
	print @q+3

--Task 9
begin try 
update PROGRESS set NOTE = '2' where  NOTE = '4'
end try
begin catch 
	print ERROR_NUMBER()
	print ERROR_MESSAGE()
	print ERROR_LINE()
	print ERROR_PROCEDURE()
	print ERROR_SEVERITY()
	print ERROR_STATE()
end catch
