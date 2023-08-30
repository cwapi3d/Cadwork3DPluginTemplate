/** @file
* Copyright (C) 2017 cadwork informatik AG
*
* This file is part of the CwAPI3D module for cadwork 3d.
*
* @ingroup       CwAPI3D
* @since         24.0
* @author        Paquet
* @date          2017-06-22
*/

#pragma once

#define CWAPI3D_INTERNAL

#ifdef CWAPI3D_EXPORTS
#define CWAPI3D_API __declspec(dllexport)
#else
#define CWAPI3D_API __declspec(dllimport)
#endif

#include <cstdint>
enum class ECwAPI3DMenuItemType
{
  None,
  Button,
  Blank,
};

enum class ECwAPI3DElementType : uint64_t
{
  None = 0,
  NormalNode = ((uint64_t)1 << 0),
  ConnectorNode = ((uint64_t)1 << 1),
  WireAxis = ((uint64_t)1 << 2),
  EaveAxis = ((uint64_t)1 << 3),
  RectangularAxis = ((uint64_t)1 << 4),
  CircularAxis = ((uint64_t)1 << 5),
  DrillingAxis = ((uint64_t)1 << 6),
  ConnectorAxis = ((uint64_t)1 << 7),
  Line = ((uint64_t)1 << 8),
  Surface = ((uint64_t)1 << 9),
  Cadwork = ((uint64_t)1 << 10),
  GlobalCut = ((uint64_t)1 << 11),
  Wall = ((uint64_t)1 << 12),
  Opening = ((uint64_t)1 << 13),
  Floor = ((uint64_t)1 << 14),
  Roof = ((uint64_t)1 << 15),
  Container = ((uint64_t)1 << 16),
  ExportSolid = ((uint64_t)1 << 17),
  Auxiliary = ((uint64_t)1 << 18),
  NestingParent = ((uint64_t)1 << 19),
  RectangularBeam = ((uint64_t)1 << 20),
  CircularBeam = ((uint64_t)1 << 21),
  SteelShape = ((uint64_t)1 << 22),
  Panel = ((uint64_t)1 << 23),
  RotationElement = ((uint64_t)1 << 24),
  AdditionalElement = ((uint64_t)1 << 25),
  Room = ((uint64_t)1 << 26),
  GraphicalObject = ((uint64_t)1 << 27),
  Dimension = ((uint64_t)1 << 28),
  TextDocument = ((uint64_t)1 << 29),
  ExportSolidScene = ((uint64_t)1 << 30),
  SectionTrace = ((uint64_t)1 << 31),
  RoundMEP = ((uint64_t)1 << 32),
  RectangularMEP = ((uint64_t)1 << 33),
  ProfileMEP = ((uint64_t)1 << 34),
  RoofSurface = ((uint64_t)1 << 35),
  ContainerBlock = ((uint64_t)1 << 36),
  RoofTileSurface = ((uint64_t)1 << 37),
  ExchangeObject = ((uint64_t)1 << 38),
  FramedWall = ((uint64_t)1 << 39),
  SolidWoodWall = ((uint64_t)1 << 40),
  LogWall = ((uint64_t)1 << 41),
  FramedRoof = ((uint64_t)1 << 42),
  SolidWoodRoof = ((uint64_t)1 << 43),
  FramedFloor = ((uint64_t)1 << 44),
  SolidWoodFloor = ((uint64_t)1 << 45),
};

enum class ECwAPI3DProcessType
{
  None = 0,
  Purlin = 2,
  Stud = 6,
  Rafter = 1,
  JackRafter = 3,
  HipValley = 11,
  Log = 4,
  Truss = 7,
  Tread = 30,
  User1 = 20,
  User2 = 21,
  User3 = 22,
  User4 = 23,
  User5 = 24,
  Panel1 = 120,
  Panel2 = 121,
  Panel3 = 122,
  Panel4 = 123,
  Panel5 = 124,
  RoughVolumeFramedWall = 50,
  RoughVolumeSolidWoodWall = 51,
  RoughVolumeLogHome = 52,
};

enum class ECwAPI3DElementFilter
{
  None,
  Name,
  Group,
  Subgroup,
  Comment,
  UserAttribute,
  SKU,
  ProductionNumber,
  PartNumber,
  Building,
  Storey,
};

enum class ECwAPI3DElementModuleProperties
{
  None = 0,
  StretchWithTop = (1 << 0),
  MoveWithTop = (1 << 1),
  DistributeHorizontal = (1 << 2),
  DistributeVertical = (1 << 3),
  HorizontalStop = (1 << 4),
  VerticalStop = (1 << 5),
  UpperSill = (1 << 6),
  LowerSill = (1 << 7),
  WindowSill = (1 << 8),
  WindowLintel = (1 << 9),
  Extrusion = (1 << 10),
  AuxiliaryElement = (1 << 11),
  DoNotPlaceAtEnd = (1 << 12),
  EB_OpenStretchTop = (1 << 13),
  Solder = (1 << 14),
  DoNotCut = (1 << 16),
  EB_OpenStretchBot = (1 << 17),
  EB_DontCollision = (1 << 18),
  EB_DontAtStart = (1 << 19),
  EB_NoInsideCoverCheck = (1 << 20),
  EB_UseForCoordinate = (1 << 21),
  EB_Killed = (1 << 15),
  EB_GlueStart = (1 << 26),
  EB_GlueEnd = (1 << 27),
  EB_Original = (1 << 28),
  EB_Start = (1 << 29),
  EB_End = (1 << 30),
  EB_Middle = (1 << 31),
};

enum class ECwAPI3DIfc2x3ElementType
{
  None = 0,
  IfcBeam = 4,
  IfcColumn = 7,
  IfcCurtainWall = 9,
  IfcDoor = 10,
  IfcMember = 12,
  IfcPlate = 14,
  IfcRailing = 15,
  IfcRamp = 16,
  IfcRampFlight = 17,
  IfcRoof = 18,
  IfcSlab = 20,
  IfcStair = 21,
  IfcStairFlight = 22,
  IfcWall = 23,
  IfcWallStandardCase = 86,
  IfcWindow = 24,
  IfcBuildingElementProxy = 5,
  IfcChimney = 6,
  IfcCovering = 8,
  IfcFooting = 11,
  IfcFurnishingElement = 48,
  IfcOpeningElement = 45,
  IfcSpace = 65,
  IfcFlowSegment = 87,
  IfcBuildingElementPart = 31,
  IfcDiscreteAccessory = 32,
  IfcFastener = 33,
  IfcMechanicalFastener = 34,
};
