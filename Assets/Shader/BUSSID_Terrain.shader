Shader "BUSSID/Terrain" {
	Properties {
		_V_T2M_Control ("Control Map (RGBA)", 2D) = "black" {}
		[Toggle(USE_SHADOWMAP)] _UseShadowMap ("Use shadow map", Float) = 0
		[NoScaleOffset] _ShadowMap ("Shadow map", 2D) = "white" {}
		_V_T2M_Splat1_uvScale ("Scale", Float) = 1
		[NoScaleOffset] _V_T2M_Splat1 ("Layer 1 (R)", 2D) = "white" {}
		[NoScaleOffset] _V_T2M_Splat2 ("Layer 2 (G)", 2D) = "black" {}
		[NoScaleOffset] _V_T2M_Splat3 ("Layer 3 (B)", 2D) = "black" {}
		[Toggle(USE_VARIATION)] _UseVariation ("Use variation", Float) = 0
		[NoScaleOffset] _VariationTex ("Variation tex", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Mobile/VertexLit"
}