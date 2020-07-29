select * from ТОВАРЫ where Цена > 100 and Цена < 400;
select Заказчик from ЗАКАЗЫ where Наименование_товара = 'Клавиатура';
select * from ЗАКАЗЫ where Заказчик = 'HyperX' order by Дата_поставки;
select * from Заказы where Дата_поставки > '2020-01-30';
