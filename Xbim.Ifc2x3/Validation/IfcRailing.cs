using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class IfcRailing : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.SharedBldgElements.IfcRailing");

		/// <summary>
		/// Tests the express where clause WR61
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool WR61() {
			var retVal = false;
			try {
				retVal = !(EXISTS(PredefinedType)) || (PredefinedType != IfcRailingTypeEnum.USERDEFINED) || ((PredefinedType == IfcRailingTypeEnum.USERDEFINED) && EXISTS(this/* as IfcObject*/.ObjectType));
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'WR61' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!WR61())
				yield return new ValidationResult() { Item = this, IssueSource = "WR61", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}