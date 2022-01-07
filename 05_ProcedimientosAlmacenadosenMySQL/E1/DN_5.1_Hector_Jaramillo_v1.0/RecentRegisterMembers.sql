CREATE DEFINER=`root`@`localhost` PROCEDURE `RecentRegisterMembers`()
BEGIN

SELECT m.idmember, m.name, m.registerdate, mt.name membershiptype FROM members m
INNER JOIN membershiptypes mt on m.membershiptypes_idmembershiptypes=mt.idmembershiptypes
where m.registerdate> DATE_ADD(curdate(), INTERVAL(-WEEKDAY(curdate())) DAY);

END