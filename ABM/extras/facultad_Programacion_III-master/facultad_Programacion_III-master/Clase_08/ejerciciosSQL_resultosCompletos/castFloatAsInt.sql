SELECT CAST(ROUND(SalesYTD/CommissionPct,0) AS INT) AS Calculo
    FROM Sales.SalesPerson
        WHERE CommissionPct != 0