Shader "BUSSID/GlassDecalDoubleSide" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_ColorSticker ("ColorSticker", Vector) = (1,1,1,1)
		_Glossiness ("Smoothness", Range(0, 1)) = 0.985
		_Metallic ("Metallic", Range(0, 1)) = 1
		_Fresnel ("Fresnel", Range(0, 4)) = 2.5
		_DecalTex ("Decal (RGBA)", 2D) = "black" {}
		[Toggle] _NoCull ("Double Sided", Float) = 0
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

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}