-- Задание 4


--- B --	
begin transaction 
select @@SPID
insert PROGRESS values ('СУБД', 1010, '2014-11-5', 5);
update PROGRESS set NOTE  =  6 
                        where NOTE = 7
-------------------------- t1 --------------------
-------------------------- t2 --------------------
rollback;

-- Задание 5

--- B ---	
begin transaction 	  
-------------------------- t1 --------------------
	update PROGRESS set NOTE = 6 where NOTE = 8 ;
commit; 
-------------------------- t2 --------------------	


-- Задание 6
begin transaction
	UPDATE PROGRESS set NOTE = 6 WHERE IDSTUDENT = 1031;
commit

UPDATE PROGRESS set NOTE = 9 WHERE IDSTUDENT = 1031;
delete PROGRESS where IDSTUDENT = 1030


-- Задание 7

--- B ---	
begin transaction 	  
insert PROGRESS values ('ОАиП', 1031, '2016-07-07',  6);
-------------------------- t1 --------------------
commit; 
select  * from PROGRESS  where IDSTUDENT = 1031;
-------------------------- t2 --------------------

delete PROGRESS where IDSTUDENT = 1031 and SUBJECT = 'ОАиП'