using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.droppable
{
    [JsType(JsMode.Global)]
    public class PhotoManager
    {
        static jQuery trash;
        static JsString recycle_icon;
        static jQuery gallery;
        static JsString trash_icon;

        static PhotoManager()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            // there's the gallery and the trash
            gallery = new jQuery("#gallery");
            trash = new jQuery("#trash");

            // let the gallery items be draggable
            new jQuery("li", gallery).draggable(new DraggableOptions
            {
                cancel = "a.ui-icon", // clicking an icon won't initiate dragging
                revert = "invalid", // when not dropped, the item will revert back to its initial position
                containment = new jQuery("#demo-frame").length.As<bool>() ? "#demo-frame" : "document", // stick to demo-frame if present
                helper = "clone",
                cursor = "move"
            });
            // let the trash be droppable, accepting the gallery items
            trash.droppable(new DroppableOptions
            {
                accept = "#gallery > li",
                activeClass = "ui-state-highlight",
                drop = (e, ui) => deleteImage(ui.draggable)
            });
            // let the gallery be droppable as well, accepting items from the trash
            gallery.droppable(new DroppableOptions
            {
                accept = "#trash li",
                activeClass = "custom-state-active",
                drop = (@event, ui) => recycleImage(ui.draggable)
            });
            // resolve the icons behavior with event delegation
            new jQuery("ul.gallery > li").click(e =>
            {
                var item = new jQuery(JsContext.@this);
                var target = new jQuery(e.target);

                if (target.@is("a.ui-icon-trash"))
                {
                    deleteImage(item);
                }
                else if (target.@is("a.ui-icon-zoomin"))
                {
                    viewLargerImage(target);
                }
                else if (target.@is("a.ui-icon-refresh"))
                {
                    recycleImage(item);
                }

                JsContext.@return(false);
            });
        }

        // image deletion function
        static void deleteImage(jQuery item)
        {
            recycle_icon = "<a href='link/to/recycle/script/when/we/have/js/off' title='Recycle this image' class='ui-icon ui-icon-refresh'>Recycle image</a>";
            item.fadeOut(() =>
                {
                    var list = new jQuery("ul", trash).length.As<bool>() ?
                        new jQuery("ul", trash) : new jQuery("<ul class='gallery ui-helper-reset'/>").appendTo(trash);
                    item.find("a.ui-icon-trash").remove();
                    item.append(recycle_icon).appendTo(list).fadeIn(() =>
                        {
                            item.animate(new Map { width = "48px" }).find("img").animate(new Map { height = "36px" });
                        });
                });
        }
        // image preview function, demonstrating the ui.dialog used as a modal window
        static void viewLargerImage(jQuery link)
        {
            var src = link.attr("href");
            var title = link.siblings("img").attr("alt");
            var modal = new jQuery("img[src$='" + src + "']");

            if (modal.length.As<bool>())
                modal.dialog("open");
            else
            {
                var img = new jQuery("<img alt='" + title + "' width='384' height='288' style='display: none; padding: 8px;' />")
                .attr("src", src).appendTo("body");
                HtmlContext.window.setTimeout(() =>
                {
                    img.dialog(new DialogOptions
                    {
                        title = title,
                        width = 400,
                        modal = true
                    });
                }, 1);
            }
        }
        // image recycle function
        static void recycleImage(jQuery item)
        {
            trash_icon = "<a href='link/to/trash/script/when/we/have/js/off' title='Delete this image' class='ui-icon ui-icon-trash'>Delete image</a>";
            item.fadeOut(() =>
            {
                item
                .find("a.ui-icon-refresh")
                    .remove()
                .end()
                .css("width", "96px")
                .append(trash_icon)
                .find("img")
                    .css("height", "72px")
                .end()
                .appendTo(gallery)
                .fadeIn();
            });
        }
    }
}