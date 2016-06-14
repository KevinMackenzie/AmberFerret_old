#pragma once

namespace AmberStudio
{
	class IResourceManager
	{
	public:
		virtual bool SetResourceCache(const std::string& location) = 0;
		virtual ResHandle GetResourceByName(const std::string& name) = 0;
	};

	class IResourceLoader
	{
	public:
		virtual std::string GetExtensionFormat() = 0;
		virtual ResHandle LoadResource(const std::istream& data) = 0;
		virtual bool UseRawData() = 0;
	};

	class IResourceExtraData
	{
	public:
		virtual void GetSize() = 0;
	};
	
}