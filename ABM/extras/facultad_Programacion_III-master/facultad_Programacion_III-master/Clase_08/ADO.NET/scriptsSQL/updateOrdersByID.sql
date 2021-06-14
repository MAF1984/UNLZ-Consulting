UPDATE Orders
    SET orders.id=(SELECT customers.id
        FROM customers
            WHERE customers.CustomerID = orders.CustomerID)