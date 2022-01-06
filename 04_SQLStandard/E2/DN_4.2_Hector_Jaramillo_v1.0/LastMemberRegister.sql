SELECT mr.idmember, mr.name, mr.registerdate, mt.name membershiptype FROM
(
SELECT idmember, name, registerdate, membershiptypes_idmembershiptypes FROM members
ORDER BY registerdate DESC LIMIT 1
)mr
INNER JOIN membershiptypes mt on mr.membershiptypes_idmembershiptypes=mt.idmembershiptypes