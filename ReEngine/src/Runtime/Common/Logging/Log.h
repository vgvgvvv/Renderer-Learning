#pragma once
#include <string>
#include "spdlog/spdlog.h"
#include "spdlog/sinks/stdout_color_sinks.h"



class LogContext
{
public:
	template<typename... Args>
	static void Info(std::string tag, std::string formatString, const Args &...args);
	template<typename... Args>
	static void Log(std::string tag, std::string formatString, const Args &...args);
	template<typename... Args>
	static void Debug(std::string tag, std::string formatString, const Args &...args);
	template<typename... Args>
	static void Warn(std::string tag, std::string formatString, const Args &...args);
	template<typename... Args>
	static void Error(std::string tag, std::string formatString, const Args &...args);
};


template <typename ... Args>
void ::LogContext::Info(std::string tag, std::string formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if(!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->info(formatString, args...);
}

template <typename ... Args>
void ::LogContext::Log(std::string tag, std::string formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->log(formatString, args...);
}

template <typename ... Args>
void ::LogContext::Debug(std::string tag, std::string formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->debug(formatString, args...);
}

template <typename ... Args>
void ::LogContext::Warn(std::string tag, std::string formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->warn(formatString, args...);
}

template <typename ... Args>
void ::LogContext::Error(std::string tag, std::string formatString, const Args&... args)
{
	auto logger = spdlog::get(tag);
	if (!logger)
	{
		logger = spdlog::stdout_color_mt(tag);
	}
	logger->error(formatString, args...);
}

#define RE_LOG_INFO(Tag, ...)	\
	LogContext::Info(Tag, __VA_ARGS__);

#define RE_LOG_LOG(Tag, ...) \
	LogContext::Log(Tag, __VA_ARGS__);

#define RE_LOG_DEBUG(Tag, ...) \
	LogContext::Debug(Tag, __VA_ARGS__);

#define RE_LOG_WARN(Tag, ...)	\
	LogContext::Warn(Tag, __VA_ARGS__);

#define RE_LOG_ERROR(Tag, ...) \
	LogContext::Error(Tag, __VA_ARGS__);
