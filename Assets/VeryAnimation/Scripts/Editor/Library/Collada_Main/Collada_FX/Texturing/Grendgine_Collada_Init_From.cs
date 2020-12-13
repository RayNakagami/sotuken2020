using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace VeryAnimation.grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="init_from", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Init_From
	{
		[XmlAttribute("mips_generate")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Mips_Generate;
		
		[XmlAttribute("array_index")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Array_Index;
		
		[XmlAttribute("mip_index")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Mip_Index;
		
		[XmlAttribute("depth")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Depth;
		
		[XmlAttribute("face")]
		[System.ComponentModel.DefaultValueAttribute(Grendgine_Collada_Face.POSITIVE_X)]
		public Grendgine_Collada_Face Face;
		
	    [XmlElement(ElementName = "ref")]
		public string Ref;			
		
	    [XmlElement(ElementName = "hex")]
		public Grendgine_Collada_Hex Hex;			
	}
}

