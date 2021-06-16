﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using WorkerServicesDemo.Data.FactoryClasses;
using WorkerServicesDemo.Data.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace WorkerServicesDemo.Data.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitDemoEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits DemoEntity's info objects</summary>
		private void InitDemoEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(DemoFieldIndex), "DemoEntity");
			this.AddElementFieldInfo("DemoEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)DemoFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("DemoEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)DemoFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("DemoEntity", "LastModified", typeof(System.DateTime), false, false, false, false,  (int)DemoFieldIndex.LastModified, 0, 0, 0);
			this.AddElementFieldInfo("DemoEntity", "Value", typeof(System.Int32), false, false, false, false,  (int)DemoFieldIndex.Value, 0, 0, 10);
		}
	}
}