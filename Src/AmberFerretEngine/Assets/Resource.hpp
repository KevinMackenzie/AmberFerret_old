#pragma once
#include "../Interfaces.hpp"

namespace AmberStudio
{
	class IResourceExtraData;

	namespace Assets
	{

		class Resource
		{
		protected:
			const std::string mResName = "";
			std::shared_ptr<IResourceExtraData> mData;
		public:
			Resource(const std::string& path, std::shared_ptr<IResourceExtraData> extraData);

			const std::string& GetResourceName();
			std::shared_ptr<IResourceExtraData> GetExtraData();
		};

	}
}