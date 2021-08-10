/* C语言声明部分 */
%{
    extern int yylval;
    #define LEX_TEST 1

    #if !LEX_TEST
    #include "y.tab.h"
    #endif

    #if LEX_TEST
        #define LEX_PRINTF(value) printf(" "); printf(#value);
    #else
        #define LEX_PRINTF(value) return value
    #endif
%}


/* Token声明部分 */
%%
"Shader"            { LEX_PRINTF (SHADER_ROOT); }
"Properties"        { LEX_PRINTF (PROPERTIES_ROOT); }
"SubShader"         { LEX_PRINTF (SUBSHADER_ROOT);  }
"Pass"              { LEX_PRINTF (PASS_ROOT); }
"Tags"              { LEX_PRINTF (TAGS_ROOT);  }

"Fallback"          { LEX_PRINTF (FALLBACK_TAG); }
"CustomEditor"      { LEX_PRINTF (CUSTOM_EDITOR_TAG); }

"Blend"             { LEX_PRINTF (BLEND_TAG);  }
"ZWrite"            { LEX_PRINTF (ZWRITE_TAG); }
"ZTest"             { LEX_PRINTF (ZTEST_TAG); }

"Cull"              { LEX_PRINTF (CULL_TAG);  }
"ColorMask"         { LEX_PRINTF (COLOR_MASK_TAG);  }

"GLSLINCLUDE"       { LEX_PRINTF (GLSLINCLUDE);  }
"GLSLPROGRAM"       { LEX_PRINTF (GLSLPROGRAM);  }
"ENDGLSL"           { LEX_PRINTF (ENDGLSL);  }

"HLSLINCLUDE"       { LEX_PRINTF (HLSLINCLUDE);  }
"HLSLPROGRAM"       { LEX_PRINTF (HLSLPROGRAM);  }
"ENDHLSL"           { LEX_PRINTF (ENDHLSL);  }

"On|Off"            { LEX_PRINTF (STATE);  }

\".*\"              { LEX_PRINTF (LITERAL_STRING);  }

"2D"                { LEX_PRINTF (TWO_D_TYPE); }
"3D"                { LEX_PRINTF (THREE_D_TYPE); }
"Float"             { LEX_PRINTF (FLOAT_TYPE); }
"Int"               { LEX_PRINTF (INT_TYPE); }
"Color"             { LEX_PRINTF (COLOR_TYPE); }
"Vector"            { LEX_PRINTF (VECTOR_TYPE); }
"Cube"              { LEX_PRINTF (CUBE_TYPE); }

=                   { LEX_PRINTF (OP_EQ); }

\/\/.*                { LEX_PRINTF (COMMENT);  }

\n                  {
                        #if LEX_TEST 
                            printf ("\n");
                        #else
                            LEX_PRINTF (NEXT_LINE);
                        #endif  
                    }
                    
\(                  { LEX_PRINTF (LEFT_ROUND_BRACKET); }
\)                  { LEX_PRINTF (RIGHT_ROUND_BRACKET); }
\[                  { LEX_PRINTF (LEFT_SQUARE_BRACKET); }
\]                  { LEX_PRINTF (RIGHT_SQUARE_BRACKET); }
\{                  { LEX_PRINTF (LEFT_BRACE);  }
\}                  { LEX_PRINTF (RIGHT_BRACE);  }
\,                  {
                        #if LEX_TEST
                            printf (","); 
                        #else
                            LEX_PRINTF(COMMA);
                        #endif 
                    }
[-+]?[0-9]*\.?[0-9]+    {LEX_PRINTF(NUMBER); }
[a-zA-Z_]+          { LEX_PRINTF (VAR_NAME); }
[ \t]+              {
                        #if LEX_TEST 
                            printf (" "); /*忽略空格*/
                        #else
                            LEX_PRINTF (WHITE_SPACE);
                        #endif 
                    }
.                   { LEX_PRINTF (ILLEGAL); }
%%


/* C语言逻辑部分 */

#ifndef yywrap
yywrap() { return 1; }
#endif

#if LEX_TEST
int main(int argc, char *argv[]) {
    yyin = fopen(argv[1], "r");
    yylex();
    fclose(yyin);
}
#endif