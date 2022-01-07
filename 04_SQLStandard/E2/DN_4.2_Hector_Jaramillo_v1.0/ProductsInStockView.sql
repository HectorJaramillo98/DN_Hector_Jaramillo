create view productsinstock
as
select p.name producttype ,i.name, i.stock  from inventory i
inner join producttypes p on p.idproducttypes=i.producttypes_idproducttypes
WHERE i.stock>0;

