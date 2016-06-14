#pragma once

#ifdef PLATFORM_WINDOWS
#ifndef AMBERFERRETENGINE_API
#ifdef AMBERFERRETENGINE_EXPORTS
#define AMBERFERRETENGINE_API __declspec(dllexport)
#else
#define AMBERFERRETENGINE_API __declspec(dllimport)
#endif
#endif
#else
#define AMBERFERRETENGINE_EXPORTS
#endif