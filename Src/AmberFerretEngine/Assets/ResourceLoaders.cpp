#include "../Stdafx.hpp"
#include "ResourceLoaders.hpp"
#include "ResourceExtraDatas.hpp"

namespace AmberStudio
{
namespace Assets
{


//--------------------------------------------------------------------------------------
std::string TxtResLoader::GetExtensionFormat()
{
	return ".txt";
}

//--------------------------------------------------------------------------------------
std::shared_ptr<IResourceExtraData> TxtResLoader::LoadResource(const std::istream& data)
{
	std::string txt;

	data.readsome
	std::shared_ptr<TxtResExtraData> ret = std::make_shared<IResourceExtraData>();
}


}
}