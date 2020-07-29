

select * from AUDITORIUM
select * from AUDITORIUM_TYPE

--Task 1
go
select TEACHER_NAME from TEACHER where PULPIT = 'ИСиТ' for xml path ('Преподаватели'), root ('Список_преподавателей'), elements;


--Task 2

go
select AUDITORIUM_TYPENAME, AUDITORIUM.AUDITORIUM_TYPE, AUDITORIUM_CAPACITY from AUDITORIUM inner join AUDITORIUM_TYPE on  AUDITORIUM.AUDITORIUM_TYPE 
= AUDITORIUM_TYPE.AUDITORIUM_TYPE where AUDITORIUM.AUDITORIUM_TYPE like '%ЛК%'for xml auto, root ('Список_аудиторий'), elements;

--Task 3 -------

go
declare @h int = 0,
@sbj varchar(3000) = '<?xml version="1.0" encoding="windows-1251" ?>
                      <дисциплины> 
                         <дисциплина код="КГиГ" название="Компьютерная геометрия и графика" кафедра="РИТ" /> 
                         <дисциплина код="ОЗИ" название="Основы защиты информации" кафедра="РИТ" />  
                      </дисциплины>';
exec sp_xml_preparedocument @h output, @sbj;
insert "SUBJECT" select [код], [название], [кафедра] from openxml(@h, '/дисциплины/дисциплина', 0) with([код] char(10), [название] varchar(100), [кафедра] char(20));      

select * from SUBJECT


-- Task 4
insert into STUDENT(IDGROUP, NAME, BDAY, INFO) values(22, 'Птров Петя Петрович', '05.04.1997', 
                                                         '<студент>
														    <паспорт серия="МС" номер="1328132" дата="12.02.2012" />
															<телефон>+375336348866</телефон>
															<адрес>
															   <страна>Беларусь</страна>
															   <город>Узда</город>
															   <улица>Новицкого</улица>
															   <дом>16</дом>
															   <квартира>43</квартира>
															</адрес>
														  </студент>');

select * from STUDENT where NAME = 'Птров Петя Петрович';

update STUDENT set INFO = '<студент>
						      <паспорт серия="МС" номер="1328132" дата="12.02.2012" />
								<телефон>+375336348866</телефон>
								<адрес>
									<страна>Беларусь</страна>
									<город>Узда</город>
									<улица>Новицкого</улица>
									<дом>16</дом>
									<квартира>43</квартира>
								</адрес>
							</студент>'
where NAME = 'Птров Петя Петрович';

select NAME[ФИО], INFO.value('(студент/паспорт/@серия)[1]', 'char(2)')[Серия паспорта], INFO.value('(студент/паспорт/@номер)[1]', 'varchar(20)')[Номер паспорта], INFO.query('/студент/адрес')[Адрес] from  STUDENT where NAME = 'Птров Петя Петрович';  


--Task 5

go
create xml schema collection Student as 
N'<?xml version="1.0" encoding="utf-16" ?>
<xs:schema attributeFormDefault="unqualified" 
   elementFormDefault="qualified"
   xmlns:xs="http://www.w3.org/2001/XMLSchema">
<xs:element name="студент">
<xs:complexType><xs:sequence>
<xs:element name="паспорт" maxOccurs="1" minOccurs="1">
  <xs:complexType>
    <xs:attribute name="серия" type="xs:string" use="required" />
    <xs:attribute name="номер" type="xs:unsignedInt" use="required"/>
    <xs:attribute name="дата"  use="required">
	<xs:simpleType>  <xs:restriction base ="xs:string">
		<xs:pattern value="[0-9]{2}.[0-9]{2}.[0-9]{4}"/>
	 </xs:restriction> 	</xs:simpleType>
     </xs:attribute>
  </xs:complexType>
</xs:element>
<xs:element maxOccurs="3" name="телефон" type="xs:unsignedInt"/>
<xs:element name="адрес">   <xs:complexType><xs:sequence>
   <xs:element name="страна" type="xs:string" />
   <xs:element name="город" type="xs:string" />
   <xs:element name="улица" type="xs:string" />
   <xs:element name="дом" type="xs:string" />
   <xs:element name="квартира" type="xs:string" />
</xs:sequence></xs:complexType>  </xs:element>
</xs:sequence></xs:complexType>
</xs:element></xs:schema>';

alter table STUDENT alter column INFO xml(Student);