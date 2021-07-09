#pragma once
#include <string>
#include "spdlog/spdlog.h"
#include "spdlog/sinks/stdout_color_sinks.h"



class LogContext
{
public:
	template<typename... Args>
	static void Info(const std::string& tag, const std::string& formatString, const Args &...args);
	template<typename... Args>
	static void Debug(const std::string& tag, const std::string& formatString, const Args &...args);
	template<typename... Args>
	static void Warn(const std::string& tag, const std::string& formatString, const Args &...args);
	template<typename... Args>
	static void Error(const std::string& tag, const std::string& formatString, const Args &...args);
};


template <typename... Args>
void ::LogContext::Info(const std::string& tag, const std::string& formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if(!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->info(formatString, args...);
}


template <typename... Args>
void ::LogContext::Debug(const std::string& tag, const std::string& formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->debug(formatString, args...);
}

template <typename... Args>
void ::LogContext::Warn(const std::string& tag, const std::string& formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->warn(formatString, args...);
}

template <typename... Args>
void ::LogContext::Error(const std::string& tag, const std::string& formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->error(formatString, args...);
}

#define RE_LOG_INFO(Tag, formatString, ...)	\
	LogContext::Info(Tag, formatString, __VA_ARGS__);

#define RE_LOG_DEBUG(Tag, formatString, ...) \
	LogContext::Debug(Tag, __VA_ARGS__);

#define RE_LOG_WARN(Tag, formatString, ...)	\
	LogContext::Warn(Tag, formatString, __VA_ARGS__);

#define RE_LOG_ERROR(Tag, formatString, ...) \
	LogContext::Error(Tag, formatString, __VA_ARGS__);
