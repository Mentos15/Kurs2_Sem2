

select * from AUDITORIUM
select * from AUDITORIUM_TYPE

--Task 1
go
select TEACHER_NAME from TEACHER where PULPIT = '����' for xml path ('�������������'), root ('������_��������������'), elements;


--Task 2

go
select AUDITORIUM_TYPENAME, AUDITORIUM.AUDITORIUM_TYPE, AUDITORIUM_CAPACITY from AUDITORIUM inner join AUDITORIUM_TYPE on  AUDITORIUM.AUDITORIUM_TYPE 
= AUDITORIUM_TYPE.AUDITORIUM_TYPE where AUDITORIUM.AUDITORIUM_TYPE like '%��%'for xml auto, root ('������_���������'), elements;

--Task 3 -------

go
declare @h int = 0,
@sbj varchar(3000) = '<?xml version="1.0" encoding="windows-1251" ?>
                      <����������> 
                         <���������� ���="����" ��������="������������ ��������� � �������" �������="���" /> 
                         <���������� ���="���" ��������="������ ������ ����������" �������="���" />  
                      </����������>';
exec sp_xml_preparedocument @h output, @sbj;
insert "SUBJECT" select [���], [��������], [�������] from openxml(@h, '/����������/����������', 0) with([���] char(10), [��������] varchar(100), [�������] char(20));      

select * from SUBJECT


-- Task 4
insert into STUDENT(IDGROUP, NAME, BDAY, INFO) values(22, '����� ���� ��������', '05.04.1997', 
                                                         '<�������>
														    <������� �����="��" �����="1328132" ����="12.02.2012" />
															<�������>+375336348866</�������>
															<�����>
															   <������>��������</������>
															   <�����>����</�����>
															   <�����>���������</�����>
															   <���>16</���>
															   <��������>43</��������>
															</�����>
														  </�������>');

select * from STUDENT where NAME = '����� ���� ��������';

update STUDENT set INFO = '<�������>
						      <������� �����="��" �����="1328132" ����="12.02.2012" />
								<�������>+375336348866</�������>
								<�����>
									<������>��������</������>
									<�����>����</�����>
									<�����>���������</�����>
									<���>16</���>
									<��������>43</��������>
								</�����>
							</�������>'
where NAME = '����� ���� ��������';

select NAME[���], INFO.value('(�������/�������/@�����)[1]', 'char(2)')[����� ��������], INFO.value('(�������/�������/@�����)[1]', 'varchar(20)')[����� ��������], INFO.query('/�������/�����')[�����] from  STUDENT where NAME = '����� ���� ��������';  


--Task 5

go
create xml schema collection Student as 
N'<?xml version="1.0" encoding="utf-16" ?>
<xs:schema attributeFormDefault="unqualified" 
   elementFormDefault="qualified"
   xmlns:xs="http://www.w3.org/2001/XMLSchema">
<xs:element name="�������">
<xs:complexType><xs:sequence>
<xs:element name="�������" maxOccurs="1" minOccurs="1">
  <xs:complexType>
    <xs:attribute name="�����" type="xs:string" use="required" />
    <xs:attribute name="�����" type="xs:unsignedInt" use="required"/>
    <xs:attribute name="����"  use="required">
	<xs:simpleType>  <xs:restriction base ="xs:string">
		<xs:pattern value="[0-9]{2}.[0-9]{2}.[0-9]{4}"/>
	 </xs:restriction> 	</xs:simpleType>
     </xs:attribute>
  </xs:complexType>
</xs:element>
<xs:element maxOccurs="3" name="�������" type="xs:unsignedInt"/>
<xs:element name="�����">   <xs:complexType><xs:sequence>
   <xs:element name="������" type="xs:string" />
   <xs:element name="�����" type="xs:string" />
   <xs:element name="�����" type="xs:string" />
   <xs:element name="���" type="xs:string" />
   <xs:element name="��������" type="xs:string" />
</xs:sequence></xs:complexType>  </xs:element>
</xs:sequence></xs:complexType>
</xs:element></xs:schema>';

alter table STUDENT alter column INFO xml(Student);