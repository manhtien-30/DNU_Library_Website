//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.1.0+802e5a8
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "featureComponentNoConfiguration"
	/// <summary>Feature Component - No Configuration</summary>
	public partial interface IFeatureComponentNoConfiguration : IPublishedElement
	{
		/// <summary>No Configuration</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string NoConfiguration { get; }
	}

	/// <summary>Feature Component - No Configuration</summary>
	[PublishedModel("featureComponentNoConfiguration")]
	public partial class FeatureComponentNoConfiguration : PublishedElementModel, IFeatureComponentNoConfiguration
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		public new const string ModelTypeAlias = "featureComponentNoConfiguration";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FeatureComponentNoConfiguration, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FeatureComponentNoConfiguration(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// No Configuration: No configuration required
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("noConfiguration")]
		public virtual string NoConfiguration => GetNoConfiguration(this, _publishedValueFallback);

		/// <summary>Static getter for No Configuration</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.1.0+802e5a8")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetNoConfiguration(IFeatureComponentNoConfiguration that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "noConfiguration");
	}
}