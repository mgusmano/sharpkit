
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
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#menu-images").kendoMenu(new MenuConfiguration
            {
                dataSource = new JsArray {
                   new {text = "Baseball", imageUrl = "../../content/shared/icons/sports/baseball.png", item = new JsArray {
                                new { text = "Top News", imageUrl = "../../content/shared/icons/16/star.png" },
                                new { text = "Photo Galleries", imageUrl = "../../content/shared/icons/16/photo.png" },
                                new { text = "Videos Records", imageUrl = "../../content/shared/icons/16/video.png" },
                                new { text = "Radio Records", imageUrl = "../../content/shared/icons/16/speaker.png" }
                   }
                   },
                   new{ text = "Golf", imageUrl = "../../content/shared/icons/sports/golf.png", items = new JsArray {
                                new { text = "Top News", imageUrl = "../../content/shared/icons/16/star.png" },
                                new { text = "Photo Galleries", imageUrl = "../../content/shared/icons/16/photo.png" },
                                new { text = "Videos Records", imageUrl = "../../content/shared/icons/16/video.png" },
                                new { text = "Radio Records", imageUrl = "../../content/shared/icons/16/speaker.png" }
                            }
                        },
                        new { text = "Swimming", imageUrl = "../../content/shared/icons/sports/swimming.png", items = new JsArray {
                                new { text = "Top News", imageUrl = "../../content/shared/icons/16/star.png" },
                                new { text = "Photo Galleries", imageUrl = "../../content/shared/icons/16/photo.png" }
                            }
                        },
                        new { text = "Snowboarding", imageUrl = "../../content/shared/icons/sports/snowboarding.png", items = new JsArray {
                                new { text = "Photo Galleries", imageUrl = "../../content/shared/icons/16/photo.png" },
                                new { text = "Videos Records", imageUrl = "../../content/shared/icons/16/video.png" }
                            }
                        }
               }
            });
            new jQuery("#menu-sprites").kendoMenu(new MenuConfiguration
            {
                dataSource = new JsArray {
                    new { text = "Brazil", spriteCssClass = "brazilFlag", items = new JsArray {
                        new { text = "History", spriteCssClass = "historyIcon" },
                        new { text = "Geography", spriteCssClass = "geographyIcon" },
                        }
                    },
                    new { text = "India", spriteCssClass = "indiaFlag", items = new JsArray {
                        new { text = "History", spriteCssClass = "historyIcon" },
                        new { text = "Geography", spriteCssClass = "geographyIcon" },
                        }
                    },
                    new { text = "Netherlands", spriteCssClass = "netherlandsFlag", items = new JsArray {
                        new { text = "History", spriteCssClass = "historyIcon" },
                        new { text = "Geography", spriteCssClass = "geographyIcon" },
                        }
                    }
                }
            });
        }
    }
}