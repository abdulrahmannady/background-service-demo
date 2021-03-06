//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using WorkerServicesDemo.Data.EntityClasses;
using WorkerServicesDemo.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace WorkerServicesDemo.Data.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Demo entity</summary>
		public EntityQuery<DemoEntity> Demo { get { return Create<DemoEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}