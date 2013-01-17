SELECT	dbo.Product.Id, 
		dbo.Product.Name, 
		dbo.Product.Price, 
		dbo.Product.Description,
		(SELECT SUM(dbo.Production.Quantity) FROM dbo.Production WHERE dbo.Production.Product_id = dbo.Product.Id) AS QProduced, 
		(SELECT SUM(dbo.Sale.Quantity) FROM dbo.Sale WHERE dbo.Sale.Product_id = dbo.Product.Id) AS QSaled, 
		((SELECT SUM(dbo.Production.Quantity) FROM dbo.Production WHERE dbo.Production.Product_id = dbo.Product.Id) - (SELECT SUM(dbo.Sale.Quantity) FROM dbo.Sale WHERE dbo.Sale.Product_id = dbo.Product.Id)) AS QAvailable
FROM	dbo.Product