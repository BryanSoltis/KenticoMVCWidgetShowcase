//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(MVCWidgetsPage.CLASS_NAME, typeof(MVCWidgetsPage))]

namespace CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase
{
	/// <summary>
	/// Represents a content item of type MVCWidgetsPage.
	/// </summary>
	public partial class MVCWidgetsPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "KenticoMVCWidgetShowcase.MVCWidgetsPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with MVCWidgetsPage fields.
		/// </summary>
		private readonly MVCWidgetsPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MVCWidgetsPageID.
		/// </summary>
		[DatabaseIDField]
		public int MVCWidgetsPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MVCWidgetsPageID"), 0);
			}
			set
			{
				SetValue("MVCWidgetsPageID", value);
			}
		}


		/// <summary>
		/// Content Page Name.
		/// </summary>
		[DatabaseField]
		public string ContentPageName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContentPageName"), @"");
			}
			set
			{
				SetValue("ContentPageName", value);
			}
		}


		/// <summary>
		/// Header Text.
		/// </summary>
		[DatabaseField]
		public string HeaderText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HeaderText"), @"");
			}
			set
			{
				SetValue("HeaderText", value);
			}
		}


		/// <summary>
		/// Intro Text.
		/// </summary>
		[DatabaseField]
		public string IntroText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("IntroText"), @"");
			}
			set
			{
				SetValue("IntroText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MVCWidgetsPage fields.
		/// </summary>
		[RegisterProperty]
		public MVCWidgetsPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MVCWidgetsPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MVCWidgetsPageFields : AbstractHierarchicalObject<MVCWidgetsPageFields>
		{
			/// <summary>
			/// The content item of type MVCWidgetsPage that is a target of the extended API.
			/// </summary>
			private readonly MVCWidgetsPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MVCWidgetsPageFields" /> class with the specified content item of type MVCWidgetsPage.
			/// </summary>
			/// <param name="instance">The content item of type MVCWidgetsPage that is a target of the extended API.</param>
			public MVCWidgetsPageFields(MVCWidgetsPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MVCWidgetsPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MVCWidgetsPageID;
				}
				set
				{
					mInstance.MVCWidgetsPageID = value;
				}
			}


			/// <summary>
			/// Content Page Name.
			/// </summary>
			public string ContentPageName
			{
				get
				{
					return mInstance.ContentPageName;
				}
				set
				{
					mInstance.ContentPageName = value;
				}
			}


			/// <summary>
			/// Header Text.
			/// </summary>
			public string HeaderText
			{
				get
				{
					return mInstance.HeaderText;
				}
				set
				{
					mInstance.HeaderText = value;
				}
			}


			/// <summary>
			/// Intro Text.
			/// </summary>
			public string IntroText
			{
				get
				{
					return mInstance.IntroText;
				}
				set
				{
					mInstance.IntroText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MVCWidgetsPage" /> class.
		/// </summary>
		public MVCWidgetsPage() : base(CLASS_NAME)
		{
			mFields = new MVCWidgetsPageFields(this);
		}

		#endregion
	}
}