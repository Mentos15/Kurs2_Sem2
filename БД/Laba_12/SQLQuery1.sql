if exists (select * from sys.objects where OBJECT_ID = object_id(N'DBO.FIRSTTASK'))
	drop table FIRSTTASK;

declare @c int, @flag char = 's';

SET IMPLICIT_TRANSACTIONS ON
CREATE TABLE FIRSTTASK(K int);
	INSERT FIRSTTASK VALUES(1),(2), (3);
	set @c = (select count(*) from FIRSTTASK);
	print cast(@c as varchar(2));
	if @flag = 'c' 
		commit;
	else
		rollback;
SET IMPLICIT_TRANSACTIONS OFF

if exists (select * from sys.objects where OBJECT_ID = object_id(N'DBO.FIRSTTASK'))
	print '������� ����������';
else 
	print '�� ����������';


-- ������� 2

use D_UNIVER;

begin try
	begin tran
		delete PROGRESS where NOTE < 6;
		insert PROGRESS values ('����', 1000, '2013-10-10', 4)
		insert PROGRESS values ('����', 6000, '2014-11-5', 5)
	commit tran
end try
begin catch
	print '������ ' + case
	when error_number() = 547
		then '��� �������� � ����� ID'
	else
		cast(error_number() as varchar(10))
	end;
	if @@TRANCOUNT > 0 rollback tran;
end catch;


-- ������� 3

declare @point varchar(30);

begin try
	begin tran
		delete PROGRESS where NOTE < 6;
		set @point = 'p1';save tran @point;
		insert PROGRESS values ('����', 1040, '2013-10-10', 4)
		set @point = 'p2';save tran @point;
		insert PROGRESS values ('����', 5007, '2014-11-5', 5)
	commit tran
end try
begin catch
	print '������ ' + case
	when error_number() = 547
		then '��� �������� � ����� ID'
	else
		cast(error_number() as varchar(10))
	end;
	if @@TRANCOUNT > 0 
		begin
			print '����������� ����� ' + @point;
			rollback tran @point;
			commit tran;
		end;
end catch;


-- ������� 4

-- A --
set transaction isolation level READ UNCOMMITTED 
	begin transaction 
	-------------------------- t1 ------------------
	select @@SPID, 'insert PROGRESS' '���������', * from PROGRESS 
	                  where NOTE < 6;
	select @@SPID, 'update PROGRESS'  '���������',  NOTE, IDSTUDENT, SUBJECT 
                      from PROGRESS  where NOTE = 6;
	commit; 
	-------------------------- t2 -----------------


-- ������� 5


-- A ---
set transaction isolation level READ COMMITTED 
begin transaction 
select count(*) from PROGRESS 	where NOTE = 6;
	-------------------------- t1 ------------------ 
	-------------------------- t2 -----------------
	select @@SPID,  'update PROGRESS'  '���������', count(*)
						from PROGRESS  where NOTE = 6;
commit; 


-- ������� 6


-- A ---
set transaction isolation level  REPEATABLE READ 
begin transaction 
select IDSTUDENT from PROGRESS where note = 9;
-------------------------- t1 ------------------ 
-------------------------- t2 -----------------
select IDSTUDENT from PROGRESS where note = 9;
select  case
when IDSTUDENT = 1010 then 'update  PROGRESS'  else ' ' 
end '���������', IDSTUDENT from PROGRESS  where NOTE = 9;
commit transaction; 


-- ������� 7
-- A ---
set transaction isolation level SERIALIZABLE 
begin transaction 
delete PROGRESS where IDSTUDENT = 1031;  
insert PROGRESS values ('��', 1031, '2015-07-07',  9);
update PROGRESS set SUBJECT = '����' where IDSTUDENT = 1031;
select  * from PROGRESS  where IDSTUDENT = 1031;
-------------------------- t1 -----------------
select  * from PROGRESS  where IDSTUDENT = 1031;
-------------------------- t2 ------------------ 
commit; 	

-- ������� 8

begin tran 
	insert PROGRESS values('��', 1032, '2015-07-07',  8)
	begin tran
		select * from PROGRESS where IDSTUDENT = 1032
		update PROGRESS set NOTE = 6 where  IDSTUDENT = 1032
	commit
if @@TRANCOUNT > 0 rollback;
select * from PROGRESS where IDSTUDENT = 1032