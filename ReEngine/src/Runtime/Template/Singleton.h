#pragma once

// singleton-pattern
// https://stackoverflow.com/questions/1008019/c-singleton-design-pattern

#define DEFINE_SINGLETON(TypeName)                                      \
	public:                                                             \
		static TypeName& Get()                                          \
		{                                                               \
			static TypeName instance; return instance;                  \
		}                                                               \
    private:                                                            \
		void InitSingleton();                                           \
        TypeName() { InitSingleton(); }                                 \
    public:                                                             \
        TypeName(TypeName const&) = delete;                             \
        void operator=(TypeName const&) = delete;                       

        // Note: Scott Meyers mentions in his Effective Modern
        //       C++ book, that deleted functions should generally
        //       be public as it results in better error messages
        //       due to the compilers behavior to check accessibility
        //       before deleted status