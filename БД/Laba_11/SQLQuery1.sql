use UNIVER

--Task 1

declare @tv char(20), @t char(300) = '';
declare SUB cursor for select SUBJECT from SUBJECT where PULPIT = 'ИСиТ';
	open SUB;
	fetch SUB into @tv;
	print 'Предметы';
	while @@FETCH_STATUS = 0
		begin 
			set @t=rtrim(@tv)+','+@t;
			fetch SUB into @tv;
		end;
	print @t;
close SUB;

--Task 2
declare @a char(20), @b char(20);
declare Curs cursor local
				for select SUBJECT, PULPIT from SUBJECT where PULPIT = 'ИСиТ';
open Curs;
fetch Curs into @a, @b;
print '1: ' + rtrim(@a) + ' ' + @b;
go
declare @a char(20), @b char(20);
fetch Curs into @a, @b;
print '2: ' + rtrim(@a) + ' ' + @b;
go


declare @a char(20), @b char(20);
declare Curs2 cursor global
				for select SUBJECT, PULPIT from SUBJECT where PULPIT = 'ИСиТ';
open Curs2;
fetch Curs2 into @a, @b;
print '1: ' + rtrim(@a) + ' ' + @b;
go
declare @a char(20), @b char(20);
fetch Curs2 into @a, @b;
print '2: ' + rtrim(@a) + ' ' + @b;
close Curs2;
DEALLOCATE Curs2;
go


--Task 3
declare @tnm char(10);
declare Curs3 cursor local dynamic 
	for select SUBJECT from SUBJECT where PULPIT = 'ИСиТ';
open Curs3;
insert SUBJECT (SUBJECT, SUBJECT_NAME, PULPIT)
				values('23gh6', '8gh7', 'ИСиТ');
fetch Curs3 into @tnm;
while @@fetch_status = 0
begin 
	print @tnm;
	fetch Curs3 into @tnm;
end;
close Curs3;

--task4
declare @tc int, @rn char(50);
declare Curs4 cursor local dynamic SCROLL
	for select row_number() over (order by SUBJECT) N,
			SUBJECT from SUBJECT where PULPIT = 'ИСиТ';
open Curs4;
fetch last from Curs4 into @tc, @rn;
print 'Первая строка: ' +  cast(@tc as varchar(3)) + ' ' + rtrim(@rn);
fetch absolute 3 from Curs4 into @tc, @rn;
print 'Последняя строка: ' +  cast(@tc as varchar(3)) + ' ' + rtrim(@rn);
fetch first from Curs4 into @tc, @rn;
print 'Третья строка от начала: ' +  cast(@tc as varchar(3)) + ' ' + rtrim(@rn);
fetch relative 3 from Curs4 into @tc, @rn;
print 'Третья строка вперед от текущей: ' +  cast(@tc as varchar(3)) + ' ' + rtrim(@rn);
close Curs4;

--task5
declare @tn char(20), @tsn char(20);
declare Curs5 cursor local dynamic
	for select SUBJECT, SUBJECT_NAME from SUBJECT for update;
open Curs5;
fetch Curs5 into @tn, @tsn;
delete SUBJECT where current of Curs5;
fetch Curs5 into @tn, @tsn;
update SUBJECT set SUBJECT_NAME = 'НЕПОНЯТНЫЙ ПРЕДМЕТ' where current of Curs5;
close Curs5;

--task6
declare @sub char(10), @nt int, @nm char(50), @fc char(10), @prf char(15);
declare Curs6 cursor local dynamic 
					for select SUBJECT, NOTE, NAME, FACULTY, PROFESSION from PROGRESS inner join STUDENT on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
						inner join GROUPS on GROUPS.IDGROUP = STUDENT.IDGROUP;
open Curs6;
fetch Curs6 into @sub, @nt, @nm, @fc, @prf;
while @@fetch_status = 0
begin
	if @nt < 4
		begin
			delete PROGRESS where current of Curs6;		
		end;
	fetch Curs6 into @sub, @nt, @nm, @fc, @prf;
end;
close Curs6;
go

declare @sub char(10), @id int, @pd date, @nt int;
declare Curs6_2 cursor local dynamic 
					for select * from PROGRESS;
open Curs6_2;
fetch Curs6_2 into @sub, @id, @pd, @nt;
while @@fetch_status = 0
begin
	if @id = 1053
		begin
			update PROGRESS set NOTE = NOTE + 1 where current of Curs6_2;		
		end;
	fetch Curs6_2 into @sub, @id, @pd, @nt;
end;
close Curs6_2;
go