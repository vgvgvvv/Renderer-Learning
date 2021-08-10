%{
    extern int yylval;
%}

%%
"Shader"            { printf (" SHADER_ROOT"); }
"Properties"        { printf (" PROPERTIES_ROOT"); }
"SubShader"         { printf (" SUBSHADER_ROOT");  }
"Pass"              { printf (" PASS_ROOT"); }
"Tags"              { printf (" TAGS_ROOT");  }

"Fallback"          { printf (" FALLBACK_TAG"); }
"CustomEditor"      { printf (" CUSTOM_EDITOR_TAG"); }

"Blend"             { printf (" BLEND_TAG");  }
"ZWrite"            { printf (" ZWRITE_TAG"); }

"Cull"              { printf (" CULL_TAG");  }
"ColorMask"         { printf (" COLOR_MASK_TAG");  }

"GLSLINCLUDE"       { printf (" GLSLINCLUDE");  }
"GLSLPROGRAM"       { printf (" GLSLPROGRAM");  }
"ENDGLSL"           { printf (" ENDGLSL");  }

"On|Off"            { printf (" STATE");  }

\".*\"              { printf (" LITERAL_STRING");  }

"2D"                { printf (" TWO_D_TYPE"); }
"3D"                { printf (" THREE_D_TYPE"); }
"Float"             { printf (" FLOAT_TYPE"); }
"Int"               { printf (" INT_TYPE"); }
"Color"             { printf (" COLOR_TYPE"); }
"Vector"            { printf (" VECTOR_TYPE"); }
"Cube"              { printf (" CUBE_TYPE"); }

=                   { printf (" OP_EQ"); }

\/\/.*                { printf (" COMMENT");  }

\n                  { printf ("\n");  }
\(                  { printf (" LEFT"); }
\)                  { printf (" RIGHT"); }
\[                  { printf (" ["); }
\]                  { printf (" ]"); }
\{                  { printf (" OBRACE");  }
\}                  { printf (" EBRACE");  }
\,                  { printf(" ,"); }
[-+]?[0-9]*\.?[0-9]+    {printf(" NUMBER"); }
[a-zA-Z_]+          { printf (" VAR_NAME"); }
[ \t]+              { printf (" "); /*忽略空格*/ }
.                   { printf (" ILLEGAL"); }
%%

#ifndef yywrap
yywrap() { return 1; }
#endif

int main(int argc, char *argv[]) {
    yyin = fopen(argv[1], "r");
    yylex();
    fclose(yyin);
}