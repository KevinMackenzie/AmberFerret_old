#pragma once
#include <string>
#include <vector>

namespace AmberStudio
{
	namespace Assets
	{
		using ByteArray = std::vector<char>;

		class InputStream
		{
			std::istream& mInternalStream;
		protected:
			void SeekBegin();
			void SeekPos(size_t streamPos);
			void SeekEnd();
		public:
			InputStream(std::istream& stream);
			size_t GetLength();
			std::string ReadAllText();
			ByteArray ReadAllBytes();
			std::string ReadSomeText(size_t startPos, size_t len);
			ByteArray ReadSomeBytes(size_t startPos, size_t len);
		};
	}
}