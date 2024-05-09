Shader "Custom/StencilShader"
{
    SubShader
    {
        ZWrite Off
        ColorMask 0
        
        Stencil
        {
            Ref 1 
            Pass Replace
        }
        
        Pass
        {}
    }
}
