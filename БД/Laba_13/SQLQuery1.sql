-- TAsk 1

go
create procedure PsSubject2
as
begin 
	declare @k int = (select count(*) from SUBJECT);
	select * from SUBJECT;
	return @k;
end;
go
declare @k int = 0;
EXEC @k = PsSubject2; --����� ���������

print '���������� ��������� = ' + cast(@k as varchar(10));

select * from SUBJECT

--Task 2

go
alter procedure PsSubject @p varchar(20), @c int output 
as
begin 
	declare @k int = (select count(*) from SUBJECT);
	print '���������: @p='+ @p+ '@c = ' + cast (@c as varchar(20));
	select * from SUBJECT where PULPIT= @p ;
	set @c = @@ROWCOUNT;
	return @k;
end;
go

declare  @k int =0, @r int = 0, @p varchar(20);
exec @k = PsSubject @p = '����', @c = @r output;
print '���������� ��������� ����� = ' + cast (@k as varchar(3));
-- Task3

select * from SUBJECT

go
alter procedure PsSubject @p varchar(20)
as
begin 
	declare @k int = (select count(*) from SUBJECT);
	select * from SUBJECT where PULPIT= @p ;
end;
go


create table #SUBJECT2
(
������� nvarchar(50),
������� nvarchar(20),
������_�������� nvarchar(50))

insert #SUBJECT2 exec PsSubject @p = '����';

select * from #SUBJECT2


--Task 4
				go
				create procedure PAUDITORIUM_INSERT @a char(20), @n varchar(50), @c integer=NULL, @t char(20)
				 as declare @ret int = 1 
				 begin try 
							insert into AUDITORIUM(AUDITORIUM, AUDITORIUM_NAME, AUDITORIUM_CAPACITY, AUDITORIUM_TYPE)
								values (@a,@n,@c,@t)
								return @ret;
				end try
				begin catch		--��������� ������
					print '����� ������: '+ cast(error_number() as varchar(6));
					print '���������: '+ error_message();
					print '�������: '+cast(error_severity() as varchar(6));
					print '�����:' + cast(error_state() as varchar(8));
					print '����� ������:'+ cast(error_line() as varchar(8));
					if ERROR_PROCEDURE() is not null
					print '��� ���������'+ error_procedure();
					return -1;
				end catch

				declare @rett int;
				exec @rett = PAUDITORIUM_INSERT @a = 'AUD32133', @n = 'POIT23133', @c = 2, @t = '��';	
				print '��� ������: '+ cast(@rett as varchar(3));
				
				select * from AUDITORIUM

--Task 5


go
create procedure SUBJECT_REPORT  @p CHAR(10)
   as  
   declare @rc int = 0;                            
   begin try    
      declare @tv char(20), @t char(300) = ' ';  
      declare ZkTov CURSOR  for 
      select SUBJECT from SUBJECT where PULPIT = @p;
      if not exists (select SUBJECT from SUBJECT where PULPIT = @p)
          raiserror('������ � �����������', 11, 1);
       else 
      open ZkTov;	  
  fetch  ZkTov into @tv;   
  print   '��������:';   
  while @@fetch_status = 0                                     
   begin 
       set @t = rtrim(@tv) + ', ' + @t;  
       set @rc = @rc + 1;       
       fetch  ZkTov into @tv; 
    end;   
print @t;        
close  ZkTov;
    return @rc;
   end try  
   begin catch              
        print '������ � ����������' 
        if error_procedure() is not null   
  print '��� ��������� : ' + error_procedure();
        return @rc;
   end catch; 
  
declare @rc� int;  
exec @rc� = SUBJECT_REPORT @p  = '����';  
print '���������� ��������� = ' + cast(@rc� as varchar(3)); 

--Task 6

select * from AUDITORIUM_TYPE
select * from AUDITORIUM

go
create  procedure PAUDITORIUM_INSERTX @a char(20), @n varchar(50), @c integer=NULL, @t char(20), @tn varchar(50)   
as  declare @rc int=1;                            
begin try 
    set transaction isolation level SERIALIZABLE;          
    begin tran
    insert into AUDITORIUM_TYPE(AUDITORIUM_TYPE, AUDITORIUM_TYPENAME)
                                               values (@t, @tn)
    exec @rc=PAUDITORIUM_INSERT @a, @n, @c, @t;  
    commit tran; 
    return @rc;           
end try
begin catch 
    print '����� ������  : ' + cast(error_number() as varchar(6));
    print '���������     : ' + error_message();
    print '�������       : ' + cast(error_severity()  as varchar(6));
    print '�����         : ' + cast(error_state()   as varchar(8));
    print '����� ������  : ' + cast(error_line()  as varchar(8));
    if error_procedure() is not  null   
                     print '��� ��������� : ' + error_procedure();
     if @@trancount > 0 rollback tran ; 
     return -1;	  
end catch;

declare @rcc int;  
exec @rcc = PAUDITORIUM_INSERTX @a = 'QQQwe�', @n = 'WWWewq�', @c = 2, @t = 'LKKf', @tn = 'Lectionnf';	 
print '��� ������=' + cast(@rcc as varchar(3));  

