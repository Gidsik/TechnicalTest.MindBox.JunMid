SELECT [Products].[name] AS product, [Categories].[name] AS category
FROM [Products]
	LEFT JOIN [ProductCategories] ON ([ProductCategories].[idProduct] = [Products].[id])
	LEFT JOIN [Categories] ON ([ProductCategories].[idCategory] = [Categories].[id])

GO