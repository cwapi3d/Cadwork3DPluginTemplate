#include "$projectname$.h"

bool plugin_x64_init(CwAPI3D::ControllerFactory* aFactory) {
  aFactory->getUtilityController()->printError(L"Hello from $projectname$!");

  return true;
}
