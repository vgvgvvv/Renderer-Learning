#pragma once


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
