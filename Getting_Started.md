# Getting Started with SharpKit #
## Integrating SharpKit into an existing project ##
  * Download and install SharpKit Setup
  * Add the following line on your .csproj file, at the bottom of the 'Import' sections:
> > `<Import Project="$(MSBuildBinPath)\SharpKit\4\SharpKit.Build.targets" />`
  * Add the following lines on your .csproj file, at the bottom of the 'Reference' sections:
```
<Reference Include="SharpKit.JavaScript"/>
<Reference Include="SharpKit.Html4"/>
```
Or
  * Include the files javascript-1.5.cs and html-4.01.cs in your project, these files are available in the SharpKit SDK project, and also in the SharpKit folder on your Program Files.

  * Create a new class and add the following code:

```
[JsType(JsMode.Global, Filename="Site.js")]
	class Site : HtmlContext
	{
	public static void btn_click(HtmlDomEventArgs e)
	{
			document.body.appendChild(document.createTextNode("Hello SharpKit!"));
	}
}
```

  * Compile the project. The `JsType` attribute will cause SharpKit to convert the class Site into the file Site.js
  * Create an .html or .aspx file, and include the Site.js file

```
<html>
<head>
    <script src="Site.js"></script>
</head>
<body>
    <button onclick="btn_click(event)">Click me</button>
</body>
</html>
```

  * View the web page in your browser

Congratulations! You've just created your first JavaScript application from C#. To continue and change the JS file, simply change the CS file and recompile.