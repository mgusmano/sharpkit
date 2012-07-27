
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/webaudio/AudioContext.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as 'partial'. Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

*****************************************************************************************************

  This library is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.

*****************************************************************************************************/

using System;

namespace SharpKit.Html.webaudio
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class AudioContext
{
	public  AudioDestinationNode destination {get; set; }
	public  double currentTime {get; set; }
	public  double sampleRate {get; set; }
	public  AudioListener listener {get; set; }
	public  int activeSourceCount {get; set; }
	public  AudioBuffer createBuffer(int numberOfChannels, int numberOfFrames, double sampleRate) { return default(AudioBuffer); }
	public  AudioBuffer createBuffer(ArrayBuffer buffer, bool mixToMono) { return default(AudioBuffer); }
	public  void decodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback) {}
	public  void decodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback, AudioBufferCallback errorCallback) {}
	public  AudioBufferSourceNode createBufferSource() { return default(AudioBufferSourceNode); }
	public  AudioGainNode createGainNode() { return default(AudioGainNode); }
	public  DelayNode createDelayNode() { return default(DelayNode); }
	public  DelayNode createDelayNode(double maxDelayTime) { return default(DelayNode); }
	public  BiquadFilterNode createBiquadFilter() { return default(BiquadFilterNode); }
	public  WaveShaperNode createWaveShaper() { return default(WaveShaperNode); }
	public  AudioPannerNode createPanner() { return default(AudioPannerNode); }
	public  ConvolverNode createConvolver() { return default(ConvolverNode); }
	public  DynamicsCompressorNode createDynamicsCompressor() { return default(DynamicsCompressorNode); }
	public  RealtimeAnalyserNode createAnalyser() { return default(RealtimeAnalyserNode); }
	public  JavaScriptAudioNode createJavaScriptNode(int bufferSize) { return default(JavaScriptAudioNode); }
	public  JavaScriptAudioNode createJavaScriptNode(int bufferSize, int numberOfInputChannels) { return default(JavaScriptAudioNode); }
	public  JavaScriptAudioNode createJavaScriptNode(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels) { return default(JavaScriptAudioNode); }
	public  Oscillator createOscillator() { return default(Oscillator); }
	public  WaveTable createWaveTable(Float32Array real, Float32Array imag) { return default(WaveTable); }
	public  AudioChannelSplitter createChannelSplitter() { return default(AudioChannelSplitter); }
	public  AudioChannelSplitter createChannelSplitter(int numberOfOutputs) { return default(AudioChannelSplitter); }
	public  AudioChannelMerger createChannelMerger() { return default(AudioChannelMerger); }
	public  AudioChannelMerger createChannelMerger(int numberOfInputs) { return default(AudioChannelMerger); }
	public  EventListener oncomplete {get; set; }
	public  void startRendering() {}
}

}