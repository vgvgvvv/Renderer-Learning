#pragma once
#include <string>
#include "spdlog/spdlog.h"
#include "spdlog/sinks/stdout_color_sinks.h"
#include "CommonLib_API.h"

class ILogHandler
{
public:
	virtual void Info(const std::string& logInfo) = 0;
	virtual void Debug(const std::string& logInfo) = 0;
	virtual void Warn(const std::string& logInfo) = 0;
	virtual void Error(const std::string& logInfo) = 0;
};

class CommonLib_API LogContext
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
private:
	static std::list<std::shared_ptr<ILogHandler>> handlers;
public:
	static void RegisterHandler(std::shared_ptr<ILogHandler> handler);
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
	
	for (auto& handler : handlers)
	{
		handler->Info(fmt::format(formatString, args...));
	}
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

	for (auto& handler : handlers)
	{
		handler->Debug(fmt::format(formatString, args...));
	}
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

	for (auto& handler : handlers)
	{
		handler->Warn(fmt::format(formatString, args...));
	}
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
	logger->dump_backtrace();

	for (auto& handler : handlers)
	{
		handler->Error(fmt::format(formatString, args...));
	}
}

#define RE_LOG_INFO(Tag, formatString, ...)	\
	LogContext::Info(Tag, formatString, __VA_ARGS__);

#define RE_LOG_DEBUG(Tag, formatString, ...) \
	LogContext::Debug(Tag, __VA_ARGS__);

#define RE_LOG_WARN(Tag, formatString, ...)	\
	LogContext::Warn(Tag, formatString, __VA_ARGS__);

#define RE_LOG_ERROR(Tag, formatString, ...) \
	LogContext::Error(Tag, formatString, __VA_ARGS__);
