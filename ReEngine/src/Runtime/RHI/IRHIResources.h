#pragma once

#include <cstdint>
#include "RHI_API.h"

class IRHIResources
{
protected:
	uint32_t render_id_;
public:

	uint32_t GetRenderId() const { return render_id_; }
	
	virtual ~IRHIResources() = default;
	
	virtual void Bind() const = 0;
	virtual void Unbind() const = 0;
};

