//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.16.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "employe"
	/// <summary>Employee</summary>
	public partial interface IEmploye : IPublishedContent
	{
		/// <summary>Department</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		string Department { get; }

		/// <summary>DoB</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		global::System.DateTime DoB { get; }

		/// <summary>Email</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		string Email { get; }

		/// <summary>Employee Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		string EmployeeName { get; }

		/// <summary>Profile Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		global::Umbraco.Core.Models.MediaWithCrops ProfileImage { get; }
	}

	/// <summary>Employee</summary>
	[PublishedModel("employe")]
	public partial class Employe : PublishedContentModel, IEmploye
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const string ModelTypeAlias = "employe";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Employe, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Employe(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Department
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("department")]
		public virtual string Department => GetDepartment(this);

		/// <summary>Static getter for Department</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static string GetDepartment(IEmploye that) => that.Value<string>("department");

		///<summary>
		/// DoB
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("doB")]
		public virtual global::System.DateTime DoB => GetDoB(this);

		/// <summary>Static getter for DoB</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static global::System.DateTime GetDoB(IEmploye that) => that.Value<global::System.DateTime>("doB");

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("email")]
		public virtual string Email => GetEmail(this);

		/// <summary>Static getter for Email</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static string GetEmail(IEmploye that) => that.Value<string>("email");

		///<summary>
		/// Employee Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("employeeName")]
		public virtual string EmployeeName => GetEmployeeName(this);

		/// <summary>Static getter for Employee Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static string GetEmployeeName(IEmploye that) => that.Value<string>("employeeName");

		///<summary>
		/// Profile Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("profileImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops ProfileImage => GetProfileImage(this);

		/// <summary>Static getter for Profile Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static global::Umbraco.Core.Models.MediaWithCrops GetProfileImage(IEmploye that) => that.Value<global::Umbraco.Core.Models.MediaWithCrops>("profileImage");
	}
}
