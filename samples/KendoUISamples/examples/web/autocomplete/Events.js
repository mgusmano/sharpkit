/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    var data = ["Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Northern Marianas Islands", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Virgin Islands", "Washington", "West Virginia", "Wisconsin", "Wyoming"];
    $("#products").kendoAutoComplete(
    {
        dataSource: data,
        select: function (e)
        {
            onSelect(e);
        },
        change: onChange,
        close: onClose,
        open: onOpen
    });
};
function onOpen()
{
    if ("kendoConsole" in window)
    {
        kendoConsole.log("event :: open");
    }
};
function onClose()
{
    if ("kendoConsole" in window)
    {
        kendoConsole.log("event :: close");
    }
};
function onChange()
{
    if ("kendoConsole" in window)
    {
        kendoConsole.log("event :: change");
    }
};
function onSelect(e)
{
    if ("kendoConsole" in window)
    {
         var dataItem = this.dataItem(e.item.index());;
          kendoConsole.log('event :: select (' + dataItem + ')');;
    }
};
