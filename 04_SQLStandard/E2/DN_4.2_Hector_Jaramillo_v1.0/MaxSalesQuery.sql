select  p. idproducttypes, p.name product , sum(s.amount) total_amount from salesproducttypes s
inner join producttypes p on p.idproducttypes=s.producttypes_idproducttypes group by idproducttypes
ORDER BY  sum(s.amount) DESC LIMIT 1;
