use Laba_2

CREATE TABLE ������(
��������_����_������� nvarchar(20)NOT NULL,
������ decimal(5,2)NOT NULL,
PRIMARY KEY (��������_����_�������)
);


CREATE TABLE ������(
��������_�����_������� nvarchar(30) NOT NULL,
���_������������� nvarchar(30) NOT NULL,
����� nvarchar(30) NOT NULL,
������� int NOT NULL,
����������_���� nvarchar(20) NOT NULL,
PRIMARY KEY(��������_�����_�������)
);

CREATE TABLE ����(
���_������� nvarchar(20) FOREIGN KEY REFERENCES ������(��������_����_�������) NOT NULL,
������� nvarchar(30) FOREIGN KEY REFERENCES ������(��������_�����_�������) NOT NULL,
����� int NOT NULL,
����_������ date NOT NULL,
����_�������� date NOT NULL,.

);

INSERT INTO ������(��������_����_�������, ������)
VALUES('���������������', 0.5),
	  ('�� �����', 0.3),
	  ('�� ���� �����������',0.7);

INSERT INTO ������(��������_�����_�������,���_�������������,�����,�������,����������_����)
VALUES('���-�����','�����','���������� 19', 291131029,'�����'),
	  ('�����������','���������','��������� 21', 295468218,'�������'),
	  ('������','�����','����������� 12',297249513 ,'��������');
INSERT INTO ����(���_�������,�������,�����,����_������,����_��������)
VALUES ('���������������','������', 50000, '15.10.2018','15.10.2020'),
	   ('�� �����','���-�����', 18000 , '30.04.2019','23.08.2020'),
	   ('�� ���� �����������','�����������',7000,'18.02.2020','27.08.2020');

