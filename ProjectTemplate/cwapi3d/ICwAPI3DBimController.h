/** @file
* Copyright (C) 2019 cadwork informatik AG
*
* This file is part of the CwAPI3D module for cadwork 3d.
*
* @ingroup       CwAPI3D
* @since         26.0
* @author        Paquet
* @date          2019-03-04
*/

#pragma once

#include "ICwAPI3DString.h"
#include "ICwAPI3DElementIDList.h"
#include "ICwAPI3DIfc2x3ElementType.h"
#include "ICwAPI3DStringList.h"

namespace CwAPI3D
{
  namespace Interfaces
  {
    /**
    * @interface ICwAPI3DBimController
    * \brief
    */
    class ICwAPI3DBimController
    {
    public:
      virtual ICwAPI3DString* getLastError(int32_t* aErrorCode) = 0;
      /**
       * \brief 
       * \param aID 
       * \return 
       */
      virtual ICwAPI3DString* getIfcGuid(elementID aID) = 0;
      /**
       * \brief 
       * \param aElementIDList 
       * \param aBuilding
       * \param aStorey
       */
      virtual void setBuildingAndStorey(ICwAPI3DElementIDList* aElementIDList, const character* aBuilding, const character* aStorey) = 0;
      /**
       * \brief 
       * \param aElement 
       * \return 
       */
      virtual ICwAPI3DString* getBuilding(elementID aElement) = 0;
      /**
       * \brief 
       * \param aElement 
       * \return 
       */
      virtual ICwAPI3DString* getStorey(elementID aElement) = 0;

      virtual void clearErrors() = 0;
      /**
       * \brief 
       * \param aElementID 
       * \return 
       */
      virtual ICwAPI3DIfc2x3ElementType* getIfc2x3ElementType(elementID aElementID) = 0;
      /**
       * \brief 
       * \param aElementIDs 
       * \param aElementType
       */
      virtual void setIfc2x3ElementType(ICwAPI3DElementIDList* aElementIDs, ICwAPI3DIfc2x3ElementType* aElementType) = 0;
      /**
       * \brief 
       * \param aFilePath 
       */
      virtual bool importIfcAsGraphicalObject(const character* aFilePath) = 0;
      /**
       * \brief 
       * \param aFilePath 
       * \return 
       */
      virtual bool importBcf(const character* aFilePath) = 0;
      /**
       * \brief 
       * \param aFilePath 
       * \return 
       */
      virtual bool exportBcf(const character* aFilePath) = 0;
      /**
       * \brief 
       * \param aElementIDs 
       * \param aFilePath
       * \return 
       */
      virtual bool exportIfc(ICwAPI3DElementIDList* aElementIDs, const character* aFilePath) = 0;
      /**
       * \brief imports an IFC File and returns the ids of the Exchange Objects
       * \param aFilePath 
       * \return 
       */
      virtual ICwAPI3DElementIDList* importIfcReturnExchangeObjects(const character* aFilePath) = 0;
      /**
       * \brief converts a list of Exchange Objects to Cadwork Elements
       * \param aExchangeObjects 
       * \return 
       */
      virtual ICwAPI3DElementIDList* convertExchangeObjects(ICwAPI3DElementIDList* aExchangeObjects) = 0;
      /**
       * \brief 
       * \param aBuilding 
       * \param aStorey 
       * \return 
       */
      virtual double getStoreyHeight(const character* aBuilding, const character* aStorey) = 0;
      /**
       * \brief 
       * \param aBuilding 
       * \param aStorey 
       * \param aHeight 
       */
      virtual void setStoreyHeight(const character* aBuilding, const character* aStorey, double aHeight) = 0;
      /**
       * \brief 
       * \param aElementType 
       * \return 
       */
      virtual ICwAPI3DString* getIfc2x3ElementTypeString(ICwAPI3DIfc2x3ElementType* aElementType) = 0;
      /**
       * \brief 
       * \param aElementType 
       * \return 
       */
      virtual ICwAPI3DString* getIfc2x3ElementTypeDisplayString(ICwAPI3DIfc2x3ElementType* aElementType) = 0;
      /**
       * \brief 
       * \return 
       */
      virtual ICwAPI3DStringList* getAllBuildings() = 0;
      /**
       * \brief 
       * \param aBuilding 
       * \return 
       */
      virtual ICwAPI3DStringList* getAllStoreys(const character* aBuilding) = 0;
    };
  }
}
