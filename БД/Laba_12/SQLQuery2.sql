-- ������� 4


--- B --	
begin transaction 
select @@SPID
insert PROGRESS values ('����', 1010, '2014-11-5', 5);
update PROGRESS set NOTE  =  6 
                        where NOTE = 7
-------------------------- t1 --------------------
-------------------------- t2 --------------------
rollback;

-- ������� 5

--- B ---	
begin transaction 	  
-------------------------- t1 --------------------
	update PROGRESS set NOTE = 6 where NOTE = 8 ;
commit; 
-------------------------- t2 --------------------	


-- ������� 6
begin transaction
	UPDATE PROGRESS set NOTE = 6 WHERE IDSTUDENT = 1031;
commit

UPDATE PROGRESS set NOTE = 9 WHERE IDSTUDENT = 1031;
delete PROGRESS where IDSTUDENT = 1030


-- ������� 7

--- B ---	
begin transaction 	  
insert PROGRESS values ('����', 1031, '2016-07-07',  6);
-------------------------- t1 --------------------
commit; 
select  * from PROGRESS  where IDSTUDENT = 1031;
-------------------------- t2 --------------------

delete PROGRESS where IDSTUDENT = 1031 and SUBJECT = '����'