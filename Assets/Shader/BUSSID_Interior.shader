Shader "BUSSID/Interior" {
	Properties {
		[Toggle(IS_LIVERY)] _IsLivery ("Is Livery", Float) = 0
		[Toggle(FULL_BRIGHT)] _FullBright ("Full bright", Float) = 0
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
		_ReflStrength ("Refl strength", Range(0, 1)) = 0
		_ReflSmoothness ("Refl smoothness", Range(0, 1)) = 1
		[Toggle(USE_REFLECTION_MASK)] _UseReflectionMask ("Use reflection mask", Float) = 0
		[NoScaleOffset] _ReflMask ("Spec, Gloss, Reflection mask", 2D) = "white" {}
		[Toggle(DEBUG_SPEC)] _DebugSpec ("Debug spec", Float) = 0
		[Toggle(DEBUG_GLOSS)] _DebugGloss ("Debug gloss", Float) = 0
		[Toggle(USE_NORMAL_MAP)] _UseNormalMap ("Use normal map", Float) = 0
		_NormalTex ("Texture", 2D) = "bump" {}
		[Toggle(USE_DIRT_DAMAGE)] _UseDirtDamage ("Use Dirt Damage", Float) = 0
		[Toggle(USE_DIRT)] _UseDirt ("Use Dirt", Float) = 0
		[Toggle(USE_DAMAGE)] _UseDamage ("Use Damage", Float) = 0
		_DirtTex ("Dirt Texture", 2D) = "white" {}
		_DirtMask ("Dirt Mask Texture", 2D) = "white" {}
		_DirtMaskValue ("Dirt Mask Value", 2D) = "black" {}
		_DirtAmount ("Dirt Amount", Range(0, 1)) = 0
		_DamageBlend ("Damage Texture Blend", Range(0, 1)) = 0
		[HideInInspector] _WashState ("Wash State", Int) = 0
		[HideInInspector] _WashGate1 ("Wash Gate1 Position", Vector) = (0,0,0,1)
		[HideInInspector] _WashGate2 ("Wash Gate2 Position", Vector) = (0,0,0,1)
		[HideInInspector] _Forward ("Object Forward Direction", Vector) = (0,0,1,1)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
	Fallback "Mobile/VertexLit"
}