create view userroles
as
select u.name, r.name roles from users u
inner join roles r on u.idusers = r.idroles