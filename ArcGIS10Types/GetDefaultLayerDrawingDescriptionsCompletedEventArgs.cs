using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace ArcGIS10Types
{
	[GeneratedCode("wsdl", "2.0.50727.3038"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetDefaultLayerDrawingDescriptionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public LayerDrawingDescription[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (LayerDrawingDescription[])this.results[0];
			}
		}

		internal GetDefaultLayerDrawingDescriptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
