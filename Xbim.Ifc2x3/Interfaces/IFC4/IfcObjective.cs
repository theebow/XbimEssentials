// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ConstraintResource
{
	public partial class @IfcObjective : IIfcObjective
	{

		[CrossSchemaAttribute(typeof(IIfcObjective), 8)]
		IItemSet<IIfcConstraint> IIfcObjective.BenchmarkValues 
		{ 
			get
			{
				//## Handle return of BenchmarkValues for which no match was found
                return _benchmarkValues4 ?? (_benchmarkValues4 = new Common.Collections.ExtendedSingleSet<IfcMetric,IIfcConstraint>(
                    () => BenchmarkValues,
                    v => BenchmarkValues = v,
                    new ItemSet<IIfcConstraint>(this, 0, -8),
                    s => s as IIfcConstraint,
                    t => t as IfcMetric
                    ));
				//##
			} 
		}

		private  Ifc4.Interfaces.IfcLogicalOperatorEnum? _logicalAggregator;


		[CrossSchemaAttribute(typeof(IIfcObjective), 9)]
		Ifc4.Interfaces.IfcLogicalOperatorEnum? IIfcObjective.LogicalAggregator 
		{ 
			get
			{
				return _logicalAggregator;
			} 
			set
			{
				SetValue(v => _logicalAggregator = v, _logicalAggregator, value, "LogicalAggregator", -9);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcObjective), 10)]
		Ifc4.Interfaces.IfcObjectiveEnum IIfcObjective.ObjectiveQualifier 
		{ 
			get
			{
				//## Custom code to handle enumeration of ObjectiveQualifier
				//##
				switch (ObjectiveQualifier)
				{
					case IfcObjectiveEnum.CODECOMPLIANCE:
						return Ifc4.Interfaces.IfcObjectiveEnum.CODECOMPLIANCE;
					
					case IfcObjectiveEnum.DESIGNINTENT:
						return Ifc4.Interfaces.IfcObjectiveEnum.DESIGNINTENT;
					
					case IfcObjectiveEnum.HEALTHANDSAFETY:
						return Ifc4.Interfaces.IfcObjectiveEnum.HEALTHANDSAFETY;
					
					case IfcObjectiveEnum.REQUIREMENT:
						return Ifc4.Interfaces.IfcObjectiveEnum.REQUIREMENT;
					
					case IfcObjectiveEnum.SPECIFICATION:
						return Ifc4.Interfaces.IfcObjectiveEnum.SPECIFICATION;
					
					case IfcObjectiveEnum.TRIGGERCONDITION:
						return Ifc4.Interfaces.IfcObjectiveEnum.TRIGGERCONDITION;
					
					case IfcObjectiveEnum.USERDEFINED:
						//## Optional custom handling of ObjectiveQualifier == .USERDEFINED. 
                        if (UserDefinedQualifier.HasValue)
                            switch (UserDefinedQualifier.Value)
                            {
                                case "CODEWAIVER":
                                case "EXTERNAL":
                                case "MERGECONFLICT":
                                case "MODELVIEW":
                                case "PARAMETER":
                                    return (Ifc4.Interfaces.IfcObjectiveEnum)System.Enum.Parse(typeof(Ifc4.Interfaces.IfcObjectiveEnum), UserDefinedQualifier.Value);
                            }
						//##
						return Ifc4.Interfaces.IfcObjectiveEnum.USERDEFINED;
					
					case IfcObjectiveEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcObjectiveEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ObjectiveQualifier
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcObjectiveEnum.CODECOMPLIANCE:
						ObjectiveQualifier = IfcObjectiveEnum.CODECOMPLIANCE;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.CODEWAIVER:
						//## Handle setting of CODEWAIVER member from IfcObjectiveEnum in property ObjectiveQualifier
                        UserDefinedQualifier = "CODEWAIVER";
				        ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcObjectiveEnum.DESIGNINTENT:
						ObjectiveQualifier = IfcObjectiveEnum.DESIGNINTENT;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.EXTERNAL:
						//## Handle setting of EXTERNAL member from IfcObjectiveEnum in property ObjectiveQualifier
                        UserDefinedQualifier = "EXTERNAL";
				        ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcObjectiveEnum.HEALTHANDSAFETY:
						ObjectiveQualifier = IfcObjectiveEnum.HEALTHANDSAFETY;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.MERGECONFLICT:
						//## Handle setting of MERGECONFLICT member from IfcObjectiveEnum in property ObjectiveQualifier
                        UserDefinedQualifier = value.ToString();
				        ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcObjectiveEnum.MODELVIEW:
						//## Handle setting of MODELVIEW member from IfcObjectiveEnum in property ObjectiveQualifier
						UserDefinedQualifier = value.ToString();
				        ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcObjectiveEnum.PARAMETER:
						//## Handle setting of PARAMETER member from IfcObjectiveEnum in property ObjectiveQualifier
						UserDefinedQualifier = value.ToString();
				        ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcObjectiveEnum.REQUIREMENT:
						ObjectiveQualifier = IfcObjectiveEnum.REQUIREMENT;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.SPECIFICATION:
						ObjectiveQualifier = IfcObjectiveEnum.SPECIFICATION;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.TRIGGERCONDITION:
						ObjectiveQualifier = IfcObjectiveEnum.TRIGGERCONDITION;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.USERDEFINED:
						ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcObjectiveEnum.NOTDEFINED:
						ObjectiveQualifier = IfcObjectiveEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcObjective), 11)]
		Ifc4.MeasureResource.IfcLabel? IIfcObjective.UserDefinedQualifier 
		{ 
			get
			{
				if (!UserDefinedQualifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedQualifier.Value);
			} 
			set
			{
				UserDefinedQualifier = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	    private IItemSet<IIfcConstraint> _benchmarkValues4;
	    //##
	}
}