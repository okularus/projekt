Shader "HSB_HSV_Colorpicker_cutdown" {
    Properties {
      _MainTex ("Texture", 2D) = "white" {}
      _HueShift("HueShift", Float) = 0
    }
    SubShader {
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM
      #pragma surface surf Lambert
      #pragma target 3.0        
 
        float3 hsv_to_rgb(float3 HSV)
        {
                float3 RGB = HSV.z;
           
                   float var_h = HSV.x * 6;
                   float var_i = floor(var_h);   // Or ... var_i = floor( var_h )
                   float var_1 = HSV.z * (1.0 - HSV.y);
                   float var_2 = HSV.z * (1.0 - HSV.y * (var_h-var_i));
                   float var_3 = HSV.z * (1.0 - HSV.y * (1-(var_h-var_i)));
                   if      (var_i == 0) { RGB = float3(HSV.z, var_3, var_1); }
                   else if (var_i == 1) { RGB = float3(var_2, HSV.z, var_1); }
                   else if (var_i == 2) { RGB = float3(var_1, HSV.z, var_3); }
                   else if (var_i == 3) { RGB = float3(var_1, var_2, HSV.z); }
                   else if (var_i == 4) { RGB = float3(var_3, var_1, HSV.z); }
                   else                 { RGB = float3(HSV.z, var_1, var_2); }
           
           return (RGB);
        }
 
      struct Input {
          float2 uv_MainTex;
      };
     
      float _HueShift;
     
      void surf (Input IN, inout SurfaceOutput o)
      {
          float3 hsv = float3(_HueShift, IN.uv_MainTex.x, IN.uv_MainTex.y);
          if ( hsv.x > 1.0 ) { hsv.x -= 1.0; }
          o.Albedo = half3(hsv_to_rgb(hsv));
      }
     
      ENDCG
    }
    Fallback "Diffuse"
  }