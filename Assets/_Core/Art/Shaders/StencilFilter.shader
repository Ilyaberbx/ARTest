Shader "Custom/StencilFilter"
{
    Properties
    {
        _Color("Color", Color) = (1,1,1,1)
        [Enum(Equal,3, NotEqual,6)] _StencilTest("StencilTestt", int) = 3

    }
    SubShader
    {
        Pass {}
    }
}