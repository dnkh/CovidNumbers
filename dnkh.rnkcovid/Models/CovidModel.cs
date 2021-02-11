using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace dnkh.covidnumbers.models
{
    

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class UniqueIdField    {
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("isSystemMaintained")]
        public bool IsSystemMaintained { get; set; } 
    }

    public class GeometryProperties    {
        [JsonPropertyName("shapeAreaFieldName")]
        public string ShapeAreaFieldName { get; set; } 

        [JsonPropertyName("shapeLengthFieldName")]
        public string ShapeLengthFieldName { get; set; } 

        [JsonPropertyName("units")]
        public string Units { get; set; } 
    }

    public class SpatialReference    {
        [JsonPropertyName("wkid")]
        public int Wkid { get; set; } 

        [JsonPropertyName("latestWkid")]
        public int LatestWkid { get; set; } 
    }

    public class Field    {
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("type")]
        public string Type { get; set; } 

        [JsonPropertyName("alias")]
        public string Alias { get; set; } 

        [JsonPropertyName("sqlType")]
        public string SqlType { get; set; } 

        [JsonPropertyName("domain")]
        public object Domain { get; set; } 

        [JsonPropertyName("defaultValue")]
        public object DefaultValue { get; set; } 

        [JsonPropertyName("length")]
        public int? Length { get; set; } 
    }

    public class CityData    {
        [JsonPropertyName("FID")]
        public int FID { get; set; } 

        [JsonPropertyName("AGS")]
        public string AGS { get; set; } 

        [JsonPropertyName("BEZ")]
        public string BEZ { get; set; } 

        [JsonPropertyName("GMD")]
        public string Name { get; set; } 

        [JsonPropertyName("GMDNR")]
        public int GMDNR { get; set; } 

        [JsonPropertyName("AREA_QKM")]
        public double AREAQKM { get; set; } 

        [JsonPropertyName("gmdnr_1")]
        public int Gmdnr1 { get; set; } 

        [JsonPropertyName("gmdtx")]
        public string Gmdtx { get; set; } 

        [JsonPropertyName("ew")]
        public int Einwohner { get; set; } 

        [JsonPropertyName("af_vt")]
        public int AfVt { get; set; } 

        [JsonPropertyName("af")]
        public int Af { get; set; } 

        [JsonPropertyName("af_dif")]
        public int AfDif { get; set; } 

        [JsonPropertyName("af100")]
        public double Af100 { get; set; } 

        [JsonPropertyName("af100k_vt")]
        public double Af100kVt { get; set; } 

        [JsonPropertyName("af100k")]
        public double Af100k { get; set; } 

        [JsonPropertyName("af100k_dif")]
        public double Af100kDif { get; set; } 

        [JsonPropertyName("ni_vt")]
        public int NiVt { get; set; } 

        [JsonPropertyName("ni")]
        public int Ni { get; set; } 

        [JsonPropertyName("ni_dif")]
        public int NiDif { get; set; } 

        [JsonPropertyName("ni_100")]
        public double Ni100 { get; set; } 

        [JsonPropertyName("ni_100k")]
        public double Ni100k { get; set; } 

        [JsonPropertyName("ni100k_vt")]
        public double Ni100kVt { get; set; } 

        [JsonPropertyName("ni_100k_di")]
        public double Ni100kDi { get; set; } 

        [JsonPropertyName("ni7_100kvt")]
        public double Ni7100kvt { get; set; } 

        [JsonPropertyName("ni7_100k")]
        public double Ni7100k { get; set; } 

        [JsonPropertyName("ni7_100kdi")]
        public double Ni7100kdi { get; set; } 

        [JsonPropertyName("gn_vt")]
        public int GnVt { get; set; } 

        [JsonPropertyName("gn")]
        public int Gn { get; set; } // Genesene

        [JsonPropertyName("gn_dif")]
        public int GnDif { get; set; } 

        [JsonPropertyName("gn100")]
        public double Gn100 { get; set; } 

        [JsonPropertyName("gn100k")]
        public double Gn100k { get; set; } 

        [JsonPropertyName("gn_su_vt")]
        public int GnSuVt { get; set; } 

        [JsonPropertyName("gn_su")]
        public int GnSu { get; set; } 

        [JsonPropertyName("gn_su_dif")]
        public int GnSuDif { get; set; } 

        [JsonPropertyName("gn_su_100")]
        public double GnSu100 { get; set; } 

        [JsonPropertyName("gn_su_100k")]
        public double GnSu100k { get; set; } 

        [JsonPropertyName("vs_vt")]
        public int VsVt { get; set; } //Verstorbene Vortag

        [JsonPropertyName("vs")]
        public int Vs { get; set; }  //Verstorbene

        [JsonPropertyName("vs_dif")]
        public int VsDif { get; set; } 

        // [JsonPropertyName("vs100")]
        // public int Vs100 { get; set; } 

        // [JsonPropertyName("vs100k")]
        // public int Vs100k { get; set; } 

        [JsonPropertyName("vs_su_vt")]
        public int VsSuVt { get; set; } 

        [JsonPropertyName("vs_su")]
        public int VsSu { get; set; } 

        [JsonPropertyName("vs_su_dif")]
        public int VsSuDif { get; set; } 

        [JsonPropertyName("vs_su_100")]
        public double VsSu100 { get; set; } 

        [JsonPropertyName("vs_su_100k")]
        public double VsSu100k { get; set; } 

        [JsonPropertyName("gf_vt")]
        public int GfVt { get; set; } 

        [JsonPropertyName("gf")] // Gesamtfälle
        public int Gf { get; set; } 

        [JsonPropertyName("gf_dif")]
        public int GfDif { get; set; } 

        [JsonPropertyName("gf100_vt")]
        public double Gf100Vt { get; set; } 

        [JsonPropertyName("gf100")]
        public double Gf100 { get; set; } 

        [JsonPropertyName("gf100_dif")]
        public double Gf100Dif { get; set; } 

        [JsonPropertyName("Shape__Area")]
        public double ShapeArea { get; set; } 

        [JsonPropertyName("Shape__Length")]
        public double ShapeLength { get; set; } 
    }

    public class City    {
        [JsonPropertyName("attributes")]
        public CityData CityData { get; set; } 
    }

    public class CovidModel   {
        [JsonPropertyName("objectIdFieldName")]
        public string ObjectIdFieldName { get; set; } 

        [JsonPropertyName("uniqueIdField")]
        public UniqueIdField UniqueIdField { get; set; } 

        [JsonPropertyName("globalIdFieldName")]
        public string GlobalIdFieldName { get; set; } 

        [JsonPropertyName("geometryProperties")]
        public GeometryProperties GeometryProperties { get; set; } 

        [JsonPropertyName("geometryType")]
        public string GeometryType { get; set; } 

        [JsonPropertyName("spatialReference")]
        public SpatialReference SpatialReference { get; set; } 

        [JsonPropertyName("fields")]
        public List<Field> Fields { get; set; } 

        [JsonPropertyName("features")]
        public List<City> Cities { get; set; } 
    }
}

