#pragma once

#ifdef MULTIPLY_EXPORTS
#define MULTIPLY_API __declspec(dllexport)
#else
#define MULTIPLY_API __declspec(dllimport)
#endif

extern "C" MULTIPLY_API double getProduct(
    const double a, const double b);