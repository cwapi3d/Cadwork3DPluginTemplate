#pragma once

#define CWAPI3D_PLUGIN_NAME L"$projectname$"
#define CWAPI3D_AUTHOR_NAME L"$cwauthorname$"
#define CWAPI3D_AUTHOR_EMAIL L"$cwauthoremail$"

#pragma warning(push, 0)

#include <CwAPI3D.h>

#pragma warning(pop)

CWAPI3D_PLUGIN bool plugin_x64_init(CwAPI3D::ControllerFactory* aFactory);
