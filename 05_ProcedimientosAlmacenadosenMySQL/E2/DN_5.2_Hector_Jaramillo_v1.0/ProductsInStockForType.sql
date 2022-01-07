CREATE DEFINER=`root`@`localhost` PROCEDURE `ProductsInStockForType`(in _producttype int)
BEGIN

select i.idinventory, i.name, i.producttypes_idproducttypes,pt.name productype_name, i.stock from inventory i
inner join producttypes pt on pt.idproducttypes=i.producttypes_idproducttypes
where producttypes_idproducttypes = _producttype;

END