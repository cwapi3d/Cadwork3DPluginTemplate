/** @file
* Copyright (C) 2019 cadwork informatik AG
*
* This file is part of the CwAPI3D module for cadwork 3d.
*
* @ingroup       CwAPI3D
* @since         26.0
* @author        Paquet
* @date          2019-02-06
*/

#pragma once

#include "ICwAPI3DElementController.h"
#include "ICwAPI3DAttributeController.h"
#include "ICwAPI3DConnectorAxisController.h"
#include "ICwAPI3DFileController.h"
#include "ICwAPI3DGeometryController.h"
#include "ICwAPI3DListController.h"
#include "ICwAPI3DMachineController.h"
#include "ICwAPI3DMaterialController.h"
#include "ICwAPI3DMenuController.h"
#include "ICwAPI3DSceneController.h"
#include "ICwAPI3DShopDrawingController.h"
#include "ICwAPI3DUtilityController.h"
#include "ICwAPI3DVisualizationController.h"
#include "ICwAPI3DRoofController.h"
#include "ICwAPI3DEndtypeController.h"
#include "ICwAPI3DElementIDList.h"
#include "ICwAPI3DVertexList.h"
#include "ICwAPI3DElementFilter.h"
#include "ICwAPI3DElementMapQuery.h"
#include "ICwAPI3DElementModuleProperties.h"
#include "ICwAPI3DBimController.h"
#include "ICwAPI3DLayerSettings.h"
#include "ICwAPI3DDisplayAttribute.h"
#include "ICwAPI3DStringList.h"
#include "ICwAPI3DPolygonList.h"
#include "ICwAPI3DDimensionController.h"
#include "ICwAPI3DGridController.h"
#include "ICwAPI3DExtendedSettings.h"

namespace CwAPI3D
{
  namespace Interfaces
  {
    /**
    * @interface ICwAPI3DControllerFactory
    * \brief
    */
    class ICwAPI3DControllerFactory
    {
    public:
      /**
       * \brief Gets the attribute controller
       * \return attribute controller
       */
      virtual ICwAPI3DAttributeController* getAttributeController() = 0;
      /**
       * \brief Gets the connector axis controller
       * \return connector axis controller
       */
      virtual ICwAPI3DConnectorAxisController* getConnectorAxisController() = 0;
      /**
       * \brief Gets the element controller
       * \return element controller
       */
      virtual ICwAPI3DElementController* getElementController() = 0;
      /**
       * \brief Gets the file controller
       * \return file controller
       */
      virtual ICwAPI3DFileController* getFileController() = 0;
      /**
       * \brief Gets the geometry controller
       * \return geometry controller
       */
      virtual ICwAPI3DGeometryController* getGeometryController() = 0;
      /**
       * \brief Gets the list controller
       * \return list controller
       */
      virtual ICwAPI3DListController* getListController() = 0;
      /**
       * \brief Gets the machine controller
       * \return machine controller
       */
      virtual ICwAPI3DMachineController* getMachineController() = 0;
      /**
       * \brief Gets the material controller
       * \return material controller
       */
      virtual ICwAPI3DMaterialController* getMaterialController() = 0;
      /**
       * \brief Gets the menu controller
       * \return menu controller
       */
      virtual ICwAPI3DMenuController* getMenuController() = 0;
      /**
       * \brief Gets the scene controller
       * \return scene controller
       */
      virtual ICwAPI3DSceneController* getSceneController() = 0;
      /**
       * \brief Gets the shop drawing controller
       * \return shop drawing controller
       */
      virtual ICwAPI3DShopDrawingController* getShopDrawingController() = 0;
      /**
       * \brief Gets the utility controller
       * \return utility controller
       */
      virtual ICwAPI3DUtilityController* getUtilityController() = 0;
      /**
       * \brief Gets the visualization controller
       * \return visualization controller
       */
      virtual ICwAPI3DVisualizationController* getVisualizationController() = 0;
      /**
       * \brief Creates an empty element ID list
       * \return element ID list
       */
      virtual ICwAPI3DElementIDList* createEmptyElementIDList() = 0;
      /**
       * \brief Creates an empty vertex list
       * \return vertex list
       */
      virtual ICwAPI3DVertexList* createEmptyVertexList() = 0;
      /**
       * \brief Creates an element filter
       * \return element filter
       */
      virtual ICwAPI3DElementFilter* createElementFilter() = 0;
      /**
       * \brief Creates an element map query
       * \return element map query
       */
      virtual ICwAPI3DElementMapQuery* createElementMapQuery() = 0;
      /**
       * \brief Gets the end-type controller
       * \return end-type controller
       */
      virtual ICwAPI3DEndtypeController* getEndtypeController() = 0;
      /**
       * \brief Creates an element ID list from an existing element ID
       * \param aID
       * \return element ID list
       */
      virtual ICwAPI3DElementIDList* createElementIDListFromElement(elementID aID) = 0;
      /**
       * \brief Creates an empty element module properties
       * \return element module properties
       */
      virtual ICwAPI3DElementModuleProperties* createEmptyElementModuleProperties() = 0;
      /**
       * \brief Gets the roof controller
       * \return roof controller
       */
      virtual ICwAPI3DRoofController* getRoofController() = 0;
      /**
       * \brief Gets the BIM controller
       * \return roof controller
       */
      virtual ICwAPI3DBimController* getBimController() = 0;
      virtual ICwAPI3DLayerSettings* createEmptyLayerSettings() = 0;
      virtual ICwAPI3DDisplayAttribute* createEmptyDisplayAttribute() = 0;
      virtual ICwAPI3DStringList* createEmptyStringList() = 0;
      virtual ICwAPI3DPolygonList* createEmptyPolygonList() = 0;
      virtual ICwAPI3DDimensionController* getDimensionController() = 0;
      virtual ICwAPI3DGridController* getGridController() = 0;

      virtual ICwAPI3DExtendedSettings* createEmptyExtendedSettings() = 0;
    };
  }
}
