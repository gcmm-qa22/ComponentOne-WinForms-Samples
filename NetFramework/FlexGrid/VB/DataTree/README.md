## DataTree
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\VB\DataTree)
____
#### Bind the grid to a hierarchical data source and show details in child grids.
____
This sample binds the grid to a hierarchical data source and allows you to expand and collapse each master record to show the details in child grids.
Child grids may in turn contain more details.

The result is a "data-tree", similar to the type of grid presented by Microsoft Access 2000 when displaying hierarchical data.

This is accomplished by deriving a control (FlexDataTree) from the C1FlexGrid.
When bound, the control detects subordinate data sources and creates additional instances of itself to display child tables.

![screenshot](screenshot.png)
