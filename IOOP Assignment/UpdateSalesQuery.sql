-- Query to update month_sales column
UPDATE ms
SET ms.month_sales = (
    -- Choose month_category_sales column where the month corresponds with the displayed month_name column (in monthly_sales table)
    -- COALESCE is used so NULL is not returned and just replaced with 0 instead
    SELECT COALESCE(SUM(cs.month_category_sales), 0)
    FROM category_sales cs
    WHERE cs.month = ms.month_name
  )
  +
  (
    -- Choose month_chef_sales column where the month corresponds with the displayed month_name column (in monthly_sales table)
    SELECT COALESCE(SUM(chs.month_chef_sales), 0)
    FROM chef_sales chs
    WHERE chs.month = ms.month_name
  )
FROM monthly_sales ms;

-- Displays all data post-data update
SELECT * FROM monthly_sales;