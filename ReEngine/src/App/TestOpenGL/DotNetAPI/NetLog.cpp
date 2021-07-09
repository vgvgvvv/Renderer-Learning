#include "NetLog.h"
#include "Common.h"


void NetLog::Info(const char* info)
{
	LogContext::Info("DotNet", info);
}

void NetLog::Debug(const char* info)
{
	LogContext::Debug("DotNet", info);
}

void NetLog::Warning(const char* info)
{
	LogContext::Warn("DotNet", info);
}

void NetLog::Error(const char* info)
{
	LogContext::Error("DotNet", info);
}
