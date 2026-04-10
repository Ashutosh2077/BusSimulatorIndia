Shader "BUSSID/RiverWater" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_BumpTex ("Normal map", 2D) = "normal" {}
		[Toggle(USE_REFLECTIONS)] _UseReflections ("Use reflections", Float) = 0
		_ReflStrength ("Refl strength", Range(0, 1)) = 0
		_ReflSmoothness ("Refl smoothness", Range(0, 1)) = 1
		_ReflCubemap ("Refl cubemap", Cube) = "white" {}
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
	Fallback "Mobile/VertexLit"
}