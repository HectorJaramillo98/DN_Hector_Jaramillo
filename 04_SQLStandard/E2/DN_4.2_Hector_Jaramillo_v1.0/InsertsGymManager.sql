-- members --
INSERT INTO `gymmanager`.`cities` (`idcities`, `name`) VALUES (1, 'Tijuana');
INSERT INTO `gymmanager`.`cities` (`idcities`, `name`) VALUES (2, 'Guadalajara');
INSERT INTO `gymmanager`.`cities` (`idcities`, `name`) VALUES (3, 'Monterrey');
INSERT INTO `gymmanager`.`cities` (`idcities`, `name`) VALUES (4, 'Merida');
INSERT INTO `gymmanager`.`cities` (`idcities`, `name`) VALUES (5, 'Navojoa');

INSERT INTO `gymmanager`.`membershiptypes` (`idmembershiptypes`, `name`, `cost`, `createdon`, `duration`) VALUES (1, 'single', 350, NOW(), 1);
INSERT INTO `gymmanager`.`membershiptypes` (`idmembershiptypes`, `name`, `cost`, `createdon`, `duration`) VALUES (2, 'singlemax', 600, NOW(), 3);
INSERT INTO `gymmanager`.`membershiptypes` (`idmembershiptypes`, `name`, `cost`, `createdon`, `duration`) VALUES (3, 'couple', 600, NOW(), 1);
INSERT INTO `gymmanager`.`membershiptypes` (`idmembershiptypes`, `name`, `cost`, `createdon`, `duration`) VALUES (4, 'couplemax', 1000, NOW(), 3);
INSERT INTO `gymmanager`.`membershiptypes` (`idmembershiptypes`, `name`, `cost`, `createdon`, `duration`) VALUES (5, '4party', 1500, NOW(), 3);

INSERT INTO `gymmanager`.`equipmenttype` (`idequipmenttype`, `name`) VALUES (1, 'Hanging leg raise');
INSERT INTO `gymmanager`.`equipmenttype` (`idequipmenttype`, `name`) VALUES (2, 'Seated leg press');
INSERT INTO `gymmanager`.`equipmenttype` (`idequipmenttype`, `name`) VALUES (3, 'Lat pulldown');
INSERT INTO `gymmanager`.`equipmenttype` (`idequipmenttype`, `name`) VALUES (4, 'Cable biceps bar');
INSERT INTO `gymmanager`.`equipmenttype` (`idequipmenttype`, `name`) VALUES (5, 'Chest press');

INSERT INTO `gymmanager`.`members` (`idMember`, `name`, `lastname`, `email`, `birthday`, `allowsletter`, `cities_idcities`, `membershiptypes_idmembershiptypes`, `equipmenttype_idequipmenttype`) VALUES (1, 'Edy', 'Perales', 'edypp@gmail.com', '1999-10-11', 1, 1, 1, 1);
INSERT INTO `gymmanager`.`members` (`idMember`, `name`, `lastname`, `email`, `birthday`, `allowsletter`, `cities_idcities`, `membershiptypes_idmembershiptypes`, `equipmenttype_idequipmenttype`) VALUES (2, 'Fernando', 'Melendez', 'fermelen@gmail.com', '1997-08-05', 0, 2, 2, 2);
INSERT INTO `gymmanager`.`members` (`idMember`, `name`, `lastname`, `email`, `birthday`, `allowsletter`, `cities_idcities`, `membershiptypes_idmembershiptypes`, `equipmenttype_idequipmenttype`) VALUES (3, 'Nelly', 'Villareal', 'nellyvilla@gmail.com', '1996-11-12', 1, 3, 3, 3);
INSERT INTO `gymmanager`.`members` (`idMember`, `name`, `lastname`, `email`, `birthday`, `allowsletter`, `cities_idcities`, `membershiptypes_idmembershiptypes`, `equipmenttype_idequipmenttype`) VALUES (4, 'Dulce', 'Villalobos', 'dulcedv@gmail.com', '1999-12-18', 0, 4, 4, 4);
INSERT INTO `gymmanager`.`members` (`idMember`, `name`, `lastname`, `email`, `birthday`, `allowsletter`, `cities_idcities`, `membershiptypes_idmembershiptypes`, `equipmenttype_idequipmenttype`) VALUES (5, 'Sofia', 'Alamos', 'sofiala@gmail.com', '1999-06-21', 1, 5, 5, 5);

-- Users --
INSERT INTO `gymmanager`.`roles` (`idroles`, `name`) VALUES (1, 'admin');
INSERT INTO `gymmanager`.`roles` (`idroles`, `name`) VALUES (2, 'receptionist');
INSERT INTO `gymmanager`.`roles` (`idroles`, `name`) VALUES (3, 'seller');
INSERT INTO `gymmanager`.`roles` (`idroles`, `name`) VALUES (4, 'trainer');
INSERT INTO `gymmanager`.`roles` (`idroles`, `name`) VALUES (5, 'nutritionist');

INSERT INTO `gymmanager`.`users` (`idusers`, `name`, `email`, `password`) VALUES (1, 'Carlos', 'Santana', 'Password#123');
INSERT INTO `gymmanager`.`users` (`idusers`, `name`, `email`, `password`) VALUES (2, 'Luis', 'Mundo', 'Password#123');
INSERT INTO `gymmanager`.`users` (`idusers`, `name`, `email`, `password`) VALUES (3, 'Caitlyn', 'Kiramman', 'Password#123');
INSERT INTO `gymmanager`.`users` (`idusers`, `name`, `email`, `password`) VALUES (4, 'Octavio', 'Paz', 'Password#123');
INSERT INTO `gymmanager`.`users` (`idusers`, `name`, `email`, `password`) VALUES (5, 'Carolina', 'Hernandez', 'Password#123');

INSERT INTO `gymmanager`.`usersinroles` (`users_idusers`, `roles_idroles`) VALUES (1, 1);
INSERT INTO `gymmanager`.`usersinroles` (`users_idusers`, `roles_idroles`) VALUES (2, 2);
INSERT INTO `gymmanager`.`usersinroles` (`users_idusers`, `roles_idroles`) VALUES (3, 3);
INSERT INTO `gymmanager`.`usersinroles` (`users_idusers`, `roles_idroles`) VALUES (4, 4);
INSERT INTO `gymmanager`.`usersinroles` (`users_idusers`, `roles_idroles`) VALUES (5, 5);

INSERT INTO `gymmanager`.`sales` (`idsales`, `users_idusers`, `date`) VALUES (1, 1, NOW());
INSERT INTO `gymmanager`.`sales` (`idsales`, `users_idusers`, `date`) VALUES (2, 2, NOW());
INSERT INTO `gymmanager`.`sales` (`idsales`, `users_idusers`, `date`) VALUES (3, 3, NOW());
INSERT INTO `gymmanager`.`sales` (`idsales`, `users_idusers`, `date`) VALUES (4, 4, NOW());
INSERT INTO `gymmanager`.`sales` (`idsales`, `users_idusers`, `date`) VALUES (5, 5, NOW());

INSERT INTO `gymmanager`.`inventory` (`idinventory`, `users_idusers`, `dateupdate`, `stock`) VALUES (1, 1, NOW(), 80);
INSERT INTO `gymmanager`.`inventory` (`idinventory`, `users_idusers`, `dateupdate`, `stock`) VALUES (2, 2, NOW(), 50);
INSERT INTO `gymmanager`.`inventory` (`idinventory`, `users_idusers`, `dateupdate`, `stock`) VALUES (3, 3, NOW(), 30);
INSERT INTO `gymmanager`.`inventory` (`idinventory`, `users_idusers`, `dateupdate`, `stock`) VALUES (4, 4, NOW(), 60);
INSERT INTO `gymmanager`.`inventory` (`idinventory`, `users_idusers`, `dateupdate`, `stock`) VALUES (5, 5, NOW(), 70);
INSERT INTO `gymmanager`.`inventory` (`idinventory`, `users_idusers`, `dateupdate`, `stock`) VALUES (6, 1, NOW(), 0);

INSERT INTO `gymmanager`.`measuretypes` (`idmeasuretypes`, `measure`) VALUES (1, 'small 200g');
INSERT INTO `gymmanager`.`measuretypes` (`idmeasuretypes`, `measure`) VALUES (2, 'medium 500g');
INSERT INTO `gymmanager`.`measuretypes` (`idmeasuretypes`, `measure`) VALUES (3, 'grande 1kg');
INSERT INTO `gymmanager`.`measuretypes` (`idmeasuretypes`, `measure`) VALUES (4, 'immeasurable 2kg');
INSERT INTO `gymmanager`.`measuretypes` (`idmeasuretypes`, `measure`) VALUES (5, 'cosmic 5kg');

INSERT INTO `gymmanager`.`producttypes` (`idproducttypes`, `name`, `cost`, `measuretypes_idmeasuretypes`, `inventory_idinventory`) VALUES (1, 'Chocolate protein', 100, 1, 1);
INSERT INTO `gymmanager`.`producttypes` (`idproducttypes`, `name`, `cost`, `measuretypes_idmeasuretypes`, `inventory_idinventory`) VALUES (2, 'Chocolate protein', 300, 2, 2);
INSERT INTO `gymmanager`.`producttypes` (`idproducttypes`, `name`, `cost`, `measuretypes_idmeasuretypes`, `inventory_idinventory`) VALUES (3, 'Chocolate protein', 500, 3, 3);
INSERT INTO `gymmanager`.`producttypes` (`idproducttypes`, `name`, `cost`, `measuretypes_idmeasuretypes`, `inventory_idinventory`) VALUES (4, 'Chocolate protein', 800, 4, 4);
INSERT INTO `gymmanager`.`producttypes` (`idproducttypes`, `name`, `cost`, `measuretypes_idmeasuretypes`, `inventory_idinventory`) VALUES (5, 'Chocolate protein', 1000, 5, 5);
INSERT INTO `gymmanager`.`producttypes` (`idproducttypes`, `name`, `cost`, `measuretypes_idmeasuretypes`, `inventory_idinventory`) VALUES (6, 'Moka protein', 100, 1, 6);

INSERT INTO `gymmanager`.`salesproducttypes` (`sales_idsales`, `producttypes_idproducttypes`) VALUES (1, 1);
INSERT INTO `gymmanager`.`salesproducttypes` (`sales_idsales`, `producttypes_idproducttypes`) VALUES (2, 2);
INSERT INTO `gymmanager`.`salesproducttypes` (`sales_idsales`, `producttypes_idproducttypes`) VALUES (3, 3);
INSERT INTO `gymmanager`.`salesproducttypes` (`sales_idsales`, `producttypes_idproducttypes`) VALUES (4, 4);
INSERT INTO `gymmanager`.`salesproducttypes` (`sales_idsales`, `producttypes_idproducttypes`) VALUES (5, 5);