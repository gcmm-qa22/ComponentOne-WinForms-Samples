CrossTabC1PrintDoc
----------------------------------------
Demonstrates how to create a data-bound C1PrintDocument with a crosstab (pivot table).

This sample uses advanced data-binding and scripting techniques to create a C1PrintDocument with a RenderTable that represents a pivot table.
The data is taken from the C1NWind.mdb database.
The pivot table puts product categories from the sample database into column headers and sales years into row headers.
The table has both data-bound rows AND data-bound columns, so it grows both right (for categories) and down (for years).
The cell at the intersection of a row (year) and column (category) contains the total sales amount for that cell's year and category.
That amount is calculated using a class that is created in code and is assigned to the document's UserData property thus making it available to scripting in the document.