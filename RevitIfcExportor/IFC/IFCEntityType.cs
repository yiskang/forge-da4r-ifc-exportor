﻿//
// BIM IFC export alternate UI library: this library works with Autodesk(R) Revit(R) to provide an alternate user interface for the export of IFC files from Revit.
// Copyright (C) 2013  Autodesk, Inc.
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// ref: https://github.com/Autodesk/revit-ifc/tree/9a6fc912fb8510647f9d2bcc0d57b0451a2194b6/Source/Revit.IFC.Common/Enums
//

namespace Revit.IFC.Common.Enums
{
    /// <summary>
    /// IFC entity types. Combining IFC2x3 and IFC4 (Add2) entities. 
    /// List of Entities for IFC2x is found in IFC2xEntityType.cs
    /// List of Entities for IFC4 is found in IFC4EntityType.cs
    /// </summary>
    public enum IFCEntityType
    {
        Ifc2DCompositeCurve,
        IfcActionRequest,
        IfcActor,
        IfcActorRole,
        IfcActuator,
        IfcActuatorType,
        IfcAddress,
        IfcAdvancedBrep,
        IfcAdvancedBrepWithVoids,
        IfcAdvancedFace,
        IfcAirTerminal,
        IfcAirTerminalBox,
        IfcAirTerminalBoxType,
        IfcAirTerminalType,
        IfcAirToAirHeatRecovery,
        IfcAirToAirHeatRecoveryType,
        IfcAlarm,
        IfcAlarmType,
        IfcAngularDimension,
        IfcAnnotation,
        IfcAnnotationCurveOccurrence,
        IfcAnnotationFillArea,
        IfcAnnotationFillAreaOccurrence,
        IfcAnnotationOccurrence,
        IfcAnnotationSurface,
        IfcAnnotationSurfaceOccurrence,
        IfcAnnotationSymbolOccurrence,
        IfcAnnotationTextOccurrence,
        IfcApplication,
        IfcAppliedValue,
        IfcAppliedValueRelationship,
        IfcApproval,
        IfcApprovalActorRelationship,
        IfcApprovalPropertyRelationship,
        IfcApprovalRelationship,
        IfcArbitraryClosedProfileDef,
        IfcArbitraryOpenProfileDef,
        IfcArbitraryProfileDefWithVoids,
        IfcAsset,
        IfcAsymmetricIShapeProfileDef,
        IfcAudioVisualAppliance,
        IfcAudioVisualApplianceType,
        IfcAxis1Placement,
        IfcAxis2Placement2D,
        IfcAxis2Placement3D,
        IfcBeam,
        IfcBeamStandardCase,
        IfcBeamType,
        IfcBezierCurve,
        IfcBlobTexture,
        IfcBlock,
        IfcBoiler,
        IfcBoilerType,
        IfcBooleanClippingResult,
        IfcBooleanResult,
        IfcBoundaryCondition,
        IfcBoundaryCurve,
        IfcBoundaryEdgeCondition,
        IfcBoundaryFaceCondition,
        IfcBoundaryNodeCondition,
        IfcBoundaryNodeConditionWarping,
        IfcBoundedCurve,
        IfcBoundedSurface,
        IfcBoundingBox,
        IfcBoxedHalfSpace,
        IfcBSplineCurve,
        IfcBSplineCurveWithKnots,
        IfcBSplineSurface,
        IfcBSplineSurfaceWithKnots,
        IfcBuilding,
        IfcBuildingElement,
        IfcBuildingElementComponent,
        IfcBuildingElementPart,
        IfcBuildingElementPartType,
        IfcBuildingElementProxy,
        IfcBuildingElementProxyType,
        IfcBuildingElementType,
        IfcBuildingStorey,
        IfcBuildingSystem,
        IfcBurner,
        IfcBurnerType,
        IfcCableCarrierFitting,
        IfcCableCarrierFittingType,
        IfcCableCarrierSegment,
        IfcCableCarrierSegmentType,
        IfcCableFitting,
        IfcCableFittingType,
        IfcCableSegment,
        IfcCableSegmentType,
        IfcCalendarDate,
        IfcCartesianPoint,
        IfcCartesianPointList,
        IfcCartesianPointList2D,
        IfcCartesianPointList3D,
        IfcCartesianTransformationOperator,
        IfcCartesianTransformationOperator2D,
        IfcCartesianTransformationOperator2DnonUniform,
        IfcCartesianTransformationOperator3D,
        IfcCartesianTransformationOperator3DnonUniform,
        IfcCenterLineProfileDef,
        IfcChamferEdgeFeature,
        IfcChiller,
        IfcChillerType,
        IfcChimney,
        IfcChimneyType,
        IfcCircle,
        IfcCircleHollowProfileDef,
        IfcCircleProfileDef,
        IfcCivilElement,
        IfcCivilElementType,
        IfcClassification,
        IfcClassificationItem,
        IfcClassificationItemRelationship,
        IfcClassificationNotation,
        IfcClassificationNotationFacet,
        IfcClassificationReference,
        IfcClosedShell,
        IfcCoil,
        IfcCoilType,
        IfcColourRgb,
        IfcColourRgbList,
        IfcColourSpecification,
        IfcColumn,
        IfcColumnStandardCase,
        IfcColumnType,
        IfcCommunicationsAppliance,
        IfcCommunicationsApplianceType,
        IfcComplexProperty,
        IfcComplexPropertyTemplate,
        IfcCompositeCurve,
        IfcCompositeCurveOnSurface,
        IfcCompositeCurveSegment,
        IfcCompositeProfileDef,
        IfcCompressor,
        IfcCompressorType,
        IfcCondenser,
        IfcCondenserType,
        IfcCondition,
        IfcConditionCriterion,
        IfcConic,
        IfcConnectedFaceSet,
        IfcConnectionCurveGeometry,
        IfcConnectionGeometry,
        IfcConnectionPointEccentricity,
        IfcConnectionPointGeometry,
        IfcConnectionPortGeometry,
        IfcConnectionSurfaceGeometry,
        IfcConnectionVolumeGeometry,
        IfcConstraint,
        IfcConstraintAggregationRelationship,
        IfcConstraintClassificationRelationship,
        IfcConstraintRelationship,
        IfcConstructionEquipmentResource,
        IfcConstructionEquipmentResourceType,
        IfcConstructionMaterialResource,
        IfcConstructionMaterialResourceType,
        IfcConstructionProductResource,
        IfcConstructionProductResourceType,
        IfcConstructionResource,
        IfcConstructionResourceType,
        IfcContext,
        IfcContextDependentUnit,
        IfcControl,
        IfcController,
        IfcControllerType,
        IfcConversionBasedUnit,
        IfcConversionBasedUnitWithOffset,
        IfcCooledBeam,
        IfcCooledBeamType,
        IfcCoolingTower,
        IfcCoolingTowerType,
        IfcCoordinatedUniversalTimeOffset,
        IfcCoordinateOperation,
        IfcCoordinateReferenceSystem,
        IfcCostItem,
        IfcCostSchedule,
        IfcCostValue,
        IfcCovering,
        IfcCoveringType,
        IfcCraneRailAShapeProfileDef,
        IfcCraneRailFShapeProfileDef,
        IfcCrewResource,
        IfcCrewResourceType,
        IfcCsgPrimitive3D,
        IfcCsgSolid,
        IfcCShapeProfileDef,
        IfcCurrencyRelationship,
        IfcCurtainWall,
        IfcCurtainWallType,
        IfcCurve,
        IfcCurveBoundedPlane,
        IfcCurveBoundedSurface,
        IfcCurveStyle,
        IfcCurveStyleFont,
        IfcCurveStyleFontAndScaling,
        IfcCurveStyleFontPattern,
        IfcCylindricalSurface,
        IfcDamper,
        IfcDamperType,
        IfcDateAndTime,
        IfcDefinedSymbol,
        IfcDerivedProfileDef,
        IfcDerivedUnit,
        IfcDerivedUnitElement,
        IfcDiameterDimension,
        IfcDimensionalExponents,
        IfcDimensionCalloutRelationship,
        IfcDimensionCurve,
        IfcDimensionCurveDirectedCallout,
        IfcDimensionCurveTerminator,
        IfcDimensionPair,
        IfcDirection,
        IfcDiscreteAccessory,
        IfcDiscreteAccessoryType,
        IfcDistributionChamberElement,
        IfcDistributionChamberElementType,
        IfcDistributionCircuit,
        IfcDistributionControlElement,
        IfcDistributionControlElementType,
        IfcDistributionElement,
        IfcDistributionElementType,
        IfcDistributionFlowElement,
        IfcDistributionFlowElementType,
        IfcDistributionPort,
        IfcDistributionSystem,
        IfcDocumentElectronicFormat,
        IfcDocumentInformation,
        IfcDocumentInformationRelationship,
        IfcDocumentReference,
        IfcDoor,
        IfcDoorLiningProperties,
        IfcDoorPanelProperties,
        IfcDoorStandardCase,
        IfcDoorStyle,
        IfcDoorType,
        IfcDraughtingCallout,
        IfcDraughtingCalloutRelationship,
        IfcDraughtingPreDefinedColour,
        IfcDraughtingPreDefinedCurveFont,
        IfcDraughtingPreDefinedTextFont,
        IfcDuctFitting,
        IfcDuctFittingType,
        IfcDuctSegment,
        IfcDuctSegmentType,
        IfcDuctSilencer,
        IfcDuctSilencerType,
        IfcEdge,
        IfcEdgeCurve,
        IfcEdgeFeature,
        IfcEdgeLoop,
        IfcElectricalBaseProperties,
        IfcElectricalCircuit,
        IfcElectricalElement,
        IfcElectricAppliance,
        IfcElectricApplianceType,
        IfcElectricDistributionBoard,
        IfcElectricDistributionBoardType,
        IfcElectricDistributionPoint,
        IfcElectricFlowStorageDevice,
        IfcElectricFlowStorageDeviceType,
        IfcElectricGenerator,
        IfcElectricGeneratorType,
        IfcElectricHeaterType,
        IfcElectricMotor,
        IfcElectricMotorType,
        IfcElectricTimeControl,
        IfcElectricTimeControlType,
        IfcElement,
        IfcElementarySurface,
        IfcElementAssembly,
        IfcElementAssemblyType,
        IfcElementComponent,
        IfcElementComponentType,
        IfcElementQuantity,
        IfcElementType,
        IfcEllipse,
        IfcEllipseProfileDef,
        IfcEnergyConversionDevice,
        IfcEnergyConversionDeviceType,
        IfcEnergyProperties,
        IfcEngine,
        IfcEngineType,
        IfcEnvironmentalImpactValue,
        IfcEquipmentElement,
        IfcEquipmentStandard,
        IfcEvaporativeCooler,
        IfcEvaporativeCoolerType,
        IfcEvaporator,
        IfcEvaporatorType,
        IfcEvent,
        IfcEventTime,
        IfcEventType,
        IfcExtendedMaterialProperties,
        IfcExtendedProperties,
        IfcExternalInformation,
        IfcExternallyDefinedHatchStyle,
        IfcExternallyDefinedSurfaceStyle,
        IfcExternallyDefinedSymbol,
        IfcExternallyDefinedTextFont,
        IfcExternalReference,
        IfcExternalReferenceRelationship,
        IfcExternalSpatialElement,
        IfcExternalSpatialStructureElement,
        IfcExtrudedAreaSolid,
        IfcExtrudedAreaSolidTapered,
        IfcFace,
        IfcFaceBasedSurfaceModel,
        IfcFaceBound,
        IfcFaceOuterBound,
        IfcFaceSurface,
        IfcFacetedBrep,
        IfcFacetedBrepWithVoids,
        IfcFailureConnectionCondition,
        IfcFan,
        IfcFanType,
        IfcFastener,
        IfcFastenerType,
        IfcFeatureElement,
        IfcFeatureElementAddition,
        IfcFeatureElementSubtraction,
        IfcFillAreaStyle,
        IfcFillAreaStyleHatching,
        IfcFillAreaStyleTiles,
        IfcFillAreaStyleTileSymbolWithStyle,
        IfcFilter,
        IfcFilterType,
        IfcFireSuppressionTerminal,
        IfcFireSuppressionTerminalType,
        IfcFixedReferenceSweptAreaSolid,
        IfcFlowController,
        IfcFlowControllerType,
        IfcFlowFitting,
        IfcFlowFittingType,
        IfcFlowInstrument,
        IfcFlowInstrumentType,
        IfcFlowMeter,
        IfcFlowMeterType,
        IfcFlowMovingDevice,
        IfcFlowMovingDeviceType,
        IfcFlowSegment,
        IfcFlowSegmentType,
        IfcFlowStorageDevice,
        IfcFlowStorageDeviceType,
        IfcFlowTerminal,
        IfcFlowTerminalType,
        IfcFlowTreatmentDevice,
        IfcFlowTreatmentDeviceType,
        IfcFluidFlowProperties,
        IfcFooting,
        IfcFootingType,
        IfcFuelProperties,
        IfcFurnishingElement,
        IfcFurnishingElementType,
        IfcFurniture,
        IfcFurnitureStandard,
        IfcFurnitureType,
        IfcGasTerminalType,
        IfcGeneralMaterialProperties,
        IfcGeneralProfileProperties,
        IfcGeographicElement,
        IfcGeographicElementType,
        IfcGeometricCurveSet,
        IfcGeometricRepresentationContext,
        IfcGeometricRepresentationItem,
        IfcGeometricRepresentationSubContext,
        IfcGeometricSet,
        IfcGrid,
        IfcGridAxis,
        IfcGridPlacement,
        IfcGroup,
        IfcHalfSpaceSolid,
        IfcHeatExchanger,
        IfcHeatExchangerType,
        IfcHumidifier,
        IfcHumidifierType,
        IfcHygroscopicMaterialProperties,
        IfcImageTexture,
        IfcIndexedColourMap,
        IfcIndexedPolyCurve,
        IfcIndexedPolygonalFace,
        IfcIndexedPolygonalFaceWithVoids,
        IfcIndexedTextureMap,
        IfcIndexedTriangleTextureMap,
        IfcInterceptor,
        IfcInterceptorType,
        IfcIntersectionCurve,
        IfcInventory,
        IfcIrregularTimeSeries,
        IfcIrregularTimeSeriesValue,
        IfcIShapeProfileDef,
        IfcJunctionBox,
        IfcJunctionBoxType,
        IfcLaborResource,
        IfcLaborResourceType,
        IfcLagTime,
        IfcLamp,
        IfcLampType,
        IfcLibraryInformation,
        IfcLibraryReference,
        IfcLightDistributionData,
        IfcLightFixture,
        IfcLightFixtureType,
        IfcLightIntensityDistribution,
        IfcLightSource,
        IfcLightSourceAmbient,
        IfcLightSourceDirectional,
        IfcLightSourceGoniometric,
        IfcLightSourcePositional,
        IfcLightSourceSpot,
        IfcLine,
        IfcLinearDimension,
        IfcLocalPlacement,
        IfcLocalTime,
        IfcLoop,
        IfcLShapeProfileDef,
        IfcManifoldSolidBrep,
        IfcMapConversion,
        IfcMappedItem,
        IfcMaterial,
        IfcMaterialClassificationRelationship,
        IfcMaterialConstituent,
        IfcMaterialConstituentSet,
        IfcMaterialDefinition,
        IfcMaterialDefinitionRepresentation,
        IfcMaterialLayer,
        IfcMaterialLayerSet,
        IfcMaterialLayerSetUsage,
        IfcMaterialLayerWithOffsets,
        IfcMaterialList,
        IfcMaterialProfile,
        IfcMaterialProfileSet,
        IfcMaterialProfileSetUsage,
        IfcMaterialProfileSetUsageTapering,
        IfcMaterialProfileWithOffsets,
        IfcMaterialProperties,
        IfcMaterialRelationship,
        IfcMaterialUsageDefinition,
        IfcMeasureWithUnit,
        IfcMechanicalConcreteMaterialProperties,
        IfcMechanicalFastener,
        IfcMechanicalFastenerType,
        IfcMechanicalMaterialProperties,
        IfcMechanicalSteelMaterialProperties,
        IfcMedicalDevice,
        IfcMedicalDeviceType,
        IfcMember,
        IfcMemberStandardCase,
        IfcMemberType,
        IfcMetric,
        IfcMirroredProfileDef,
        IfcMonetaryUnit,
        IfcMotorConnection,
        IfcMotorConnectionType,
        IfcMove,
        IfcNamedUnit,
        IfcObject,
        IfcObjectDefinition,
        IfcObjective,
        IfcObjectPlacement,
        IfcOccupant,
        IfcOffsetCurve2D,
        IfcOffsetCurve3D,
        IfcOneDirectionRepeatFactor,
        IfcOpeningElement,
        IfcOpeningStandardCase,
        IfcOpenShell,
        IfcOpticalMaterialProperties,
        IfcOrderAction,
        IfcOrganization,
        IfcOrganizationRelationship,
        IfcOrientedEdge,
        IfcOuterBoundaryCurve,
        IfcOutlet,
        IfcOutletType,
        IfcOwnerHistory,
        IfcParameterizedProfileDef,
        IfcPath,
        IfcPcurve,
        IfcPerformanceHistory,
        IfcPermeableCoveringProperties,
        IfcPermit,
        IfcPerson,
        IfcPersonAndOrganization,
        IfcPhysicalComplexQuantity,
        IfcPhysicalQuantity,
        IfcPhysicalSimpleQuantity,
        IfcPile,
        IfcPileType,
        IfcPipeFitting,
        IfcPipeFittingType,
        IfcPipeSegment,
        IfcPipeSegmentType,
        IfcPixelTexture,
        IfcPlacement,
        IfcPlanarBox,
        IfcPlanarExtent,
        IfcPlane,
        IfcPlate,
        IfcPlateStandardCase,
        IfcPlateType,
        IfcPoint,
        IfcPointOnCurve,
        IfcPointOnSurface,
        IfcPolygonalBoundedHalfSpace,
        IfcPolygonalFaceSet,
        IfcPolyline,
        IfcPolyLoop,
        IfcPort,
        IfcPostalAddress,
        IfcPreDefinedColour,
        IfcPreDefinedCurveFont,
        IfcPreDefinedDimensionSymbol,
        IfcPreDefinedItem,
        IfcPreDefinedPointMarkerSymbol,
        IfcPreDefinedProperties,
        IfcPreDefinedPropertySet,
        IfcPreDefinedSymbol,
        IfcPreDefinedTerminatorSymbol,
        IfcPreDefinedTextFont,
        IfcPresentationItem,
        IfcPresentationLayerAssignment,
        IfcPresentationLayerWithStyle,
        IfcPresentationStyle,
        IfcPresentationStyleAssignment,
        IfcProcedure,
        IfcProcedureType,
        IfcProcess,
        IfcProduct,
        IfcProductDefinitionShape,
        IfcProductRepresentation,
        IfcProductsOfCombustionProperties,
        IfcProfileDef,
        IfcProfileProperties,
        IfcProject,
        IfcProjectedCRS,
        IfcProjectionCurve,
        IfcProjectionElement,
        IfcProjectLibrary,
        IfcProjectOrder,
        IfcProjectOrderRecord,
        IfcProperty,
        IfcPropertyAbstraction,
        IfcPropertyBoundedValue,
        IfcPropertyConstraintRelationship,
        IfcPropertyDefinition,
        IfcPropertyDependencyRelationship,
        IfcPropertyEnumeratedValue,
        IfcPropertyEnumeration,
        IfcPropertyListValue,
        IfcPropertyReferenceValue,
        IfcPropertySet,
        IfcPropertySetDefinition,
        IfcPropertySetTemplate,
        IfcPropertySingleValue,
        IfcPropertyTableValue,
        IfcPropertyTemplate,
        IfcPropertyTemplateDefinition,
        IfcProtectiveDevice,
        IfcProtectiveDeviceTrippingUnit,
        IfcProtectiveDeviceTrippingUnitType,
        IfcProtectiveDeviceType,
        IfcProxy,
        IfcPump,
        IfcPumpType,
        IfcQuantityArea,
        IfcQuantityCount,
        IfcQuantityLength,
        IfcQuantitySet,
        IfcQuantityTime,
        IfcQuantityVolume,
        IfcQuantityWeight,
        IfcRadiusDimension,
        IfcRailing,
        IfcRailingType,
        IfcRamp,
        IfcRampFlight,
        IfcRampFlightType,
        IfcRampType,
        IfcRationalBezierCurve,
        IfcRationalBSplineCurveWithKnots,
        IfcRationalBSplineSurfaceWithKnots,
        IfcRectangleHollowProfileDef,
        IfcRectangleProfileDef,
        IfcRectangularPyramid,
        IfcRectangularTrimmedSurface,
        IfcRecurrencePattern,
        IfcReference,
        IfcReferencesValueDocument,
        IfcRegularTimeSeries,
        IfcReinforcementBarProperties,
        IfcReinforcementDefinitionProperties,
        IfcReinforcingBar,
        IfcReinforcingBarType,
        IfcReinforcingElement,
        IfcReinforcingElementType,
        IfcReinforcingMesh,
        IfcReinforcingMeshType,
        IfcRelAggregates,
        IfcRelAssigns,
        IfcRelAssignsTasks,
        IfcRelAssignsToActor,
        IfcRelAssignsToControl,
        IfcRelAssignsToGroup,
        IfcRelAssignsToGroupByFactor,
        IfcRelAssignsToProcess,
        IfcRelAssignsToProduct,
        IfcRelAssignsToProjectOrder,
        IfcRelAssignsToResource,
        IfcRelAssociates,
        IfcRelAssociatesAppliedValue,
        IfcRelAssociatesApproval,
        IfcRelAssociatesClassification,
        IfcRelAssociatesConstraint,
        IfcRelAssociatesDocument,
        IfcRelAssociatesLibrary,
        IfcRelAssociatesMaterial,
        IfcRelAssociatesProfileProperties,
        IfcRelationship,
        IfcRelaxation,
        IfcRelConnects,
        IfcRelConnectsElements,
        IfcRelConnectsPathElements,
        IfcRelConnectsPorts,
        IfcRelConnectsPortToElement,
        IfcRelConnectsStructuralActivity,
        IfcRelConnectsStructuralElement,
        IfcRelConnectsStructuralMember,
        IfcRelConnectsWithEccentricity,
        IfcRelConnectsWithRealizingElements,
        IfcRelContainedInSpatialStructure,
        IfcRelCoversBldgElements,
        IfcRelCoversSpaces,
        IfcRelDeclares,
        IfcRelDecomposes,
        IfcRelDefines,
        IfcRelDefinesByObject,
        IfcRelDefinesByProperties,
        IfcRelDefinesByTemplate,
        IfcRelDefinesByType,
        IfcRelFillsElement,
        IfcRelFlowControlElements,
        IfcRelInteractionRequirements,
        IfcRelInterferesElements,
        IfcRelNests,
        IfcRelOccupiesSpaces,
        IfcRelOverridesProperties,
        IfcRelProjectsElement,
        IfcRelReferencedInSpatialStructure,
        IfcRelSchedulesCostItems,
        IfcRelSequence,
        IfcRelServicesBuildings,
        IfcRelSpaceBoundary,
        IfcRelSpaceBoundary1stLevel,
        IfcRelSpaceBoundary2ndLevel,
        IfcRelVoidsElement,
        IfcReparametrisedCompositeCurveSegment,
        IfcRepresentation,
        IfcRepresentationContext,
        IfcRepresentationItem,
        IfcRepresentationMap,
        IfcResource,
        IfcResourceApprovalRelationship,
        IfcResourceConstraintRelationship,
        IfcResourceLevelRelationship,
        IfcResourceTime,
        IfcRevolvedAreaSolid,
        IfcRevolvedAreaSolidTapered,
        IfcRibPlateProfileProperties,
        IfcRightCircularCone,
        IfcRightCircularCylinder,
        IfcRoof,
        IfcRoofType,
        IfcRoot,
        IfcRoundedEdgeFeature,
        IfcRoundedRectangleProfileDef,
        IfcSanitaryTerminal,
        IfcSanitaryTerminalType,
        IfcScheduleTimeControl,
        IfcSchedulingTime,
        IfcSeamCurve,
        IfcSectionedSpine,
        IfcSectionProperties,
        IfcSectionReinforcementProperties,
        IfcSensor,
        IfcSensorType,
        IfcServiceLife,
        IfcServiceLifeFactor,
        IfcShadingDevice,
        IfcShadingDeviceType,
        IfcShapeAspect,
        IfcShapeModel,
        IfcShapeRepresentation,
        IfcShellBasedSurfaceModel,
        IfcSimpleProperty,
        IfcSimplePropertyTemplate,
        IfcSite,
        IfcSIUnit,
        IfcSlab,
        IfcSlabElementedCase,
        IfcSlabStandardCase,
        IfcSlabType,
        IfcSlippageConnectionCondition,
        IfcSolarDevice,
        IfcSolarDeviceType,
        IfcSolidModel,
        IfcSoundProperties,
        IfcSoundValue,
        IfcSpace,
        IfcSpaceHeater,
        IfcSpaceHeaterType,
        IfcSpaceProgram,
        IfcSpaceThermalLoadProperties,
        IfcSpaceType,
        IfcSpatialElement,
        IfcSpatialElementType,
        IfcSpatialStructureElement,
        IfcSpatialStructureElementType,
        IfcSpatialZone,
        IfcSpatialZoneType,
        IfcSphere,
        IfcSphericalSurface,
        IfcStackTerminal,
        IfcStackTerminalType,
        IfcStair,
        IfcStairFlight,
        IfcStairFlightType,
        IfcStairType,
        IfcStructuralAction,
        IfcStructuralActivity,
        IfcStructuralAnalysisModel,
        IfcStructuralConnection,
        IfcStructuralConnectionCondition,
        IfcStructuralCurveAction,
        IfcStructuralCurveConnection,
        IfcStructuralCurveMember,
        IfcStructuralCurveMemberVarying,
        IfcStructuralCurveReaction,
        IfcStructuralItem,
        IfcStructuralLinearAction,
        IfcStructuralLinearActionVarying,
        IfcStructuralLoad,
        IfcStructuralLoadCase,
        IfcStructuralLoadConfiguration,
        IfcStructuralLoadGroup,
        IfcStructuralLoadLinearForce,
        IfcStructuralLoadOrResult,
        IfcStructuralLoadPlanarForce,
        IfcStructuralLoadSingleDisplacement,
        IfcStructuralLoadSingleDisplacementDistortion,
        IfcStructuralLoadSingleForce,
        IfcStructuralLoadSingleForceWarping,
        IfcStructuralLoadStatic,
        IfcStructuralLoadTemperature,
        IfcStructuralMember,
        IfcStructuralPlanarAction,
        IfcStructuralPlanarActionVarying,
        IfcStructuralPointAction,
        IfcStructuralPointConnection,
        IfcStructuralPointReaction,
        IfcStructuralProfileProperties,
        IfcStructuralReaction,
        IfcStructuralResultGroup,
        IfcStructuralSteelProfileProperties,
        IfcStructuralSurfaceAction,
        IfcStructuralSurfaceConnection,
        IfcStructuralSurfaceMember,
        IfcStructuralSurfaceMemberVarying,
        IfcStructuralSurfaceReaction,
        IfcStructuredDimensionCallout,
        IfcStyledItem,
        IfcStyledRepresentation,
        IfcStyleModel,
        IfcSubContractResource,
        IfcSubContractResourceType,
        IfcSubedge,
        IfcSurface,
        IfcSurfaceCurve,
        IfcSurfaceCurveSweptAreaSolid,
        IfcSurfaceFeature,
        IfcSurfaceOfLinearExtrusion,
        IfcSurfaceOfRevolution,
        IfcSurfaceReinforcementArea,
        IfcSurfaceStyle,
        IfcSurfaceStyleLighting,
        IfcSurfaceStyleRefraction,
        IfcSurfaceStyleRendering,
        IfcSurfaceStyleShading,
        IfcSurfaceStyleWithTextures,
        IfcSurfaceTexture,
        IfcSweptAreaSolid,
        IfcSweptDiskSolid,
        IfcSweptDiskSolidPolygonal,
        IfcSweptSurface,
        IfcSwitchingDevice,
        IfcSwitchingDeviceType,
        IfcSymbolStyle,
        IfcSystem,
        IfcSystemFurnitureElement,
        IfcSystemFurnitureElementType,
        IfcTable,
        IfcTableColumn,
        IfcTableRow,
        IfcTank,
        IfcTankType,
        IfcTask,
        IfcTaskTime,
        IfcTaskTimeRecurring,
        IfcTaskType,
        IfcTelecomAddress,
        IfcTendon,
        IfcTendonAnchor,
        IfcTendonAnchorType,
        IfcTendonType,
        IfcTerminatorSymbol,
        IfcTessellatedFaceSet,
        IfcTessellatedItem,
        IfcTextLiteral,
        IfcTextLiteralWithExtent,
        IfcTextStyle,
        IfcTextStyleFontModel,
        IfcTextStyleForDefinedFont,
        IfcTextStyleTextModel,
        IfcTextStyleWithBoxCharacteristics,
        IfcTextureCoordinate,
        IfcTextureCoordinateGenerator,
        IfcTextureMap,
        IfcTextureVertex,
        IfcTextureVertexList,
        IfcThermalMaterialProperties,
        IfcTimePeriod,
        IfcTimeSeries,
        IfcTimeSeriesReferenceRelationship,
        IfcTimeSeriesSchedule,
        IfcTimeSeriesValue,
        IfcTopologicalRepresentationItem,
        IfcTopologyRepresentation,
        IfcToroidalSurface,
        IfcTransformer,
        IfcTransformerType,
        IfcTransportElement,
        IfcTransportElementType,
        IfcTrapeziumProfileDef,
        IfcTriangulatedFaceSet,
        IfcTrimmedCurve,
        IfcTShapeProfileDef,
        IfcTubeBundle,
        IfcTubeBundleType,
        IfcTwoDirectionRepeatFactor,
        IfcTypeObject,
        IfcTypeProcess,
        IfcTypeProduct,
        IfcTypeResource,
        IfcUnitaryControlElement,
        IfcUnitaryControlElementType,
        IfcUnitaryEquipment,
        IfcUnitaryEquipmentType,
        IfcUnitAssignment,
        IfcUShapeProfileDef,
        IfcValve,
        IfcValveType,
        IfcVector,
        IfcVertex,
        IfcVertexBasedTextureMap,
        IfcVertexLoop,
        IfcVertexPoint,
        IfcVibrationIsolator,
        IfcVibrationIsolatorType,
        IfcVirtualElement,
        IfcVirtualGridIntersection,
        IfcVoidingFeature,
        IfcWall,
        IfcWallElementedCase,
        IfcWallStandardCase,
        IfcWallType,
        IfcWasteTerminal,
        IfcWasteTerminalType,
        IfcWaterProperties,
        IfcWindow,
        IfcWindowLiningProperties,
        IfcWindowPanelProperties,
        IfcWindowStandardCase,
        IfcWindowStyle,
        IfcWindowType,
        IfcWorkCalendar,
        IfcWorkControl,
        IfcWorkPlan,
        IfcWorkSchedule,
        IfcWorkTime,
        IfcZone,
        IfcZShapeProfileDef,
        UnKnown
    }
}