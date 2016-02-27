#pragma once

#ifdef WIN32
#ifdef AMBERFERRETENGINE_EXPORTS
#define AMBERFERRETENGINE_API __declspec(dllexport)
#else
#define AMBERFERRETENGINE_API __declspec(dllimport)
#endif
#else
#define AMBERFERRETENGINE_EXPORTS
#endif