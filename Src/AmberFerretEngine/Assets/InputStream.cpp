#include "../Stdafx.hpp"
#include "InputStream.hpp"

using namespace AmberStudio;
using namespace Assets;


//--------------------------------------------------------------------------------------
void InputStream::SeekBegin()
{
	mInternalStream.seekg(std::istream::beg);
}

//--------------------------------------------------------------------------------------
void InputStream::SeekPos(size_t streamPos)
{
	mInternalStream.seekg(std::istream::beg + streamPos);
}

//--------------------------------------------------------------------------------------
void InputStream::SeekEnd()
{
	mInternalStream.seekg(std::istream::end);
}

//--------------------------------------------------------------------------------------
InputStream::InputStream(std::istream& stream) :
	mInternalStream(stream)
{}

//--------------------------------------------------------------------------------------
size_t InputStream::GetLength()
{
	SeekBegin();
	auto beg = mInternalStream.tellg();
	SeekEnd();
	auto end = mInternalStream.tellg();
}

//--------------------------------------------------------------------------------------
std::string InputStream::ReadAllText()
{
	SeekBegin();
	std::string s(std::istreambuf_iterator<char>(mInternalStream), {});
	return s;
}

//--------------------------------------------------------------------------------------
ByteArray InputStream::ReadAllBytes()
{
	SeekBegin();
	std::vector<char> v(std::istreambuf_iterator<char>(mInternalStream), {});
	return v;
}

//--------------------------------------------------------------------------------------
std::string InputStream::ReadSomeText(size_t startPos, size_t len)
{
	return std::string(mInternalStream.beg + startPos, mInternalStream.beg + startPos + len);
}

