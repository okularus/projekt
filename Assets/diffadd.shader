Shader "ChannelBlend/DiffuseAdd" {
Properties {
      _MainTex ("Texture", 2D) = "white" {}
      _BlendTex ("Texture", 2D) = "white" {}
    }
 
    SubShader {
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM
      #pragma surface surf Lambert
      struct Input {
          float2 uv_MainTex;
 
      };
      sampler2D _MainTex;
          sampler2D _BlendTex;
 
      void surf (Input IN, inout SurfaceOutput o) {
        o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
        half3 blend = tex2D (_BlendTex, IN.uv_MainTex).rgb;
               
                //I think this can be optimized a bit
                o.Albedo.r = min(1.0, o.Albedo.r + blend.r);
                o.Albedo.g = min(1.0, o.Albedo.g + blend.g);
                o.Albedo.b = min(1.0, o.Albedo.b + blend.b);
      }
      ENDCG
    }
    Fallback "Diffuse"
  }