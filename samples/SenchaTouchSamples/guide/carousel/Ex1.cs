using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ext.carousel;
using Ext;
using SharpKit.JavaScript;

namespace SenchaTouchSamples.guide.carousel
{
    [JsType(JsMode.Global)]
    public class Ex1
    {
        static Ex1()
        {
            ExtClass.create("Ext.Carousel", new
            {
                fullscreen = true,
                defaults = new { styleHtmlContent = true },
                items = new object[]
                {
                    new 
                    {
                        html = "Item 1",
                        style= "background-color= #5E99CC"
                    },
                    new 
                    {
                        html = "Item 2",
                        style= "background-color= #759E60"
                    },
                    new 
                    {
                        html = "Item 3"
                    }
                }
            });
        }
    }

}