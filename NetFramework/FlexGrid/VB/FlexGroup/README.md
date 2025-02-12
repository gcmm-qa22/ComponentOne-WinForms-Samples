## FlexGroup
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\VB\FlexGroup)
____
#### Implement Outlook-style grouping and filtering using the FlexGrid.
____
This is an advanced sample. It implements a composite control (FlexGroup) that contains a FlexGrid and a grouping area above it.
The user can drag columns to new positions within the grid or to the grouping area.
When a column is dragged to the grouping area, the grid automatically sorts the data and creates a group for each value on the column.

The FlexGroup control exposes the contained grid via a 'Grid' property.

Other useful properties are:

* FilterRow, a Boolean property that controls the display of a filter row above the data, and
* Groups, a string containing a comma-delimited list of column names that defines the current grouping view.
Most of the code in the sample is used to implement the column header dragging (this is done with a simple class that inherits from the Label control).

The main variable in the sample is the _groups member, a list of columns that defines the groups currently active.
An UpdateGroups() member scans the list to apply the required sorting/grouping.

The sample defines two custom styles, used to paint the grouping area and the group rows on the grid.
The custom styles are editable at design time and are saved with the grid styles.

The sample uses OwnerDraw cells to make the grouped detail rows look like they do in Outlook.
If you set the grid's DrawMode property to normal, the grid will revert to its default appearance.

![screenshot](screenshot.png)
