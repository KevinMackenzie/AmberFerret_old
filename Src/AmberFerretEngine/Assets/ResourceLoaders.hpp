#pragma once

namespace AmberStudio
{
	namespace Assets
	{
		class TxtResLoader : public IResourceLoader
		{
		public:
			virtual std::string GetExtensionFormat();
			virtual ResHandle LoadResource(const std::istream& data);
			virtual bool UseRawData();
		};
	}
}