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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,220,48,16,189,7,242,31,6,211,131,13,139,72,174,77,27,232,110,54,101,33,253,96,237,237,165,244,160,149,103,29,5,125,24,73,222,212,45,253,239,29,89,222,102,227,77,33,131,193,210,232,205,155,121,143,49,92,163,111,185,64,168,208,57,238,237,46,176,133,53,59,217,116,142,7,105,205,249,217,239,243,51,160,232,188,52,13,148,189,15,168,175,142,83,199,133,90,91,243,223,71,135,108,105,130,12,18,253,107,48,108,185,71,19,14,208,239,67,186,31,114,119,146,134,48,232,242,82,220,163,230,159,73,3,188,135,108,227,221,26,185,10,253,237,122,179,202,138,31,169,176,237,182,74,10,16,138,123,15,233,253,5,42,120,11,115,238,241,133,151,196,50,154,112,68,104,247,52,182,172,17,246,86,214,240,197,148,124,79,98,114,187,125,64,17,192,163,169,209,205,32,17,206,113,71,202,6,218,15,174,241,128,197,19,221,17,115,140,45,77,193,254,177,29,104,176,184,122,14,75,188,224,6,61,36,62,79,137,34,21,76,192,53,10,169,185,130,214,73,17,157,74,85,236,35,134,170,111,177,94,88,213,105,243,141,171,14,223,141,208,235,60,186,249,53,226,55,229,77,54,237,46,119,144,39,178,107,184,188,56,68,241,28,52,17,22,3,217,202,47,184,17,168,176,166,57,130,235,144,152,79,113,62,184,184,24,180,154,158,55,88,161,110,21,15,113,114,131,143,112,103,5,87,242,23,223,42,44,7,92,62,234,217,120,116,180,187,134,252,167,197,101,107,244,182,115,130,64,214,17,203,236,180,77,140,168,243,83,63,238,197,176,112,217,12,178,147,30,158,13,254,172,124,101,237,92,54,233,150,21,172,178,227,12,197,43,132,144,128,148,96,183,214,105,30,242,137,64,106,124,201,46,230,111,78,252,142,17,238,157,125,28,12,88,254,20,216,70,137,135,250,41,252,207,211,117,60,210,143,190,191,164,50,148,147,237,3,0,0 };
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

