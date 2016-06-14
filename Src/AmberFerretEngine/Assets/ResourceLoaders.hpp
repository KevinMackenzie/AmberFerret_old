#pragma once

namespace AmberStudio
{
	namespace Assets
	{
		class TxtResLoader : public IResourceLoader
		{
		public:
			virtual std::string GetExtensionFormat();
			virtual std::shared_ptr<IResourceExtraData> LoadResource(const std::istream& data);
		};
	}
}