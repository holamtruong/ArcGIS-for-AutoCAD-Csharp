using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ArcGIS10Types
{
	[GeneratedCode("wsdl", "2.0.50727.3038"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.esri.com/schemas/ArcGIS/10.0")]
	[Serializable]
	public class PropertySet
	{
		private PropertySetProperty[] propertyArrayField;

		[XmlArray(Form = XmlSchemaForm.Unqualified), XmlArrayItem(Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public PropertySetProperty[] PropertyArray
		{
			get
			{
				return this.propertyArrayField;
			}
			set
			{
				this.propertyArrayField = value;
			}
		}
	}
}
