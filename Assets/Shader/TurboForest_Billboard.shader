Shader "TurboForest/Billboard" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Cutoff ("Cutoff", Range(0, 1)) = 0.5
		_Scale ("Scale", Float) = 1
		_CenterShiftX ("CenterShiftX", Float) = 0
		_CenterShiftY ("CenterShiftY", Float) = 0
		[Toggle(WHITE)] _White ("White", Float) = 0
		[Toggle(UNLIT)] _FillWithRed ("Unlit", Float) = 0
		[Toggle(SINGLE_QUAD)] _SingleQuad ("Single quad", Float) = 0
		[Toggle(CYLINDRICAL)] _Cylindrical ("Cylindrical", Float) = 0
		[Toggle(ATLAS)] _Atlas ("Atlas", Float) = 0
		[Toggle(WIND)] _Wind ("Wind", Float) = 0
		[Toggle(REFLECTIONS_FLIP)] _Reflection ("Reflections Flip", Float) = 0
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

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}