using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using Ext;
using Ext.data;
using Ext.data.proxy;
using Ext.tree;

namespace ExtJsSamples.examples.tree
{
     [JsType(JsMode.Global, Filename = "check-tree-sk.js")]
    public class CheckTree
    {
         static CheckTree()
         {
         }

         //TODO
         static void OnReady()
         {
             var store = ExtContext.create("Ext.data.TreeStore", new TreeStoreConfig
             {
                 //proxy = 
                 // sorter
             });
//             Ext.require([
//    'Ext.tree.*',
//    'Ext.data.*',
//    'Ext.window.MessageBox'
//]);

//Ext.onReady(function() {
//    var store = Ext.create('Ext.data.TreeStore', {
//        proxy: {
//            type: 'ajax',
//            url: 'check-nodes.json'
//        },
//        sorters: [{
//            property: 'leaf',
//            direction: 'ASC'
//        }, {
//            property: 'text',
//            direction: 'ASC'
//        }]
//    });

             var tree = ExtContext.create("Ext.tree.panel", new PanelConfig
             {
                 //store = store,
                 rootVisible = false,
                 useArrows = true,
                 frame = true,
                 title = "Check Tree",
                 renderTo = "tree-div",
                 width = 200,
                 height = 250,
                 //dockedItems =    

             });
//    var tree = Ext.create('Ext.tree.Panel', {
//        store: store,
//        rootVisible: false,
//        useArrows: true,
//        frame: true,
//        title: 'Check Tree',
//        renderTo: 'tree-div',
//        width: 200,
//        height: 250,
//        dockedItems: [{
//            xtype: 'toolbar',
//            items: {
//                text: 'Get checked nodes',
//                handler: function(){
//                    var records = tree.getView().getChecked(),
//                        names = [];
                    
//                    Ext.Array.each(records, function(rec){
//                        names.push(rec.get('text'));
//                    });
                    
//                    Ext.MessageBox.show({
//                        title: 'Selected Nodes',
//                        msg: names.join('<br />'),
//                        icon: Ext.MessageBox.INFO
//                    });
//                }
//            }
//        }]
//    });
//});

         }
    }
}