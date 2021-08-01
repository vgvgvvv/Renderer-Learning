#pragma once

#define DEFARG(name, defval) ((#name[0]) ? (name + 0) : defval)