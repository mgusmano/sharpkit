using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.KineticJs
{
    public class Node
    {
        /// <summary>
        /// Node constructor.  Nodes are entities that can be transformed, layered,and have events bound to them. They are the building blocks of a KineticJSapplication
        /// </summary>
        /// <param name="config"></param>
        public Node(object config) { }
        //TODO: danel did this one. whay not constructor?

        /// <summary>
        /// clone node
        /// </summary>
        /// <param name="config">used to override cloned attrs</param>
        /// <returns></returns>
        public Node clone(object config) { return null; }

        /// <summary>
        /// get absolute alpha
        /// </summary>
        /// <returns></returns>
        public object getAbsoluteAlpha() { return null; }
        /// <summary>
        /// get absolute position relative to stage
        /// </summary>
        /// <returns></returns>
        public XYProperty getAbsolutePosition() { return null; }
        /// <summary>
        /// get transform of the node while taking intoaccount the transforms of its parents
        /// </summary>
        /// <returns></returns>
        public object getAbsoluteTransform() { return null; }
        /// <summary>
        /// get absolute z-index by taking into accountall parent and sibling indices
        /// </summary>
        /// <returns></returns>
        public object getAbsoluteZIndex() { return null; }

        /// <summary>
        /// get alpha. Alpha values range from 0 to 1.A node with an alpha of 0 is fully transparent, and a nodewith an alpha of 1 is fully opaque
        /// </summary>
        /// <returns></returns>
        public object getAlpha() { return null; }

        /// <summary>
        /// get attrs
        /// </summary>
        /// <returns></returns>
        public object getAttrs() { return null; }
        /// <summary>
        /// get detection type
        /// </summary>
        /// <returns></returns>
        public Type getDetectionType() { return null; }
        /// <summary>
        /// get drag bounds
        /// </summary>
        /// <returns></returns>
        public Bounds getDragBounds() { return null; }
        /// <summary>
        /// get drag constraint
        /// </summary>
        /// <returns></returns>
        public JsString getDragConstraint() { return null; }
        /// <summary>
        /// get draggable
        /// </summary>
        /// <returns></returns>
        public JsString getDraggable() { return null; }
        /// <summary>
        /// get id
        /// </summary>
        /// <returns></returns>
        public object getId() { return null; }
        /// <summary>
        /// get layer that contains the node
        /// </summary>
        /// <returns></returns>
        public object getLayer() { return null; }
        /// <summary>
        /// get node level in node tree
        /// </summary>
        /// <returns></returns>
        public object getLevel() { return null; }
        /// <summary>
        /// determine if listening to events or not
        /// </summary>
        /// <returns></returns>
        public bool getListening() { return null; }
        /// <summary>
        /// get name
        /// </summary>
        /// <returns></returns>
        public object getName() { return null; }
        /// <summary>
        /// get offset
        /// </summary>
        /// <returns></returns>
        public JsNumber getOffset() { return null; }
        /// <summary>
        /// get parent container
        /// </summary>
        /// <returns></returns>
        public object getParent() { return null; }
        /// <summary>
        /// get node position relative to container
        /// </summary>
        /// <returns></returns>
        public object getPosition() { return null; }
        /// <summary>
        /// get rotation in radians
        /// </summary>
        /// <returns></returns>
        public JsNumber getRotation() { return null; }
        /// <summary>
        /// get rotation in degrees
        /// </summary>
        /// <returns></returns>
        public JsNumber getRotationDeg() { return null; }
        /// <summary>
        /// get scale
        /// </summary>
        /// <returns></returns>
        public object getScale() { return null; }
        /// <summary>
        /// get stage that contains the node
        /// </summary>
        /// <returns></returns>
        public object getStage() { return null; }
        /// <summary>
        /// get transform of the node while not takinginto account the transforms of its parents
        /// </summary>
        /// <returns></returns>
        public object getTransform() { return null; }
        /// <summary>
        /// get node x position
        /// </summary>
        /// <returns></returns>
        public JsNumber getX() { return null; }
        /// <summary>
        /// get node y position
        /// </summary>
        /// <returns></returns>
        public JsNumber getY() { return null; }
        /// <summary>
        /// get zIndex
        /// </summary>
        /// <returns></returns>
        public JsNumber getZIndex() { return null; }
        /// <summary>
        /// hide node
        /// </summary>
        public void hide() { }
        /// <summary>
        /// determine if node is currently in drag and drop mode
        /// </summary>
        public void isDragging() {}
        /// <summary>
        /// determine if shape is visible or not.
        /// Shape is visible onlyif it's visible and all of its ancestors are visible. If one ancestoris invisible, this means that the shape is also invisible
        /// </summary>
        public void isVisible() { }
        /// <summary>
        /// move node by an amount
        /// </summary>
        public void move() { }
        /// <summary>
        /// move node down
        /// </summary>
        public void moveDown() {}
        /// <summary>
        /// move node to another container
        /// </summary>
        /// <param name="newContainer"></param>
        /// <returns></returns>
        public object moveTo(Container newContainer) { return null; }
        /// <summary>
        /// move node to bottom
        /// </summary>
        public void moveToBottom() {}
        /// <summary>
        /// move node to top
        /// </summary>
        /// <returns></returns>
        public void moveToTop() {  }
        /// <summary>
        /// move node up
        /// </summary>
        /// <returns></returns>
        public void moveUp() { }
        /// <summary>
        /// remove event bindings from the node. Pass in a string ofevent types delimmited by a space to remove multiple eventbindings at once such as 'mousedown mouseup mousemove'.include a namespace to remove an event binding by namesuch as 'click.foobar'.
        /// </summary>
        /// <param name="typesStr"></param>
        public void off(JsString typesStr) { }

        /// <summary>
        /// bind events to the node. KineticJS supports mouseover, mousemove,mouseout, mousedown, mouseup, click, dblclick, touchstart, touchmove,touchend, tap, dbltap, dragstart, dragmove, and dragend. Pass in a stringof event types delimmited by a space to bind multiple events at oncesuch as 'mousedown mouseup mousemove'.
        /// include a namespace to bind anevent by name such as 'click.foobar'.
        /// </summary>
        /// <param name="typesStr"></param>
        /// <param name="handler"></param>
        public void on(JsString typesStr, JsFunction handler) { }

        /// <summary>
        /// rotate node by an amount in radians
        /// </summary>
        /// <param name="theta"></param>
        public void rotate(JsNumber theta) { }

        /// <summary>
        /// rotate node by an amount in degrees
        /// </summary>
        /// <param name="theta"></param>
        public void rotateDeg(JsNumber deg) { }

        /// <summary>
        /// set absolute position relative to stage
        /// </summary>
        /// <param name="pos">object containing an x and y property</param>
        public void setAbsolutePosition(XYProperty pos) { }

        /// <summary>
        /// set alpha
        /// </summary>
        /// <param name="alpha">Alpha values range from 0 to 1.A node with an alpha of 0 is fully transparent, and a nodewith an alpha of 1 is fully opaque</param>
        public void setAlpha(object alpha) {}

        /// <summary>
        /// set attrs
        /// </summary>
        /// <param name="config"></param>
        public void setAttrs(object config) {}

        /// <summary>
        /// set default attrs
        /// </summary>
        /// <param name="confic"></param>
        public void setDefaultAttrs(object confic) { }

        /// <summary>
        /// set detection type
        /// </summary>
        /// <param name="type">can be "path" or "pixel"</param>
        public void setDetectionType(Type type) {}

        /// <summary>
        /// set drag bounds
        /// </summary>
        /// <param name="bounds"></param>
        public void setDragBounds(Bounds bounds) { }

        /// <summary>
        /// set drag constraint
        /// </summary>
        /// <param name="constraint"></param>
        public void setDragConstraint(JsString constraint) { }

        /// <summary>
        /// set draggable
        /// </summary>
        /// <param name="constraint"></param>
        public void setDraggable(JsString draggable) {}

        /// <summary>
        /// listen or don't listen to events
        /// </summary>
        /// <param name="listening"></param>
        public void setListening(bool listening) { }

        /// <summary>
        /// set offset
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setOffset(JsNumber x, JsNumber y) {}

        /// <summary>
        /// set node position
        /// </summary>
        /// <param name="point"></param>
        public void setPosition(object point) { }

        /// <summary>
        /// set node rotation in radians
        /// </summary>
        /// <param name="theta"></param>
        public void setRotation(JsNumber theta) {}

        /// <summary>
        /// set node rotation in degrees
        /// </summary>
        /// <param name="theta"></param>
        public void setRotationDeg(JsNumber deg) { }

        /// <summary>
        /// set node scale.
        /// </summary>
        /// <param name="scale"></param>
        public void setScale(JsNumber scale) { }
        //TODO: {Number|Array|Object|List} was writen in type

        /// <summary>
        /// set node x position
        /// </summary>
        /// <param name="x"></param>
        public void setX(JsNumber x) { }

        /// <summary>
        /// set node y position
        /// </summary>
        /// <param name="x"></param>
        public void setY(JsNumber y) { }

        /// <summary>
        /// set zIndex
        /// </summary>
        /// <param name="zIndex"></param>
        public void setZIndex(JsNumber zIndex) { }
        //TODO: zIndex was writhen "int"

        /// <summary>
        /// show node
        /// </summary>
        public void show() { }

        /// <summary>
        /// simulate event
        /// </summary>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public object simulate(JsString eventType) { return null; }

        /// <summary>
        /// transition node to another state.
        /// Any property that can accept a real number can be transitioned, including x, y, rotation, alpha, strokeWidth, radius, scale.x, scale.y, offset.x, offset.y, etc.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public object transitionTo(Config config) { return null; }

    }

    public class Container : Node
    {
    }

    public class XYProperty
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
    }

    public class Type
    {
        public JsString path { get; set; }
        public JsString pixel { get; set; }
    }

    public class Bounds
    {
        /// <summary>
        /// Optional left bounds position
        /// </summary>
        public JsNumber left  { get; set; }
        /// <summary>
        /// Optional top bounds position
        /// </summary>
        public JsNumber top { get; set; }
        /// <summary>
        /// Optional right  bounds position
        /// </summary>
        public JsNumber right { get; set; }
        /// <summary>
        /// Optional bottom  bounds position
        /// </summary>
        public JsNumber bottom { get; set; }
    }

    public class Config
    {
        /// <summary>
        /// Optional. duration that the transition runs in seconds
        /// </summary>
        public JsNumber duration  { get; set; }

        /// <summary>
        /// Optional. easing function. can be linear, ease-in, ease-out, ease-in-out, back-ease-in, back-ease-out, back-ease-in-out,
        /// elastic-ease-in, elastic-ease-out, elastic-ease-in-out, bounce-ease-out, bounce-ease-in, bounce-ease-in-out, strong-ease-in, strong-ease-out, or strong-ease-in-out linear is the default
        /// </summary>
        public JsString easing  { get; set; }

        /// <summary>
        /// Optional. callback function to be executed when transition completes
        /// </summary>
        public ConfigCB callback  { get; set; } 
    }

    /// <summary>
    /// callback function to be executed when transition completes
    /// </summary>
    /// <param name="callback"></param>
    public delegate void ConfigCB(JsAction callback);
    //TODO: danel chack
}
