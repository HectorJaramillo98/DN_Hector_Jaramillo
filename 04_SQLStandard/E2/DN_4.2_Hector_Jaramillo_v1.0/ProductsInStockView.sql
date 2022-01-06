create view productsinstock
as
select p.name product , i.stock  from inventory i
inner join producttypes p on p.inventory_idinventory =i.idinventory
WHERE i.stock>0;

