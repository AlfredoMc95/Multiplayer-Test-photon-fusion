Shader"Unlit/MainMenuShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color1 ("Color 1", Color) = (1,1,1,1)
        _Color2 ("Color 2", Color) = (0,0,0,1)
        _GradientDirection ("Gradient Direction", Vector) = (1,0,0,0)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
#include "UnityCG.cginc"
            
struct appdata
{
    float4 vertex : POSITION;
    float2 uv : TEXCOORD0;
};
            
struct v2f
{
    float2 uv : TEXCOORD0;
    float4 vertex : SV_POSITION;
};
            
sampler2D _MainTex;
float4 _MainTex_ST;
float4 _Color1;
float4 _Color2;
float4 _GradientDirection;
            
v2f vert(appdata v)
{
    v2f o;
    o.vertex = UnityObjectToClipPos(v.vertex);
    o.uv = v.uv;
    return o;
}
            
fixed4 frag(v2f i) : SV_Target
{
    float gradient = dot(i.uv, _GradientDirection.xy) + _GradientDirection.z;
    return lerp(_Color1, _Color2, gradient);
}
            ENDCG
        }
    }
}