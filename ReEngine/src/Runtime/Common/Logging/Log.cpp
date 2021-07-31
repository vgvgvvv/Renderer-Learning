#include "Log.h"

std::list<std::shared_ptr<ILogHandler>> LogContext::handlers;

void LogContext::RegisterHandler(std::shared_ptr<ILogHandler> handler)
{
	handlers.push_back(handler);
}
