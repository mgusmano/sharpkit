
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
namespace KendoUISamples.examples.web.menu
{
    [JsType(JsMode.Global)]
    public class Images
    {
        static Images()
        {
        }
        //TODO: 
        static void OnReady()
        {
            new jQuery("#menu-images").kendoMenu(new MenuConfiguration
            {
                //dataSorce== undocument property in menuConfiguration
            });

            //<script>
            //    $("#menu-images").kendoMenu({
            //        dataSource: [
            //            {
            //                text: "Baseball", imageUrl: "../../content/shared/icons/sports/baseball.png",
            //                items: [
            //                    { text: "Top News", imageUrl: "../../content/shared/icons/16/star.png" },
            //                    { text: "Photo Galleries", imageUrl: "../../content/shared/icons/16/photo.png" },
            //                    { text: "Videos Records", imageUrl: "../../content/shared/icons/16/video.png" },
            //                    { text: "Radio Records", imageUrl: "../../content/shared/icons/16/speaker.png" }
            //                ]
            //            },
            //            {
            //                text: "Golf", imageUrl: "../../content/shared/icons/sports/golf.png",
            //                items: [
            //                    { text: "Top News", imageUrl: "../../content/shared/icons/16/star.png" },
            //                    { text: "Photo Galleries", imageUrl: "../../content/shared/icons/16/photo.png" },
            //                    { text: "Videos Records", imageUrl: "../../content/shared/icons/16/video.png" },
            //                    { text: "Radio Records", imageUrl: "../../content/shared/icons/16/speaker.png" }
            //                ]
            //            },
            //            {
            //                text: "Swimming", imageUrl: "../../content/shared/icons/sports/swimming.png",
            //                items: [
            //                    { text: "Top News", imageUrl: "../../content/shared/icons/16/star.png" },
            //                    { text: "Photo Galleries", imageUrl: "../../content/shared/icons/16/photo.png" }
            //                ]
            //            },
            //            {
            //                text: "Snowboarding", imageUrl: "../../content/shared/icons/sports/snowboarding.png",
            //                items: [
            //                    { text: "Photo Galleries", imageUrl: "../../content/shared/icons/16/photo.png" },
            //                    { text: "Videos Records", imageUrl: "../../content/shared/icons/16/video.png" }
            //                ]
            //            }
            //        ]
            //    });
            //</script>
            

            //    <script>
            //    $("#menu-sprites").kendoMenu({
            //        dataSource: [{
            //            text: "Brazil", spriteCssClass: "brazilFlag", items: [
            //                    { text: "History", spriteCssClass: "historyIcon" },
            //                    { text: "Geography", spriteCssClass: "geographyIcon" },
            //                ]
            //        },
            //            {
            //                text: "India", spriteCssClass: "indiaFlag", items: [
            //                    { text: "History", spriteCssClass: "historyIcon" },
            //                    { text: "Geography", spriteCssClass: "geographyIcon" },
            //                ]
            //            },
            //            {
            //                text: "Netherlands", spriteCssClass: "netherlandsFlag", items: [
            //                    { text: "History", spriteCssClass: "historyIcon" },
            //                    { text: "Geography", spriteCssClass: "geographyIcon" },
            //                ]
            //            }]
            //    });
            //</script>        
        }
    }
}