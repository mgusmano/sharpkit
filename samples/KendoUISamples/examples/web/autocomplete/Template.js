/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#titles").kendoAutoComplete(
    {
        minLength: 3,
        dataTextField: "Name",
        template: "<img src=\'${ data.BoxArt.SmallUrl }\' alt=\'${ data.Name }\' /><h3>${ data.Name } <span>${ data.ReleaseYear }</span></h3>",
        dataSource:
        {
            type: "odata",
            serverFiltering: true,
            serverPaging: true,
            pageSize: 20,
            transport: {read: "http://odata.netflix.com/Catalog/Titles"}
        }
    });
};
