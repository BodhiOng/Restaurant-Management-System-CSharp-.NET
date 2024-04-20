UPDATE ms
SET ms.month_sales = (
    SELECT COALESCE(SUM(cs.month_category_sales), 0)
    FROM category_sales cs
    WHERE cs.month = ms.month_name
  )
  +
  (
    SELECT COALESCE(SUM(chs.month_chef_sales), 0)
    FROM chef_sales chs
    WHERE chs.month = ms.month_name
  )
FROM monthly_sales ms;
