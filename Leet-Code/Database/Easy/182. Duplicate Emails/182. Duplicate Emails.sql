-- Generic SQL Solution
SELECT Email
FROM Person
GROUP BY Email
HAVING COUNT(*) > 1;

-- Oracle SQL Solution
SELECT Email
FROM Person
GROUP BY Email
HAVING COUNT(*) > 1;

-- MySQL Solution
SELECT Email
FROM Person
GROUP BY Email
HAVING COUNT(*) > 1;

-- PostgreSQL Solution
SELECT Email
FROM Person
GROUP BY Email
HAVING COUNT(*) > 1;