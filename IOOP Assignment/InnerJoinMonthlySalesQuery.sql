-- Query to create inner joins (only run once. and it has been runned before, do not run again)

-- Inner joins from monthly_sales table with category_sales table regarding the month's name
SELECT ms.month_name, cs.month_category_sales
FROM monthly_sales ms
INNER JOIN category_sales cs ON ms.month_name = cs.month;

-- Inner joins from monthly_sales table with chef_sales table regarding the month's name
SELECT ms.month_name, chs.month_chef_sales
FROM monthly_sales ms
INNER JOIN chef_sales chs ON ms.month_name = chs.month;