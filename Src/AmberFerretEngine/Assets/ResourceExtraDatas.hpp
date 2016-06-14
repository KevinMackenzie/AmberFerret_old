#pragma once

namespace AmberStudio
{
	namespace Assets 
	{
		class TxtResExtraData : IResourceExtraData
		{
			std::string mTxtData = "";
		public:
			TxtResExtraData(const std::string& text);

			virtual long GetSize()
			{
				return mTxtData.size();
			}
		};
	}
}