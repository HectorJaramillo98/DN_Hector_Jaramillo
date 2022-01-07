CREATE DEFINER=`root`@`localhost` PROCEDURE `Sales`(in _idproduct int, in _iduser int,in _amount int)
BEGIN

declare _salesId int;
select max(idsales) + 1 into _salesId from sales;

insert into sales (idsales,users_idusers,date) values(_salesId,_iduser,now());
INSERT INTO salesinventory (sales_idsales, inventory_idinventory, amount) VALUES (_salesId,_idproduct, _amount);
END