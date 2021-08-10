%{
#include <stdio.h>
#include <string.h>
void yyerror(const char *str);
%}
%token SHADER_ROOT PROPERTIES_ROOT SUBSHADER_ROOT PASS_ROOT TAGS_ROOT
%%

ShaderRoot : SHADER_ROOT { Properties SubShader+ } 

Properties : PROPERTIES_ROOT { Property }

Property : 

SubShader : SUBSHADER_ROOT { }
%%