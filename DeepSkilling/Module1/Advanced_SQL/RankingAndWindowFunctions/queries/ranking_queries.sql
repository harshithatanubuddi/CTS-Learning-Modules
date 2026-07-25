SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Row_Num
FROM Products;

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Rank_No
FROM Products;

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Dense_Rank
FROM Products;

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Row_Num
    FROM Products
) AS Result
WHERE Row_Num <= 3;

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Row_Num
    FROM Products
) AS Result
WHERE Row_Num <= 3;