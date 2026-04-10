Shader "BUSSID/Building" {
	Properties {
		[Toggle(TEST_HIGHLIGHT)] _TestHightlight ("Test Highlight", Float) = 0
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
		[Toggle(USE_GLOW)] _UseGlow ("Use glow", Float) = 0
		[Toggle(MULTIPLY_GLOW)] _MultiplyGlow ("Multiply glow", Float) = 0
		[NoScaleOffset] _GlowTex ("Glow map", 2D) = "black" {}
		[Toggle(BUILDINGS_AO)] _BuildingsAO ("Buildings AO", Float) = 1
		[Toggle(CAST_AO)] _CastAO ("Cast planar AO", Float) = 1
		_PLAOIntensity ("AO intensity", Range(0, 1)) = 0.75
		[Toggle(RECEIVE_AO)] _ReceiveAO ("Receive planar AO", Float) = 0
		[Toggle(ALPHATEST)] _Alphatest ("Use Cutoff", Float) = 0
		_Cutoff ("Cutoff", Range(0, 1)) = 0.5
		[Toggle(HEADLIGHT_GLOSS)] _HeadlightGloss ("Headlight Gloss", Float) = 0
		_GlossMask ("Gloss mask", 2D) = "white" {}
		_HeadlightGlossScale ("Headlight Gloss Scale", Float) = 1
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