using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;

using THREE;

namespace THREE.Example
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : jQueryContextBase
    {
        static void DefaultClient_Load()
        {
            J(document.body).append("Ready<br/>");
        }
        static void btnTest_click(HtmlDomEventArgs e)
        {
	        // set the scene size
	        float WIDTH = 400;
	        float HEIGHT = 300;

	        // set some camera attributes
	        float VIEW_ANGLE = 45;
	        float ASPECT = WIDTH / HEIGHT;
	        float NEAR = 0.1f;
	        float FAR = 10000;

	        // get the DOM element to attach to
	        // - assume we've got jQuery to hand
	        jQuery container = J("#container");

	        // create a WebGL renderer, camera
	        // and a scene
            WebGLRenderer renderer = new WebGLRenderer();
	        Camera camera = new PerspectiveCamera(VIEW_ANGLE, ASPECT, NEAR, FAR  );
	        Scene scene= new Scene();

	        // the camera starts at 0,0,0 so pull it back
	        camera.position.z = 300;

	        // start the renderer
	        renderer.setSize(WIDTH, HEIGHT);

	        // attach the render-supplied DOM element
	        container.append(renderer.domElement);

	        // create the sphere's material
            MeshLambertMaterial sphereMaterial = new MeshLambertMaterial(new MeshLambertMaterialOptions { color = 0xcc0000 });

            // set up the sphere vars
            int radius = 50, segments = 16, rings = 16;

            // create a new mesh with sphere geometry -
            // we will cover the sphereMaterial next!
            Mesh sphere = new Mesh(new SphereGeometry(radius, segments, rings), sphereMaterial);

            // add the sphere to the scene
            scene.add(sphere);

            // create a point light
            var pointLight = new PointLight(0xFFFFFF);

            // set its position
            pointLight.position.x = 10;
            pointLight.position.y = 50;
            pointLight.position.z = 130;

            // add to the scene
            scene.add(pointLight);

            // draw!
            renderer.render(scene, camera);

        }
    }
}