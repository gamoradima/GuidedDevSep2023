namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrMyRealtyEventsSchema

	/// <exclude/>
	public class UsrMyRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrMyRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrMyRealtyEventsSchema(UsrMyRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("370b8c47-8cfa-4660-9e1e-04f9b779678a");
			Name = "UsrMyRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("20734b0f-dd07-4c7e-8f8c-b5dad3d73a58");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,219,48,16,188,11,232,63,44,132,28,36,192,32,146,107,221,6,136,93,39,48,144,62,96,201,189,4,61,208,212,90,97,65,145,2,73,57,85,11,255,123,249,144,83,203,78,145,236,73,90,206,206,206,44,70,210,6,77,75,25,66,137,90,83,163,182,150,204,149,220,242,186,211,212,114,37,147,63,9,184,234,12,151,53,20,189,177,216,76,143,58,199,83,77,163,228,255,222,52,146,133,180,220,114,52,111,128,144,197,14,165,29,144,15,161,219,135,214,61,119,2,36,234,172,96,143,216,208,47,78,61,124,132,116,109,244,10,169,176,253,237,106,189,76,243,31,97,174,237,54,130,51,96,130,26,3,241,249,5,38,120,15,51,106,240,133,151,64,18,221,31,209,169,157,147,204,43,132,157,226,21,124,149,5,221,57,35,153,218,252,68,102,193,160,172,80,79,32,210,205,112,235,92,5,210,27,93,27,192,252,153,237,31,175,175,141,83,64,158,185,14,36,152,79,71,168,72,10,58,88,113,182,179,216,200,35,126,140,173,144,241,134,10,104,53,103,254,68,113,136,220,161,45,251,22,171,185,18,93,35,191,83,209,225,135,1,122,157,249,51,126,243,248,117,241,41,61,217,205,183,144,69,174,107,184,186,60,84,62,194,140,61,249,66,178,52,115,42,25,10,172,156,8,171,59,156,38,103,40,99,181,207,130,11,162,161,53,150,216,180,130,90,47,90,226,19,220,43,70,5,255,77,55,2,139,128,203,6,43,107,131,218,37,85,186,179,187,152,146,21,26,213,105,230,64,74,59,150,201,187,179,53,190,188,197,207,253,16,134,144,177,116,2,233,217,14,67,194,105,150,166,84,106,198,235,248,151,230,164,84,131,134,252,85,27,78,126,108,144,91,165,27,106,179,19,123,110,237,21,185,156,93,156,30,218,151,125,212,234,41,184,95,252,98,216,122,127,135,241,19,244,62,25,127,237,147,125,242,23,81,134,113,202,211,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7e0e8cd4-d04a-0d1c-0d28-23c738576f40"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("20734b0f-dd07-4c7e-8f8c-b5dad3d73a58"),
				CreatedInSchemaUId = new Guid("370b8c47-8cfa-4660-9e1e-04f9b779678a"),
				ModifiedInSchemaUId = new Guid("370b8c47-8cfa-4660-9e1e-04f9b779678a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("370b8c47-8cfa-4660-9e1e-04f9b779678a"));
		}

		#endregion

	}

	#endregion

}

