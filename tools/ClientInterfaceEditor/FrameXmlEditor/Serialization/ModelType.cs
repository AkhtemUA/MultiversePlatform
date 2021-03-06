/********************************************************************

The Multiverse Platform is made available under the MIT License.

Copyright (c) 2012 The Multiverse Foundation

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, 
merge, publish, distribute, sublicense, and/or sell copies 
of the Software, and to permit persons to whom the Software 
is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
OR OTHER DEALINGS IN THE SOFTWARE.

*********************************************************************/

using System.ComponentModel;
using Microsoft.MultiverseInterfaceStudio.FrameXml.Controls;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Drawing.Design;

namespace Microsoft.MultiverseInterfaceStudio.FrameXml.Serialization
{
	/// Generated from Ui.xsd into two pieces and merged here.
	/// Manually modified later - DO NOT REGENERATE

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PlayerModelType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TabardModelType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DressUpModelType))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "3.5.20706.1")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.multiverse.net/ui")]
	[System.Xml.Serialization.XmlRootAttribute("Model", Namespace = "http://www.multiverse.net/ui", IsNullable = false)]
	public partial class ModelType : FrameType
	{
		/// <remarks/>
		[XmlElement("FogColor")]
		[Browsable(false)]
		public ColorType FogColorXml
		{
			get
			{
				return ColorType.FromColor(this.FogColor);
			}
			set
			{
				this.FogColor = ColorType.ToColor(value);
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[Category("Appearance")]
		public string file
		{
			get
			{
				return this.Properties.GetValue<string>("file");
			}
			set
			{
				this.Properties["file"] = value;
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(1f)]
		[Category("Appearance")]
		public float scale
		{
			get
			{
				return this.Properties.GetValue<float>("scale");
			}
			set
			{
				this.Properties["scale"] = value;
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0f)]
		[Category("Appearance")]
		public float fogNear
		{
			get
			{
				return this.Properties.GetValue<float>("fogNear");
			}
			set
			{
				this.Properties["fogNear"] = value;
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(1f)]
		[Category("Appearance")]
		public float fogFar
		{
			get
			{
				return this.Properties.GetValue<float>("fogFar");
			}
			set
			{
				this.Properties["fogFar"] = value;
			}
		}
	}
}
