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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcTankType : IIfcTankType
	{
		Xbim.Ifc4.HvacDomain.IfcTankTypeEnum IIfcTankType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcTankTypeEnum.PREFORMED:
						//## Handle translation of PREFORMED member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle translation of PREFORMED member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Xbim.Ifc2x3.HVACDomain.IfcTankTypeEnum.SECTIONAL:
						//## Handle translation of SECTIONAL member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle translation of SECTIONAL member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Xbim.Ifc2x3.HVACDomain.IfcTankTypeEnum.EXPANSION:
						return Xbim.Ifc4.HvacDomain.IfcTankTypeEnum.EXPANSION;
					
					case Xbim.Ifc2x3.HVACDomain.IfcTankTypeEnum.PRESSUREVESSEL:
						return Xbim.Ifc4.HvacDomain.IfcTankTypeEnum.PRESSUREVESSEL;
					
					case Xbim.Ifc2x3.HVACDomain.IfcTankTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcTankTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcTankTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcTankTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}