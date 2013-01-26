SELECT	dbo.Product.Id, 
		dbo.Product.Name, 
		dbo.Product.Price, 
		dbo.Product.Description,
		ISNULL((SELECT SUM(dbo.Production.Quantity) FROM dbo.Production WHERE dbo.Production.Product_id = dbo.Product.Id), 0) AS QProduced, 
		ISNULL((SELECT SUM(dbo.Sale.Quantity) FROM dbo.Sale WHERE dbo.Sale.Product_id = dbo.Product.Id), 0) AS QSaled, 
		(ISNULL((SELECT SUM(dbo.Production.Quantity) FROM dbo.Production WHERE dbo.Production.Product_id = dbo.Product.Id), 0) - ISNULL((SELECT SUM(dbo.Sale.Quantity) FROM dbo.Sale WHERE dbo.Sale.Product_id = dbo.Product.Id), 0)) AS QAvailable
FROM	dbo.Product