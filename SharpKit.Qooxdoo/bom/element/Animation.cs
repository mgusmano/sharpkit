// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.element
{
    /// <summary>
	/// <para>Wrapper for <see cref="qx.bom.element.AnimationCss"/> and
	/// <see cref="qx.bom.element.AnimationJs"/>. It offers the pubilc API and decides using
	/// feature checks either to use CSS animations or JS animations.</para>
	/// <para>If you use this class, the restrictions of the JavaScript animations apply.
	/// This means that you can not use transforms and custom bezier timing functions.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.element.Animation", OmitOptionalParameters = true, Export = false)]
    public partial class Animation 
    {
		#region Methods

		public Animation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This function takes care of the feature check and starts the animation.
		/// It takes a DOM element to apply the animation to, and a description.
		/// The description should be a map, which could look like this:</para>
		/// <code>
		/// {
		/// "duration": 1000,
		/// "keep": 100,
		/// "keyFrames": {
		/// 0 : {"opacity": 1, "scale": 1},
		/// 100 : {"opacity": 0, "scale": 0}
		/// },
		/// "origin": "50% 50%",
		/// "repeat": 1,
		/// "timing": "ease-out",
		/// "alternate": false,
		/// "delay" : 2000
		/// }
		/// </code>
		/// <para>duration is the time in milliseconds one animation cycle should take.</para>
		/// <para>keep is the key frame to apply at the end of the animation. (optional)
		/// Keep in mind that the keep key is reversed in case you use an reverse
		/// animation or set the alternate key and a even repeat count.</para>
		/// <para>keyFrames is a map of separate frames. Each frame is defined by a
		/// number which is the percentage value of time in the animation. The value
		/// is a map itself which holds css properties or transforms
		/// <see cref="qx.bom.element.Transform"/> (Transforms only for CSS Animations).</para>
		/// <para>origin maps to the transform origin <see cref="qx.bom.element.Transform.SetOrigin"/>
		/// (Only for CSS animations).</para>
		/// <para>repeat is the amount of time the animation should be run in
		/// sequence. You can also use &#8220;infinite&#8221;.</para>
		/// <para>timing takes one of the predefined value:
		/// ease | linear | ease-in
		/// | ease-out | ease-in-out |
		/// cubic-bezier(&lt;number&gt;, &lt;number&gt;, &lt;number&gt;, &lt;number&gt;)
		/// (cubic-bezier only available for CSS animations)</para>
		/// <para>alternate defines if every other animation should be run in reverse order.</para>
		/// <para>delay is the time in milliseconds the animation should wait before start.</para>
		/// </summary>
		/// <param name="el">The element to animate.</param>
		/// <param name="desc">The animations description.</param>
		/// <param name="duration">The duration in milliseconds of the animation which will override the duration given in the description.</param>
		/// <returns>AnimationHandle instance to control the animation.</returns>
		[JsMethod(Name = "animate")]
		public static qx.bom.element.AnimationHandle Animate(qx.html.Element el, object desc, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Starts an animation in reversed order. For further details, take a look at
		/// the <see cref="Animate"/> method.</para>
		/// </summary>
		/// <param name="el">The element to animate.</param>
		/// <param name="desc">The animations description.</param>
		/// <param name="duration">The duration in milliseconds of the animation which will override the duration given in the description.</param>
		/// <returns>AnimationHandle instance to control the animation.</returns>
		[JsMethod(Name = "animateReverse")]
		public static qx.bom.element.AnimationHandle AnimateReverse(qx.html.Element el, object desc, double duration) { throw new NotImplementedException(); }

		#endregion Methods
    }
}