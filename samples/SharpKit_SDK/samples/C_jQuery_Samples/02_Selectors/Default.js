/*Generated by SharpKit 5 v4.29.2000*/
function jQuerySelectorsSample_Load()
{
    $(".MyExpander > #Header").mousedown(function(e)
    {
        $(this).siblings(".MyExpander > #Content").toggle();
    });
};