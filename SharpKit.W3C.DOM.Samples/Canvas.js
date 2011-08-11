
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null)return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null){$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){d=function(){return arguments.callee.func.apply(arguments.callee.target,arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
buildSpinner({x:50,y:50,size:20,degrees:30});var canvasTimer;var ctx;var i=0;var degreesList;var degrees;var data;function buildSpinner(d)
{data=d;var canvas=document.getElementsByTagName("canvas")[0];canvas.height=100;canvas.width=300;document.getElementsByTagName("article")[0].appendChild(canvas);ctx=canvas.getContext("2d");i=0;degrees=data.degrees;degreesList=new Array();for(i=0;i<degrees;i++)
{degreesList.push(i);}
i=0;canvasTimer=setInterval(draw,1000/degrees);}
function reset()
{ctx.clearRect(0,0,100,100);var left=degreesList.slice(0,1);var right=degreesList.slice(1,degreesList.length);degreesList=right.concat(left);}
function draw()
{var c,s,e;var d=0;if(i==0)
{reset();}
ctx.save();d=degreesList[i];c=Math.floor(255/degrees*i);ctx.strokeStyle="rgb("+c+", "+c+", "+c+")";ctx.lineWidth=data.size;ctx.beginPath();s=Math.floor(360/degrees*(d));e=Math.floor(360/degrees*(d+1))-1;ctx.arc(data.x,data.y,data.size,(Math.PI/180)*s,(Math.PI/180)*e,false);ctx.stroke();ctx.restore();i++;if(i>=degrees)
{i=0;}}