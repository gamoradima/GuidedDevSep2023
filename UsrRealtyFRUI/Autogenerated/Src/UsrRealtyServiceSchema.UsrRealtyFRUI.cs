﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("842706fb-e948-4f96-b41e-fdc90697e512");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("20734b0f-dd07-4c7e-8f8c-b5dad3d73a58");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,60,43,64,254,129,213,73,6,92,1,189,54,77,1,187,177,13,183,112,28,68,14,114,48,122,96,164,117,34,148,15,133,92,186,17,26,255,123,150,34,147,202,125,184,200,173,7,63,184,59,59,59,59,92,42,46,193,54,188,4,182,2,99,184,213,27,204,63,105,181,169,111,157,225,88,107,117,124,244,227,248,40,113,182,86,183,172,104,45,130,204,11,48,219,186,132,133,174,64,156,28,74,230,215,112,115,24,48,42,177,222,118,125,126,226,250,66,12,228,103,227,63,165,136,153,210,82,246,11,67,131,223,26,122,104,1,214,82,147,2,57,130,7,172,163,10,26,21,13,47,241,171,143,141,108,115,14,72,172,13,41,186,169,69,141,237,37,220,187,218,128,4,133,54,235,31,188,124,118,202,254,81,226,81,121,12,84,3,223,164,113,55,162,46,89,41,184,181,236,18,184,192,54,74,97,239,217,152,91,136,167,33,155,83,182,90,42,209,246,181,19,131,191,142,100,189,108,32,220,79,127,130,100,77,179,206,213,86,127,131,108,1,120,167,43,146,152,94,44,139,85,58,100,99,93,181,5,182,194,203,38,216,130,88,249,45,188,68,243,107,195,155,6,170,161,231,73,188,102,176,56,213,70,114,220,43,8,161,252,179,213,106,72,3,216,70,43,11,135,113,126,112,207,26,103,175,160,172,37,23,108,6,184,210,200,197,72,106,167,112,220,174,218,6,230,85,102,209,248,203,51,157,55,33,54,100,123,193,229,102,3,38,102,58,181,49,75,142,147,255,231,180,209,3,31,238,140,74,234,13,139,148,249,220,158,59,33,150,102,34,27,108,179,126,131,1,123,124,100,7,80,189,142,29,117,146,252,13,223,211,16,144,65,69,98,0,157,81,236,237,187,147,238,188,235,190,11,16,80,34,179,225,231,148,41,248,206,66,44,187,178,96,232,106,21,253,167,75,142,77,105,227,133,147,42,155,58,85,230,133,147,89,122,101,205,133,161,117,185,42,206,210,193,51,106,106,180,204,126,49,131,194,215,119,96,160,43,9,147,164,3,210,62,185,119,92,100,129,55,191,224,134,240,8,38,243,74,102,174,174,246,93,122,233,48,82,85,71,212,243,229,21,108,125,55,159,41,185,141,147,7,127,158,119,196,128,117,194,91,19,60,202,39,15,80,58,132,162,228,130,155,15,17,245,49,27,132,170,104,114,40,234,66,187,215,62,150,217,228,191,122,43,113,179,233,169,76,30,184,108,4,100,189,213,142,227,166,203,47,111,210,151,105,233,179,123,2,243,210,110,28,213,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("842706fb-e948-4f96-b41e-fdc90697e512"));
		}

		#endregion

	}

	#endregion

}
