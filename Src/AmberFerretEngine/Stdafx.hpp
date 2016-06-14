#pragma once

#ifdef AMBERFERRETENGINE_EXPORTS
#include "App\AmberFerretEngineExport.hpp"
#endif
#include "Exports.hpp"
//#include "Assets\Resource.hpp"


#include <memory>
#include <string>

namespace AmberStudio
{
	using std::shared_ptr;

	using ResHandle = shared_ptr<Assets::Resource>;
}

#include "Interfaces.hpp"