/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("#datetimepicker").kendoDateTimePicker( {change: onChange, close: onClose, open: onOpen});
};
function onOpen(e)
{
    kendoConsole.log("Open: " + e.view + " view");
};
function onClose(e)
{
    kendoConsole.log("Close: " + e.view + " view");
};
function onChange()
{
    kendoConsole.log("Change :: " + kendo.toString(this.value(), "g"));
};